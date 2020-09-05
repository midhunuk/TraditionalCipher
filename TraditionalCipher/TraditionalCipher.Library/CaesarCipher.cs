using System;
using System.Text;
using System.Text.RegularExpressions;

namespace TraditionalCipher.Library
{
    public class CaesarCipher
    {
        private Regex onlyCapitalLetters = new Regex("^[A-Z]+$");
        public string Encrypt(string text, int key)
        {
            var convertedText = this.ValidateAndConvert(text);
            var encryptedStringBuilder = new StringBuilder();
            foreach(var character in convertedText)
            {
                var charIndex = character - 39;
                var shfitedCharIndex = (charIndex + key%26) % 26;
                encryptedStringBuilder.Append(Convert.ToChar(shfitedCharIndex + 65));
            }

            return encryptedStringBuilder.ToString();
        }

        public string Decrypt(string encryptext, int key)
        {
            var convertedText = this.ValidateAndConvert(encryptext);
            var decryptedStringBuilder = new StringBuilder();
            foreach (var character in convertedText)
            {
                var charIndex = character - 65;
                var shfitedCharIndex = (charIndex +26 - key%26) % 26;
                decryptedStringBuilder.Append(Convert.ToChar(shfitedCharIndex + 65));
            }

            return decryptedStringBuilder.ToString();
        }

        private string ValidateAndConvert(string text)
        {
            if(string.IsNullOrEmpty(text))
            {
                throw new ArgumentNullException("Input string.");
            }

            var convertedtext = text.ToUpper();
            convertedtext = Regex.Replace(convertedtext, @"\s", "");
            if(!onlyCapitalLetters.IsMatch(convertedtext))
            {
                throw new ArgumentException("Input text contains unwanted character.");
            }

            return convertedtext;
        }
    }
}
