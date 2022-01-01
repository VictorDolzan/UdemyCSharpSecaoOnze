using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharpSecaoOnze.ExcecoesPersonalizadas.Entities;

namespace CSharpSecaoOnze.ExcecoesPersonalizadas
{
    class ExcecoesPersonalizadas
    {
        public static void ExecutarExcecoesPersonalizadas()
        {

            Console.Write("Room Number: ");
            int rNumber = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (MM/dd/yyyy): ");
            DateTime dCheckIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (MM/dd/yyyy): ");
            DateTime dCheckOut = DateTime.Parse(Console.ReadLine());

            Reservation reserv1 = new(rNumber, dCheckIn, dCheckOut);
            Console.Write("Reservation: " + reserv1);

            Console.WriteLine();
            Console.WriteLine("Enter data to update reservation: ");

            Console.Write("Check-in date (MM/dd/yyyy): ");
            DateTime uCheckIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (MM/dd/yyyy): ");
            DateTime uCheckOut = DateTime.Parse(Console.ReadLine());
            reserv1.UpdateDates(uCheckIn, uCheckOut);

            Console.Write("Reservation: " + reserv1);

        }
    }
}