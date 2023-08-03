using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyCenter.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [ForeignKey(nameof(Center))]
        public int ?CenterId { get; set; }
        public Center? Center { get; set; }
        [ForeignKey(nameof(Image))]
        public int? ImageId { get; set; }
        public Image? Image { get; set; }
        [ForeignKey(nameof(Gallery))]
        public int? GalleryId { get; set; }
        public Gallery? Gallery { get; set; }
        public ICollection<Service>? ServicesOffers { get; set; }
      
        public int Points { get; set; }
        public ICollection< Offers>? Offers { get; set; }
        public ICollection<Favorate>? Favorates { get; set; }
    }
}
