using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProgram
{
    public class Reservation
    {
        public int ReservationNumber {  get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public HotelRoom Room { get; set; }
        public int DurationInDays {  get; set; }
        public decimal Total {  get; set; }

        public Reservation(DateTime startTime, DateTime endTime, HotelRoom room)
        {
            StartTime = startTime;
            EndTime = endTime;
            Room = room;
        }

        public virtual string DisplayDetails()
        {
            return $"{ReservationNumber} {StartTime} {EndTime} {Room} {DurationInDays} {Total}";
        }
    }
}
