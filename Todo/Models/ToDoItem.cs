using System.ComponentModel.DataAnnotations;

namespace Todo.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }=string.Empty;

        [Required]
        public string Description { get; set; }=String.Empty;


        public bool IsCompleted { get; set; }

        [Required]

        public DateOnly DueDate { get; set; }
    }
}
