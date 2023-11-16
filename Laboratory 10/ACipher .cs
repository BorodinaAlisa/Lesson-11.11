using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_10
{
    internal class ACipher : ICipher
    {   
        public string Encode(string text)
        {
            char[] chars = text.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = ShiftCharacter(chars[i], 1);
            }
            return new string (chars);  
        }
        public string Decode(string text)   
        {
            char[] chars = text.ToCharArray();
            for (int i = 0; i <chars.Length; i++)   
            {
                chars[i] = ShiftCharacter(chars[i], -1);
            }
            return new string (chars);
        }
        private char ShiftCharacter (char c, int offset)
        {
            if (!char.IsLetter(c))
                return c;
            char baseChar = char.IsLower(c) ? 'a' : 'A';
            return (char)(((c - baseChar + offset) % 26) + baseChar);   
        }
    }
}
