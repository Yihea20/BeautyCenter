using AutoMapper;
using BeautyCenter.DTOs;
using BeautyCenter.IRebository;
using BeautyCenter.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BeautyCenter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UserController> _logger;
        private readonly IMapper _mapper;

        public UserController(IUnitOfWork unitOfWork, ILogger<UserController> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task<IActionResult> AddUser([FromBody] CreateUserDTO user)
        {
            var result = _mapper.Map<User>(user);
            await _unitOfWork.User.Insert(result);
            await _unitOfWork.Save();
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {

            var user = await _unitOfWork.User.GetAll();
            var result = _mapper.Map<IList<UserDTO>>(user);
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var employee = await _unitOfWork.User.Get(q => q.Id == id);


            if (employee == null)
            {
                return NotFound();
            }
            else
            {
                await _unitOfWork.User.Delete(id);
                await _unitOfWork.Save();


                return Ok();
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, [FromBody] CreateUserDTO userDto)
        {
            var old = await _unitOfWork.User.Get(q => q.Id == id);
            _mapper.Map(userDto, old);
            _unitOfWork.User.Update(old);
            await _unitOfWork.Save();
            return Ok();
        }
    }
}
