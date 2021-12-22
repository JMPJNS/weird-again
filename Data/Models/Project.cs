using System.ComponentModel.DataAnnotations;

namespace Weird_Again.Data.Models
{
    public class Project
    {
        public int Id { get; set; }

        [Required]
        [StringLength(128, MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        [StringLength(2000, MinimumLength = 2)]
        public string Description { get; set; }

        [Required]
        [StringLength(2000, MinimumLength = 2)] 
        public string GithubUrl { get; set; }

        public string ImageUrl { get; set; }
    }
}
