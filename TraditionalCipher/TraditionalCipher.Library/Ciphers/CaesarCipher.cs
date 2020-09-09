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

        public string Encrypt(string text, InputType inputType, int key = 3)
        {
            return this.valiatorAndConverter.ValidateAndConvert(text, inputType, 
                (int index, int maxChar) => { return (index + maxChar  + key % maxChar) % maxChar; } );
        }

        public string Decrypt(string encryptext, InputType inputType, int key=3)
        {
            return this.valiatorAndConverter.ValidateAndConvert(encryptext, inputType,
                (int index, int maxChar) => { return (index + maxChar - key % maxChar) % maxChar; });
        }
    }
}
