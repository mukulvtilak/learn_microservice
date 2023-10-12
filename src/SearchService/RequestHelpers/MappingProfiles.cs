using AutoMapper;
using Contracts;
using MassTransit;
using MongoDB.Entities;
using SearchService.Models;

namespace SearchService.RequestHelpers;

public class MappingProfiles : Profile
{
    private readonly IMapper _mapper;

    public MappingProfiles(IMapper mapper)
    {
        _mapper = mapper;
    }

    public async Task Consume(ConsumeContext<AuctionCreated> context)
    {
        Console.WriteLine("--> Consuming created auction: " + context.Message.Id);

        var item = _mapper.Map<Item>(context.Message);

        await item.SaveAsync();
    }
}
