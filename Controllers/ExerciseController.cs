using AutoMapper;
using GymApi.Data;
using GymApi.Dtos.Request;
using GymApi.Dtos.Response;
using GymApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace GymApi.Controllers;

[ApiController]
[Route("exercicios")]
public class ExerciseController : ControllerBase
{
    private readonly GymContext _context;
    private readonly IMapper _mapper;

    public ExerciseController(IMapper mapper, GymContext context)
    {
        _mapper = mapper;
        _context = context;
    }
    [HttpGet]
    public IActionResult GetAll()
    {
        var exerciseList = _context.Exercises.ToList();

        var dto = _mapper.Map<ICollection<ReadExerciseDto>>(exerciseList);

        return Ok(dto);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id) 
    {
        var exercise = _context.Exercises.Find(id);

        if (exercise is null) return NotFound();

        return Ok(_mapper.Map<ReadExerciseDto>(exercise));
    }

    [HttpPost]
    public IActionResult AddExercise([FromBody] CreateExerciseDto dto)
    {
        var exercise = _mapper.Map<Exercise>(dto);

        _context.Exercises.Add(exercise);
        _context.SaveChanges();

        return CreatedAtAction(nameof(GetById), new { id = exercise.Id }, exercise);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateExerciseById(int id, [FromBody] UpdateExerciseDto dto)
    {
        var exercise = _context.Exercises.Find(id);

        if (exercise is null) return NotFound();

        _mapper.Map(dto, exercise);
        _context.SaveChanges();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteById(int id)
    {
        var exercise = _context.Exercises.Find(id);

        if(exercise is null) return NotFound();

        _context.Remove(exercise);
        _context.SaveChanges();

        return NoContent();
    }
}
