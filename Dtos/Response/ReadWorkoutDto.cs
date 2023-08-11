using GymApi.Models;
using System.ComponentModel.DataAnnotations;

namespace GymApi.Dtos.Response;

public class ReadWorkoutDto
{
    public int Id { get; set; }

    public required string Name { get; set; }

    public required ICollection<ExerciseDetail> ExerciseDetails { get; set; }

    public required Client Client { get; set; }
}
