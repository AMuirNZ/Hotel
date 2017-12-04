using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Data.Database;

namespace Hotel.Data
{
    class GuestsClass
    {

        public int BookingID { get; set; }

        public IEnumerable viewGuests()
        {
            //Our standard Using statement passing all the data to context 
            using (var context = new MotelEntities())
            {
                //What ever we want our code to do we do it in here
                //Pass our fields across to a variable
                var alldata = from g in context.Guests where g.BookingIDFK == BookingID 
                    select new
                    {
                        g.GuestID,
                        g.BookingIDFK,
                        g.Name,
                        g.Address,
                        g.NumberOfGuests,
                        g.RoomBooked,
                        g.CheckIn,
                        g.CheckOut,
                        g.BookingDate


                    };
                return alldata.ToList();
            }
        }
    }
}
