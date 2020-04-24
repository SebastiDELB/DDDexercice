using DDDexercice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;


namespace UnitTestProject1
{
    [TestClass]
    public class TestClassCreneau
    {
        [TestMethod]
        public void CreationCreneau()
        {
            DateTime date = new DateTime(year: 2020, month: 4, day: 22, hour: 10, minute: 45, second: 00);
            Creneau unCreneau = new Creneau(date, 120);

            Assert.AreEqual(date, unCreneau.date);
        }
        [TestMethod]
        public void NullReferenceExceptioneDeclarationCreneau()
        {
            Assert.ThrowsException<ArgumentNullException>(delegate { Creneau unCreneau = new Creneau(DateTime.Now, 0); });

        }
        [TestMethod]
        public void ExceptionSurLeJourDeLaSemaineDeclarationCreneau()
        {
            DateTime date = new DateTime(year: 2020, month: 4, day: 19);
            Assert.ThrowsException<Exception>(delegate { Creneau unCreneau = new Creneau(date, 120); });
        }
        [TestMethod]
        public void ExceptionHeureDeDebutDeclarationCreneau()
        {
            DateTime date = new DateTime(year: 2020, month: 4, day: 19, hour: 7, minute: 49, second: 03);
            Assert.ThrowsException<Exception>(delegate { Creneau unCreneau = new Creneau(date, 120); });
        }
        [TestMethod]
        public void ExceptionHeureDeFinDeclarationCreneau()
        {
            DateTime date = new DateTime(year: 2020, month: 4, day: 19, hour: 21, minute: 30, second: 00);
            Assert.ThrowsException<Exception>(delegate { Creneau unCreneau = new Creneau(date, 120); });
        }
    }
}
