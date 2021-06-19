using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tourrento.DAL;

namespace Tourrento.BLL.Mediator
{
    public class TransactionBehavior<TRequest, TResult> : IPipelineBehavior<TRequest, TResult>
         where TRequest : ICommand<TResult>
    {
        private readonly TourrentoDbContext _dbContext;

        public TransactionBehavior(TourrentoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<TResult> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResult> next)
        {
            using var tran = await _dbContext.Database.BeginTransactionAsync();

            try
            {
                var result = await next();
                await tran.CommitAsync();
                return result;
            }
            catch (System.Exception)
            {
                await tran.RollbackAsync();
                throw;
            }
        }
    }
}
