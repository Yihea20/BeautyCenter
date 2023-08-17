using AutoMapper;
using BeautyCenter.DTOs;
using BeautyCenter.IRebository;
using BeautyCenter.Models;
using FirebaseAdmin.Messaging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


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
        [HttpPost("send-notification-to-user")]
        public async Task<IActionResult> SendNotificationUser([FromBody] CreateNotificationForUser request)
        {
            var message = new Message
            {
                Notification = new FirebaseAdmin.Messaging.Notification
                {
                    Title = request.Title,
                    Body = request.Body,
                },
                Token=request.Token,
            };

            try
            {
                var response = await FirebaseMessaging.DefaultInstance.SendAsync(message);
                var notifi = _mapper.Map<Models.Notification>(request);
                await _unitOfWork.Notification.Insert(notifi);
                await _unitOfWork.Save();
                return Ok(new { Message = "Notification sent successfully.", Response = response });
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to send notification: {ex.Message}");
            }
        }
        [HttpPost("send-notification-to-group")]
        public async Task<IActionResult> SendNotificationGroup([FromBody] CreateNotificationForGroup request)
        {
            var message = new Message
            {
                Notification = new FirebaseAdmin.Messaging.Notification
                {
                    Title = request.Title,
                    Body = request.Body,
                },
                Token = request.Topic,
            };

            try
            {
                var response = await FirebaseMessaging.DefaultInstance.SendAsync(message);
                var notifi = _mapper.Map<Models.Notification>(request);
                await _unitOfWork.Notification.Insert(notifi);
                await _unitOfWork.Save();

                return Ok(new { Message = "Notification sent successfully to topic.", Response = response });
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to send notification: {ex.Message}");
            }
        }


    }
}
