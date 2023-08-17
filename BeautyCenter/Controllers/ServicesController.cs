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
        private readonly IWebHostEnvironment environment;
        public ServicesController(IUnitOfWork unitOfWork, ILogger<ServicesController> logger, IMapper mapper, IWebHostEnvironment _environment)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
            environment = _environment;
        }
        [NonAction]
        private string GetFilePath(string name)
        {
            return this.environment.WebRootPath + "\\Upload\\ServiceImage\\" + name;
        }
        [HttpPost]
        public async Task<IActionResult> AddService([FromForm] ServiceFile service)
        {
            try
            {
                string FilePath = GetFilePath(service.Create.Name);
                if (!System.IO.Directory.Exists(FilePath))
                {
                    System.IO.Directory.CreateDirectory(FilePath);
                }
                string url = FilePath + "\\" + service.Create.Name + ".png";
                if (System.IO.File.Exists(url))
                {
                    System.IO.File.Delete(url);
                }
                using (FileStream stream = System.IO.File.Create(url))
                {
                    await service.File.CopyToAsync(stream);
                    var result = _mapper.Map<Service>(service.Create);
                    result.ImageURL = url;
                    await _unitOfWork.Service.Insert(result);
                    await _unitOfWork.Save();
                    return Ok();
                }
            }
            catch (Exception e)
            {
                return NotFound();
            }

        }


    
        [HttpGet]
        public async Task<IActionResult> GetAllServices()
        {

            var  service= await _unitOfWork.Service.GetAll();
            var result = _mapper.Map<IList<ServiceDTO>>(service);
            return Ok(result);
        }
        [HttpGet]
        [Route("all_by_name")]
        public async Task<IActionResult> GetAllByNameServices(string name)
        {

            var service = await _unitOfWork.Service.GetAll(q=>q.Name==name);

            var result = _mapper.Map<IList<ServiceDTO>>(service);
            return Ok(result); return Ok(result);
        }
        [HttpGet]
        [Route("all_by_type")]
        public async Task<IActionResult> GetAllByTypeServices(string type)
        {

            var service = await _unitOfWork.Service.GetAll(q=>q.Type==type);

            var result = _mapper.Map<IList<ServiceDTO>>(service);
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteServices(int id)
        {
            var service = await _unitOfWork.Service.Get(q => q.Id == id);


            try
            {

                if (System.IO.File.Exists(service.ImageURL))
                {
                    System.IO.File.Delete(service.ImageURL);
                    await _unitOfWork.Service.Delete(id);
                    await _unitOfWork.Save();

                    return Ok();
                }
                else
                {


                    return NotFound();
                }
            }
            catch (Exception e) { return BadRequest(); }
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
            var result = _mapper.Map<ServiceDTO >(service);
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
