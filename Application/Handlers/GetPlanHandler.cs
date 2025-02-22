using Application.Requests;
using Application.Responses;
using AutoMapper;
using Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers
{
    public class GetPlanHandler : IRequestHandler<GetPlanRequest, PlanResponse>
    {
        private readonly IPlanRepository _planRepository;
        private readonly IMapper _mapper;

        public GetPlanHandler(IPlanRepository planRepository, IMapper mapper)
        {
            _planRepository = planRepository;
            _mapper = mapper;
        }


        public async Task<PlanResponse> Handle(GetPlanRequest request, CancellationToken cancellationToken)
        {
            var plans = await _planRepository.GetAllPlans();

            return new PlanResponse()
            {
                Plans = plans,
            };
        }
    }
}
