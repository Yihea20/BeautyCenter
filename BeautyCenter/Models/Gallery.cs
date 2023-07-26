using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyCenter.Models
{
    public class Gallery
    {
        public int Id { get; set; }
       
        public ICollection<Image> Images { get; set; }

    }
}
