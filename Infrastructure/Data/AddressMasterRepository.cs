using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class AddressMasterRepository : IAddressMasterRepository
    {
        private readonly DBContext _dbContext;

        public AddressMasterRepository(DBContext dBContext)
        {
            _dbContext = dBContext;
        }

        public async Task<IList<AddressMaster>> GetAllAddressAsync()
        {
            return await _dbContext.AddressMaster.ToListAsync(); 
        }

    }
}