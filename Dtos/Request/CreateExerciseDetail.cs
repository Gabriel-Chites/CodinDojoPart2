using GymApi.Models;
using System.ComponentModel.DataAnnotations;

namespace GymApi.Dtos.Request;

public class CreateExerciseDetail
{
    [Required]
    public int ExerciseId { get; set; }

    [Required]
    public int WorkoutId { get; set; }

    [Required]
    public double Load { get; set; }

    [Required]
    public int Rep { get; set; }

    [Required]
    public int Series { get; set; }

    [Required]
    public TimeSpan RestTime { get; set; }
}
