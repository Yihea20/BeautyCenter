﻿using AutoMapper;
using BeautyCenter.DTOs;
using BeautyCenter.Models;
using BeautyCenter.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BeautyCenter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsManagerController : ControllerBase
    {
        private readonly UserManager<Person> _userManager;
        private readonly ILogger<AccountsManagerController> _logger;
        private readonly IAuthoManger _authoManger;
        private readonly IMapper _mapper;

        public AccountsManagerController(UserManager<Person> userManager, ILogger<AccountsManagerController> logger, IAuthoManger authoManger, IMapper mapper)
        {
            _userManager = userManager;
            _logger = logger;
            _authoManger = authoManger;
            _mapper = mapper;
        }
        //[HttpPost]
        //[Route("Regis")]
        //[ProducesResponseType(StatusCodes.Status202Accepted)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(StatusCodes.Status500InternalServerError)]
        //public async Task<IActionResult> Register([FromBody] UserRegistDTO personDTO)
        //{
        //    _logger.LogInformation($"Registerstion Attempt for {personDTO.Email}");
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }
        //    try
        //    {
        //        var user = _mapper.Map<User>(personDTO);
        //        user.UserName = personDTO.FirstName + personDTO.LastName;
        //        user.Email = personDTO.Email;
        //        var result = await _userManager.CreateAsync(user, personDTO.Password);
        //        //result = await _userManager.AddPasswordAsync(user,);
        //        if (!result.Succeeded)
        //        {
        //            foreach (var Error in result.Errors)
        //            {
        //                ModelState.AddModelError(Error.Code, Error.Description);

        //            }
        //            return BadRequest(ModelState);
        //        }
        //        await _userManager.AddToRolesAsync(user, personDTO.RoleName);

        //        return Ok($"StatusCode:{StatusCodes.Status202Accepted}");
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, $"somthging went wrong in the {nameof(Register)}");
        //        return Problem($"somthging went wrong in the {nameof(Register)}");
        //    }
        //}
        //[HttpPost]
        //[Route("login")]
        //public async Task<IActionResult> Login([FromBody] UserLoginDTO personDTO)
        //{
        //    _logger.LogInformation($"Registerstion Attempt for {personDTO.Email}");
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }
        //    try
        //    {
        //        if (!await _authoManger.ValidateUser(personDTO))
        //        {
        //            return Unauthorized();
        //        }
        //        Random rnd = new Random();
        //        int myRandomNo = rnd.Next(10000000, 99999999);
        //        var person = await _userManager.FindByEmailAsync(personDTO.Email) as Person;
        //        person.Code = myRandomNo.ToString();
        //        await _userManager.UpdateAsync(person);
        //        return Accepted(new TokenRequest { Token = await _authoManger.CreatToken(), RefreshToken = await _authoManger.CreateRefreshToken(), rand= myRandomNo.ToString() });
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, $"somthging went wrong in the {nameof(Login)}");
        //        return Problem($"somthging went wrong in the {nameof(Login)}");
        //    }
        //}
        //[HttpPost]
        //[Route("refreshtoken")]
        //public async Task<IActionResult> RefreshToken([FromBody] TokenRequest request)
        //{
        //    var tokenRequest = await _authoManger.VerifyRefreshToken(request);
        //    if (tokenRequest is null)
        //    {
        //        return Unauthorized();
        //    }

        //    return Ok(tokenRequest);
        //}
    }
}
