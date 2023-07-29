using AutoMapper;
using BeautyCenter.IRebository;
using BeautyCenter.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static BeautyCenter.DTOs.CreateFavorite;

namespace BeautyCenter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoriteController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<FavoriteController> _logger;
        private readonly IMapper _mapper;

        public FavoriteController(IUnitOfWork unitOfWork, ILogger<FavoriteController> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllFavorite()
        {
            var favorite = await _unitOfWork.Favorate.GetAll();
            var result = _mapper.Map<IList<Favorate>>(favorite);
            return Ok(result);
        }


        [HttpPost]
        public async Task<IActionResult> AddFavorite([FromBody] FavoriteDTO favorite)
        {
            var result = _mapper.Map<Favorate>(favorite);
            await _unitOfWork.Favorate.Insert(result);
            await _unitOfWork.Save();
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFavorite(int id)
        {
            var favorite = await _unitOfWork.Favorate.Get(q => q.Id == id);


            if (favorite == null)
            {
                return NotFound();
            }
            else
            {
                await _unitOfWork.Favorate.Delete(id);
                await _unitOfWork.Save();


                return Ok();
            }
        }

    }
}
