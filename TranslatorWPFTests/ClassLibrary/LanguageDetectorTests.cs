using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TranslatorWPF;

namespace TranslatorWPF.Tests
{
    [TestClass]
    public class LanguageDetectorTests
    {
        [TestMethod]
        public void GetFullNameLanguageTest()
        {
            LanguageDetector lang = new LanguageDetector("siemano")
            {
                DetectedLanguage = "pl"
            };
            String expected = "Polish";
            String actual;

            actual = lang.GetFullNameLanguage();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetFullNameLanguageAreNotEqualTest()
        {
            LanguageDetector lang = new LanguageDetector("siemano")
            {
                DetectedLanguage = "pl"
            };
            String expected = "English";
            String actual;

            actual = lang.GetFullNameLanguage();

            Assert.AreNotEqual(expected, actual);
        }
    }
}
