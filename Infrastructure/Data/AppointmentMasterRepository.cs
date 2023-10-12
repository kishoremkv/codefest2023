using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class AppointmentMasterRepository : IAppointmentMasterRepository
    {
        private readonly DBContext _dbContext;

        public AppointmentMasterRepository(DBContext dBContext)
        {
            _dbContext = dBContext;
        }

        public async Task<IList<AppointmentMaster>> GetAllAppointmentsAsync()
        {
            return await _dbContext.AppointmentMaster.ToListAsync();
        }

        public async Task<IList<UserMaster>> GetAllUsersAsync()
        {
            return await _dbContext.UserMaster.ToListAsync();

        }
    }
}