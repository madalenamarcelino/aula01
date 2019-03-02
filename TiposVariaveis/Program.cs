using System;
using System.Text;

namespace TiposVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int qual = 1234;
            float fff = 86f;
            string val = "44";
            decimal dec = 33m;
            char woow = 'h';
        
            Console.WriteLine("Os valores sao: "  + qual + " " + fff + " " + val + " " + dec + " " + woow);

            char omega = '0x000D';
            char eternity = '\u03A9';
            Console.WriteLine(omega + eternity);
        }
    }
}
