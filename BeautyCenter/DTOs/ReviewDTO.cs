namespace BeautyCenter.DTOs
{
    public class CreateEmployeeReview {
        public string Reviews { get; set; }

        public int EmployeeId { get; set; }
    }
    public class CreateServiceReview
    {
        public string Reviews { get; set; }
        public int ServiceId { get; set; }
       
    }
    public class LikeDto
    {
        public int Like { get; set; }
    }
    public class ReviewDTO
    {
        public int Id { get; set; }
            public string Reviews { get; set; }
            public int ServiceId { get; set; }
            public int EmployeeId { get; set; }
       
    }
}
