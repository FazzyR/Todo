using Microsoft.EntityFrameworkCore;
using Todo.Data;
using Todo.Interfaces;
using Todo.Models;

namespace Todo.Repository
{
    public class TodoRepository:IToDoRepository
    {

        private readonly ApplicationDbContext _context;
        public TodoRepository(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }


        public Task<List<ToDoItem>> GetAllAsync() { 
        
        
            return _context.ToDoItems.ToListAsync();
        }
    }
}
