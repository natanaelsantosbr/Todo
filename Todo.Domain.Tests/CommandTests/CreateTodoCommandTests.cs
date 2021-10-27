using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Todo.Domain.Commands;

namespace Todo.Domain.Tests.CommandTests
{
    [TestClass]
    public class CreateTodoCommandTests
    {
        private readonly CreateTodoCommand _invalidCommand = new CreateTodoCommand("", "", DateTime.Now);

        private readonly CreateTodoCommand _validCommand = new CreateTodoCommand("Titulo da Tarefa", "Natanael", DateTime.Now);

        public CreateTodoCommandTests()
        {

        }

        [TestMethod]
        public void Dado_um_comando_invalido()
        {            
            Assert.AreEqual(_invalidCommand.Valid, false);
        }


        [TestMethod]
        public void Dado_um_comando_valido()
        {            
            Assert.AreEqual(_validCommand.Valid, true);
        }
    }
}
