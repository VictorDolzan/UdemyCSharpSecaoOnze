using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharpSecaoOnze.ExercicioFixacao.EntitiesF;
using CSharpSecaoOnze.ExercicioFixacao.EntitiesF.Exceptions;

namespace CSharpSecaoOnze.ExercicioFixacao
{
    class ExercicioFixacao
    {
        public static void ExecutarExercicioFixacao()
        {
            try
            {
                Console.WriteLine("Enter account data: ");
                Console.Write("Number: ");
                int accNumber = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string hName = Console.ReadLine();
                Console.Write("Initial Balance: ");
                double iBalance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw Limit: ");
                double wLimit = double.Parse(Console.ReadLine());

                Account acc = new(accNumber, hName, iBalance, wLimit);
                Console.WriteLine();

                Console.Write("Enter the amount for withdraw: ");
                double wAmount = double.Parse(Console.ReadLine());
                acc.Withdraw(wAmount);

                Console.WriteLine("New balance: " + acc.Balance.ToString("F2"));
            }
            catch(AccountException e)
            {
                Console.WriteLine("Error! " + e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Format error! " + e.Message);
            }
        }
    }
}