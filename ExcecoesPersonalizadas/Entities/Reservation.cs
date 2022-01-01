using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoOnze.ExcecoesPersonalizadas.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {
        }
        public Reservation(int externalRoomNumber, DateTime externalCheckIn, DateTime externalCheckOut)
        {
            RoomNumber = externalRoomNumber;
            CheckIn = externalCheckIn;
            CheckOut = externalCheckOut;
        }
        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }
        public void UpdateDates(DateTime externalCheckIn, DateTime externalCheckOut)
        {
            CheckIn = externalCheckIn;
            CheckOut = externalCheckOut;
        }

        public override string ToString()
        {
            return "Room"
            + RoomNumber
            + ", check-in: "
            + CheckIn.ToString("MM/dd/yyyy")
            + ", check-out: "
            + CheckOut.ToString("MM/dd/yyyy")
            + ", "
            + Duration()
            + " nights";
        }
    }
}