﻿
using Domain.Entities;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Responses
{
    public class PlanResponse
    {
        public List<Plan> Plans { get; set; }
    }
}
