using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharpSecaoOnze.ExcecoesPersonalizadas.Entities.Exceptions;

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
            if (externalCheckOut <= externalCheckIn)
            {
                throw new DomainException("Check-out must be after check-in");
            }
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
            DateTime now = DateTime.Now;
            if (externalCheckIn < now || externalCheckOut < now)
            {
                throw new DomainException("Reservation dates for updates must be future dates!");
            }
            if (externalCheckOut <= externalCheckIn)
            {
                throw new DomainException("Check-out must be after check-in");
            }
            CheckIn = externalCheckIn;
            CheckOut = externalCheckOut;
        }

        public override string ToString()
        {
            return "Room "
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