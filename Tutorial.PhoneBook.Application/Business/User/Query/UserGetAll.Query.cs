using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.PhoneBook.Application.Business.User.Query
{
    public class UserGetAllQuery : IRequest<UserGetAllOutput>
    {
    }
}
