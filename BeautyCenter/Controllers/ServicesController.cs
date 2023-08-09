﻿using AutoMapper;
using BeautyCenter.DTOs;
using BeautyCenter.IRebository;
using BeautyCenter.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using static BeautyCenter.DTOs.CreateGallery;
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
        public async Task<IActionResult> AddService([FromBody] CreateService serviceDto)
        {
            var result = _mapper.Map<Service>(serviceDto);
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

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteServices(int id)
        {
            var service = await _unitOfWork.Service.Get(q => q.Id == id);


            if (service == null)
            {
                return NotFound();
            }
            else
            {
                await _unitOfWork.Service.Delete(id);
                await _unitOfWork.Save();


                return Ok();
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateService(int id, [FromBody] CreateService ServiceDto) 
        { 
            var old = await _unitOfWork.Service.Get(q => q.Id == id);
            _mapper.Map(ServiceDto, old);
            _unitOfWork.Service.Update(old);
            await _unitOfWork.Save();
            return Ok();
        }
        [HttpGet("Name")]
        public async Task<IActionResult> GetService(string Name)
        {
            var service = await _unitOfWork.Service.Get(q => q.Name == Name);
            var result = _mapper.Map<ServiceDTO>(service);
            return Ok(result);
        }

        [HttpGet("type")]
        public async Task<IActionResult> GetServiceByType(string type)
        {
            var service = await _unitOfWork.Service.Get(q => q.Type==type);
            var result = _mapper.Map<IList <ServiceDTO >>(service);
            return Ok(result);
        }
    }
}
