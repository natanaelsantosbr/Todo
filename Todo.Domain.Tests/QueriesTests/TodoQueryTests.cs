using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Domain.Entities;
using Todo.Domain.Queries;

namespace Todo.Domain.Tests.QueriesTests
{
    [TestClass]
    public class TodoQueryTests
    {
        private List<TodoItem> _items;

        public TodoQueryTests()
        {
            _items = new List<TodoItem>
            {
                new TodoItem("Tarefa 1", DateTime.Now, "natanael"),
                new TodoItem("Tarefa 2", DateTime.Now, "natanael2"),
                new TodoItem("Tarefa 3", DateTime.Now, "natanael"),
                new TodoItem("Tarefa 4", DateTime.Now, "natanael2"),
                new TodoItem("Tarefa 5", DateTime.Now, "natanael")
            };

        }


        [TestMethod]
        public void Dada_a_consulta_deve_retornar_tarefas_apenas_do_usuario_natanael()
        {
            var result = _items.AsQueryable().Where(TodoQueries.GetAll("natanael"));
            Assert.AreEqual(3, result.Count());
        }
    }
}
