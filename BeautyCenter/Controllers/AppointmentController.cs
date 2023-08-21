using AutoMapper;
using BeautyCenter.DTOs;
using BeautyCenter.IRebository;
using BeautyCenter.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static BeautyCenter.DTOs.CreateAppointment;



namespace BeautyCenter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<AppointmentController> _logger;
        private readonly IMapper _mapper;

        public AppointmentController(IUnitOfWork unitOfWork, ILogger<AppointmentController> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAppointment()
        {
            var appointment = await _unitOfWork.Appointment.GetAll(include:q=>q.Include(x=>x.Service));
            var result = _mapper.Map<IList<Appointment>>(appointment);
            return Ok(result);
        }


        [HttpPost]
        [Route("add_user_appointment")]
        public async Task<IActionResult> AddUserAppointment([FromBody] UserAppointment appointment)
        {
            var result = _mapper.Map<Appointment>(appointment);
            result.Status = "Upcoming";
            await _unitOfWork.Appointment.Insert(result);
            
            await _unitOfWork.Save();
            return Ok();
        }
        [HttpPost]
        [Route("add_employee_appointment")]
        public async Task<IActionResult> AddEmployeeAppointment([FromBody] EmployeeAppointment appointment)
        {
            var result = _mapper.Map<Appointment>(appointment);
            result.Status = "Upcoming";
            await _unitOfWork.Appointment.Insert(result);
            
            await _unitOfWork.Save();
            return Ok();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAppointment(int id, [FromBody] CreateAppointment AppointmentDto)
        {
            var old = await _unitOfWork.Appointment.Get(q => q.Id == id);
            _mapper.Map(AppointmentDto, old);
            _unitOfWork.Appointment.Update(old);
            //int idd = old.User.Id;
          //UserController.UpdateUserpoint(idd,10);
            await _unitOfWork.Save();

            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAppointment(int id)
        {
            var appointment = await _unitOfWork.Appointment.Get(q => q.Id == id);


            if (appointment == null)
            {
                return NotFound();
            }
            else
            {
                await _unitOfWork.Appointment.Delete(id);
                await _unitOfWork.Save();


                return Ok();
            }
        }

        [HttpGet("{Status}")]
        public async Task<IActionResult> AppointmentByStatus(String Status)
        {
            var Appointment = await _unitOfWork.Appointment.GetAll(q => q.Status == Status);
            var result = _mapper.Map<IList<AppointmentDTO>>(Appointment);
            return Ok(result);

        }
        //[HttpPut("{Status}")]
        //public async Task<IActionResult> DeleteAppointment(String Status, [FromBody] CreateAppointment AppointmentDto)
        //{
        //    var old = await _unitOfWork.Appontment.Get(q => q.Status == Status);
        //   // CreateAppointment AppointmentDto;
        //    _mapper.Map(AppointmentDto.Status, old);
        //    _unitOfWork.Appontment.Update(old);
        //    await _unitOfWork.Save();
        //    return Ok();

        //}
     

    }
}
