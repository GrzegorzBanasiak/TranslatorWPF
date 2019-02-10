using Microsoft.VisualStudio.TestTools.UnitTesting;
using TranslatorWPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslatorWPF.Tests
{
    [TestClass()]
    public class TextGetterTests
    {
        [TestMethod()]
        public void GetBetweenTest()
        {
            String text = "mmHello Worldss";
            String before = "mm";
            String after = "ss";
            String expected = "Hello World";
            String actual;

            actual = TextGetter.GetBetween(text, before, after);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetBetweenTestNotEqual()
        {
            String text = "mmHello Worldss";
            String before = "mm";
            String after = "ss";
            String expected = "Hello Worldss";
            String actual;

            actual = TextGetter.GetBetween(text, before, after);

            Assert.AreNotEqual(expected, actual);
        }
    }
}