using FluentAssertions;
using Xunit;
using TraditionalCipher.Library;
using TraditionalCipher.Library.Ciphers;
using TraditionalCipher.Library.Interface;

namespace TraditionalCipher.Tests
{
    public class CaesarCipherTests
    {
        private CaesarCipher caesarCipher;

        public CaesarCipherTests()
        {
            this.caesarCipher = new CaesarCipher(new ValiatorAndConverter());
        }

        [Theory]
        [ClassData(typeof(CaesarCipherTestData))]
        public void EncryptText(int key, string encryptedString)
        {
            // Arrange
            var text = "A B C D E F G H I J K L M n o p q r s t u v W X Y Z";

            // Act
            var encryptText = this.caesarCipher.Encrypt(text, InputType.EnglishAlphabetsOnly, key);

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
            var decryptText = this.caesarCipher.Decrypt(encryptedString, InputType.EnglishAlphabetsOnly, key);

            // Assert
            decryptText.Should().Be(text);
        }

        [Fact]
        public void ClassicEncryptText()
        {
            // Arrange
            var text = "A B C D E F G H I J K L M n o p q r s t u v W X Y Z";
            var encryptedString = "DEFGHIJKLMNOPQRSTUVWXYZABC";

            // Act
            var encryptText = this.caesarCipher.Encrypt(text, InputType.EnglishAlphabetsOnly);

            // Assert
            encryptText.Should().Be(encryptedString);
        }

        [Fact]
        public void ClassicDecryptText()
        {
            // Arrange
            var text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; 
            var encryptedString = "DEFGHIJKLMNOPQRSTUVWXYZABC";

            // Act
            var decryptText = this.caesarCipher.Decrypt(encryptedString, InputType.EnglishAlphabetsOnly);

            // Assert
            decryptText.Should().Be(text);
        }
    }
}
