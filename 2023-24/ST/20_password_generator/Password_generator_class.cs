using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_password_generator
{
    internal class Password_generator_class
    {
        public Password_generator_class()
        {
        }
        
        public string Generate_password(int passwordLen)
        {
            string[] passwords = new string[3];
            passwords[0] = Generate_charRange(passwordLen, 48, 57);
            passwords[1] = Generate_charRange(passwordLen, 97, 122);
            passwords[2] = Generate_charRange(passwordLen, 65, 90);

            Random rand = new Random();
            // Generate indexes so every type appears at least once
            // TODO: dont care could finish this

            string final_password = "";
            for (int i = 0; i < passwordLen; i++)
            {
                final_password += passwords[rand.Next(0, 3)][i];
            }
            return final_password;
        }

        private string Generate_charRange(int passwordLen, int min, int max)
        {
            max += 1; // Random max value is the bound so the biggest char would never get generated
            if (min > max)
            {
                return "";
            }
            Random rand = new Random();
            string pass_string = "";
            for (int i = 0; i < passwordLen; i++)
            {
                char character = (char)rand.Next(min, max);
                pass_string += character;
            }
            return pass_string;
        }
    }
}
