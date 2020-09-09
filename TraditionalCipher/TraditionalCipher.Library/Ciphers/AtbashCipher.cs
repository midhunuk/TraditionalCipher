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

        public string Encrypt(string text, InputType inputType)
        {
            return this.valiatorAndConverter.ValidateAndConvert(text, inputType, this.Shfit);
        }

        public string Decrypt(string text, InputType inputType)
        {
            return this.valiatorAndConverter.ValidateAndConvert(text, inputType, this.Shfit);
        }
        private int Shfit(int index, int maxChar) 
        { 
            return Math.Abs(index - (maxChar - 1));
        }
}
}
