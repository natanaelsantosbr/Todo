using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Domain.Entities
{
    public class TodoItem : Entity
    {
        public TodoItem()
        {
            this.Done = false;
        }

        public TodoItem(string title, DateTime date, string user)
        {
            this.Title = title;
            this.Date = date;
            this.User = user;
        }

        public string Title { get; private set; }
        public bool Done { get; private set; }
        public DateTime Date { get; private set; }
        public string User { get; set; }

        public void MarkAsDone()
        {
            this.Done = true;
        }

        public void MarkAsUndone()
        {
            this.Done = false;
        }

        public void UpdateTitle(string title)
        {
            this.Title = title;
        }

    }
}
