using System;
using System.Text;
using TraditionalCipher.Library.Interface;

namespace TraditionalCipher.Library.Ciphers
{
    public class AtbashCipher
    {
        private readonly IValiatorAndConverter valiatorAndConverter;

        public AtbashCipher(IValiatorAndConverter valiatorAndConverter)
        {
            this.valiatorAndConverter = valiatorAndConverter;
        }

        public string Encrypt(string text)
        {
            return convert(text);
        }

        public string Decrypt(string text)
        {
            return convert(text);
        }

        private string convert(string text)
        {
            var convertedText = this.valiatorAndConverter.ValidateAndConvertToAllUpper(text);
            var encryptedStringBuilder = new StringBuilder();
            foreach (var character in convertedText)
            {
                var charIndex = character - 65;
                var shfitedCharIndex = Math.Abs(charIndex - 25);
                encryptedStringBuilder.Append(Convert.ToChar(shfitedCharIndex + 65));
            }
            return encryptedStringBuilder.ToString();
        }
    }
}
