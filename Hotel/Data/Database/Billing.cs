//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hotel.Data.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Billing
    {
        public int BillingID { get; set; }
        public int GuestIDFK { get; set; }
        public decimal BarCharge { get; set; }
        public decimal WiFiCharge { get; set; }
        public decimal TelephoneCharge { get; set; }
        public decimal RoomCharge { get; set; }
    
        public virtual Guest Guest { get; set; }
    }
}
