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
    [TestClass]
    public class TestUt
    {
        private readonly IRegionService _regionService;


        public TestUt(IRegionService regionService)
        {
            _regionService = regionService;

        }

        [TestMethod]
        public async void Add()
        {
            //arrange
            string phonenumber = "0012313213";
            //act
            var actual = await _regionService.GetRegion(phonenumber);

            //Assert
            Assert.AreEqual("0012", actual?.Code);
        }
    }

}
