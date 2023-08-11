using GymApi.Models;
using System.ComponentModel.DataAnnotations;

namespace GymApi.Dtos.Request;

public class CreateClientDto
{
    [Required]
    public string Name { get; set; }

    [Required]
    public int Age { get; set; }

    [Required]
    public string Gender { get; set; }

    [Required]
    public double Weight { get; set; }

    [Required]
    public double Height { get; set; }

    [Required]
    public double ArmSize { get; set; }

    [Required]
    public double WaistSize { get; set; }

    [Required]
    public double AbdominalSize { get; set; }

    [Required]
    public double ChestSize { get; }

    [Required]
    public int WorkoutId { get; set; }
}
