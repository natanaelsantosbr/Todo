﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Domain.Entities;
using Todo.Domain.Repositories;

namespace Todo.Domain.Tests.Repositories
{
    public class FakeTodoRepository : ITodoRepository
    {
        public void Create(TodoItem todo)
        {

        }

        public IEnumerable<TodoItem> GetAll(string user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TodoItem> GetAllDone(string user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TodoItem> GetAllUnDone(string user)
        {
            throw new NotImplementedException();
        }

        public TodoItem GetById(Guid id, string user)
        {
            return new TodoItem("Titulo Aqui", DateTime.Now, "Natanael");
        }

        public IEnumerable<TodoItem> GetByPeriod(string user, DateTime data, bool done)
        {
            throw new NotImplementedException();
        }

        public void Update(TodoItem todo)
        {

        }
    }
}
