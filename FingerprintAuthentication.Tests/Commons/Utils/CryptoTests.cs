using Microsoft.VisualStudio.TestTools.UnitTesting;
using FingerprintAuthentication.Commons.Utils;

namespace FingerprintAuthentication.Tests.Commons.Utils
{
    /// <summary>
    /// Summary description for CryptoTests
    /// </summary>
    [TestClass]
    public class CryptoTests
    {
        [TestMethod]
        public void HashMD5_Text_Should_Be_Correct()
        {
            string value = "value";
            string expectedHash = "2063C1608D6E0BAF80249C42E2BE5804";
            Assert.AreEqual(Crypto.HashMD5(value), expectedHash);
        }
        [TestMethod]
        public void HashMD5_Text_Salt_Should_Be_Correct()
        {
            string value = "value";
            string salt = "salt";
            string expectedHash = "EDCFC93E3A3010A74FDCF1E8CEEDFEAB";
            Assert.AreEqual(Crypto.HashMD5(value, salt), expectedHash);
        }
    }
}
