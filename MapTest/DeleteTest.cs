using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MapSpace;

namespace MapTest
{
    [TestClass]
    public class DeleteTest
    {
        private Map map;

        [TestInitialize]
        public void Init()
        {
            map = new Map();
            map["0"] = "000";
            map["00"] = "000";
        }

        [TestMethod]
        public void CorrectDeleting()
        {
            map.Delete("0");
            Assert.AreEqual("000", map["00"]);
            Assert.ThrowsException<ArgumentException>(() => map["0"]);
        }

        [TestMethod]
        public void DontDeleteNonexistentKey()
        {
            Assert.ThrowsException<ArgumentException>(() => map.Delete("1"));
        }
    }
}
