using Ardalis.ApiEndpoints;
using Azure;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Tutorial.PhoneBook.WebApi.EndPoints.User
{
    public class GetById : EndpointBaseSync.WithRequest<GetByIdRequest>
    .WithActionResult<GetByIdResponse>
    {
        [HttpGet(GetByIdRequest.Route)]
        [SwaggerOperation(
            Summary = "Get list of All Users",
            Description = "list of All Users",
            OperationId = "Users.GetAll",
            Tags = new[] { "UsersEndpoint" })]
        public override ActionResult<GetByIdResponse> Handle([FromQuery]GetByIdRequest request)
        {
            return Ok();
        }
    }
}
