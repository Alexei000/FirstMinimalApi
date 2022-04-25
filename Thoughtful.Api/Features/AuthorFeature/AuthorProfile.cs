using Thoughtful.Domain.Model;

namespace Thoughtful.Api.Features.AuthorFeature;

// ReSharper disable once UnusedMember.Global
public class AuthorProfile : Profile
{
    public AuthorProfile()
    {
        CreateMap<AuthorDto, Author>().ReverseMap();
    }
}