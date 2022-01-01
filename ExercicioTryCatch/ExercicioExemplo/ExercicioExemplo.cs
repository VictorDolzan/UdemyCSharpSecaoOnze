using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoOnze.ExercicioTryCatch.ExercicioExemplo
{
    class ExercicioExemplo
    {
        public static void ExecutarExercicioExemplo()
        {
            try
            {
                Console.WriteLine("Digite um número: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite outro número: ");
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine("Resultado: " + result);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Error!" + e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Error! " + e.Message);
            }
        }
    }
}