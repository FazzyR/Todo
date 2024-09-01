using Microsoft.AspNetCore.Mvc;
using Todo.Data;
using Todo.Interfaces;
using Todo.Models;
using Todo.ViewModels;

namespace Todo.Controllers
{
    public class ToDoController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly IToDoRepository _todoRepo;
        public ToDoController(ApplicationDbContext dbContext, IToDoRepository TodoRepo)
        {
            _context = dbContext;
            _todoRepo = TodoRepo;
        }
        public IActionResult Index()
        {
            var todoitems=_context.ToDoItems.ToList();

            return View(todoitems);
        }


        public IActionResult CreateToDo()
        {


            return View();
        }

        [HttpPost]
        public IActionResult CreateToDo(CreateToDoItemViewModel createToDoItemViewModel)
        {

           ToDoItem toDoItem = new ToDoItem
           {
               Title= createToDoItemViewModel.Title,
               Description= createToDoItemViewModel.Description,
               IsCompleted= createToDoItemViewModel.IsCompleted,
               DueDate= createToDoItemViewModel.DueDate,

           };
            _context.Add(toDoItem);


            return View("Index");
        }
    }
}
