using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using BeautyCenter.Models;

namespace Dashboard.Data
{
   

        public class Appontment
        {
            public Bokking[] Appoinments { get; set; }
        }

        public class Bokking
        {
        [JsonPropertyName("Id")]
            public int Id { get; set; }
            public DateTime DateTime { get; set; }
            public string Status { get; set; }
            public int ServiceId { get; set; }
            public int? UserID { get; set; }
           public int? employeeId { get; set; }
             }

       

    }
