using AutoMapper;
using BeautyCenter.DTOs;
using BeautyCenter.IRebository;
using BeautyCenter.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private IList<ServiceWithImage> services;
        public ServicesController(IUnitOfWork unitOfWork, ILogger<ServicesController> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
            services = new List<ServiceWithImage>();
        }
        [HttpPost]
        public async Task<IActionResult> AddService([FromForm] ServiceFile serviceDto)
        {
            using (MemoryStream stream=new MemoryStream()) {
                await serviceDto.File.CopyToAsync(stream);

                var result = _mapper.Map<Service>(serviceDto.Create);
                result.ImageArray = stream.ToArray();
                await _unitOfWork.Service.Insert(result);
                await _unitOfWork.Save();
                return Ok();
            }
        
         }
        [HttpGet]
        public async Task<IActionResult> GetAllServices()
        {

            var  service= await _unitOfWork.Service.GetAll();
            foreach (var item in service)
            {
                services.Add(new ServiceWithImage()
                {
                    Id=item.Id,
                    Name=item.Name,
                    Type=item.Type,
                    Price=item.Price,
             
                    ImageArray = Convert.ToBase64String(item.ImageArray),
                details=item.details,
                CreatedDate=item.CreatedDate,
                    CostomerDetId=item.CostomerDetId,
                CostomerDet=item.CostomerDet,
                Employees=item.Employees,
                Users=item.Users,

                });
            }
            var result = _mapper.Map<IList<ServiceDTO>>(services);
            return Ok(result);
        }
        [HttpGet]
        [Route("all_by_name")]
        public async Task<IActionResult> GetAllByNameServices(string name)
        {

            var service = await _unitOfWork.Service.GetAll(q=>q.Name==name);
            foreach (var item in service)
            {
                services.Add(new ServiceWithImage()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Type = item.Type,
                    Price = item.Price,

                    ImageArray = Convert.ToBase64String(item.ImageArray),
                    details = item.details,
                    CreatedDate = item.CreatedDate,
                    CostomerDetId = item.CostomerDetId,
                    CostomerDet = item.CostomerDet,
                    Employees = item.Employees,
                    Users = item.Users,

                });
            }
            var result = _mapper.Map<IList<ServiceDTO>>(services);
            return Ok(result);
        }
        [HttpGet]
        [Route("all_by_type")]
        public async Task<IActionResult> GetAllByTypeServices(string type)
        {

            var service = await _unitOfWork.Service.GetAll(q=>q.Type==type);
            foreach (var item in service)
            {
                services.Add(new ServiceWithImage()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Type = item.Type,
                    Price = item.Price,

                    ImageArray = Convert.ToBase64String(item.ImageArray),
                    details = item.details,
                    CreatedDate = item.CreatedDate,
                    CostomerDetId = item.CostomerDetId,
                    CostomerDet = item.CostomerDet,
                    Employees = item.Employees,
                    Users = item.Users,

                });
            }
            var result = _mapper.Map<IList<ServiceDTO>>(services);
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
            result.ImageArray = Convert.ToBase64String(service.ImageArray);
            return Ok(result);
        }

        [HttpGet("type")]
        public async Task<IActionResult> GetServiceByType(string type)
        {
            var service = await _unitOfWork.Service.Get(q => q.Type==type);
            var result = _mapper.Map<ServiceDTO >(service);
            result.ImageArray = Convert.ToBase64String(service.ImageArray);
            return Ok(result);
        }
        [HttpPut]
        [Route("service_image")]
        public async Task<IActionResult> AddServiceImage(string name, [FromBody] UpdateService service )
        {

            var old = await _unitOfWork.Service.Get(q => q.Name==name);
            _mapper.Map(service, old);
            _unitOfWork.Service.Update(old);
            await _unitOfWork.Save();
            return Ok();
        }
    }
}
