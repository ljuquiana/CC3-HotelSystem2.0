using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProgram
{
    public class Hotel
    {
        public string HotelName {  get; set; }
        public string Location {  get; set; }
        private List<HotelRoom> _allRooms;

        public Hotel(string hotelName, string location, List<HotelRoom> rooms)
        {
            HotelName = hotelName;
            Location = location;
            _allRooms = rooms;
        }

        public Hotel()
        {
            _allRooms = new List<HotelRoom>();
        }

        public void DisplayAvailableRooms()
        {
            foreach (HotelRoom room in _allRooms)
            {
                Console.WriteLine("\t" + room.DisplayDetails());
            }
        }

        public void DisplayBookedRooms()
        {
            foreach (HotelRoom room in _allRooms)
            {    
                if (room.Status == false)
                {
                    Console.WriteLine("\t" + room.DisplayDetails());
                }
            }
        }

        public void ReserveRoom(HotelRoom room)
        {
            room.Status = false;
        }

        public virtual string DisplayDetails()
        {
            return $"{HotelName} {Location} {_allRooms}";
        }
    }
}
