using AutoMapper;
using GymApi.Data;
using GymApi.Dtos.Request;
using GymApi.Dtos.Response;
using GymApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace GymApi.Controllers;

[ApiController]
[Route("treinos")]
public class WorkoutController : ControllerBase
{
    private readonly GymContext _context;
    private readonly IMapper _mapper;

    public WorkoutController(GymContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var workout = _context.Workouts.ToList();

        var dto = _mapper.Map<ICollection<ReadWorkoutDto>>(workout);

        return Ok(dto);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id) 
    {
        var workout = _context.Workouts.Find(id);
        if (workout is null) return NotFound();

        var dto = _mapper.Map<ReadWorkoutDto>(workout);

        return Ok(dto);
    }

    [HttpPost]
    public IActionResult AddWorkout([FromBody] CreateWorkoutDto dto)
    {
        var workout = _mapper.Map<Workout>(dto);

        _context.Workouts.Add(workout);
        _context.SaveChanges();

        return CreatedAtAction(nameof(GetById), new {id = workout.Id}, workout);
    }

    [HttpPut("{id}")]

    public IActionResult UpdateWorkout(int id, [FromBody] UpdateWorkoutDto dto)
    {
        var workout = _context.Workouts.Find(id);
        if (workout is null) return NotFound();

        _mapper.Map(dto, workout);
        _context.SaveChanges();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteById(int id)
    {
        var workout = _context.Workouts.Find(id);
        if (workout is null) return NotFound();

        _context.Workouts.Remove(workout);
        _context.SaveChanges();
        return NoContent();

    }
}
