using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment6.Models
{

    public class Movie
    {
        public int Id { get; set; }
        
        [Required]
        public string Title { get; set; }
        
        public int Year { get; set; }
        
        public string Genre { get; set; }

        public virtual ICollection<MovieActor>? MovieActors { get; set; }
    }
}