﻿using System;   
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel.Data.Database;

namespace Hotel.Data
{

    //Guests variables introduced from form.
    class GuestsClass
    {
        public int GuestID { get; set; }
        public int BookingIDFK { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int NumberOfGuests { get; set; }
        public int RoomBooked { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public DateTime BookingDate { get; set; }
        public int BookingID { get; set; }

      

        public IEnumerable viewGuests()
        {
            //Our standard Using statement passing all the data to context 
            using (var context = new MotelEntities())
            {
                //Extract all fields from databases and assign to correct names
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

        //Add Guest to database     
        public void addGuest()
        {
            using (var context = new MotelEntities())
            {
                //assign variables to fields from database

                var GuestZ = new Guest();

                GuestZ.BookingIDFK = BookingIDFK;
                GuestZ.Name = Name;
                GuestZ.Address = Address;
                GuestZ.NumberOfGuests = NumberOfGuests;
                GuestZ.RoomBooked = RoomBooked;
                GuestZ.CheckIn = CheckIn;
                GuestZ.CheckOut = CheckOut;
                GuestZ.BookingDate = BookingDate;


                //Add to entity set of context
                context.Guests.Add(GuestZ);
                context.SaveChanges();

            }
        }

        //Delete Guest from Database
        public void deleteGuest()
        {
            using (var context = new MotelEntities())
            {

                //select the row you want to delete
                var contact = (from s in context.Guests
                               where s.GuestID == GuestID
                               select s).SingleOrDefault();
                //run remove command
                context.Guests.Remove(contact);
                //save the changes
                context.SaveChanges();


            }
        }

        //Update currently existing guest in database         
        public void updateGuest()
        {

            //assign variables to fields from database
            using (var context = new MotelEntities())
            {
                var query = from s in context.Guests
                            where s.GuestID == GuestID
                            select s;
                var guest = query.FirstOrDefault();

                guest.Name = Name;
                guest.Address = Address;
                guest.NumberOfGuests = NumberOfGuests;
                guest.RoomBooked = RoomBooked;
                guest.Address = Address;
                guest.CheckIn = CheckIn;
                guest.CheckOut = CheckOut;
                guest.BookingDate = BookingDate;

                context.SaveChanges();


            }

            
        }

       
    }
}
