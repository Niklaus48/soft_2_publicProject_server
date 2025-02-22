using API.Helpers;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Application.Requests;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace soft_2_publicProject_server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PlanController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("get_plans")]
        public async Task<IActionResult> GetPlans()
        {
            try
            {
                var req = new GetPlanRequest();
                var response = await _mediator.Send(req);
                return Ok(Output.CreateResponse(true, response, "Plans retrieved successfully"));
            }
            catch (Exception ex)
            {
                return BadRequest(Output.CreateResponse(false, ex.Message, "Failed to retrieve plans"));
            }
        }

    }
}
