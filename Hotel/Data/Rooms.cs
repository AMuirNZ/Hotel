using Hotel.Data.Database;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Data
{
    class Rooms
    {
        public int RoomID { get; set; }
        public int NumSingleBeds { get; set; }
        public int NumDoubleBeds { get; set; }
        public string ExtraFeatures { get; set; }
        public decimal TariffSinglePerson { get; set; }
        public decimal Tariff2People { get; set; }
        public decimal TariffExtraPerson { get; set; }

        public IEnumerable viewRooms()
        {
            //Our standard Using statement passing all the data to context 
            using (var context = new MotelEntities())
            {
                //What ever we want our code to do we do it in here
                //Pass our fields across to a variable
                var alldata = from g in context.Rooms
                    select new
                    {
                        g.RoomID,
                        g.NumSingleBeds,
                        g.NumDoubleBeds,
                        g.ExtraFeatures,
                        g.TariffSinglePerson,
                        g.Tariff2People,
                        g.TariffExtraPerson
                    };
                return alldata.ToList();
            }

        }

        public void updateRooms()
        {
            using (var context = new MotelEntities())
            {
                var query = from s in context.Rooms
                    where s.RoomID == RoomID
                    select s;
                var room = query.FirstOrDefault();

                room.NumSingleBeds = NumSingleBeds;
                room.NumDoubleBeds = NumDoubleBeds;
                room.ExtraFeatures = ExtraFeatures;
                room.TariffSinglePerson = 15;
                room.Tariff2People = 25;
                room.TariffExtraPerson = 5;
                context.SaveChanges();


            }
        }

        public void addRooms()
        {
            using (var context = new MotelEntities())
            {


                var Roomz = new Room();
                Roomz.NumSingleBeds = NumSingleBeds;
                Roomz.NumDoubleBeds = NumDoubleBeds;
                Roomz.ExtraFeatures = ExtraFeatures;
                Roomz.TariffSinglePerson = TariffSinglePerson;
                Roomz.Tariff2People = Tariff2People;
                Roomz.TariffExtraPerson = TariffExtraPerson;


                //Add to entity set of context
                context.Rooms.Add(Roomz);
                context.SaveChanges();

            }
        }

        public void deleteRoom()
        {
            using (var context = new MotelEntities())
            {

                //select the row you want to delete
                var contact = (from s in context.Rooms
                    where s.RoomID == RoomID
                    select s).SingleOrDefault();
                //run remove command
                context.Rooms.Remove(contact);
                //save the changes
                context.SaveChanges();


            }
        }
    }
}
