using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyCenter.Models
{
    
    public class Employee:Person
    {        
        public int Rate { get; set; }
        public int TotlaRate { get; set; }
        
        public ICollection<Favorite>? Favorites { get; set; }
        public ICollection<Service>? ServicesCanDo { get; set; }
        public ICollection<TimeModel>? DateTime { get; set; }
        public ICollection <Review>? Reviews { get; set; }
        public string Exp { get; set; }
    }
}
