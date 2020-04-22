using DDDexercice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Creneau unCreneau = new Creneau(DateTime.Now(), 120);
        }
    }
}
