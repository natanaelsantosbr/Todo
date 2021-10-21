using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Domain.Commands.Contracts
{
    public class CreateTodoCommand : ICommand
    {
        public CreateTodoCommand()
        {

        }

        public string Title { get; set; }

        public string User { get; set; }

        public DateTime Date { get; set; }

        public bool Validate()
        {
            throw new NotImplementedException();
        }
    }
}
