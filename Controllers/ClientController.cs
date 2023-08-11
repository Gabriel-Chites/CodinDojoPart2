using AutoMapper;
using GymApi.Data;
using GymApi.Dtos.Request;
using GymApi.Dtos.Response;
using GymApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace GymApi.Controllers;

[ApiController]
[Route("alunos")]
public class ClientController : ControllerBase
{
    private readonly GymContext _context;
    private readonly IMapper _mapper;

    public ClientController(IMapper mapper, GymContext context)
    {
        _mapper = mapper;
        _context = context;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var clients = _context.Clients.ToList();
        var dto = _mapper.Map<ICollection<ReadClientDto>>(clients);
        
        return Ok(dto);
    }

    [HttpGet("{id}")]
    public IActionResult GetById([FromRoute] int id)
    {
        var client = _context.Clients.Find(id);
        //var client = _context.Clients.FirstOrDefault(x => x.Id == id);
        if (client is null) return NotFound();

        var dto = _mapper.Map<ReadClientDto>(client);

        return Ok(dto);
    }

    [HttpPost]
    public IActionResult AddClient([FromBody] CreateClientDto dto)
    {
        var client = _mapper.Map<Client>(dto);

        _context.Clients.Add(client);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetById), new {id = client.Id}, client);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateClient(int id, [FromBody] UpdateClientDto dto) 
    {
        var client = _context.Clients.Find(id);
        if (client is null) return NotFound();

        _mapper.Map(dto, client);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteClient(int id) 
    {
        var client = _context.Clients.Find(id);
        if (client is null) return NotFound();

        _context.Clients.Remove(client);
        _context.SaveChanges();
        return NoContent();
    }
}
