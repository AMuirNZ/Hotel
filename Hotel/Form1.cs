using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel.Data;


namespace Hotel
{
    public partial class Form1 : Form
    {
        //Establish classes
        Rooms myRooms = new Rooms();
        BillingsClass myBillings = new BillingsClass();
        BookingsClass myBookings = new BookingsClass();
        private GuestsClass myGuests = new GuestsClass();
        private Empty myEmpty = new Empty();

        public Form1()
        {
            InitializeComponent();
            //Load rooms DGV upon startup
            DGVData.DataSource = myRooms.viewRooms();

        }
        
        //Send information from DGV to form
        private void DGVData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRoomID.Text = DGVData.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtNumSingleBeds.Text = DGVData.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNumDoubleBeds.Text = DGVData.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtExtraFeatures.Text = DGVData.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtTariffSinglePerson.Text = DGVData.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtTariff2People.Text = DGVData.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtTariffExtraPerson.Text = DGVData.Rows[e.RowIndex].Cells[5].Value.ToString();
            dgvBookings.DataSource = myBookings.viewBookings();
            myBookings.GuestID = Convert.ToInt16(txtRoomID.Text);
            myBookings.numSingleBeds = Convert.ToInt16(txtNumSingleBeds.Text);
            myBookings.numDoubleBeds = Convert.ToInt16(txtNumDoubleBeds.Text);
                
            

            txtBookingID2.Text = DGVData.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        //Add Room
        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            //Work out if any fields are empty
            if (txtNumSingleBeds.Text != string.Empty && txtNumDoubleBeds.Text != string.Empty &&
                txtTariffSinglePerson.Text != string.Empty && txtTariff2People.Text != string.Empty && txtTariffExtraPerson.Text != string.Empty)
            {
                //Proceed to add room if all entered
                AddRoom();

            }
            else
            {
                //Display error message no rooms.
                MessageBox.Show("Please enter all fields");
            } 
            
        }

        private void AddRoom()
        {
            //myRooms.RoomID = Convert.ToInt16(txtRoomID.Text);
            roomsTextFields();

            myRooms.addRooms();
            DGVData.DataSource = myRooms.viewRooms();
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            if (txtRoomID.Text != string.Empty)
            {


                roomsTextFields();
                myRooms.RoomID = Convert.ToInt16(txtRoomID.Text);
                myRooms.deleteRoom();
                DGVData.DataSource = myRooms.viewRooms();
            }
            else
            {
                MessageBox.Show("Please select a record to delete");
            }

        }


        //Update room
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            roomsTextFields();
            myRooms.RoomID = Convert.ToInt16(txtRoomID.Text);

