using System;
using Xunit;
using GroceryStoreAPI.Models;
using GroceryStoreAPI.Data;
using Moq;
using Moq.Protected;

namespace CustomerControllerTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var mockInfo = new Mock<Customer>();
            mockInfo.SetupAllProperties();
         


            //Action act = () => { 
            //    var sut = new Customer(mockInfo.Object);
               
            //};

        }
    }
}
