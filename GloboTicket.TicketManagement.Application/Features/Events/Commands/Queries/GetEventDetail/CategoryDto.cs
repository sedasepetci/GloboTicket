﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Application.Features.Events.Commands.Queries.GetEventDetail
{
    public class CategoryDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}