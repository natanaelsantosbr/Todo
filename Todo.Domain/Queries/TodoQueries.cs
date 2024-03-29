﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Todo.Domain.Entities;

namespace Todo.Domain.Queries
{
    public static class TodoQueries
    {
        public static Expression<Func<TodoItem, bool>> GetAll(string user)
        {
            return x => x.User == user;
        }

        public static Expression<Func<TodoItem, bool>> GetAllDone(string user)
        {
            return x => x.User == user && x.Done;
        }

        public static Expression<Func<TodoItem, bool>> GetAllUnDone(string user)
        {
            return x => x.User == user && !x.Done;
        }

        public static Expression<Func<TodoItem, bool>> GetByPeriod(string user, DateTime data, bool done)
        {
            return x => x.User == user &&
            x.Done == done &&
            x.Date.Date == data.Date;
        }

        public static Expression<Func<TodoItem, bool>> GetById(string user, DateTime data, bool done)
        {
            return x => x.User == user &&
            x.Done == done &&
            x.Date.Date == data.Date;
        }
    }
}
