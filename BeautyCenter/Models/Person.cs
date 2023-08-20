using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyCenter.Models
{
    public class Person
    {
        
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [ForeignKey(nameof(Center))]
        public int? CenterId { get; set; }
        public Center? Center { get; set; }
        public string ? ImageURL { get; set; }
        [ForeignKey(nameof(Gallery))]
        public int? GalleryId { get; set; }
        public Gallery? Gallery { get; set; }
        public ICollection<Service> ServicesOffers { get; set; }

        public int Points { get; set; }
        public ICollection<Offers>? Offers { get; set; }
        public ICollection<Favorite>? Favorites { get; set; }

    }
}
