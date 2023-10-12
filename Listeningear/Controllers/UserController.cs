using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Core.Interfaces;
using Core.Models;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace Listeningear.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private DBContext _dbContext;

        private readonly IUserMasterRepository _userRepo;
        private readonly IMapper _mapper;

        public UserController(IUserMasterRepository userRepo)
        {
//            _mapper = mapper;
            _userRepo = userRepo;
        }

        [HttpGet]
        public async Task<ActionResult<IList<UserMaster>>> GetUserDetails()
        {
            var users = await _userRepo.GetAllUsersAsync();
            return Ok(users);
        }
    }
}