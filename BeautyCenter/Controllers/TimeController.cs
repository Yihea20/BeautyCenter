using AutoMapper;
using BeautyCenter.DTOs;
using BeautyCenter.IRebository;
using BeautyCenter.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BeautyCenter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<TimeController> _logger;
        private readonly IMapper _mapper;


        public TimeController(IUnitOfWork unitOfWork, ILogger<TimeController> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task<IActionResult> AddTime([FromBody]CreateTiem model)
        {
            var time=_mapper.Map<TimeModel>(model);
            await _unitOfWork.TimeModel.Insert(time);
            await _unitOfWork.Save();
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetEmployeeTime(DateTime dateTime )
        {
            var time =await _unitOfWork.TimeModel.Get(q => q.DateTime == dateTime);
            if(time==null)
            {
                return Ok(time.EmployyId);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
