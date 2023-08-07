﻿using AutoMapper;
using BeautyCenter.DTOs;
using BeautyCenter.IRebository;
using BeautyCenter.Models;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<IActionResult> GetAllAppontment()
        {
            var appointment = await _unitOfWork.Appontment.GetAll();
            var result = _mapper.Map<IList<Appontment>>(appointment);
            return Ok(result);
        }


        [HttpPost]
        public async Task<IActionResult> AddAppontment([FromBody] AppointmentDTO appointment)
        {
            var result = _mapper.Map<Appontment>(appointment);
            await _unitOfWork.Appontment.Insert(result);
            result.Status = "Upcoming";
            await _unitOfWork.Save();
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAppointment(int id, [FromBody] CreateAppointment AppointmentDto)
        {
            var old = await _unitOfWork.Appontment.Get(q => q.Id == id);
            _mapper.Map(AppointmentDto, old);
            _unitOfWork.Appontment.Update(old);
            //int idd = old.User.Id;
          //UserController.UpdateUserpoint(idd,10);
            await _unitOfWork.Save();

            return Ok();
        }

        [HttpGet("{Status}")]
        public async Task<IActionResult> AppointmentByStatus(String Status)
        {
            var Appointment = await _unitOfWork.Appontment.GetAll(q => q.Status == Status);
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
