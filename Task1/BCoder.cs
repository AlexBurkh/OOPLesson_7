using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class BCoder : ICoder
    {
        public string Encode(string input)
        {
            string result = string.Empty;
            for (Int32 i = 0; i < input.Length; i++)
            {
                result += EncodeSymbol(input[i]);
            }
            return result;
        }

        public string Decode(string input)
        {
            string result = string.Empty;
            for (Int32 i = 0; i < input.Length; i++)
            {
                result += DecodeSymbol(input[i]);
            }
            return result;
        }

        private char EncodeSymbol(char symbol)
        {
            if (symbol >= 'А' && symbol <= 'Я')
            {
                return (char)('Я' - (symbol - 'А'));
            }
            if (symbol >= 'а' && symbol <= 'я')
            {
                return (char)('я' - (symbol - 'а'));
            }
            if (symbol >= '0' && symbol <= '9')
            {
                return (char)('9' - (symbol - '0'));
            }
            throw new ArgumentException("Символ не принадлежит алфавиту");
        }
        private char DecodeSymbol(char symbol)
        {
            if (symbol >= 'А' && symbol <= 'Я')
            {
                return (char)('А' + ('Я' - symbol));
            }
            if (symbol >= 'а' && symbol <= 'я')
            {
                return (char)('а' + ('я' - symbol));
            }
            if (symbol >= '0' && symbol <= '9')
            {
                return (char)('0' + ('9' - symbol));
            }
            throw new ArgumentException("Символ не принадлежит алфавиту");
        }
    }
}
