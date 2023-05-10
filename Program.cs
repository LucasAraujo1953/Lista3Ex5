using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int t1;
            int t2;
            int t3;     
            int t4;
            int t5;
            int t6;
            int t7;
            int t8;
            int t9;
            int t10;

            do
            {
                Console.Write("Digite um Valor: ");
                n1 = int.Parse(Console.ReadLine());
                
            }
            while (n1 <= 0);

            t1 = n1 * 1;
            t2 = n1 * 2;
            t3 = n1 * 3;
            t4 = n1 * 4;
            t5 = n1 * 5;
            t6 = n1 * 6;
            t7 = n1 * 7;
            t8 = n1 * 8;
            t9 = n1 * 9;
            t10 = n1 * 10;
            Console.WriteLine("Portanto a tabuada deste valor é {0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);

        }
    }
}
