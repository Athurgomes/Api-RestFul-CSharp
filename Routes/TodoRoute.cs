using InitCRUD.Data;
using InitCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace InitCRUD.Routes;

public static class TodoRoute
{
    public static void CrudRoutes(this WebApplication app)
    {
        var route=app.MapGroup("todo");

        route.MapPost("", async (TodoRequest req, TodoContext context) =>
        {
            var todos=new TodoModels(req.Todo, req.Status,  req.Prioridade);
            await context.AddAsync(todos);
            await context.SaveChangesAsync();
        });

        route.MapGet("", async (TodoContext context) =>
        {
            var todos = await context.Todos.ToListAsync();
            return Results.Ok(todos);
        });
        
        route.MapPut("{id:guid}", async (Guid id, TodoRequest req, TodoContext context) =>
        {
            var todos = await context.Todos.FirstOrDefaultAsync(x => x.Id == id);
            if(todos==null)
                return Results.NotFound();
            todos.UpdateTodo(req.Todo, req.Status, req.Prioridade);
            await context.SaveChangesAsync();
            return  Results.Ok(todos);
        });
        
        route.MapPatch("{id:guid}", async (Guid id, TodoPatchRequest req, TodoContext context) =>
        {
            var todos = await context.Todos.FirstOrDefaultAsync(x => x.Id == id);
            if(todos==null)
                return Results.NotFound();
            if (req.Todo!=null)
            {
                todos.ChangeTodo(req.Todo);
            }
            if (req.Status != null)
            {
                todos.ChangeStatus(req.Status.Value);
            }
            if (req.Prioridade != null)
            {
                todos.ChangePrioridade(req.Prioridade.Value);
            }
            await context.SaveChangesAsync();
            return  Results.Ok(todos);
        });
        
        route.MapDelete("{id:guid}", async (Guid id, TodoContext context) =>
        {
            var todos = await context.Todos.FindAsync(id);
            if(todos==null)
                return Results.NotFound();
            context.Todos.Remove(todos);
            await context.SaveChangesAsync();
            return Results.Ok(todos);
        });
    }
}