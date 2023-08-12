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

        public ImageController(IUnitOfWork unitOfWork, ILogger<ImageController> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task<IActionResult> AddImage([FromForm]ImageFile image)
        {
            //CreateImage create = new CreateImage();
            try
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    await image.file.CopyToAsync(stream);
                    //create.Name = image;

                    var result = _mapper.Map<Image>(image.Create) ;
                    result.ImageArray = stream.ToArray();
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

            var image = await _unitOfWork.Image.Get(q=>q.Id==id);
            var result = _mapper.Map<ImageDTO>(image);
            result.ImagyArray = Convert.ToBase64String(image.ImageArray);
            return Ok(result);
        }

        [HttpGet]
        [Route("download")]
        public async Task<IActionResult> DownloadImage(int id)
        {

            var image = await _unitOfWork.Image.Get(q => q.Id == id);
            return File(image.ImageArray,"image/jpg",image.Name+".jpg");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteImage(int id)
        {
            var image = await _unitOfWork.Image.Get(q => q.Id == id);


            if (image == null)
            {
                return NotFound();
            }
            else
            {
                await _unitOfWork.Image.Delete(id);
                await _unitOfWork.Save();


                return Ok();
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateImage(int id, [FromBody] CreateImage ImageDto)
        {
            var old = await _unitOfWork.Image.Get(q => q.Id == id);
            _mapper.Map(ImageDto, old);
            _unitOfWork.Image.Update(old);
            await _unitOfWork.Save();
            return Ok();
        }

    }
}
