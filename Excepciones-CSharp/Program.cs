using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Introduzca un número: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Introduzca otro número: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
                Console.ReadLine();
            }
            catch (DivideByZeroException e)
            {
                Console.Write(e.Message);
            }
            catch(FormatException e)
            {
                Console.Write(e.Message);
            }
        }
    }
}
