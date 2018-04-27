using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class Empty
    {
        public bool Guests(string Name, string Address, string NumberOfGuests, string RoomBooked)
        {
            if (Name != string.Empty
                && Address != string.Empty &&
                NumberOfGuests != string.Empty && RoomBooked != string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
