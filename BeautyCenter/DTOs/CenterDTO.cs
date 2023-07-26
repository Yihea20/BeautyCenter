namespace BeautyCenter.DTOs
{
    public class CreateCenter {
        //name
        public DateTime OpenTime { get; set; }
        public DateTime CloseTime
        {
            get; set;
        }
    public class CenterDTO:CreateCenter
    {
        public int Id { get; set; }
        }
    }
}
