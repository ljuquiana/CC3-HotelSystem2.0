using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProgram
{
    public class HotelRoom
    {
        public int RoomNumber {  get; set; }
        public RoomStyle Style { get; set; }
        public bool Status { get; set; }
        public decimal BookingPrice {  get; set; }

        public HotelRoom(int roomNumber, RoomStyle style, bool status, decimal price)
        {
            RoomNumber = roomNumber;
            Style = style;
            Status = status;
            BookingPrice = price;
        }

        public virtual string DisplayDetails()
        {
            return $"{RoomNumber} {Status} {BookingPrice}";
        }
    }
}
