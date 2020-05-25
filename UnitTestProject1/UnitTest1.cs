using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TESTDelete.Controllers;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            System.Diagnostics.Debugger.Break();
            int count = 1;
            HomeController controller = new HomeController();
            ViewResult result = controller.CheckCountValue(count) as ViewResult;
            Assert.IsNotNull(result);
        }
    }
}
