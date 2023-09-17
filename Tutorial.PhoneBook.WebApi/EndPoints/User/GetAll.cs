using Ardalis.ApiEndpoints;
using Azure;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Tutorial.PhoneBook.Application.Business.User.Query;

namespace Tutorial.PhoneBook.WebApi.EndPoints.User
{
  
    public class GetAll : EndpointBaseAsync.WithoutRequest
    .WithActionResult<GetAllResponse>
    {
        private readonly IMediator _mediator;

        public GetAll(IMediator mediator)
        {
            _mediator = mediator;
        }

        [ApiVersion("1.0")]
        [HttpGet(GetAllRequest.Route)]
        [SwaggerOperation(
            Summary = "Get list of All Users",
            Description = "list of All Users",
            OperationId = "Users.GetAll",
            Tags = new[] { "UsersEndpoint" })]
        public override async Task<ActionResult<GetAllResponse>> HandleAsync(CancellationToken cancellationToken = default)
        {
            UserGetAllQuery query = new UserGetAllQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}
