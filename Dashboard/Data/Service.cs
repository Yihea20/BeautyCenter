using System.ComponentModel.DataAnnotations.Schema;

namespace Dashboard.Data
{
    public class Service
    {
        public int Id { get; set; }

        public int Price { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int TopServic { get; set; }

        public string? ImageURL { get; set; }
        public string details { get; set; }
         public DateTime CreatedDate { get; set; }
       
    }
}
