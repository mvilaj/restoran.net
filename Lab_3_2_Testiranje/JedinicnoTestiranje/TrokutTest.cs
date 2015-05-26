using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_3_2_Testiranje;

namespace JedinicnoTestiranje
{
    [TestClass]
    public class TrokutTest
    {
        [TestMethod]
        public void IzracunajVisinuTest()
        {
            Trokut t1 = new Trokut(-5);
            float v1 = t1.IzracunajVisinu();
            Assert.IsTrue(v1 >= 0, "Visina mora biti veca od nule!");
        }

        [TestMethod]
        public void IzracunajPovrsinuTest() {
            Trokut t1 = new Trokut(-1);
            float p1 = t1.IzracunajPovrsinu();
            Assert.IsTrue(p1 >= 0, "Povrsina mora biti veca od nule!");
        }

        [TestMethod]
        public void IzracunajOpsegTest() {
            Trokut t1 = new Trokut(-1);
            float o1 = t1.IzrcunajOpseg();
            Assert.IsTrue(o1 >= 0, "Opseg mora biti veci od nule!");
        }
    }
}
