using System;
using System.Text.RegularExpressions;
using TraditionalCipher.Library.Interface;

namespace TraditionalCipher.Library
{
    public class ValiatorAndConverter : IValiatorAndConverter
    {
        private Regex onlyCapitalLetters = new Regex("^[A-Z]+$");

        public string ValidateAndConvertToAllUpper(string text)
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
