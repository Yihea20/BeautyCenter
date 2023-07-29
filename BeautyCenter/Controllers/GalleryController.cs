using AutoMapper;
using BeautyCenter.IRebository;
using BeautyCenter.Models;
using BeautyCenter.Rebository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using static BeautyCenter.DTOs.CreateGallery;

namespace BeautyCenter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GalleryController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GalleryController> _logger;
        private readonly IMapper _mapper;

        public GalleryController(IUnitOfWork unitOfWork, ILogger<GalleryController> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task<IActionResult> AddGallery([FromBody] GalleryDTO gallery)
        {
            var result = _mapper.Map<Gallery>(gallery);
            await _unitOfWork.Gallery.Insert(result);
            await _unitOfWork.Save();
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetAllGallery()
        {

            var gallery = await _unitOfWork.Gallery.GetAll();
            var result = _mapper.Map<IList<GalleryDTO>>(gallery);
            return Ok(result);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGallery(int id)
        {
            var gallery = await _unitOfWork.Gallery.Get(q => q.Id == id);


            if (gallery == null)
            {
                return NotFound();
            }
            else
            {
                await _unitOfWork.Gallery.Delete(id);
                await _unitOfWork.Save();


                return Ok();
            }
        }
    }
}
