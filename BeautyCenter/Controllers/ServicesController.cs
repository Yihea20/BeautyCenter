using AutoMapper;
using BeautyCenter.DTOs;
using BeautyCenter.IRebository;
using BeautyCenter.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static BeautyCenter.DTOs.CreateCenter;
using static BeautyCenter.DTOs.CreateService;

namespace BeautyCenter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ServicesController> _logger;
        private readonly IMapper _mapper;
        public ServicesController(IUnitOfWork unitOfWork, ILogger<ServicesController> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task<IActionResult> AddService([FromBody] CreateService service)
        {
            var result = _mapper.Map<Service>(service);
            await _unitOfWork.Service.Insert(result);
            await _unitOfWork.Save();
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetAllServices()
        {

            var  service= await _unitOfWork.Service.GetAll();
            var result = _mapper.Map<IList<ServiceDTO>>(service);
            return Ok(result);
        }
    }
}
