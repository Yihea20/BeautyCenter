using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyCenter.Models
{
    public class Person:IdentityUser
    {
       
        public string? Code { get; set; }
    }
}
