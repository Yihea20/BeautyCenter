using AutoMapper;
using BeautyCenter.DTOs;
using BeautyCenter.IRebository;
using BeautyCenter.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static BeautyCenter.DTOs.CreateCustomer;
using static System.Net.Mime.MediaTypeNames;

namespace BeautyCenter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CustomerController> _logger;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment environment;
        public CustomerController(IUnitOfWork unitOfWork, ILogger<CustomerController> logger, IMapper mapper, IWebHostEnvironment _environment)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
            environment = _environment;
        }
        [NonAction]
        private string GetFilePath(string name)
        {
            return this.environment.WebRootPath + "\\Upload\\image\\" + name;
        }
        [HttpPost]
        public async Task<IActionResult> AddCenter([FromForm] CustomerImage customer)
        {
            string hosturl = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}";
            try
            {
                string FilePath = GetFilePath(customer.CreateCustomer.CostomerDetails);
                if (!System.IO.Directory.Exists(FilePath))
                {
                    System.IO.Directory.CreateDirectory(FilePath);
                }
                string url = FilePath + "\\" + customer.CreateCustomer.CostomerDetails + ".png";
                if (System.IO.File.Exists(url))
                {
                    System.IO.File.Delete(url);
                }
                using (FileStream stream = System.IO.File.Create(url))
                {
                    await customer.File.CopyToAsync(stream);
                    var result = _mapper.Map<CustomerDet>(customer.CreateCustomer);
                    result.ImageUrl = hosturl + "\\Upload\\image\\" + customer.CreateCustomer.CostomerDetails + "\\" + customer.CreateCustomer.CostomerDetails + ".png"; ;
                    await _unitOfWork.CustomerDet.Insert(result);
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
        public async Task<IActionResult> GetAllCustomer()
        {

            var customer = await _unitOfWork.CustomerDet.GetAll();
            var result = _mapper.Map<IList<CustomerDTO>>(customer);
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            var customer = await _unitOfWork.CustomerDet.Get(q => q.Id == id);

           

            try
            {

                if (System.IO.File.Exists(customer.ImageUrl))
                {
                    System.IO.File.Delete(customer.ImageUrl);
                    await _unitOfWork.CustomerDet.Delete(id);
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
        public async Task<IActionResult> UpdateCustomer(int id, [FromBody] CreateCustomer customerDto)
        {
            var old = await _unitOfWork.CustomerDet.Get(q => q.Id == id);
            _mapper.Map(customerDto, old);
            _unitOfWork.CustomerDet.Update(old);
            await _unitOfWork.Save();
            return Ok();
        }

    }
}

