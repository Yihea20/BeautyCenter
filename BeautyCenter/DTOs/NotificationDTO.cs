using BeautyCenter.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyCenter.DTOs
{
    public class CreateNotificationForUser
    {

        public string Title { get; set; }
        public string Body { get; set; }
        public string Token { get; set; }
        public int? ServiceId { get; set; }
     

    }
    public class CreateNotificationForGroup
    {   public string Title { get; set; }
        public string Body { get; set; }
        public string? Topic { get; set; }
        public int? ServiceId { get; set; }

    }
    public class NotificationDTO
    {
        public int Id { set; get; }
    }
}