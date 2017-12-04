using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Data.Database;

namespace Hotel.Data
{
    class BookingsClass
    {

        public int GuestID { get; set; }


        public IEnumerable viewBookings()
        {
            //Our standard Using statement passing all the data to context 
            using (var context = new MotelEntities())
            {
                //What ever we want our code to do we do it in here
                //Pass our fields across to a variable
                var alldata = from g in context.Bookings where g.RoomIDFK == GuestID
                    select new
                    {
                        g.BookingID,
                        //g.RoomIDFK,
                        g.BookingFrom,
                        g.BookingTo,
                        g.RoomCost


                    }; 
                    
                return alldata.ToList();
            }
        }
    }
}

