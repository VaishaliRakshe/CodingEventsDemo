using System;
using System.ComponentModel.DataAnnotations;

namespace CodingEventsDemo.ViewModels
{
    public class AddEventViewModel
    {
        [Required(ErrorMessage ="Name is required.")]
        [StringLength(12, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 character.")]

        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a description for your event.")]
        [StringLength(500, ErrorMessage = "Description is too long!")]
        public string Description { get; set; }
        [EmailAddress]
        public string ContactEmail { get; set; }
    }
}
