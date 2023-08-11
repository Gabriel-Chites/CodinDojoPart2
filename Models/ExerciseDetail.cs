using System.ComponentModel.DataAnnotations;

namespace GymApi.Models;

public class ExerciseDetail
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    public int ExerciseId { get; set; }
    public Exercise Exercise { get; set; }

    [Required]
    public int WorkoutId { get; set; }
    public Workout Workout { get; set; }

    [Required]
    public double Load { get; set; }

    [Required]
    public int Rep { get; set; }

    [Required]
    public int Series { get; set; }

    [Required]
    public TimeSpan RestTime { get; set; }
}