            myRooms.updateRooms();
            DGVData.DataSource = myRooms.viewRooms();
        }


        //Send all rooms values from form to other thing
        private void roomsTextFields()
        {
            

            myRooms.NumSingleBeds = Convert.ToInt16(txtNumSingleBeds.Text);
            myRooms.NumDoubleBeds = Convert.ToInt16(txtNumDoubleBeds.Text);
            myRooms.ExtraFeatures = txtExtraFeatures.Text;
            myRooms.TariffSinglePerson = Convert.ToDecimal(txtTariffSinglePerson.Text);
            myRooms.Tariff2People = Convert.ToDecimal(txtTariff2People.Text);
            myRooms.TariffExtraPerson = Convert.ToDecimal(txtTariffExtraPerson.Text);
            
        }


       //same as above thing
        private void BookingsTextFields()
        {
            
            myBookings.RoomIDFK = Convert.ToInt16(txtRoomID.Text);
            myBookings.BookingFrom = Convert.ToDateTime(txtBookingFrom.Text);
            myBookings.BookingTo = Convert.ToDateTime(txtBookingTo.Text);
            //myBookings.RoomCost = Convert.ToDecimal(txtRoomCost.Text);

        }


        //Add content from Guests DGV to form
        private void DGVGuests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtGuestID.Text = DGVGuests.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtBookingIDFK.Text = DGVGuests.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtName.Text = DGVGuests.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtAddress.Text = DGVGuests.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtNumberOfGuests.Text = DGVGuests.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtRoomBooked.Text = DGVGuests.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtCheckIn.Text = DGVGuests.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtCheckOut.Text = DGVGuests.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtBookingDate.Text = DGVGuests.Rows[e.RowIndex].Cells[8].Value.ToString();
            myBillings.GuestID = Convert.ToInt16(txtGuestID.Text);
            dgvBillings.DataSource = myBillings.viewBillings();
        }

        //Add content from Bookings DGV to form
        private void dgvBookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

            txtBookingID2.Text = dgvBookings.Rows[e.RowIndex].Cells[0].Value.ToString();


            txtRoomIDFK.Text = dgvBookings.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtBookingFrom.Text = dgvBookings.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtBookingTo.Text = dgvBookings.Rows[e.RowIndex].Cells[3].Value.ToString();

            txtRoomCost.Text = dgvBookings.Rows[e.RowIndex].Cells[4].Value.ToString();


            Date();
            myGuests.BookingID = Convert.ToInt16(txtBookingID2.Text);
            DGVGuests.DataSource = myGuests.viewGuests();

        }
        //Date calculator
        private void Date()
        {
            DateTime BookingFrom = Convert.ToDateTime(txtBookingFrom.Text);
            DateTime BookingTo = Convert.ToDateTime(txtBookingTo.Text);

            //Calculate how many days between booking from and booking to.
            lblDays.Text = (BookingTo - BookingFrom).TotalDays.ToString();

        }


        //add content from billings dgv to form
        private void dgvBillings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBillingID.Text = dgvBillings.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtGuestIDFK.Text = dgvBillings.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtBarCharge.Text = dgvBillings.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtWiFiCharge.Text = dgvBillings.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtTelephoneCharge.Text = dgvBillings.Rows[e.RowIndex].Cells[4].Value.ToString();

            lblTotalCost.Text = dgvBillings.Rows[e.RowIndex].Cells[5].Value.ToString();

        }

        //Add booking button
        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            
            
            BookingsTextFields(); //Important for sending to 
            myBookings.addBooking();
            dgvBookings.DataSource = myBookings.viewBookings();
        }

        private void btnDeleteBooking_Click(object sender, EventArgs e)
        {
            myBookings.BookingID = Convert.ToInt16(txtBookingID2.Text);
            BookingsTextFields();
            myBookings.deleteBooking();
            dgvBookings.DataSource = myBookings.viewBookings();
        }

        private void btnAddGuest_Click(object sender, EventArgs e)
        {

            bool Empty;
           

            Empty = myEmpty.Guests(txtName.Text, txtAddress.Text, txtNumberOfGuests.Text, txtRoomBooked.Text);

            if (Empty == true)
            {
                addGuest();
            }
            else
            {
                MessageBox.Show("Please enter all fields");
            }
        }

        private void addGuest()
        {
            //myGuests.GuestID = Convert.ToInt16(txtGuestID.Text);
            GuestsTextFields();
            myGuests.addGuest();
            DGVGuests.DataSource = myGuests.viewGuests();
        }


        private void GuestsTextFields()
        {
            int BookingID = Convert.ToInt16(txtBookingID2.Text);

            myGuests.BookingIDFK = BookingID;
            myGuests.Name = txtName.Text;
            myGuests.Address = txtAddress.Text;
            myGuests.NumberOfGuests = Convert.ToInt16(txtNumberOfGuests.Text);
            myGuests.RoomBooked = Convert.ToInt16(txtRoomID.Text);
            myGuests.CheckIn = Convert.ToDateTime(txtCheckIn.Text);
            myGuests.CheckOut = Convert.ToDateTime(txtCheckOut.Text);
            myGuests.BookingDate = DateTime.Now;



        }

        private void BillingsTextFields()
        {
            decimal Tarriff, BarCharge, TelephoneCharge, WiFiCharge, RoomCost, TarriffSinglePerson, Tarriff2People, TariffExtraPerson, RoomCost2, Days;

            int NumberOfGuests, GuestIDFK; //BillingID, 

            TarriffSinglePerson = Convert.ToDecimal(txtTariffSinglePerson.Text);
            Tarriff2People = Convert.ToDecimal(txtTariff2People.Text);
            TariffExtraPerson = Convert.ToDecimal(txtTariffExtraPerson.Text);
            RoomCost2 = Convert.ToDecimal(txtRoomCost.Text);
            Days = Convert.ToDecimal(lblDays.Text);

            
                
            NumberOfGuests = Convert.ToInt16(txtNumberOfGuests.Text);

            if (NumberOfGuests  == 1)
            {
                Tarriff = TarriffSinglePerson;
            }
            else if (NumberOfGuests == 2)
            {
                Tarriff = Tarriff2People;
            }
            else
            {
                Tarriff = Tarriff2People + (TariffExtraPerson * (NumberOfGuests - 2));
            }


             

            //BillingID = Convert.ToInt16(txtBillingID.Text);
            GuestIDFK = Convert.ToInt16(txtGuestID.Text);
            BarCharge = Convert.ToDecimal(txtBarCharge.Text);
            WiFiCharge = Convert.ToDecimal(txtWiFiCharge.Text);
            TelephoneCharge = Convert.ToDecimal(txtTelephoneCharge.Text);
            RoomCost = (RoomCost2 * Days) + BarCharge + WiFiCharge + Tarriff + TelephoneCharge;

           
            myBillings.GuestID = GuestIDFK;
            myBillings.BarCharge = BarCharge;
            myBillings.WiFiCharge = WiFiCharge;
            myBillings.TelephoneCharge = TelephoneCharge;
            myBillings.RoomCost = RoomCost;

            lblTotalCost.Text = RoomCost.ToString();

        }

        //Button for adding billing
        private void btnAddBilling_Click(object sender, EventArgs e)
        {
            BillingsTextFields();
            myBillings.addBilling();
            dgvBillings.DataSource = myBillings.viewBillings();
        }
        
        //Button for deleting guests
        private void btnDeleteGuest_Click(object sender, EventArgs e)
        {
            GuestsTextFields();
            myGuests.deleteGuest();
            DGVGuests.DataSource = myGuests.viewGuests();
        }

        //Button for updating bookings
        private void btnUpdateBookings_Click(object sender, EventArgs e)
        {
            BookingsTextFields();
            myBookings.BookingID = Convert.ToInt16(txtBookingID2.Text);

            myBookings.updateBooking();
            dgvBookings.DataSource = myBookings.viewBookings();
        }

        //Button for updating guests 
        private void btnUpdateGuest_Click(object sender, EventArgs e)
        {
            GuestsTextFields();
            myGuests.GuestID = Convert.ToInt16(txtGuestID.Text);

            myGuests.updateGuest();
            DGVGuests.DataSource = myGuests.viewGuests();
        }
    }
}

