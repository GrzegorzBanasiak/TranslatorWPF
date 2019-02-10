using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TranslatorWPF;

namespace TranslatorWPF.Tests
{
    [TestClass]
    public class LanguageDetectorTests
    {
        [TestMethod]
        public void DetectTest()
        {
            LanguageDetector lang = new LanguageDetector("I have a dog");
            String expected = "en";
            String actual;

            lang.Detect();
            actual = lang.DetectedLanguage;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DetectAreNotEqualTest()
        {
            LanguageDetector lang = new LanguageDetector("I have a dog");
            String expected = "pl";
            String actual;

            lang.Detect();
            actual = lang.DetectedLanguage;

            Assert.AreNotEqual(expected, actual);
        }

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
