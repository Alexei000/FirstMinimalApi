using Thoughtful.Api.Abstractions;
using Thoughtful.Dal;

namespace Thoughtful.Api.Features.AuthorFeature
{
    public class AuthorModule: IModule
    {
        private IMediator _mediator;
        private IMapper _mapper;

        public WebApplicationBuilder RegisterModule(WebApplicationBuilder builder)
        {
            var provider = builder.Services.BuildServiceProvider();
            _mediator = provider.GetRequiredService<IMediator>();
            _mapper = provider.GetRequiredService<IMapper>();
            return builder;
        }

        public IEndpointRouteBuilder MapEndpoint(IEndpointRouteBuilder app)
        {
            app.MapGet("/api/authors", async () => await _mediator.Send(new GetAllAuthorsQuery()))
                .WithName("GetAuthors");

            app.MapPost("/api/authors", async (ThoughtfulDbContext ctx, AuthorDto authorDto) =>
            {
                await _mediator.Send(new CreateAuthorCommand { Author = authorDto });
            });

            return app;
        }
    }

    
}
