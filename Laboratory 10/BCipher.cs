using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_10
{
    public class BCipher : ICipher
    {
        public string Encode(string text)
        {
            char[] chars = text.ToCharArray();
            for (int i = 0; i < chars.Length; i++) 
            {
                chars[i] = ReplaceCharacter(chars[i]);
            }
            return new string(chars);   
        }
        public string Decode(string text) 
        {
            char[] chars = text.ToCharArray();
            for (int i= 0; i < chars.Length; i++) 
            {
                chars[i] = ReplaceCharacter(chars[i]);
            }
            return new string(chars);
        }   
        private char ReplaceCharacter(char c) 
        {
            if (!char.IsLetter(c))
                return c;
            char baseChar = char.IsLower(c) ? 'a' : 'A';
            int index = c - baseChar;
            return (char)(baseChar + 25 - index);
        }
    }
}
