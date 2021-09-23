using RegionsTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegionsTask.Services.Interfaces
{
    public interface IRegionService
    {
        Task<Region> GetRegion(string phoneNumber);

    }
}
