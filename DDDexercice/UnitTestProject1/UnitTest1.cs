using DDDexercice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void NullReferenceExceptioneDeclarationCreneau()
        {
            Assert.ThrowsException<NullReferenceException>(delegate { Creneau unCreneau = new Creneau(DateTime.Now, 0); });

        }
        [TestMethod]
        public void ExceptionSurLeJourDeLaSemaineDeclarationCreneau()
        {
            DateTime date = new DateTime(year: 2020, month: 4, day: 18);
            Assert.ThrowsException<Exception>(delegate { Creneau unCreneau = new Creneau(DateTime.Now, 120); });

        }
    }
}
