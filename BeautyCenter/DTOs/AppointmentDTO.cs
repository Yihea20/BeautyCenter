﻿using BeautyCenter.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyCenter.DTOs
{

    public class CreateAppointment
    {
       
        //public int? ServiceId { set; get; }
        //public Service Service { set; get; }
        //[ForeignKey(nameof(User))]
        //public string? UserID { set; get; }
        //public User? User { get; set; }
        //[ForeignKey(nameof(Employee))]
        //public string? EmployeeId { set; get; }
        //public Employee? Employee { get; set; }
        public DateTime DateTime { get; set; }
        public class AppointmentDTO :CreateAppointment
        {
            public int Id { get; set; }
        }
    }
}