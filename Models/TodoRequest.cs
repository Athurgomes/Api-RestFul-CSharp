namespace InitCRUD.Models;
public record TodoRequest(string Todo, TodoModels.TodoStatus Status, TodoModels.TodoPrioridade Prioridade);
public record TodoPatchRequest(
    string? Todo,
    TodoModels.TodoStatus? Status,
    TodoModels.TodoPrioridade? Prioridade
);