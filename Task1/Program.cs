using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICoder acoder = new ACoder();
            ICoder bcoder = new BCoder();

            string input = "Привет";
            string a = acoder.Encode(input);
            string b = bcoder.Encode(input);
            string outputa = acoder.Decode(a);
            string outputb = bcoder.Decode(b);
        }
    }
}
