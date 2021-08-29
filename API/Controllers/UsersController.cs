using API.Data;
using API.DTOs;
using API.Entitities;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Authorize]
    [AllowAnonymous]
    public class UsersController : BaseApiController{  //To inherit from BaseApiController base

        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        public UsersController(IUserRepository userRepository, IMapper mapper )
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MemberDto>>> GetUsers()  //To create an endpoint which returns all the users of the type AppUser which is a list hence IEnumerable is used
        {
            var users = await _userRepository.GetMembersAsync();
            //var usersToReturn = _mapper.Map<IEnumerable<MemberDto>>(users); //Will map users with memberDto and return MemberDto type value
            return Ok(users);
        }

        [HttpGet("{username}")] //username is the route parameter
        public async Task<ActionResult<MemberDto>> GetUser(string username)  //To create an endpoint which returns selected  user of the id mentioned of type AppUser which is a list hence IEnumerable is used
        {
            return await _userRepository.GetMemberAsync(username); //Will map user with memberDto and return MemberDto type value
        }
    }
}
