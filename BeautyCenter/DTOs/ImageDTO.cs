using Microsoft.AspNetCore.Mvc;

namespace BeautyCenter.DTOs
{
    
    public class CreateImage
    {
       
        public string Name { get; set; }
    }
    public class ImageDTO
        {
            public int Id { get; set; }
        public string ImagyArray { get; set; }
        }
    public class ImageFile 
    {
        public CreateImage Create { get; set; }
        public IFormFile file { get; set; }
        //public ImageFile()
        //{
        //    this.Create = new CreateImage();
        //}

    }
}