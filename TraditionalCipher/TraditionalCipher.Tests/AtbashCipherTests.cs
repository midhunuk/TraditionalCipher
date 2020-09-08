using FluentAssertions;
using TraditionalCipher.Library;
using TraditionalCipher.Library.Ciphers;
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
            var encryptText = this.atbashCipher.Encrypt(text);

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
            var decryptText = this.atbashCipher.Decrypt(encryptedString);

            // Assert
            decryptText.Should().Be(text);
        }
    }
}
