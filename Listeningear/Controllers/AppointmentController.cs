using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Core.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Listeningear.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentMasterRepository _appRepo;
        private readonly IMapper _mapper;

        public AppointmentController(IAppointmentMasterRepository addRepo, IMapper mapper)
        {
            _mapper = mapper;
            _appRepo = addRepo;
        }

        [HttpGet]
        public async Task<ActionResult<IList<AppointmentMaster>>> GetAddressDetails()
        {
            var appointments = await _appRepo.GetAllAppointmentsAsync();
            return Ok(appointments);
        }
    }
}