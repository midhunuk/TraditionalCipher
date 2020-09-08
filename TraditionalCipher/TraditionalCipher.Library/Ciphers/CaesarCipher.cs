using System;
using System.Text;
using TraditionalCipher.Library.Interface;

namespace TraditionalCipher.Library.Ciphers
{
    public class CaesarCipher
    {
        private readonly IValiatorAndConverter valiatorAndConverter;

        public CaesarCipher(IValiatorAndConverter valiatorAndConverter)
        {
            this.valiatorAndConverter = valiatorAndConverter;
        }

        public string Encrypt(string text, int key = 3)
        {
            var convertedText = this.valiatorAndConverter.ValidateAndConvertToAllUpper(text);
            var encryptedStringBuilder = new StringBuilder();
            foreach(var character in convertedText)
            {
                var charIndex = character - 39;
                var shfitedCharIndex = (charIndex + key%26) % 26;
                encryptedStringBuilder.Append(Convert.ToChar(shfitedCharIndex + 65));
            }

            return encryptedStringBuilder.ToString();
        }

        public string Decrypt(string encryptext, int key=3)
        {
            var convertedText = this.valiatorAndConverter.ValidateAndConvertToAllUpper(encryptext);
            var decryptedStringBuilder = new StringBuilder();
            foreach (var character in convertedText)
            {
                var charIndex = character - 65;
                var shfitedCharIndex = (charIndex +26 - key%26) % 26;
                decryptedStringBuilder.Append(Convert.ToChar(shfitedCharIndex + 65));
            }

            return decryptedStringBuilder.ToString();
        }
    }
}
