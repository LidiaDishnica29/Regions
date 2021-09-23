using AutoMapper;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RegionsTask.Controllers;
using RegionsTask.DTO;
using RegionsTask.Models;
using RegionsTask.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RegionTest
{
    public class MockTest
    {
        public Mock<IRegionService> mock;
        public Mock<ILogger<RegionController>> logger ;
        public Mock<IMapper> mapper;

        public MockTest(Mock<IRegionService> mock, Mock<ILogger<RegionController>> logger, Mock<IMapper> mapper)
        {
            this.mock = mock;
            this.logger = logger;
            this.mapper = mapper;
        }
       
        [Fact]
        public async Task GetRegion()
        {
            var regionDto = new Region()
            {
                Name = "Region 2",
                Code = "0011"
            };
            mock.Setup(p =>  p.GetRegion("0011")).ReturnsAsync(regionDto);
            RegionController region = new RegionController(mock.Object, logger.Object, mapper.Object);
            var result = await region.DetectCountryFor("0011");
            Assert.IsTrue(region.Equals(result));
        }
        [Fact]
        public async Task GetRegionTest()
        {
            var regionDto = new Region()
            {
                Name = "Country 1",
                Code = "001"
            };
            mock.Setup(p =>  p.GetRegion("001")).ReturnsAsync(regionDto);
            RegionController region = new RegionController(mock.Object, logger.Object, mapper.Object);
            var result = await region.DetectCountryFor("001");
            Assert.IsTrue(region.Equals(result));
        }
    }
}
