using System;
using System.Collections.Generic;
using System.Text;

namespace ContadorRegressivo
{
	public class Recursividade
	{
		//função recurssiva para calcular o fatorial de n
		
		public int Factorial(int pValor)
		{
			

			if (pValor <= 1)
			{
                Console.WriteLine(pValor);
                if (pValor == 1)
                {
                    Console.WriteLine("Explosão!!!");
                }
				return 1;
			}
			else
			{
                Console.WriteLine(pValor);
				return Factorial(pValor - 1) * pValor;

			}
			
		}


		
		
	}
}
