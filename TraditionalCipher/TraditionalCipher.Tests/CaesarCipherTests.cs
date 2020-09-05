using FluentAssertions;
using System;
using Xunit;
using TraditionalCipher.Library;

namespace TraditionalCipher.Tests
{
    public class CaesarCipherTests
    {
        private CaesarCipher caesarCipherCodec;

        public CaesarCipherTests()
        {
            this.caesarCipherCodec = new CaesarCipher();
        }

        [Theory]
        [ClassData(typeof(CaesarCipherTestData))]
        public void EncryptText(int key, string encryptedString)
        {
            // Arrange
            var text = "A B C D E F G H I J K L M n o p q r s t u v W X Y Z";

            // Act
            var encryptText = this.caesarCipherCodec.Encrypt(text, key);

            // Assert
            encryptText.Should().Be(encryptedString);

        }

        [Theory]
        [ClassData(typeof(CaesarCipherTestData))]
        public void DecryptText(int key, string encryptedString)
        {
            // Arrange
            var text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            // Act
            var decryptText = this.caesarCipherCodec.Decrypt(encryptedString, key);

            // Assert
            decryptText.Should().Be(text);

        }

        [Fact]
        public void InvalidCharacterInInputText_ArgumentExceptionIsThrown()
        {
            // Arrange
            var text = "Ad @ 73";

            // Act
            Action encrypt = () => this.caesarCipherCodec.Encrypt(text, 5);
            Action decrypt = () => this.caesarCipherCodec.Decrypt(text, 5);

            // Assert
            encrypt.Should().Throw<ArgumentException>().WithMessage("Input text contains unwanted character.");
            decrypt.Should().Throw<ArgumentException>().WithMessage("Input text contains unwanted character.");
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void EmptyAndNullInputText_ArgumentNullExceptionIsThrown(string inputText)
        {
            // Act
            Action encrypt = () => this.caesarCipherCodec.Encrypt(inputText, 5);
            Action decrypt = () => this.caesarCipherCodec.Decrypt(inputText, 5);

            // Assert
            encrypt.Should().Throw<ArgumentNullException>();
            decrypt.Should().Throw<ArgumentNullException>();
        }
    }
}
