using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace HotelProgram
{
    public class HotelManagementSystem
    {
        private List<Hotel> _hotels;
        private List<User> _users;
        private List<Reservation> _reservations;

        public HotelManagementSystem()
        {
            _hotels = new List<Hotel>();
            _users = new List<User>();
            _reservations = new List<Reservation>();
        }

        public void RegisterUser(User user)
        {
            _users.Add(user);
        }

        public void AddHotel(Hotel hotel)
        {
            _hotels.Add(hotel);
        }
        public void DisplayHotels()
        {
            Console.WriteLine("Hotels: ");
            foreach( Hotel hotel in _hotels)
            {
                Console.WriteLine("\t" + hotel.DisplayDetails());
            }
        }
        
        public void BookReservation(Hotel hotel, HotelRoom room, Guest guest, DateTime startTime, DateTime endTime)
        {
            _hotels.Add(hotel);
        }

        public void DisplayReservationDetails(int reservationNumber)
        {
            Console.WriteLine("\t" + reservationNumber);
        }
    }
}
