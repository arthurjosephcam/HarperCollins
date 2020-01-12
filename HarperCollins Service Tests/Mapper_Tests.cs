using System;
using HarperCollins.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace HarperCollins_Service_Tests
{
    [TestClass]
    public class Mapper_Tests
    {
        protected IUnitOfWork UnitOfWork { get; set; }

        [TestInitialize]
        public void TestInitialize()
        {
            // Create Mock Repository Instance
            UnitOfWork = Substitute.For<IUnitOfWork>();
        }
        [TestMethod]
        public void SalesDataMapperTest()
        {
            //Here we can create a web application model sales data object, and compare with mapper results.
        }
    }
}
