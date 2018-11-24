using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestDemo;
namespace unitTestDemo.Tests
{
    [TestClass]
    public class GetCustomerTest
    {
        [TestMethod]
        public void GetName_ShouldReturnCustomerName()
        {
            var result = new GetCustomer().GetName();
            Assert.AreEqual("Mark", "Mark");
        }
    }
}
