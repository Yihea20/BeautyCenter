using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyCenter.Models
{
    public class Notification
    {
        public int Id { set; get; }
        public string Title { get; set; }
        [ForeignKey(nameof(Service))]
        public int ServiceId { get; set; }
        public Service Service { get; set; } 
    }
}
