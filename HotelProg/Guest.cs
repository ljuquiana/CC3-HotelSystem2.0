using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProgram
{
    public class Guest : User
    {
        private List<Reservation> _reservations;
        public int TotalBookedRooms { get; set; }

        public Guest(string name, string address, string email, int phoneNumber) : base(name, address, email, phoneNumber)
        {
            _reservations = new List<Reservation>();
        }

        public void BookReservation(Reservation reservation)
        {
            _reservations.Add(reservation);
        }

        public void DisplayReservations()
        {
            foreach (Reservation reservation in _reservations)
            {
                Console.WriteLine("\t" + reservation.DisplayDetails());
            }
        }
    }
}
