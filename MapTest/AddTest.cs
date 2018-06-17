using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MapSpace;

namespace MapTest
{
    [TestClass]
    public class AddTest
    {
        private Map map;

        [TestInitialize]
        public void Init()
        {
            map = new Map();
        }

        [TestMethod]
        public void CorrectAdding()
        {
            map["0"] = "00";
            Assert.AreEqual("00", map["0"]);
        }

        [TestMethod]
        public void DontAddTwoValuesByOneKey()
        {
            map["0"] = "00";
            Assert.ThrowsException<ArgumentException>(() => map["0"] = "000");
        }

        [TestMethod]
        public void DontAddEmptyStringKey()
        {
            Assert.ThrowsException<ArgumentException>(() => map[""] = "000");
        }
    }
}
