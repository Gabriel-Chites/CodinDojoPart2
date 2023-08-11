using AutoMapper;
using GymApi.Dtos.Request;
using GymApi.Dtos.Response;
using GymApi.Models;

namespace GymApi.Profiles;

public class ExerciseProfile : Profile
{
    public ExerciseProfile()
    {
        CreateMap<CreateExerciseDto, Exercise>();
        CreateMap<Exercise, ReadExerciseDto>();
        CreateMap<UpdateExerciseDto, Exercise>();
    }
}
