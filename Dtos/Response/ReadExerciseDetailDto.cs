using GymApi.Models;
using System.ComponentModel.DataAnnotations;

namespace GymApi.Dtos.Response;

public class ReadExerciseDetailDto
{
    public int Id { get; set; }

    public int ExerciseId { get; set; }

    public int WorkoutId { get; set; }

    public double Load { get; set; }

    public int Rep { get; set; }

    public int Series { get; set; }

    public TimeSpan RestTime { get; set; }
}
