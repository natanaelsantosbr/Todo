using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Todo.Domain.Commands;

namespace Todo.Domain.Tests.CommandTests
{
    [TestClass]
    public class CreateTodoCommandTests
    {
        [TestMethod]
        public void Dado_um_comando_invalido()
        {
            var command = new CreateTodoCommand("", "", DateTime.Now);
            command.Validate();
            Assert.AreEqual(command.Valid, false);
            Assert.AreEqual(command.Invalid, true);
        }


        [TestMethod]
        public void Dado_um_comando_valido()
        {
            var command = new CreateTodoCommand("Titulo da Tarefa", "Natanael", DateTime.Now);
            command.Validate();
            Assert.AreEqual(command.Valid, true);
            Assert.AreEqual(command.Invalid, false);
        }
    }
}
