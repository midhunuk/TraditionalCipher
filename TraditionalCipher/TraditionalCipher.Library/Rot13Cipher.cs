using System;
using System.Collections.Generic;
using System.Text;

namespace TraditionalCipher.Library
{
    public class Rot13Cipher
    {
        private CaesarCipher caesarCipher;

        public Rot13Cipher()
        {
            this.caesarCipher = new CaesarCipher();
        }

        public string Encrypt(string text)
        {
            return this.caesarCipher.Encrypt(text, 13);
        }

        public string Decrypt(string encryptext, int key)
        {
            return this.caesarCipher.Decrypt(encryptext, 13);
        }
    }
}
