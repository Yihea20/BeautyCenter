using AutoMapper;
using BeautyCenter.DTOs;
using BeautyCenter.IRebository;
using BeautyCenter.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static BeautyCenter.DTOs.CreateCenter;

namespace BeautyCenter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CenterController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CenterController> _logger;
        private readonly IMapper _mapper;

        public CenterController(IUnitOfWork unitOfWork, ILogger<CenterController> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task<IActionResult> AddCenter([FromBody] CreateCenter center)
        {
            var result = _mapper.Map<Center>(center);
            await _unitOfWork.Center.Insert(result);
            await _unitOfWork.Save();
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCenter() {

            var center = await _unitOfWork.Center.GetAll();
            var result = _mapper.Map<IList<CenterDTO>>(center);
            return Ok(result);
        }
       
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCenter(int id)
        {
           var center = await _unitOfWork.Center.Get(q=>q.Id==id);


            if (center == null)
            {
                return NotFound();
            }
            else
            {
                await _unitOfWork.Center.Delete(id);
                await _unitOfWork.Save();


                return Ok();
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCenter(int id, [FromBody] CreateCenter centerDto)
        {
            var old = await _unitOfWork.Center.Get(q => q.Id == id);
            _mapper.Map(centerDto, old);
            _unitOfWork.Center.Update(old);
            await _unitOfWork.Save();
            return Ok();
        }
    }
}
