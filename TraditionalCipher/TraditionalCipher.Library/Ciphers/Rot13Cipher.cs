using TraditionalCipher.Library.Interface;

namespace TraditionalCipher.Library.Ciphers
{
    public class Rot13Cipher
    {
        private CaesarCipher caesarCipher;

        public Rot13Cipher(IValiatorAndConverter valiatorAndConverter)
        {
            this.caesarCipher = new CaesarCipher(valiatorAndConverter);
        }

        public string Encrypt(string text, InputType inputType)
        {
            return this.caesarCipher.Encrypt(text, inputType, 13);
        }

        public string Decrypt(string encryptext, InputType inputType)
        {
            return this.caesarCipher.Decrypt(encryptext, inputType, 13);
        }
    }
}
