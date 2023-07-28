using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyCenter.Models
{
    public class User:Person
    {
        public ICollection<Service>? ServicesOffers { get; set; }
      
        public int Points { get; set; }
        public ICollection< Offers>? Offers { get; set; }
        public ICollection<Favorate>? Favorates { get; set; }
    }
}
