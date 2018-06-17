using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MapSpace;

namespace MapTest
{
    [TestClass]
    public class FindTest
    {
        private Map map;

        [TestInitialize]
        public void Init()
        {
            map = new Map();
            map["0"] = "000";
        }

        [TestMethod]
        public void CorrectFinding()
        {
            Assert.AreEqual("000", map["0"]);
        }

        [TestMethod]
        public void DontFindNonexistentKey()
        {
            Assert.ThrowsException<ArgumentException>(() => map["1"]);
        }
    }
}
