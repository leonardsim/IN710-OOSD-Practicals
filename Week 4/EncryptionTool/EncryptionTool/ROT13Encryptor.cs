using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionTool
{
    public class ROT13Encryptor : IEncryption
    {
        public string Encrypt(string input)
        {
            // Save string characters into char array
            char[] arrayChar = input.ToCharArray();

            for (int i = 0; i < arrayChar.Length; i++)
            {
                // Saves the content of arrayChar[i] as an int by casting it
                int numVal = (int)arrayChar[i];  
                
                // Checks if it is within the character range 1- 26
                if (numVal >= 'a' && numVal <= 'z')
                {
                    // If the character is further down than 'm' then deduct it by 13
                    // Else add 13 to it
                    if (numVal >'m')
                    {
                        numVal -= 13;
                    }
                    else
                    {
                        numVal += 13;
                    }
                }
                else if (numVal >= 'A' && numVal <= 'Z') // Same concept as above except with Captital letters
                {
                    if (numVal > 'M')
                    {
                        numVal -= 13;
                    }
                    else
                    {
                        numVal += 13;
                    }
                }
                // Cast the numVal back into a char and store it back into the array
                arrayChar[i] = (char)numVal;
            }

            //return the encrypted string
            string encString = new string(arrayChar);

            return encString;
        }

    }
}
