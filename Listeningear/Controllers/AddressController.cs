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
    public class AddressController : ControllerBase
    {

        private readonly IAddressMasterRepository _addRepo;
        private readonly IMapper _mapper;

        public AddressController(IAddressMasterRepository addRepo, IMapper mapper)
        {
            _mapper = mapper;
            _addRepo = addRepo;
        }

        [HttpGet]
        public async Task<ActionResult<IList<AddressMaster>>> GetAddressDetails()
        {
            var address = await _addRepo.GetAllAddressAsync();
            return Ok(address);
        }
    }
}