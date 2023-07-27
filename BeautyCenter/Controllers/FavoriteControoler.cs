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
    public class FavoriteControoler : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<FavoriteControoler> _logger;
        private readonly IMapper _mapper;

        public FavoriteControoler(IUnitOfWork unitOfWork, ILogger<FavoriteControoler> logger, IMapper mapper)
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
    }
}
