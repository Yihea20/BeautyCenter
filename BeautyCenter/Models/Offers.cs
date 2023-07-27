using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyCenter.Models
{
    public class Offers
    {
        public int Id { get; set; }
        [ForeignKey(nameof(Service))]
        public int ?IdSerivce { get; set; }
        public Service? Service { get; set; }
        public int? IdSerivce { get; set; }
        public Service? Service { get; set; }
        public string Description { get; set; }
    }
    public class Package : Offers { } 
}
