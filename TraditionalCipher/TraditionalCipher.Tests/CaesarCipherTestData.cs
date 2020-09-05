using System;
using System.Collections;
using System.Collections.Generic;

namespace TraditionalCipher.Tests
{
    class CaesarCipherTestData : IEnumerable<object[]>
    {
        private const int Cases = 54;
        private int[] keyArray;
        private string[] encryptedStringArray;

        public CaesarCipherTestData()
        {
            this.Initialize();
        }

        public IEnumerator<object[]> GetEnumerator()
        {
            for (var i = 0; i < Cases; i++)
            {
                yield return new object[] { this.keyArray[i], this.encryptedStringArray[i] };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        private void Initialize()
        {
            var baseString = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            this.keyArray = new int[Cases];
            this.encryptedStringArray = new string[Cases];
            for (var i = 0; i < this.encryptedStringArray.Length; i++)
            {
                var key = (i - 26) % 26;
                this.keyArray[i] = key;
                if (key > 0)
                {
                    this.encryptedStringArray[i] = baseString.Substring(key, baseString.Length - key) + baseString.Substring(0, key);
                }
                else if(key < 0)
                {
                    var absKey = Math.Abs(key); 
                    this.encryptedStringArray[i] = baseString.Substring(baseString.Length - absKey, absKey) + baseString.Substring(0, baseString.Length - absKey);
                }
                else
                {
                    this.encryptedStringArray[i] = baseString;
                }
            }
        }
    }
}
