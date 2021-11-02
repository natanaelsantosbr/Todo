using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Domain.Entities;
using Todo.Domain.Infra.Contexts;
using Todo.Domain.Queries;
using Todo.Domain.Repositories;

namespace Todo.Domain.Infra.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        private readonly DataContext _context;

        public TodoRepository(DataContext context)
        {
            this._context = context;
        }

        public void Create(TodoItem todo)
        {
            this._context.Todos.Add(todo);
            this._context.SaveChanges();
        }

        public IEnumerable<TodoItem> GetAll(string user)
        {
            //AsNoTracking = Ele nao cria um objeto na memoria (Usar quando for apenas select, nao tiver update)
            return this._context.Todos.AsNoTracking()
                .Where(TodoQueries.GetAll(user))
                .OrderBy(a => a.Date);
        }

        public IEnumerable<TodoItem> GetAllDone(string user)
        {
            return this._context.Todos.AsNoTracking()
                .Where(TodoQueries.GetAllDone(user))
                .OrderBy(a => a.Date);
        }

        public IEnumerable<TodoItem> GetAllUnDone(string user)
        {
            return this._context.Todos.AsNoTracking()
                .Where(TodoQueries.GetAllUnDone(user))
                .OrderBy(a => a.Date);
        }

        public TodoItem GetById(Guid id, string user)
        {
            return this._context.Todos.AsNoTracking()
                .Where(a => a.Id == id && a.User == user)
               .FirstOrDefault();
        }

        public IEnumerable<TodoItem> GetByPeriod(string user, DateTime data, bool done)
        {
            return this._context.Todos.AsNoTracking()
                .Where(TodoQueries.GetByPeriod(user, data, done))
                .OrderBy(a => a.Date);
        }

        public void Update(TodoItem todo)
        {
            this._context.Entry(todo).State = EntityState.Modified;
            this._context.SaveChanges();
        }
    }
}
