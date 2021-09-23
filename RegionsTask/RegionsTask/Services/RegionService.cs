using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RegionsTask.Models;
using RegionsTask.Repositories.Interfaces;
using RegionsTask.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegionsTask.Services
{
    public class RegionService : IRegionService
    {
        private readonly IGenericRepository<Region> _genericRepository;
        private readonly ILogger<Region> _logger;
        public RegionService(IGenericRepository<Region> genericRepository, ILogger<Region> logger)
        {
            _genericRepository = genericRepository;
            _logger = logger;
        }

        public async Task<Region> GetRegion(string phoneNumber)
        {
            try
            {
                Region responses = new Region();
                if (string.IsNullOrEmpty(phoneNumber))
                {
                    return null;
                }
                if (phoneNumber.Length >= 3 && phoneNumber.StartsWith("001"))
                {
                    if (phoneNumber.Length >= 4 && phoneNumber.Substring(3, 1).Equals("1"))
                    {
                        responses = await _genericRepository.GetAllAsQueryable().Where(x => x.Code == "0011").FirstOrDefaultAsync();
                    }
                    else if (phoneNumber.Length >= 4 && phoneNumber.Substring(3, 1).Equals("2"))
                    {
                        responses = await _genericRepository.GetAllAsQueryable().Where(x => x.Code == "0012").FirstOrDefaultAsync();
                    }
                    else
                    {
                        responses = await _genericRepository.GetAllAsQueryable().Where(x => x.Code == "001").FirstOrDefaultAsync();
                    }

                }
                return responses;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unexpected error has ocurred!");
                throw;
            }
        }
    }
}
