using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Server.Data;
using Server.Data.Dtos;
using Server.Models;
using Server.Data.Dtos.Product;
using Server.Data.Enums;
using Server.Data.Dtos.Category;
using Server.Data.Dtos.Customer;

namespace Server.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CategoryController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /// <summary>
        /// Adiciona uma categoria ao banco de dados
        /// </summary>
        /// <param name="categoryDto">Objeto com os campos necessários para criação de uma categoria</param>
        /// <returns>IActionResult</returns>
        /// <response code="201">Caso inserção seja feita com sucesso</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult Create([FromBody] CreateCategoryDto categoryDto)
        {
            CategoryModel category = _mapper.Map<CategoryModel>(categoryDto);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            _context.Categories.Add(category);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById),
            new { id = category.Id },
            categoryDto);
        }

        ///// <summary>
        ///// Edição um produto ao banco de dados
        ///// </summary>
        ///// <param name="categoryDto">Objeto com os campos necessários para edição de um produto</param>
        ///// <returns>IActionResult</returns>
        ///// <response code="204">Caso edição seja feita com sucesso</response>
        //[HttpPut("{id}")]
        //[ProducesResponseType(StatusCodes.Status204NoContent)]
        //public IActionResult Update(int id, [FromBody] UpdateCustomerDto categoryDto)
        //{


        //    var category = _context.Categories.FirstOrDefault(category => category.Id == id);

        //    if (category is null) return NotFound();
        //    //já tem um objeto category existente e deseja atualizar seus dados com base em um categoryDto.
        //    _mapper.Map(categoryDto, category);
        //    _context.SaveChanges();
        //    //A convenção é retornar noContent no Update
        //    return NoContent();
        //}


        ///// <summary>
        ///// Recupera todos os produtos ao banco de dados
        ///// </summary>
        ///// <param name="skip">Pula um número especificado de produtos em uma sequência.</param>
        ///// <param name="take">Retorna um número especificado de produtos do início de uma sequência.</param>
        ///// <returns>IActionResult</returns>
        ///// <response code="200">Caso a recuperação da lista seja feita com sucesso</response>
        //[HttpGet]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //public IEnumerable<ReadCategoryDto> GetAll([FromQuery] int skip = 0, [FromQuery] int take = 10)
        //{
        //    return _mapper.Map<List<ReadCategoryDto>>(_context.Categories.Skip(skip).Take(take));
        //}

        ///// <summary>
        ///// Recupera uma categoria ao banco de dados
        ///// </summary>
        ///// <param name="id">Referente a uma categoria específica no banco de dados.</param>
        ///// <returns>IActionResult</returns>
        ///// <response code="200">Caso a recuperação da categoria seja feito com sucesso</response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetById(int id)
        {
            var category = _context.Categories.FirstOrDefault(category => category.Id == id);

            if (category is null) return NotFound();

            var categoryDto = _mapper.Map<ReadCategoryDto>(category);

            return Ok(categoryDto);
        }

        ///// <summary>
        ///// Deleta um produto ao banco de dados
        ///// </summary>
        ///// <param name="id">Referente a um produto específico no banco de dados.</param>
        ///// <returns>IActionResult</returns>
        ///// <response code="204">Caso deleção seja feita com sucesso</response>
        //[HttpDelete]
        //[ProducesResponseType(StatusCodes.Status204NoContent)]
        //public IActionResult Delete(int id)
        //{
        //    var category = _context.Categories.FirstOrDefault(category => category.Id == id);

        //    if (category is null) return NotFound();

        //    _context.Categories.Remove(category);
        //    _context.SaveChanges();

        //    return NoContent();
        //}


    }
}
