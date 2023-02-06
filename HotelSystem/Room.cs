using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem
{
    internal class Room
    {
        public int RoomNumber { get; set; }
        public decimal RoomPrice { get; set; }
        public RoomType RoomType { get; set;}
        public bool IsAvailable { get; set; }
    }
}
