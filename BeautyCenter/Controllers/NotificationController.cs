using AutoMapper;
using BeautyCenter.IRebository;
using BeautyCenter.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static BeautyCenter.DTOs.CreateImage;
using static BeautyCenter.DTOs.CreateNotification;

namespace BeautyCenter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<NotificationController> _logger;
        private readonly IMapper _mapper;

        public NotificationController(IUnitOfWork unitOfWork, ILogger<NotificationController> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task<IActionResult> AddNotification([FromBody] NotificationDTO notification)
        {

            var result = _mapper.Map<Notification>(notification);
            await _unitOfWork.Notification.Insert(result);
            await _unitOfWork.Save();
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetAllNotification()
        {

            var notification = await _unitOfWork.Notification.GetAll();
            var result = _mapper.Map<IList<NotificationDTO>>(notification);
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNotification(int id)
        {
            var notification = await _unitOfWork.Notification.Get(q => q.Id == id);


            if (notification == null)
            {
                return NotFound();
            }
            else
            {
                await _unitOfWork.Notification.Delete(id);
                await _unitOfWork.Save();


                return Ok();
            }
        }

    }
}
