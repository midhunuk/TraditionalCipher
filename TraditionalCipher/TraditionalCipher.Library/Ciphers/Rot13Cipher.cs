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

        public string Encrypt(string text)
        {
            return this.caesarCipher.Encrypt(text, 13);
        }

        public string Decrypt(string encryptext)
        {
            return this.caesarCipher.Decrypt(encryptext, 13);
        }
    }
}
