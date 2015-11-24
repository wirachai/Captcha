using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Captcha.Test
{
    [TestFixture]
    class CaptchaTest
    {
        [Test]
        public void Get_ShouldReturnOnePlus1_WhenInput1111()
        {
            Captcha captcha = new Captcha(1, 1, 1, 1);
            var result = captcha.Get();
            Assert.AreEqual("One + 1", result);
        }
    }
}
