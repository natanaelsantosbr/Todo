using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using Todo.Domain.Commands;
using Todo.Domain.Entities;
using Todo.Domain.Handlers;
using Todo.Domain.Repositories;

namespace Todo.Domain.Api.Controllers
{
    [ApiController]
    [Route("v1/todos")]
    public class TodoController : ControllerBase
    {
        [Route("")]
        [HttpGet]
        public IEnumerable<TodoItem> GetAll([FromBody] [FromServices] ITodoRepository repository)
        {
            return repository.GetAll("natanaelsantosbr");
        }

        [Route("")]
        [HttpPost]
        public GenericCommandResult Create([FromBody] CreateTodoCommand command,
            [FromServices] TodoHandler handler)
        {
            command.User = "natanaelsantosbr";
            return (GenericCommandResult)handler.Handle(command);
        }
    }
}
