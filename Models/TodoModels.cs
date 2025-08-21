namespace InitCRUD.Models;

public class TodoModels
{
    public TodoModels(string todo, TodoStatus status, TodoPrioridade prioridade)
    {
        Todo = todo;
        Status = status;
        Prioridade = prioridade;
        Id = Guid.NewGuid();
    }

    public enum TodoStatus
    {
        NaoIniciada=0,
        EmAndamento=1,
        Concluida=2,
        Cancelada=3
    }
    
    public enum TodoPrioridade
    {
        Baixa=0,
        Media=1,
        Alta=2
    }
    
    public Guid Id { get; init; }
    public string Todo { get; private set; }
    public TodoStatus Status { get; private set; }
    public TodoPrioridade Prioridade { get; private set; }
    public void ChangeTodo(string todo)
    {
        Todo = todo;
    }
    public void ChangeStatus(TodoStatus status)
    {
        Status = status;
    }
    public void ChangePrioridade(TodoPrioridade prioridade)
    {
        Prioridade = prioridade;
    }
    public void UpdateTodo(string todo, TodoStatus status,  TodoPrioridade prioridade)
    {
        Todo = todo;
        Status = status;
        Prioridade = prioridade;
    }
}