using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Server.Data;
using Server.Data.Dtos;
using Server.Models;
using Server.Data.Dtos.Product;
using Server.Data.Enums;

namespace Server.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ProductController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateProductDto productDto)
        {
            ProductModel product = _mapper.Map<ProductModel>(productDto);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            _context.Products.Add(product);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById),
            new { id = product.Id },
            productDto);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] UpdateCustomerDto productDto)
        {


            var product = _context.Products.FirstOrDefault(product => product.Id == id);

            if (product is null) return NotFound();
            //já tem um objeto product existente e deseja atualizar seus dados com base em um productDto.
            _mapper.Map(productDto, product);
            _context.SaveChanges();
            //A convenção é retornar noContent no Update
            return NoContent();
        }

        [HttpGet]
        public IEnumerable<ReadProductDto> GetAll([FromQuery] int skip = 0, [FromQuery] int take = 10)
        {
            return _mapper.Map<List<ReadProductDto>>(_context.Products.Skip(skip).Take(take));
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var product = _context.Products.FirstOrDefault(product => product.Id == id);

            if (product is null) return NotFound();

            var productDto = _mapper.Map<ReadProductDto>(product);

            return Ok(productDto);
        }


        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var product = _context.Products.FirstOrDefault(product => product.Id == id);

            if (product is null) return NotFound();

            _context.Products.Remove(product);
            _context.SaveChanges();

            return NoContent();
        }


    }
}
