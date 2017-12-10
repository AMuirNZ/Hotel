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
        public int BookingID{ get; set; }
        public int RoomIDFK { get; set; }
        public DateTime BookingFrom { get; set; }
        public DateTime BookingTo { get; set; }
        public decimal RoomCost { get; set; }
        public int numSingleBeds { get; set; }
        public int numDoubleBeds { get; set; }


       


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
                        g.RoomIDFK,
                        g.BookingFrom,
                        g.BookingTo,
                        g.RoomCost


                    }; 
                    
                return alldata.ToList();
            }
        }

        public void addBooking()
        {
            using (var context = new MotelEntities())
            {


                var BookingZ = new Booking();
              
                BookingZ.RoomIDFK = GuestID;
                BookingZ.BookingFrom = BookingFrom;
                BookingZ.BookingTo = BookingTo;
                BookingZ.RoomCost = 100 + (numSingleBeds * 20 ) + (numDoubleBeds * 40);


                //Add to entity set of context
                context.Bookings.Add(BookingZ);
                context.SaveChanges();

            }
        }

        public void deleteBooking()
        {
            using (var context = new MotelEntities())
            {

                //select the row you want to delete
                var contact = (from s in context.Bookings
                    where s.BookingID == BookingID
                    select s).SingleOrDefault();
                //run remove command
                context.Bookings.Remove(contact);
                //save the changes
                context.SaveChanges();


            }
        }
    }
}

