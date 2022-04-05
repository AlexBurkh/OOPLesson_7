using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class ACoder : ICoder
    {
        public string Encode(string input)
        {
            string result = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                result += EncodeSymbol(input[i]);
            }
            return result;
        }
        public string Decode(string input)
        {
            string result = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                result += DecodeSymbol(input[i]);
            }
            return result;
        }

        private char EncodeSymbol(char symbol)
        {
            return ++symbol;
        }
        private char DecodeSymbol(char symbol)
        {
            return --symbol;
        }
    }
}
