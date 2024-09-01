using Todo.Models;

namespace Todo.Interfaces
{
    public interface IToDoRepository
    {
        Task<List<ToDoItem>> GetAllAsync();

    }
}
