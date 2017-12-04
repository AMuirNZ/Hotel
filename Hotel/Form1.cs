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
        Rooms myRooms = new Rooms();
        BillingsClass myBillings = new BillingsClass();
        BookingsClass myBookings = new BookingsClass();
        private GuestsClass myGuests = new GuestsClass();

        public Form1()
        {
            InitializeComponent();
            DGVData.DataSource = myRooms.viewRooms();
            
        }

        private void DGVData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



            txtRoomID.Text = DGVData.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNumSingleBeds.Text = DGVData.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtNumDoubleBeds.Text = DGVData.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtExtraFeatures.Text = DGVData.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtTariffSinglePerson.Text = DGVData.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtTariff2People.Text = DGVData.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtTariffExtraPerson.Text = DGVData.Rows[e.RowIndex].Cells[6].Value.ToString();
            dgvBookings.DataSource = myBookings.viewBookings();
            myBookings.GuestID = Convert.ToInt16(txtRoomID.Text);

            //if (e.RowIndex >= 0)
            //{


            //    txtCustID.Text = CustID.ToString();

            //}
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            roomsTextFields();

            myRooms.addRooms();
            DGVData.DataSource = myRooms.viewRooms();
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {

            roomsTextFields();
            myRooms.deleteRoom();
            DGVData.DataSource = myRooms.viewRooms();

        }

        private void txtTariffSinglePerson_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            roomsTextFields();

            myRooms.updateRooms();
            DGVData.DataSource = myRooms.viewRooms();
        }



        private void roomsTextFields()
        {
            myRooms.RoomID = Convert.ToInt16(txtRoomID.Text);
            myRooms.NumSingleBeds = Convert.ToInt16(txtNumSingleBeds.Text);
            myRooms.NumDoubleBeds = Convert.ToInt16(txtNumDoubleBeds.Text);
            myRooms.ExtraFeatures = txtExtraFeatures.Text;
            myRooms.TariffSinglePerson = Convert.ToDecimal(txtTariffSinglePerson.Text);
            myRooms.Tariff2People = Convert.ToDecimal(txtTariff2People.Text);
            myRooms.TariffExtraPerson = Convert.ToDecimal(txtTariffExtraPerson.Text);
        }

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

            //DGVGuests.DataSource = myBookings.viewBookings();
        }

        private void dgvBookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBookingID.Text = dgvBookings.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtRoomIDFK.Text = dgvBookings.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtBookingFrom.Text = dgvBookings.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtBookingTo.Text = dgvBookings.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtRoomCost.Text = dgvBookings.Rows[e.RowIndex].Cells[4].Value.ToString();
            myGuests.BookingID = Convert.ToInt16(txtBookingID.Text);
            DGVGuests.DataSource = myGuests.viewGuests();
            
        }

        private void dgvBillings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBillingID.Text = dgvBillings.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtGuestIDFK.Text = dgvBillings.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtBarCharge.Text = dgvBillings.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtWiFiCharge.Text = dgvBillings.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtTelephoneCharge.Text = dgvBillings.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtRoomCharge.Text = dgvBillings.Rows[e.RowIndex].Cells[0].Value.ToString();
            dgvBillings.DataSource = myBillings.viewBillings();


            
        }

       
    }
}