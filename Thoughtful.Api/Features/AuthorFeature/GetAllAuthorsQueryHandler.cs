using Thoughtful.Dal;
using Thoughtful.Domain.Model;

namespace Thoughtful.Api.Features.AuthorFeature
{
    public class GetAllAuthorsQueryHandler : IRequestHandler<GetAllAuthorsQuery, List<Author>>
    {
        private readonly ThoughtfulDbContext _ctx;

        public GetAllAuthorsQueryHandler(ThoughtfulDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<List<Author>> Handle(GetAllAuthorsQuery request, CancellationToken token)
        {
            return await _ctx.Authors.ToListAsync(token);
        }
    }
}
