using AutoMapper;
using BeautyCenter.DTOs;
using BeautyCenter.IRebository;
using BeautyCenter.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using static BeautyCenter.DTOs.CreateGallery;
using static BeautyCenter.DTOs.CreateImage;

namespace BeautyCenter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ImageController> _logger;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment environment;
        public ImageController(IUnitOfWork unitOfWork, ILogger<ImageController> logger, IMapper mapper, IWebHostEnvironment _environment)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
            environment = _environment;
        }
        [NonAction]
        private string GetFilePath(string name)
        {
            return this.environment.WebRootPath + "/Upload/image/" + name;
        }
        [HttpPost]
        public async Task<IActionResult> AddImage([FromForm] ImageFile image)
        {
            //CreateImage create = new CreateImage();
            string imageURL = string.Empty;
            string hosturl = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}";
            try
            {
                string FilePath = GetFilePath(image.Create.Name);

                if (!System.IO.Directory.Exists(FilePath))
                {
                    System.IO.Directory.CreateDirectory(FilePath);
                }
                string url = FilePath + "/" + image.Create.Name + ".png";
                if (System.IO.File.Exists(url))
                {
                    System.IO.File.Delete(url);
                }
                using (FileStream stream = System.IO.File.Create(url))
                {
                    await image.file.CopyToAsync(stream);
                    var result = _mapper.Map<Image>(image.Create);
                    result.URL = hosturl + "/Upload/image/" + image.Create.Name + "/" + image.Create.Name + ".png"; 
                    await _unitOfWork.Image.Insert(result);
                    await _unitOfWork.Save();
                    return Ok();
                }
            }
            catch (Exception e) {
                return NotFound();
            }

        }
        [HttpGet]
        public async Task<IActionResult> GetAllImage()
        {
           
            var image = await _unitOfWork.Image.GetAll();
            var result = _mapper.Map<IList<ImageDTO>>(image);

            return Ok(result);
        }
        [HttpGet]
        [Route("id")]
        public async Task<IActionResult> GetImage(int id)
        {

            var image = await _unitOfWork.Image.Get(q => q.Id == id);
            var result = _mapper.Map<ImageDTO>(image);

            return Ok(result);
        }

        [HttpGet]
        [Route("download")]
        public async Task<IActionResult> DownloadImage(int id)
        {

            var image = await _unitOfWork.Image.Get(q => q.Id == id);
            if (System.IO.File.Exists(image.URL))
            {
                MemoryStream stream = new MemoryStream();
                using (FileStream file = new FileStream(image.URL, FileMode.Open)
                )
                {
                    await file.CopyToAsync(stream);
                }
                stream.Position = 0;
                return File(stream,"image/jpg",image.Name+".jpg");
            }
            else { return NotFound(); }
        }
        [HttpGet]
        [Route("show")]
        public async Task<IActionResult> ShowImage(int id)
        {

            var image = await _unitOfWork.Image.Get(q => q.Id == id);
            if (System.IO.File.Exists(image.URL))
            {
                MemoryStream stream = new MemoryStream();
                using (FileStream file = new FileStream(image.URL, FileMode.Open)
                )
                {
                    await file.CopyToAsync(stream);
                }
                stream.Position = 0;
                return File(stream, "image/jpg" + image.Name + ".jpg");
            }
            else { return NotFound(); }
        }

        [HttpDelete]
        [Route("remove")]
        public async Task<IActionResult> DeleteImage(int id)
        {
            var image = await _unitOfWork.Image.Get(q => q.Id == id);


            try
            {

                if (System.IO.File.Exists(image.URL))
                {
                    System.IO.File.Delete(image.URL);
                    await _unitOfWork.Image.Delete(id);
                    await _unitOfWork.Save();

                    return Ok();
                }
                else
                {
                   

                    return NotFound();
                }
            }
            catch (Exception e){ return BadRequest(); }
        }
        //[HttpPut("{id}")]
        //public async Task<IActionResult> UpdateImage(int id, [FromBody] CreateImage ImageDto)
        //{
        //    var old = await _unitOfWork.Image.Get(q => q.Id == id);
        //    _mapper.Map(ImageDto, old);
        //    _unitOfWork.Image.Update(old);
        //    await _unitOfWork.Save();
        //    return Ok();
        //}

    }
}
