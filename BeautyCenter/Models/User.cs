using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyCenter.Models
{
   
    public class User:Person
    {

        public ICollection<Favorite>? Favorites { get; set; }
    }
}
