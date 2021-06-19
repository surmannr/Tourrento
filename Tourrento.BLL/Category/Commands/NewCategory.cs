using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tourrento.BLL.Mediator;
using Tourrento.DAL;

namespace Tourrento.BLL.Category.Commands
{
    public static class NewCategory
    {
        public class Command : ICommand<Shared.Dto.Category>
        {
            public Shared.Dto.Category Category { get; set; }
        }

        public class Handler : IRequestHandler<Command, Shared.Dto.Category>
        {
            private readonly TourrentoDbContext context;
            private readonly IMapper mapper;

            public Handler(TourrentoDbContext context, IMapper mapper)
            {
                this.context = context;
                this.mapper = mapper;
            }

            public async Task<Shared.Dto.Category> Handle(Command request, CancellationToken cancellationToken)
            {
                if(request.Category.ParentCategoryId != null)
                {
                    var parentcategory = await context.Categories.Where(c => c.Id == request.Category.ParentCategoryId).FirstOrDefaultAsync();

                    if(parentcategory != null)
                    {
                        if ( parentcategory.ParentCategoryId != null)
                        {
                            throw new InvalidOperationException("A kategória nem lehet 2-nél nagyobb szintű fa.");
                        }
                    } 
                    else
                    {
                        throw new InvalidOperationException("Nem létezik ilyen szülő kategória amit megadtál.");
                    }
                }

                var category = mapper.Map<DAL.Models.Category>(request.Category);

                var result = context.Categories.Add(category);
                await context.SaveChangesAsync();

                return mapper.Map<Shared.Dto.Category>(result.Entity);
            }
        }
    }
}
