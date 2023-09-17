using AutoMapper;
using Tutorial.PhoneBook.Application.Business.User.Query;


namespace Tutorial.PhoneBook.WebApi.EndPoints.User.V2
{
    public class GetAllV2Mapper : Profile
    {
        public GetAllV2Mapper()
        {
            CreateMap<GetAllRequestV2, UserGetAllV2Query>()
                .ConstructUsing(src => new UserGetAllV2Query(src.CorrelationId()));


            CreateMap<UserGetAllV2Output, GetAllResponseV2>()
               .ConstructUsing(src => new GetAllResponseV2(src.CorrelationId()));
        }

    }
}
