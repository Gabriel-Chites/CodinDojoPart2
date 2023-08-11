using System.ComponentModel.DataAnnotations;

namespace GymApi.Models;

public class Workout
{
    [Required]
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    public ICollection <ExerciseDetail> ExerciseDetails{ get; set; }
    
    public Client? Client { get; set; }
    public Workout()
    {
        ExerciseDetails = new List<ExerciseDetail>();
    }
}
