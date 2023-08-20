using AutoMapper;
using BeautyCenter.DTOs;
using BeautyCenter.IRebository;
using BeautyCenter.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static BeautyCenter.DTOs.CreateEmployee;
using static BeautyCenter.DTOs.CreateGallery;

namespace BeautyCenter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<EmployeeController> _logger;
        private readonly IMapper _mapper;

        public EmployeeController(IUnitOfWork unitOfWork, ILogger<EmployeeController> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task<IActionResult> AddEmployee([FromBody] CreateEmployee employee)
        {
            var result = _mapper.Map<Employee>(employee);
            await _unitOfWork.Employee.Insert(result);
            await _unitOfWork.Save();
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetAllEmployee()
        {

            var employee = await _unitOfWork.Employee.GetAll();
            var result = _mapper.Map<IList<EmployeeDTO>>(employee);
            return Ok(result);
        }
        [HttpGet]
        [Route("TopEmployee")]
        public async Task<IActionResult> GetTopEmployee()
        {

            var employee = await _unitOfWork.Employee.GetAll(orderBy:q=>q.OrderByDescending(x=>x.Rate));
            var result = _mapper.Map<IList<EmployeeDTO>>(employee);
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var employee = await _unitOfWork.Employee.Get(q => q.Id == id);


            if (employee == null)
            {
                return NotFound();
            }
            else
            {
                await _unitOfWork.Employee.Delete(id);
                await _unitOfWork.Save();


                return Ok();
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmployee(int id, [FromBody] CreateEmployee employee)
        {
            var old = await _unitOfWork.Employee.Get(q => q.Id == id);
            _mapper.Map(employee, old);
            _unitOfWork.Employee.Update(old);
            await _unitOfWork.Save();
            return Ok();
        }

        [HttpGet("{FirstName}")]
        public async Task<IActionResult> EmployeeByFirstname(String FirstName)
        {
            var employee = await _unitOfWork.Employee.GetAll(q => q.FirstName == FirstName);
            var result = _mapper.Map<IList<EmployeeDTO>>(employee);
            return Ok(result);

        }
        [HttpPost("{LastName}")]
        public async Task<IActionResult> EmployeeByLastname(String LastName)
        {
            var employee = await _unitOfWork.Employee.GetAll(q => q.LastName == LastName);
            var result = _mapper.Map<IList<EmployeeDTO>>(employee);
            return Ok(result);

        }

        [HttpGet("Rate")]
        public async Task<IActionResult> EmployeeByRate(int rate)
        {
            var employee = await _unitOfWork.Employee.GetAll(q => q.Rate == rate);
            var result = _mapper.Map<IList<EmployeeDTO>>(employee);
            return Ok(result);

        }

    }
}

