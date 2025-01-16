using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using StuffDoers;

namespace StuffDoerTests
{
    [TestClass]
    public class StuffDoerTests
    {
        [TestMethod]
        public void StuffDoerDoStuffTest()
        {
            var stuffDoer = new StuffDoer();
            var stuff = stuffDoer.DoStuff();
            Assert.AreEqual(stuff, "Stuff Has Been Done!");
        }
    }
}
