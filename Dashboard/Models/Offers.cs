﻿using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyCenter.Models
{
    public class Offers
    {
        public int Id { get; set; }
        [ForeignKey(nameof(Service))]
        public int? IdSerivce { get; set; }
        public Service? Service { get; set; }
        [ForeignKey(nameof(User))]
        public int? UserId { get; set; }
        public User? User { get; set; }
        public string Description { get; set; }
    }
    public class Package : Offers 
    { } 
}
