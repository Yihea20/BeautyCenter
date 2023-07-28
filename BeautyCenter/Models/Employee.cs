namespace BeautyCenter.Models
{
    public class Employee:User
    {
        
        public int Rate { get; set; }
        public int TotlaRate { get; set; }
        public ICollection<Service>? ServicesCanDo { get; set; }
        public DateTime DateTime { get; set; }
        public string Exp { get; set; }
    }
}
