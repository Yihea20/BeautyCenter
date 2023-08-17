using BeautyCenter.Models;
using System.Text.Json.Serialization;

namespace BeautyCenter.DTOs
{
    public class CreateCenter {
        public string Name { get; set; }
        public DateTime OpenTime { get; set; }
        public DateTime CloseTime { get; set;}    
    }
    public class CenterDTO : CreateCenter
    {
        public int Id { get; set; }       
    }
}
