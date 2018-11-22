using Microsoft.VisualStudio.TestTools.UnitTesting;
using FingerprintAuthentication.Commons.Utils;

namespace FingerprintAuthentication.Tests.Commons.Utils
{
    /// <summary>
    /// Summary description for CryptoTests
    /// </summary>
    [TestClass]
    public class StringUtilsTests
    {
        [TestMethod]
        public void NumbersOnly_Must_Return_123()
        {
            string value = "1te2ste3";
            Assert.AreEqual("123", StringUtils.NumbersOnly(value));
        }
    }
}
