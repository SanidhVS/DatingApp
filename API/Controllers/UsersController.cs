﻿using API.Data;
using API.Entitities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{

    public class UsersController : BaseApiController  //To inherit from BaseApiController base
    {
        private DataContext _context;

        public UsersController(DataContext context )
        {
            _context = context;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()  //To create an endpoint which returns all the users of the type AppUser which is a list hence IEnumerable is used
        {
            return await _context.Users.ToListAsync();
        }

        [Authorize]
        [HttpGet("{id}")] //id is the route parameter
        public async Task<ActionResult<AppUser>> GetUser(int id)  //To create an endpoint which returns selected  user of the id mentioned of type AppUser which is a list hence IEnumerable is used
        {
            return await _context.Users.FindAsync(id);
        }
    }
}
