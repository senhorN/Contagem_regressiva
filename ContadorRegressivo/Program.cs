using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContadorRegressivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Recursividade rec = new Recursividade();

            ////variavel valor criada
            int valor;

            Console.WriteLine("==================================================");
            Console.WriteLine();
            Console.WriteLine("==              Contador regressivo           == ");
            Console.WriteLine("==================================================");
            Console.WriteLine();



            //O usuário informa um valor
            Console.WriteLine(DateTime.Now.ToString("dd/MMM/yyyy HH:mm:SS") + ("| Informe um número:"));
            valor = int.Parse(Console.ReadLine());

            //pulo de uma linha 
            Console.WriteLine();

            //recebe valor do usuário 
            int obj = rec.Factorial(valor);
            Console.WriteLine(obj);

            

            
        
    
        }
    } 
}
