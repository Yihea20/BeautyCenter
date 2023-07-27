﻿using AutoMapper;
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
            await _unitOfWork.Save();
            return Ok();
        }
    }
}