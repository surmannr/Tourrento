using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tourrento.DAL;
using Tourrento.Shared.Exceptions;

namespace Tourrento.BLL.Category.Queries
{
    public static class GetCategories
    {
        public class Query : IRequest<List<Shared.Dto.Category>>
        {

        }

        public class Hander : IRequestHandler<Query, List<Shared.Dto.Category>>
        {
            private readonly TourrentoDbContext _dbContext;
            private readonly IMapper mapper;

            public Hander(TourrentoDbContext dbContext, IMapper mapper)
            {
                _dbContext = dbContext;
                this.mapper = mapper;
            }

            public async Task<List<Shared.Dto.Category>> Handle(Query request, CancellationToken cancellationToken)
            {
                var categories = await _dbContext.Categories.ToListAsync();
                if (categories == null) throw new DbNullException();
                return  mapper.Map<List<Shared.Dto.Category>>(categories);
            }
        }
    }
}
