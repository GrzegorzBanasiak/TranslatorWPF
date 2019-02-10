using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TranslatorWPF;

namespace TranslatorWPFTests.ClassLibrary
{
    [TestClass]
    public class SettingsTests
    {
        [TestMethod]
        public void GetKeyTest()
        {
            String actual;
            String expected = "trnsl.1.1.20190122T131408Z.7e8f1dd71efa4d37.2d3037c7e197068496a8cfca764dc21812229fad";

            actual = Settings.API_KEY;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetKeyTestNotEqual()
        {
            String actual;
            String expected = "68496a8cfca764dc21812229fad";

            actual = Settings.API_KEY;

            Assert.AreNotEqual(expected, actual);
        }
    }
}
