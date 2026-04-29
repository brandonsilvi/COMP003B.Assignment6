using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment6.Models
{
    public class Actor
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        public string Nationality { get; set; }

        public virtual ICollection<MovieActor> MovieActors { get; set; }
    }
}