using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using TraditionalCipher.Library.Interface;

namespace TraditionalCipher.Library
{
    public class ValiatorAndConverter : IValiatorAndConverter
    {
        private Regex onlyCapitalLetters = new Regex("^[A-Z]+$");
        private Dictionary<InputType , Func<string, Func<int, int, int>, string>> converterSelector;

        public ValiatorAndConverter()
        {
            this.converterSelector = new Dictionary<InputType, Func<string, Func<int, int, int>, string>>
            {
                { InputType.EnglishAlphabetsOnly, this.ValidateAndConvertForEnglishAlphabetsOnly }
            };
        }

        public string ValidateAndConvert(string text, InputType inputType, Func<int, int, int> shfitFuction)
        {
            return converterSelector[inputType].Invoke(text, shfitFuction);
        }

        private string ValidateAndConvertForEnglishAlphabetsOnly(string text, Func<int, int, int> shfitFuction)
        {
            var validatedString = this.ValidateAndConvertToAllUpper(text);
            var modifiedStringBuilder = new StringBuilder();
            foreach (var character in validatedString)
            {
                var charIndex = character - 65;
                var shfitedCharIndex = shfitFuction.Invoke(charIndex, 26);
                modifiedStringBuilder.Append(Convert.ToChar(shfitedCharIndex + 65));
            }
            return modifiedStringBuilder.ToString();
        }

        private string ValidateAndConvertToAllUpper(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new ArgumentNullException("Input string.");
            }

            var convertedtext = text.ToUpper();
            convertedtext = Regex.Replace(convertedtext, @"\s", "");
            if (!onlyCapitalLetters.IsMatch(convertedtext))
            {
                throw new ArgumentException("Input text contains unwanted character.");
            }

            return convertedtext;
        }
    }
}
