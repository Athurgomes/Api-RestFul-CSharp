namespace InitCRUD.Models;

public class TodoModels
{
    public TodoModels(string todo, TodoStatus status)
    {
        Todo = todo;
        Status = status;
        Id = Guid.NewGuid();
    }

    public enum TodoStatus
    {
        NaoIniciada=0,
        EmAndamento=1,
        Concluida=2,
        Cancelada=3
    }
    
    public Guid Id { get; init; }
    public string Todo { get; private set; }
    public TodoStatus Status { get; private set; }

    public void ChangeTodo(string todo)
    {
        Todo = todo;
    }

    public void ChangeStatus(TodoStatus status)
    {
        Status = status;
    }
    public void UpdateTodo(string todo, TodoStatus status)
    {
        Todo = todo;
        Status = status;
    }
}