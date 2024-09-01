using System.ComponentModel.DataAnnotations;

namespace Todo.ViewModels
{
    public class CreateToDoItemViewModel
    {

      

        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; } = String.Empty;


        public bool IsCompleted { get; set; }

        [Required]
        [Display(Name = "DueDate")]

        public DateOnly DueDate { get; set; }


    }
}
