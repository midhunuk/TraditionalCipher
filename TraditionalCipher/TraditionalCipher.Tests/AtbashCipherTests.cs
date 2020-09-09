using FluentAssertions;
using TraditionalCipher.Library;
using TraditionalCipher.Library.Ciphers;
using TraditionalCipher.Library.Interface;
using Xunit;

namespace TraditionalCipher.Tests
{
    public class AtbashCipherTests
    {
        private AtbashCipher atbashCipher;

        public AtbashCipherTests()
        {
            this.atbashCipher = new AtbashCipher(new ValiatorAndConverter());
        }

        [Fact]
        public void EncryptYText()
        {
            // Arrange
            var text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var encryptedString = "ZYXWVUTSRQPONMLKJIHGFEDCBA";

            // Act
            var encryptText = this.atbashCipher.Encrypt(text, InputType.EnglishAlphabetsOnly);

            // Assert
            encryptText.Should().Be(encryptedString);
        }

        [Fact]
        public void DecryptText()
        {
            // Arrange
            var text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var encryptedString = "ZYXWVUTSRQPONMLKJIHGFEDCBA";

            // Act
            var decryptText = this.atbashCipher.Decrypt(encryptedString, InputType.EnglishAlphabetsOnly);

            // Assert
            decryptText.Should().Be(text);
        }
    }
}
