using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TranslatorWPF;

namespace TranslatorWPF.Tests
{
    [TestClass]
    public class TranslatorTests
    {
        [TestMethod]
        public void TranslateTest()
        {
            Translator tran = new Translator();
            String expected = "kot";
            String actual;

            actual = tran.Translate("cat", "pl");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TranslateAreNotEqualTest()
        {
            Translator tran = new Translator();
            String expected = "kot";
            String actual;

            actual = tran.Translate("cat", "it");

            Assert.AreNotEqual(expected, actual);
        }
    }
}
