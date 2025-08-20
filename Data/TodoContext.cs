using InitCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace InitCRUD.Data;
public class TodoContext: DbContext 
{
    public DbSet<TodoModels> Todos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=todos.sqlite");
        base.OnConfiguring(optionsBuilder);
    }
}