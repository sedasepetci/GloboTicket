using AutoMapper;
using GloboTicket.TicketManagement.Application.Features.Events.Commands.Queries.GetEventDetail;
using GloboTicket.TicketManagement.Application.Features.Events.Commands.Queries.GetEventsList;
using GloboTicket.TicketManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Application.Profiles
{
    public class MappingProfiles:Profile
    {
        public MappingProfiles()
        {
            CreateMap<Event,EventListVm>().ReverseMap();
            CreateMap<Event,EventDetailVm>().ReverseMap();
            CreateMap<Category,CategoryDto>().ReverseMap();
        }
    }
}
