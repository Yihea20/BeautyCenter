namespace BeautyCenter.DTOs
{
    public class CreateServiceEmployeeDTO
    {

        public int ServiceId { set; get; }

        public int EmployeeId { get; set; }


    }
    public class ServiceEmployeeDTO:CreateServiceEmployeeDTO
    {
        public int Id { get; set; }
        }
}
