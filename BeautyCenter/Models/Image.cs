using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyCenter.Models
{
    public class Image
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string? URL { get; set; }
        [ForeignKey(nameof(Gallery))]
        public int? GalleryId { get; set; }
        public Gallery? Gallery { get; set; }
    }
}
