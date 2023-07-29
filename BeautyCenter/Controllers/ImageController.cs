using AutoMapper;
using BeautyCenter.IRebository;
using BeautyCenter.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<IActionResult> AddImage([FromBody] ImageDTO image)
        {
            
                var result = _mapper.Map<Image>(image);
                await _unitOfWork.Image.Insert(result);
                await _unitOfWork.Save();
                return Ok();
           }
        [HttpGet]
        public async Task<IActionResult> GetAllImage()
        {

            var image = await _unitOfWork.Image.GetAll();
            var result = _mapper.Map<IList<ImageDTO>>(image);
            return Ok(result);
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

    }
}
