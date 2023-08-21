using AutoMapper;
using BeautyCenter.DTOs;
using BeautyCenter.IRebository;
using BeautyCenter.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BeautyCenter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceEmployeeController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ServiceEmployeeController> _logger;
        private readonly IMapper _mapper;


        public ServiceEmployeeController(IUnitOfWork unitOfWork, ILogger<ServiceEmployeeController> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        [HttpPost]
        
        public async Task<IActionResult> AddUserAppointment([FromBody] CreateServiceEmployeeDTO appointment)
        {
            var result = _mapper.Map<ServiceEmployee>(appointment);
            
            await _unitOfWork.ServiceEmployee.Insert(result);

            await _unitOfWork.Save();
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetAllServiceEmployee()
        {
            var appointment = await _unitOfWork.ServiceEmployee.GetAll();
            var result = _mapper.Map<IList<ServiceEmployeeDTO>>(appointment);
            return Ok(result);
        }
        [HttpGet]
        [Route("Id")]
        public async Task<IActionResult> GetServiceEmployee(int id)
        {
            var appointment = await _unitOfWork.ServiceEmployee.Get(q=>q.Id==id);
            var result = _mapper.Map<ServiceEmployeeDTO>(appointment);
            return Ok(result);
        }
    }
}
