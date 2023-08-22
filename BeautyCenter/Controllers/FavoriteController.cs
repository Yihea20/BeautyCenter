using AutoMapper;
using BeautyCenter.DTOs;
using BeautyCenter.IRebository;
using BeautyCenter.Models;
using BeautyCenter.Rebository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static BeautyCenter.DTOs.CreateEmployee;
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
            var favorite = await _unitOfWork.Favorite.GetAll();
            var result = _mapper.Map<IList<Favorite>>(favorite);
            return Ok(result);
        }


        [HttpPost]
        [Route("add_favorite_service")]
        public async Task<IActionResult> AddServiceFavorite([FromBody] ServiceCreateFavorite favorite)
        {
            var result = _mapper.Map<Favorite>(favorite);
            await _unitOfWork.Favorite.Insert(result);
            await _unitOfWork.Save();
            return Ok();
        }
        [HttpPost]
        [Route("add_favorite_Employee")]
        public async Task<IActionResult> AddEmployeeFavorite([FromBody] EmployeeCreateFavorite favorite)
        {
            var result = _mapper.Map<Favorite>(favorite);
            await _unitOfWork.Favorite.Insert(result);
            await _unitOfWork.Save();
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFavorite(int id)
        {
            var favorite = await _unitOfWork.Favorite.Get(q => q.Id == id);


            if (favorite == null)
            {
                return NotFound();
            }
            else
            {
                await _unitOfWork.Favorite.Delete(id);
                await _unitOfWork.Save();


                return Ok();
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateFavorite(int id, [FromBody] CreateFavorite favoriteDto)
        {
            var old = await _unitOfWork.Favorite.Get(q => q.Id == id);
            _mapper.Map(favoriteDto, old);
            _unitOfWork.Favorite.Update(old);
            await _unitOfWork.Save();
            return Ok();
        }

        [HttpGet("{UserID}")]
        public async Task<IActionResult> Favorite(int UserID)
        {
            var favorite = await _unitOfWork.Favorite.GetAll(x => x.UserID == UserID , include: q => q.Include(x => x.Service), includee: q => q.Include(x => x.Employee));
            var result = _mapper.Map<IList<FavoriteDTO>>(favorite);
            return Ok(result);
        }
        [HttpGet("ServiceId")]
        public async Task<IActionResult> GetAllFavoriteService(int ServiceId)
        {
            var favorite = await _unitOfWork.Favorite.GetAll(x => x.ServiceId == ServiceId,include:q=>q.Include(x=>x.Service));
            var result = _mapper.Map<IList<FavoriteDTO>>(favorite);
            return Ok(result);
        }

        [HttpGet("EmployeeId")]
        public async Task<IActionResult> GetAllFavoriteEmployee(int EmployeeId)
        {
            var favorite = await _unitOfWork.Favorite.GetAll(x => x.EmployeeId == EmployeeId, include: q => q.Include(x => x.Employee));
            var result = _mapper.Map<IList<FavoriteDTO>>(favorite);
            return Ok(result);
        }

    }
}
