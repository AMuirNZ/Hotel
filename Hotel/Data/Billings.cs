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

        //Billings variables introduced from form.
    {

        public int GuestID { get; set; }
        public int BillingID { get; set; }
       
       
        public decimal  BarCharge { get; set; }

        public decimal WiFiCharge { get; set; }

        public decimal TelephoneCharge { get; set; }

        public decimal RoomCost { get; set; }


        public IEnumerable viewBillings()
        {


            
     

            //Extract all fields from databases and assign to correct names
            using (var context = new MotelEntities())
            {
                
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
        //Add billing to database
        public void addBilling()
        {
            using (var context = new MotelEntities())
            {

                //assign variables to fields from database
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
