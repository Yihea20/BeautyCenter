namespace BeautyCenter.DTOs
{
    public class TimeDTO:CreateTiem
    {
        public int Id { get; set; }
    }
    public class CreateTiem {
        public int EmployeeId { get; set; }
        public DateTime DateTime { get; set; }
    }
}
