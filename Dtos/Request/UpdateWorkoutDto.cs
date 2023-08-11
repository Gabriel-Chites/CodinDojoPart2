using System.ComponentModel.DataAnnotations;

namespace GymApi.Dtos.Request;

public class UpdateWorkoutDto
{   
    [Required]
    public string Name { get; set; }
}
