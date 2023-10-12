using AutoMapper;
using Contracts;
using MassTransit;
using MongoDB.Entities;
using SearchService.Models;

namespace SearchService.RequestHelpers;

public class MappingProfiles : Profile
{
    private readonly IMapper _mapper;

    public MappingProfiles()
    {
        CreateMap<AuctionCreated, Item>();
    }
}
