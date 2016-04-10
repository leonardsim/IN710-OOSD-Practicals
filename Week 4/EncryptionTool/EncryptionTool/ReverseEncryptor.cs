using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionTool
{
    public class ReverseEncryptor : IEncryption
    {
        public string Encrypt(string input)
        {
            // Save string characters into char array
            char[] arrayChar = input.ToCharArray();

            // Call the Array Reverse feature, which reverses the characters
            Array.Reverse(arrayChar);

            // Save and return the reversed string
            string encString = new string(arrayChar);

            return encString;
        }
    }
}
