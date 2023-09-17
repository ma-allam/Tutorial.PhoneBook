using MediatR;
using Tutorial.PhoneBook.Core.Messages;

namespace Tutorial.PhoneBook.Application.Business.User.Query
{
    public class UserGetAllV2Query : BaseRequest, IRequest<UserGetAllV2Output>
    {
        public UserGetAllV2Query() { }
        public UserGetAllV2Query(Guid correlationId) : base(correlationId) { }
    }
}