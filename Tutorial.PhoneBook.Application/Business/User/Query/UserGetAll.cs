using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.PhoneBook.Application.Business.User.Query
{
    public class UserGetAllHandler : IRequestHandler<UserGetAllQuery, UserGetAllOutput>
    {
        async Task<UserGetAllOutput> IRequestHandler<UserGetAllQuery, UserGetAllOutput>.Handle(UserGetAllQuery request, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            UserGetAllOutput output = new UserGetAllOutput();   
            return output;
        }
    }
}
