using Microsoft.EntityFrameworkCore;
using TodoListApi.Data;
using TodoListApi.Models;
using TodoListApi.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace TodoListApi.Testes
{
    public class TarefasControllerTestes
    {
        private AppDbContext CriarContexto()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            return new AppDbContext(options);
        }

        [Fact]
        public async Task CriarTarefa_DeveRetornar201()
        {
            // Preparar
            var context = CriarContexto();
            var controller = new TarefasController(context);
            var novaTarefa = new Tarefa
            {
                Titulo = "Tarefa de teste",
                Descricao = "Descrição de teste",
                Concluida = false
            };

            // Agir
            var resultado = await controller.PostTarefa(novaTarefa);

            // verificar
            var createdResult = Assert.IsType<CreatedAtActionResult>(resultado.Result);
            Assert.Equal(201, createdResult.StatusCode);
        }

        [Fact]
        public async Task ListarTarefas_DeveRetornarListaVazia()
        {
            // Arrange
            var context = CriarContexto();
            var controller = new TarefasController(context);

            // Act
            var resultado = await controller.GetTarefas();

            // Assert
            var okResult = Assert.IsType<List<Tarefa>>(resultado.Value);
            Assert.Empty(okResult);
        }
    }
}