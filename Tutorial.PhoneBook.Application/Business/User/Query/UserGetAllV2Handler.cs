using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.PhoneBook.Application.Business.User.Query
{
    public class UserGetAllV2Handler : IRequestHandler<UserGetAllV2Query, UserGetAllV2Output>
    {
        public async Task<UserGetAllV2Output> Handle(UserGetAllV2Query request, CancellationToken cancellationToken)
        {
            UserGetAllV2Output userGetAllV2Output=new UserGetAllV2Output(request.CorrelationId()); 
            userGetAllV2Output.Result=new List<SelectedUserDto>();
            userGetAllV2Output.Result.Add(new SelectedUserDto());
            userGetAllV2Output.Result.Add(new SelectedUserDto());
            Task.CompletedTask.Wait();
            return userGetAllV2Output;
        }
    }
}
