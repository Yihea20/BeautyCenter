using AutoMapper;
using BeautyCenter.DTOs;
using BeautyCenter.IRebository;
using BeautyCenter.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static BeautyCenter.DTOs.CreateOffer;

namespace BeautyCenter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OffersController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<OffersController> _logger;
        private readonly IMapper _mapper;

        public OffersController(IUnitOfWork unitOfWork, ILogger<OffersController> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllOffer()
        {
            var offer = await _unitOfWork.Offers.GetAll();
            var result = _mapper.Map<IList<OfferDTO>>(offer);
            return Ok(result);
        }


        [HttpPost]
        public async Task<IActionResult> AddOffer([FromBody] OfferDTO offers)
        {
            var result = _mapper.Map<Offers>(offers);
            await _unitOfWork.Offers.Insert(result);
            await _unitOfWork.Save();
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOffer(int id)
        {
            var Offer = await _unitOfWork.Offers.Get(q => q.Id == id);


            if (Offer == null)
            {
                return NotFound();
            }
            else
            {
                await _unitOfWork.Offers.Delete(id);
                await _unitOfWork.Save();


                return Ok();
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOffer(int id, [FromBody] CreateOffer OfferDto)
        {
            var old = await _unitOfWork.Offers.Get(q => q.Id == id);
            _mapper.Map(OfferDto, old);
            _unitOfWork.Offers.Update(old);
            await _unitOfWork.Save();
            return Ok();
        }

    }
}
