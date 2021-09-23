using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RegionsTask.DTO;
using RegionsTask.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegionsTask.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionController : Controller
    {
        private readonly IRegionService _regionService;

        private readonly ILogger<RegionController> _logger;
        private readonly IMapper _mapper;
        public RegionController(IRegionService regionService,ILogger<RegionController> logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
            _regionService = regionService;
        }
        [HttpGet("DetectCountryFor/{phone}")]
        public async Task<ActionResult<RegionDto>> DetectCountryFor(string phone)
        {
            try
            {
                var region = await _regionService.GetRegion(phone);
                var model = _mapper.Map<RegionDto>(region);

                return Ok(model);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An unexpected error has occured");
                return BadRequest(new { message = "An unexpected error has occured" });
            }
        }
    }
}
