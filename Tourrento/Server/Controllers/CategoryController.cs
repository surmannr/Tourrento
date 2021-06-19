using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tourrento.BLL.Category.Commands;
using Tourrento.BLL.Category.Queries;
using Tourrento.Shared.Dto;

namespace Tourrento.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator mediator;

        public CategoryController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<List<Category>> GetCategories([FromQuery] GetCategories.Query query)
        {
            return await mediator.Send(query);
        }

        [HttpPost]
        public async Task<Category> AddNewCategory([FromBody] NewCategory.Command command)
        {
            return await mediator.Send(command);
        }

        [HttpDelete]
        public async Task DeleteCategory([FromQuery] DeleteCategory.Command command)
        {
            await mediator.Send(command);
        }
    }
}
