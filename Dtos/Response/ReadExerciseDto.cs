using System.ComponentModel.DataAnnotations;

namespace GymApi.Dtos.Response;

public class ReadExerciseDto
{
    public int Id { get; set; }

    public required string Name { get; set; }

    public string? Description { get; set; }

    public required string Picture { get; set; }
}
