using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mjoir1865
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0;
            int n = int.Parse(Console.ReadLine());
            for (i = 0; n > i; i++)
            {
               
               
                string[] texto = Console.ReadLine().Split(' ');
                string nome = texto[0]; int forca = int.Parse(texto[1]);

                if (nome == "Thor")
                {
                    Console.WriteLine("Y");

                }
                else
                {
                    Console.WriteLine("N");
                }
                
            }
            
            Console.ReadKey();


        }
    }
}
