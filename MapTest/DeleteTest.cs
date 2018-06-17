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
        }

        [TestMethod]
        public void CorrectDeleting()
        {
            map.Delete("0");
            Assert.ThrowsException<ArgumentException>(() => map["0"]);
        }

        [TestMethod]
        public void DontDeleteNonexistentKey()
        {
            Assert.ThrowsException<ArgumentException>(() => map.Delete("1"));
        }
    }
}
