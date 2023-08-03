using BeautyCenter.Models;

namespace BeautyCenter.DTOs
{
    public class CreateEmployee
    {
        public int Rate { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int TotlaRate { get; set; }
        //public ICollection<Service>? ServicesCanDo { get; set; }
        public DateTime DateTime { get; set; }
        public string Exp { get; set; }

        public class EmployeeDTO :CreateEmployee
        {
            public int Id { get; set; }
        }
    }
}