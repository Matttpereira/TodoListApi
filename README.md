# ToDoList API

API REST para gerenciamento de tarefas (To Do List) desenvolvida em C# com ASP.NET Core.

## Tecnologias
- .NET 8.0
- ASP.NET Core Web API
- Entity Framework Core 8.0
- SQL Server Express
- Swagger (Swashbuckle)
- xUnit (testes unitários)

## Pré-requisitos
- Visual Studio 2022
- .NET 8.0 SDK (ARM64 ou x64)
- SQL Server Express

## Como executar

### 1. Clonar o repositório
git clone https://github.com/Matttpereira/TodoListApi.git

### 2. Configurar o banco de dados
No arquivo `appsettings.json`, verifique a string de conexão:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost\\SQLEXPRESS;Database=TodoListDb;Trusted_Connection=True;TrustServerCertificate=True"
}
```

### 3. Criar o banco de dados
No terminal, dentro da pasta TodoListApi: 
```
dotnet ef database update
```

### 4. Executar o projeto
Abra no Visual Studio 2022 e pressione F5.

O Swagger estará disponível em: `https://localhost:7006/swagger`

## Endpoints

| Método | Rota | Descrição |
|--------|------|-----------|
| GET | /api/Tarefas | Lista todas as tarefas |
| GET | /api/Tarefas/{id} | Busca tarefa por ID |
| POST | /api/Tarefas | Cria nova tarefa |
| PUT | /api/Tarefas/{id} | Atualiza tarefa |
| DELETE | /api/Tarefas/{id} | Remove tarefa |

## Testes
Para executar os testes unitários, no Visual Studio:

**Teste** → **Executar Todos os Testes**
