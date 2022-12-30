using System;
using System.ComponentModel.DataAnnotations;

namespace MovieApp.Models
{
	public class Movie
	{
		public int Id { get; set; }

        [StringLength(50)]
        [Required]
        public String Name { get; set; }

        [StringLength(500)]
        public String? Description { get; set; }

        [Display(Name = "Release Year")]
        [RegularExpression(@"^(\d{4})$", ErrorMessage = "Please use YYYY format.")]
        [Required]
        public int ReleaseYear { get; set; }

	}
}

