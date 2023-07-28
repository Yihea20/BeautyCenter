namespace BeautyCenter.DTOs
{
    public class CreateOffer
    {
        public string Description { get; set; }
    
        public class OfferDTO : CreateOffer
        {
            public int Id { get; set; }
        }
}

}
