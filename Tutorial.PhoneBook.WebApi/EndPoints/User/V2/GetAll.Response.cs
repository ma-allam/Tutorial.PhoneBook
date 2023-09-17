using Tutorial.PhoneBook.Application.Business.User.Query;
using Tutorial.PhoneBook.Core.Messages;

namespace Tutorial.PhoneBook.WebApi.EndPoints.User
{
    public class GetAllResponseV2 : BaseResponse
    {
        public GetAllResponseV2() { }
        public GetAllResponseV2(Guid correlationId) : base(correlationId) { }

        public List<SelectedUserDto> Result { get; set; }
    }
}
