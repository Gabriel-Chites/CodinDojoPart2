using System.ComponentModel.DataAnnotations;

namespace GymApi.Dtos.Request;

public class CreateWorkoutDto
{
    [Required]

    public string Name { get; set; }

}