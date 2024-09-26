using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Server.Data;
using Server.Data.Dtos;
using Server.Data.Dtos.Customer;
using Server.Models;
using Microsoft.EntityFrameworkCore;

namespace Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomerController : ControllerBase
{

    private ApplicationDbContext _context;
    private IMapper _mapper;

    public CustomerController(
        ApplicationDbContext context,
        IMapper mapper
        )
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult Create([FromBody] CreateCustomerDto customerDto)
    {
        //Criar um novo objeto Customer com base nos dados de um customerDto.
        Customer customer = _mapper.Map<Customer>(customerDto);

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }


        _context.Customer.Add(customer);
        _context.SaveChanges();

        return CreatedAtAction(nameof(GetById),
        new { id = customer.Id },
        customerDto);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody] UpdateCustomerDto customerDto)
    {


        var customer = _context.Customer.FirstOrDefault(customer => customer.Id == id);

        if (customer is null) return NotFound();
        //já tem um objeto customer existente e deseja atualizar seus dados com base em um customerDto.
        _mapper.Map(customerDto, customer);
        _context.SaveChanges();
        //A convenção é retornar noContent no Update
        return NoContent();
    }

    [HttpGet]
    public IEnumerable<ReadCustomerDto> GetAll([FromQuery] int skip = 0, [FromQuery] int take = 10)
    {
        return _mapper.Map<List<ReadCustomerDto>>(_context.Customer.Include(a => a.Address).Skip(skip).Take(take));
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var customer = _context.Customer.Include(a => a.Address).FirstOrDefault(customer => customer.Id == id);

        if (customer is null) return NotFound();

        var customerDto = _mapper.Map<ReadCustomerDto>(customer);

        return Ok(customerDto);
    }

    [HttpGet("GetByPhone/{phoneNumber}")]
    public IActionResult GetByPhone(string phoneNumber)
    {
        var customer = _context.Customer.Include(a => a.Address).FirstOrDefault(customer => customer.PhoneNumber == phoneNumber);

        if (customer is null) return NotFound();

        var customerDto = _mapper.Map<ReadCustomerDto>(customer);

        return Ok(customerDto);
    }

    [HttpDelete]
    public IActionResult Delete(int id)
    {
        var customer = _context.Customer.Include(a => a.Address).FirstOrDefault(customer => customer.Id == id);

        if (customer is null) return NotFound();

        _context.Customer.Remove(customer);
        _context.SaveChanges();

        return NoContent();
    }
}
