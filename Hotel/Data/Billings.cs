using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Data.Database;

namespace Hotel.Data
{
    class BillingsClass


    {

        public int GuestID { get; set; }
        public int BillingID { get; set; }
        //public int GuestIDFK { get; set; }
       
        public decimal  BarCharge { get; set; }

        public decimal WiFiCharge { get; set; }

        public decimal TelephoneCharge { get; set; }

        public decimal RoomCost { get; set; }


        public IEnumerable viewBillings()
        {


            
     

            //Our standard Using statement passing all the data to context 
            using (var context = new MotelEntities())
            {
                //What ever we want our code to do we do it in here
                //Pass our fields across to a variable
                var alldata = from g in context.Billings where g.GuestIDFK == GuestID
                              select new
                    {
                        g.BillingID,
                        g.GuestIDFK,
                        g.BarCharge,
                        g.WiFiCharge,
                        g.TelephoneCharge,
                        g.RoomCharge,
                     
                    };
                return alldata.ToList();
            }

        }

        public void addBilling()
        {
            using (var context = new MotelEntities())
            {


                var BillingZ = new Billing();

                BillingZ.GuestIDFK = GuestID;
                BillingZ.BarCharge = BarCharge;
                BillingZ.WiFiCharge = WiFiCharge;
                BillingZ.TelephoneCharge = TelephoneCharge;
                BillingZ.RoomCharge = RoomCost;



                //Add to entity set of context
                context.Billings.Add(BillingZ);
                context.SaveChanges();

            }
        }

    }
}
