using AutoMapper;
using GymApi.Dtos.Request;
using GymApi.Dtos.Response;
using GymApi.Models;

namespace GymApi.Profiles;

public class WorkoutProfile : Profile
{
    public WorkoutProfile()
    {
        CreateMap<CreateWorkoutDto, Workout>();
        CreateMap<Workout, ReadWorkoutDto>();
        CreateMap<UpdateWorkoutDto, Workout>();
    }
}
