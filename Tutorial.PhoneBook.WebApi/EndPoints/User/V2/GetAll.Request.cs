using Tutorial.PhoneBook.Core.Messages;

namespace Tutorial.PhoneBook.WebApi.EndPoints.User
{
    public class GetAllRequestV2 : BaseRequest
    {
        public const string Route = "/api/user/v{version:apiVersion}/GetAll";
        public GetAllRequestV2() { }
        public GetAllRequestV2(Guid correlationId) : base(correlationId) { }
    }
}
