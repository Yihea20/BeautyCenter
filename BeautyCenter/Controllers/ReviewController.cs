using AutoMapper;
using BeautyCenter.DTOs;
using BeautyCenter.IRebository;
using BeautyCenter.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BeautyCenter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ReviewController> _logger;
        private readonly IMapper _mapper;

        public ReviewController(IUnitOfWork unitOfWork, ILogger<ReviewController> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        [HttpPost]
        [Route("add_Employee_review")]
        public async Task<IActionResult> AddEmployeeReview([FromBody] CreateEmployeeReview employee)
        {
            var result = _mapper.Map<Review>(employee);
            
            await _unitOfWork.Review.Insert(result);

            await _unitOfWork.Save();
            return Ok();
        }
        [HttpPost]
        [Route("add_Service_review")]
        public async Task<IActionResult> AddServiceReviewt([FromBody] CreateServiceReview review)
        {
            var result = _mapper.Map<Review>(review);

            await _unitOfWork.Review.Insert(result);

            await _unitOfWork.Save();
            return Ok();
        }
        [HttpPut]
        [Route("Like")]
        public async Task<IActionResult> Like(int id, [FromBody]LikeDto like)
        {
            var old= await _unitOfWork.Review.Get(q => q.Id == id);
            like.Like = old.Like + 1;
            _mapper.Map(like, old);
          _unitOfWork.Review.Update(old);
            await _unitOfWork.Save();
            return Ok();

        }
        [HttpGet]
        [Route("GetAllReview")]
        public async Task<IActionResult> GetAllReview()
        {
            var appointment = await _unitOfWork.Review.GetAll(include: q => q.Include(x => x.Service), includee: q => q.Include(x => x.Employee));
            var result = _mapper.Map<IList<ReviewDTO>>(appointment);
            return Ok(result);
        }

        [HttpGet]
        [Route("GetReviewById")]
        public async Task<IActionResult> GetReviewById(int id)
        {
            var appointment = await _unitOfWork.Review.Get(q=>q.Id==id,include: q => q.Include(x => x.Service), includee: q => q.Include(x => x.Employee));
            var result = _mapper.Map<ReviewDTO>(appointment);
            return Ok(result);
        }
    }
}
