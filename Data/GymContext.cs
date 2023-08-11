using GymApi.Models;
using Microsoft.EntityFrameworkCore;

namespace GymApi.Data;

public class GymContext: DbContext
{
    public DbSet<Client> Clients { get; set; }
    public DbSet<Exercise> Exercises { get; set; }
    public DbSet<ExerciseDetail> ExercisesDetail { get; set; }
    public DbSet<Workout> Workouts { get; set; }

    public GymContext(DbContextOptions<GymContext> options): base(options)
    { }
}
