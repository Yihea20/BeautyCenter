using BeautyCenter.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyCenter.DTOs
{

    public class CreateAppointment
    {

        public int? ServiceId { set; get; }
        
        public string? UserID { set; get; }
 
        
        public string Status { set; get; }
        public DateTime DateTime { get; set; }
        public class AppointmentDTO :CreateAppointment
        {
            public int Id { get; set; }
        }
    }
}