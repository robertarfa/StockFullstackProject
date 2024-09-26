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

        /// <summary>
        /// Adiciona um produto ao banco de dados
        /// </summary>
        /// <param name="productDto">Objeto com os campos necessários para criação de um produto</param>
        /// <returns>IActionResult</returns>
        /// <response code="201">Caso inserção seja feita com sucesso</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
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

        /// <summary>
        /// Edição um produto ao banco de dados
        /// </summary>
        /// <param name="productDto">Objeto com os campos necessários para edição de um produto</param>
        /// <returns>IActionResult</returns>
        /// <response code="204">Caso edição seja feita com sucesso</response>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
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


        /// <summary>
        /// Recupera todos os produtos ao banco de dados
        /// </summary>
        /// <param name="skip">Pula um número especificado de produtos em uma sequência.</param>
        /// <param name="take">Retorna um número especificado de produtos do início de uma sequência.</param>
        /// <returns>IActionResult</returns>
        /// <response code="200">Caso a recuperação da lista seja feita com sucesso</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IEnumerable<ReadProductDto> GetAll([FromQuery] int skip = 0, [FromQuery] int take = 10)
        {
            return _mapper.Map<List<ReadProductDto>>(_context.Products.Skip(skip).Take(take));
        }

        /// <summary>
        /// Recupera um produto ao banco de dados
        /// </summary>
        /// <param name="id">Referente a um produto específico no banco de dados.</param>
        /// <returns>IActionResult</returns>
        /// <response code="200">Caso a recuperação do produto seja feito com sucesso</response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetById(int id)
        {
            var product = _context.Products.FirstOrDefault(product => product.Id == id);

            if (product is null) return NotFound();

            var productDto = _mapper.Map<ReadProductDto>(product);

            return Ok(productDto);
        }

        /// <summary>
        /// Deleta um produto ao banco de dados
        /// </summary>
        /// <param name="id">Referente a um produto específico no banco de dados.</param>
        /// <returns>IActionResult</returns>
        /// <response code="204">Caso deleção seja feita com sucesso</response>
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
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
