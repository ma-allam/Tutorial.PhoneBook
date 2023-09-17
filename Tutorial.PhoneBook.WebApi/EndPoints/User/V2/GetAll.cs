using Ardalis.ApiEndpoints;
using AutoMapper;
using Azure;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Net.WebSockets;
using Tutorial.PhoneBook.Application.Business.User.Query;

namespace Tutorial.PhoneBook.WebApi.EndPoints.User.V2
{
    public class GetAllV2 : EndpointBaseAsync.WithRequest<GetAllRequestV2>
    .WithActionResult<GetAllResponseV2>
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public GetAllV2(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [ApiVersion("2.0")]
        [HttpGet(GetAllRequestV2.Route)]
        [SwaggerOperation(
            Summary = "Get list of All Users",
            Description = "list of All Users",
            OperationId = "Users.GetAll",
            Tags = new[] { "UsersEndpoint" })]
        //UserGetAllV2Output
        public override async Task<ActionResult<GetAllResponseV2>> HandleAsync([FromQuery]GetAllRequestV2  getAllRequestV2,CancellationToken cancellationToken = default)
        {


            UserGetAllV2Query userGetAllV2Query = _mapper.Map<UserGetAllV2Query>(getAllRequestV2);
            var output=await _mediator.Send(userGetAllV2Query, cancellationToken);
            var result = _mapper.Map<GetAllResponseV2>(output);
            return Ok(result);
        }
    }
}
