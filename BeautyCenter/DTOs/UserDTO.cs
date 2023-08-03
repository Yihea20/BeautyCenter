using BeautyCenter.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyCenter.DTOs
{
    public class CreateUserDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CenterId { get; set; }
        public int Points { get; set; }

    }
    public class UserDTO : CreateUserDTO
    {
        public int Id {get; set; }
    }
}
