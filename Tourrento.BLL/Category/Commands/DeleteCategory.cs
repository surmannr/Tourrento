using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Tourrento.BLL.Mediator;
using Tourrento.DAL;
using Tourrento.Shared.Exceptions;

namespace Tourrento.BLL.Category.Commands
{
    public static class DeleteCategory
    {
        public class Command : ICommand<Unit>
        {
            public int Id { get; set; }
        }

        public class Handler : IRequestHandler<Command, Unit>
        {
            private readonly TourrentoDbContext context;
            private readonly IMapper mapper;

            public Handler(TourrentoDbContext context, IMapper mapper)
            {
                this.context = context;
                this.mapper = mapper;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var category = await context.Categories.Where(c => c.Id == request.Id).FirstOrDefaultAsync();

                if(category == null)
                {
                    throw new DbNullException();
                }

                var childcategory = await context.Categories.Where(c => c.ParentCategoryId == category.Id).FirstOrDefaultAsync();

                if (childcategory != null)
                {
                    throw new InvalidOperationException("Szülő kategóriát nem lehet törölni! Előtte töröld az összes gyerekelemet.");
                }

                context.Categories.Remove(category);
                await context.SaveChangesAsync();

                return Unit.Task.Result;
            }
        }
    }
}
