using AutoMapper;
using GymApi.Dtos.Request;
using GymApi.Dtos.Response;
using GymApi.Models;

namespace GymApi.Profiles;  

public class ClientProfile : Profile
{
	public ClientProfile()
	{
		CreateMap<CreateClientDto, Client>();
        CreateMap<Client, ReadClientDto>();
        CreateMap<UpdateClientDto, Client>();
    }

}
