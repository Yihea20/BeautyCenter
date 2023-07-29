﻿using AutoMapper;
using BeautyCenter.IRebository;
using BeautyCenter.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static BeautyCenter.DTOs.CreateCustomer;

namespace BeautyCenter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CustomerController> _logger;
        private readonly IMapper _mapper;

        public CustomerController(IUnitOfWork unitOfWork, ILogger<CustomerController> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task<IActionResult> AddCenter([FromBody] CustomerDTO customer)
        {
            var result = _mapper.Map<CostomerDet>(customer);
            await _unitOfWork.CostomerDet.Insert(result);
            await _unitOfWork.Save();
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCustomer()
        {

            var customer = await _unitOfWork.CostomerDet.GetAll();
            var result = _mapper.Map<IList<CustomerDTO>>(customer);
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            var customer = await _unitOfWork.CostomerDet.Get(q => q.Id == id);


            if (customer == null)
            {
                return NotFound();
            }
            else
            {
                await _unitOfWork.CostomerDet.Delete(id);
                await _unitOfWork.Save();


                return Ok();
            }
        }

    }
}

