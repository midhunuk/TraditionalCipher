using FluentAssertions;
using TraditionalCipher.Library;
using TraditionalCipher.Library.Ciphers;
using TraditionalCipher.Library.Interface;
using Xunit;

namespace TraditionalCipher.Tests
{
    public class Rot13CipherTests
    {
        private Rot13Cipher rot13Cipher;

        public Rot13CipherTests()
        {
            this.rot13Cipher = new Rot13Cipher(new ValiatorAndConverter());
        }

        [Fact]
        public void EncryptYText()
        {
            // Arrange
            var text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var encryptedString = "NOPQRSTUVWXYZABCDEFGHIJKLM";

            // Act
            var encryptText = this.rot13Cipher.Encrypt(text, InputType.EnglishAlphabetsOnly);

            // Assert
            encryptText.Should().Be(encryptedString);
        }

        [Fact]
        public void DecryptText()
        {
            // Arrange
            var text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var encryptedString = "NOPQRSTUVWXYZABCDEFGHIJKLM";

            // Act
            var decryptText = this.rot13Cipher.Decrypt(encryptedString, InputType.EnglishAlphabetsOnly);

            // Assert
            decryptText.Should().Be(text);
        }
    }
}
