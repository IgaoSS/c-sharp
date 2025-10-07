using HelloWorld;
using HelloWorld.Teste;
using System.ComponentModel;
using System.Globalization;
using System.Text;

namespace HelloWorld;

class Program
{
    static void Main()
    {
        int numero = 0;

        while (numero < 10)
        {
            numero++;
            if(numero == 5)
            {
                continue;
            }
            
            Console.WriteLine(numero);
        }
    }
}