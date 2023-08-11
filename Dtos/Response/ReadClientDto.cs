using GymApi.Models;
using System.ComponentModel.DataAnnotations;

namespace GymApi.Dtos.Response;

public class ReadClientDto
{
    public int Id { get; init; }

    public required string Name { get; init; }

    public int Age { get; init; }

    public required string Gender { get; init; }

    public double Weight { get; init; }

    public double Height { get; init; }

    public double ArmSize { get; init; }

    public double WaistSize { get; init; }

    public double AbdominalSize { get; init; }

    public double ChestSize { get; }

    public int WorkoutId { get; init; }
}
