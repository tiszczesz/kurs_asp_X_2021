using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiProjectsWebRazor.Domain;

namespace MultiProjectsWebRazor.UTests
{
    [TestClass]
    public class EncodeTest 
    {
        [TestMethod]
        public void EncodeWithKeyZero()
        {
            // Arrange
            Encrypt encrypt = new Encrypt();
            encrypt.Key = 0;
            encrypt.PlainText = "ala ma kota";

            // Act
            var result = encrypt.EncText();

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(encrypt.PlainText,encrypt.EncodingText);
        }

        [TestMethod]
        public void EncodeWithKeyOne()
        {
            // Arrange
            Encrypt encrypt = new Encrypt();
            encrypt.Key = 1;
            encrypt.PlainText = "ala ma kota";

            // Act
            var result = encrypt.EncText();

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual("bmb nb lpub", encrypt.EncodingText);
        }
        [TestMethod]
        public void EncodeOneChar()
        {
            // Arrange
            Encrypt encrypt = new Encrypt();
            encrypt.Key = 1;
            encrypt.PlainText = "a";

            // Act
            var result = encrypt.EncText();

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual("b", encrypt.EncodingText);
        }

        [TestMethod]
        public void EncodeSpaceChar()
        {
            // Arrange
            Encrypt encrypt = new Encrypt();
            encrypt.Key = 1;
            encrypt.PlainText = " ";

            // Act
            var result = encrypt.EncText();

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(" ", encrypt.EncodingText);
        }
    }
}
