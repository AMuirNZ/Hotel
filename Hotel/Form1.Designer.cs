namespace Hotel
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBillingsID = new System.Windows.Forms.Label();
            this.txtGuestID = new System.Windows.Forms.TextBox();
            this.txtBookingIDFK = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBarCharge = new System.Windows.Forms.TextBox();
            this.txtWiFiCharge = new System.Windows.Forms.TextBox();
            this.txtGuestIDFK = new System.Windows.Forms.TextBox();
            this.txtTelephoneCharge = new System.Windows.Forms.TextBox();
            this.txtBillingID = new System.Windows.Forms.TextBox();
            this.dgvBillings = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDeleteGuest = new System.Windows.Forms.Button();
            this.btnAddGuest = new System.Windows.Forms.Button();
            this.txtBookingDate = new System.Windows.Forms.DateTimePicker();
            this.txtCheckOut = new System.Windows.Forms.DateTimePicker();
            this.txtCheckIn = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtNumberOfGuests = new System.Windows.Forms.TextBox();
            this.txtRoomBooked = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.DGVGuests = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.txtBookingTo = new System.Windows.Forms.DateTimePicker();
            this.btnDeleteBooking = new System.Windows.Forms.Button();
            this.btnAddBooking = new System.Windows.Forms.Button();
            this.txtBookingFrom = new System.Windows.Forms.DateTimePicker();
            this.txtRoomIDFK = new System.Windows.Forms.TextBox();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.dgvBookings = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVData = new System.Windows.Forms.DataGridView();
            this.txtNumSingleBeds = new System.Windows.Forms.TextBox();
            this.txtNumDoubleBeds = new System.Windows.Forms.TextBox();
            this.txtExtraFeatures = new System.Windows.Forms.TextBox();
            this.txtTariffSinglePerson = new System.Windows.Forms.TextBox();
            this.txtTariffExtraPerson = new System.Windows.Forms.TextBox();
            this.txtTariff2People = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDeleteRoom = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btnAddBilling = new System.Windows.Forms.Button();
            this.txtRoomCost = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtBookingID2 = new System.Windows.Forms.Label();
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.btnUpdateBookings = new System.Windows.Forms.Button();
            this.btnUpdateGuest = new System.Windows.Forms.Button();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillings)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVGuests)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVData)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBillingsID
            // 
            this.txtBillingsID.AutoSize = true;
            this.txtBillingsID.Location = new System.Drawing.Point(600, 233);
            this.txtBillingsID.Name = "txtBillingsID";
            this.txtBillingsID.Size = new System.Drawing.Size(57, 13);
            this.txtBillingsID.TabIndex = 14;
            this.txtBillingsID.Text = "BookingID";
            this.txtBillingsID.Visible = false;
            // 
            // txtGuestID
            // 
            this.txtGuestID.Location = new System.Drawing.Point(578, 315);
            this.txtGuestID.Name = "txtGuestID";
            this.txtGuestID.Size = new System.Drawing.Size(100, 20);
            this.txtGuestID.TabIndex = 1;
            this.txtGuestID.Visible = false;
            // 
            // txtBookingIDFK
            // 
            this.txtBookingIDFK.Location = new System.Drawing.Point(578, 279);
            this.txtBookingIDFK.Name = "txtBookingIDFK";
            this.txtBookingIDFK.Size = new System.Drawing.Size(100, 20);
            this.txtBookingIDFK.TabIndex = 10;
            this.txtBookingIDFK.Visible = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lblTotalCost);
            this.tabPage4.Controls.Add(this.label20);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.txtBarCharge);
            this.tabPage4.Controls.Add(this.txtWiFiCharge);
            this.tabPage4.Controls.Add(this.txtGuestIDFK);
            this.tabPage4.Controls.Add(this.txtTelephoneCharge);
            this.tabPage4.Controls.Add(this.txtBillingID);
            this.tabPage4.Controls.Add(this.dgvBillings);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(535, 351);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Billings";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(164, 255);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "Telephone Charge";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(329, 255);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Bar Charge";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "WiFi Charge";
            // 
            // txtBarCharge
            // 
            this.txtBarCharge.Location = new System.Drawing.Point(301, 273);
            this.txtBarCharge.Name = "txtBarCharge";
            this.txtBarCharge.Size = new System.Drawing.Size(100, 20);
            this.txtBarCharge.TabIndex = 6;
            // 
            // txtWiFiCharge
            // 
            this.txtWiFiCharge.Location = new System.Drawing.Point(34, 271);
            this.txtWiFiCharge.Name = "txtWiFiCharge";
            this.txtWiFiCharge.Size = new System.Drawing.Size(100, 20);
            this.txtWiFiCharge.TabIndex = 5;
            // 
            // txtGuestIDFK
            // 
            this.txtGuestIDFK.Location = new System.Drawing.Point(159, 223);
            this.txtGuestIDFK.Name = "txtGuestIDFK";
            this.txtGuestIDFK.Size = new System.Drawing.Size(100, 20);
            this.txtGuestIDFK.TabIndex = 13;
            this.txtGuestIDFK.Visible = false;
            // 
            // txtTelephoneCharge
            // 
            this.txtTelephoneCharge.Location = new System.Drawing.Point(159, 271);
            this.txtTelephoneCharge.Name = "txtTelephoneCharge";
            this.txtTelephoneCharge.Size = new System.Drawing.Size(100, 20);
            this.txtTelephoneCharge.TabIndex = 4;
            // 
            // txtBillingID
            // 
            this.txtBillingID.Location = new System.Drawing.Point(34, 223);
            this.txtBillingID.Name = "txtBillingID";
            this.txtBillingID.Size = new System.Drawing.Size(100, 20);
            this.txtBillingID.TabIndex = 1;
            this.txtBillingID.Visible = false;
            // 
            // dgvBillings
            // 
            this.dgvBillings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillings.Location = new System.Drawing.Point(6, 15);
            this.dgvBillings.Name = "dgvBillings";
            this.dgvBillings.Size = new System.Drawing.Size(506, 187);
            this.dgvBillings.TabIndex = 0;
            this.dgvBillings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBillings_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnUpdateGuest);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.btnDeleteGuest);
            this.tabPage3.Controls.Add(this.btnAddGuest);
            this.tabPage3.Controls.Add(this.txtBookingDate);
            this.tabPage3.Controls.Add(this.txtCheckOut);
            this.tabPage3.Controls.Add(this.txtCheckIn);
            this.tabPage3.Controls.Add(this.txtAddress);
            this.tabPage3.Controls.Add(this.txtNumberOfGuests);
            this.tabPage3.Controls.Add(this.txtRoomBooked);
            this.tabPage3.Controls.Add(this.txtName);
            this.tabPage3.Controls.Add(this.DGVGuests);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(535, 351);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Guests";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(328, 258);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 13);
            this.label18.TabIndex = 20;
            this.label18.Text = "Check Out";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(336, 306);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 13);
            this.label17.TabIndex = 19;
            this.label17.Text = "Booking Date";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(57, 258);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "Check In";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(405, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Room Booked";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(264, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Number of Guests";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(142, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Name";
            // 
            // btnDeleteGuest
            // 
            this.btnDeleteGuest.Location = new System.Drawing.Point(112, 322);
            this.btnDeleteGuest.Name = "btnDeleteGuest";
            this.btnDeleteGuest.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteGuest.TabIndex = 13;
            this.btnDeleteGuest.Text = "Delete";
            this.btnDeleteGuest.UseVisualStyleBackColor = true;
            this.btnDeleteGuest.Click += new System.EventHandler(this.btnDeleteGuest_Click);
            // 
            // btnAddGuest
            // 
            this.btnAddGuest.Location = new System.Drawing.Point(18, 322);
            this.btnAddGuest.Name = "btnAddGuest";
            this.btnAddGuest.Size = new System.Drawing.Size(75, 23);
            this.btnAddGuest.TabIndex = 12;
            this.btnAddGuest.Text = "Add";
            this.btnAddGuest.UseVisualStyleBackColor = true;
            this.btnAddGuest.Click += new System.EventHandler(this.btnAddGuest_Click);
            // 
            // txtBookingDate
            // 
            this.txtBookingDate.Location = new System.Drawing.Point(285, 322);
            this.txtBookingDate.Name = "txtBookingDate";
            this.txtBookingDate.Size = new System.Drawing.Size(200, 20);
            this.txtBookingDate.TabIndex = 11;
            // 
            // txtCheckOut
            // 
            this.txtCheckOut.Location = new System.Drawing.Point(285, 274);
            this.txtCheckOut.Name = "txtCheckOut";
            this.txtCheckOut.Size = new System.Drawing.Size(200, 20);
            this.txtCheckOut.TabIndex = 10;
            // 
            // txtCheckIn
            // 
            this.txtCheckIn.Location = new System.Drawing.Point(32, 274);
            this.txtCheckIn.Name = "txtCheckIn";
            this.txtCheckIn.Size = new System.Drawing.Size(200, 20);
            this.txtCheckIn.TabIndex = 9;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(132, 235);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 5;
            // 
            // txtNumberOfGuests
            // 
            this.txtNumberOfGuests.Location = new System.Drawing.Point(256, 235);
            this.txtNumberOfGuests.Name = "txtNumberOfGuests";
            this.txtNumberOfGuests.Size = new System.Drawing.Size(100, 20);
            this.txtNumberOfGuests.TabIndex = 4;
            // 
            // txtRoomBooked
            // 
            this.txtRoomBooked.Location = new System.Drawing.Point(385, 235);
            this.txtRoomBooked.Name = "txtRoomBooked";
            this.txtRoomBooked.Size = new System.Drawing.Size(100, 20);
            this.txtRoomBooked.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(7, 235);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 2;
            // 
            // DGVGuests
            // 
            this.DGVGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVGuests.Location = new System.Drawing.Point(3, 6);
            this.DGVGuests.Name = "DGVGuests";
            this.DGVGuests.Size = new System.Drawing.Size(495, 196);
            this.DGVGuests.TabIndex = 0;
            this.DGVGuests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVGuests_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnUpdateBookings);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.lblDays);
            this.tabPage2.Controls.Add(this.txtBookingTo);
            this.tabPage2.Controls.Add(this.btnDeleteBooking);
            this.tabPage2.Controls.Add(this.btnAddBooking);
            this.tabPage2.Controls.Add(this.txtBookingFrom);
            this.tabPage2.Controls.Add(this.txtRoomIDFK);
            this.tabPage2.Controls.Add(this.txtBookingID);
            this.tabPage2.Controls.Add(this.dgvBookings);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(535, 351);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bookings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(55, 238);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Booking From";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(268, 242);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Booking To";
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(446, 189);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(35, 13);
            this.lblDays.TabIndex = 18;
            this.lblDays.Text = "label1";
            // 
            // txtBookingTo
            // 
            this.txtBookingTo.Location = new System.Drawing.Point(227, 264);
            this.txtBookingTo.Name = "txtBookingTo";
            this.txtBookingTo.Size = new System.Drawing.Size(200, 20);
            this.txtBookingTo.TabIndex = 16;
            this.txtBookingTo.Value = new System.DateTime(2017, 12, 13, 9, 45, 7, 0);
            // 
            // btnDeleteBooking
            // 
            this.btnDeleteBooking.Location = new System.Drawing.Point(206, 297);
            this.btnDeleteBooking.Name = "btnDeleteBooking";
            this.btnDeleteBooking.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteBooking.TabIndex = 15;
            this.btnDeleteBooking.Text = "Delete Room";
            this.btnDeleteBooking.UseVisualStyleBackColor = true;
            this.btnDeleteBooking.Click += new System.EventHandler(this.btnDeleteBooking_Click);
            // 
            // btnAddBooking
            // 
            this.btnAddBooking.Location = new System.Drawing.Point(21, 297);
            this.btnAddBooking.Name = "btnAddBooking";
            this.btnAddBooking.Size = new System.Drawing.Size(75, 23);
            this.btnAddBooking.TabIndex = 15;
            this.btnAddBooking.Text = "Add";
            this.btnAddBooking.UseVisualStyleBackColor = true;
            this.btnAddBooking.Click += new System.EventHandler(this.btnAddBooking_Click);
            // 
            // txtBookingFrom
            // 
            this.txtBookingFrom.Location = new System.Drawing.Point(21, 264);
            this.txtBookingFrom.Name = "txtBookingFrom";
            this.txtBookingFrom.Size = new System.Drawing.Size(200, 20);
            this.txtBookingFrom.TabIndex = 8;
            // 
            // txtRoomIDFK
            // 
            this.txtRoomIDFK.Location = new System.Drawing.Point(250, 204);
            this.txtRoomIDFK.Name = "txtRoomIDFK";
            this.txtRoomIDFK.Size = new System.Drawing.Size(100, 20);
            this.txtRoomIDFK.TabIndex = 4;
            this.txtRoomIDFK.Visible = false;
            // 
            // txtBookingID
            // 
            this.txtBookingID.Location = new System.Drawing.Point(121, 204);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Size = new System.Drawing.Size(100, 20);
            this.txtBookingID.TabIndex = 3;
            this.txtBookingID.Visible = false;
            // 
            // dgvBookings
            // 
            this.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookings.Location = new System.Drawing.Point(6, 6);
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.Size = new System.Drawing.Size(399, 180);
            this.dgvBookings.TabIndex = 0;
            this.dgvBookings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookings_CellContentClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.DGVData);
            this.tabPage1.Controls.Add(this.txtNumSingleBeds);
            this.tabPage1.Controls.Add(this.txtNumDoubleBeds);
            this.tabPage1.Controls.Add(this.txtExtraFeatures);
            this.tabPage1.Controls.Add(this.txtTariffSinglePerson);
            this.tabPage1.Controls.Add(this.txtTariffExtraPerson);
            this.tabPage1.Controls.Add(this.txtTariff2People);
            this.tabPage1.Controls.Add(this.btnUpdate);
            this.tabPage1.Controls.Add(this.btnDeleteRoom);
            this.tabPage1.Controls.Add(this.btnAddRoom);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(535, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rooms";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Double Beds";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Extra Features";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tariff Two People";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tariff Extra Person";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tariff Single Person";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Single Beds";
            // 
            // DGVData
            // 
            this.DGVData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVData.Location = new System.Drawing.Point(3, 3);
            this.DGVData.Name = "DGVData";
            this.DGVData.Size = new System.Drawing.Size(438, 188);
            this.DGVData.TabIndex = 0;
            this.DGVData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVData_CellContentClick);
            this.DGVData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVData_CellContentClick);
            // 
            // txtNumSingleBeds
            // 
            this.txtNumSingleBeds.Location = new System.Drawing.Point(6, 211);
            this.txtNumSingleBeds.Name = "txtNumSingleBeds";
            this.txtNumSingleBeds.Size = new System.Drawing.Size(100, 20);
            this.txtNumSingleBeds.TabIndex = 2;
            // 
            // txtNumDoubleBeds
            // 
            this.txtNumDoubleBeds.Location = new System.Drawing.Point(134, 211);
            this.txtNumDoubleBeds.Name = "txtNumDoubleBeds";
            this.txtNumDoubleBeds.Size = new System.Drawing.Size(100, 20);
            this.txtNumDoubleBeds.TabIndex = 3;
            // 
            // txtExtraFeatures
            // 
            this.txtExtraFeatures.Location = new System.Drawing.Point(266, 211);
            this.txtExtraFeatures.Name = "txtExtraFeatures";
            this.txtExtraFeatures.Size = new System.Drawing.Size(100, 20);
            this.txtExtraFeatures.TabIndex = 4;
            // 
            // txtTariffSinglePerson
            // 
            this.txtTariffSinglePerson.Location = new System.Drawing.Point(6, 252);
            this.txtTariffSinglePerson.Name = "txtTariffSinglePerson";
            this.txtTariffSinglePerson.Size = new System.Drawing.Size(100, 20);
            this.txtTariffSinglePerson.TabIndex = 5;
            // 
            // txtTariffExtraPerson
            // 
            this.txtTariffExtraPerson.Location = new System.Drawing.Point(266, 252);
            this.txtTariffExtraPerson.Name = "txtTariffExtraPerson";
            this.txtTariffExtraPerson.Size = new System.Drawing.Size(100, 20);
            this.txtTariffExtraPerson.TabIndex = 7;
            // 
            // txtTariff2People
            // 
            this.txtTariff2People.Location = new System.Drawing.Point(134, 252);
            this.txtTariff2People.Name = "txtTariff2People";
            this.txtTariff2People.Size = new System.Drawing.Size(100, 20);
            this.txtTariff2People.TabIndex = 6;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(201, 297);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.Location = new System.Drawing.Point(106, 297);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteRoom.TabIndex = 9;
            this.btnDeleteRoom.Text = "Delete Room";
            this.btnDeleteRoom.UseVisualStyleBackColor = true;
            this.btnDeleteRoom.Click += new System.EventHandler(this.btnDeleteRoom_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(6, 297);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(75, 23);
            this.btnAddRoom.TabIndex = 8;
            this.btnAddRoom.Text = "Add";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(543, 377);
            this.tabControl1.TabIndex = 12;
            // 
            // btnAddBilling
            // 
            this.btnAddBilling.Location = new System.Drawing.Point(74, 418);
            this.btnAddBilling.Name = "btnAddBilling";
            this.btnAddBilling.Size = new System.Drawing.Size(75, 23);
            this.btnAddBilling.TabIndex = 15;
            this.btnAddBilling.Text = "Add Billing";
            this.btnAddBilling.UseVisualStyleBackColor = true;
            this.btnAddBilling.Click += new System.EventHandler(this.btnAddBilling_Click);
            // 
            // txtRoomCost
            // 
            this.txtRoomCost.AutoSize = true;
            this.txtRoomCost.Location = new System.Drawing.Point(617, 178);
            this.txtRoomCost.Name = "txtRoomCost";
            this.txtRoomCost.Size = new System.Drawing.Size(56, 13);
            this.txtRoomCost.TabIndex = 17;
            this.txtRoomCost.Text = "RoomCost";
            this.txtRoomCost.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(585, 137);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 13);
            this.label19.TabIndex = 18;
            this.label19.Text = "label19";
            this.label19.Visible = false;
            // 
            // txtBookingID2
            // 
            this.txtBookingID2.AutoSize = true;
            this.txtBookingID2.Location = new System.Drawing.Point(603, 195);
            this.txtBookingID2.Name = "txtBookingID2";
            this.txtBookingID2.Size = new System.Drawing.Size(57, 13);
            this.txtBookingID2.TabIndex = 19;
            this.txtBookingID2.Text = "BookingID";
            this.txtBookingID2.Visible = false;
            // 
            // txtRoomID
            // 
            this.txtRoomID.Location = new System.Drawing.Point(578, 58);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(100, 20);
            this.txtRoomID.TabIndex = 20;
            this.txtRoomID.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(301, 332);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 13);
            this.label20.TabIndex = 19;
            this.label20.Text = "Total Cost";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(360, 332);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(0, 13);
            this.lblTotalCost.TabIndex = 20;
            // 
            // btnUpdateBookings
            // 
            this.btnUpdateBookings.Location = new System.Drawing.Point(121, 297);
            this.btnUpdateBookings.Name = "btnUpdateBookings";
            this.btnUpdateBookings.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateBookings.TabIndex = 21;
            this.btnUpdateBookings.Text = "Update";
            this.btnUpdateBookings.UseVisualStyleBackColor = true;
            this.btnUpdateBookings.Click += new System.EventHandler(this.btnUpdateBookings_Click);
            // 
            // btnUpdateGuest
            // 
            this.btnUpdateGuest.Location = new System.Drawing.Point(194, 322);
            this.btnUpdateGuest.Name = "btnUpdateGuest";
            this.btnUpdateGuest.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateGuest.TabIndex = 21;
            this.btnUpdateGuest.Text = "Update";
            this.btnUpdateGuest.UseVisualStyleBackColor = true;
            this.btnUpdateGuest.Click += new System.EventHandler(this.btnUpdateGuest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 453);
            this.Controls.Add(this.txtRoomID);
            this.Controls.Add(this.txtBookingID2);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btnAddBilling);
            this.Controls.Add(this.txtRoomCost);
            this.Controls.Add(this.txtBookingIDFK);
            this.Controls.Add(this.txtBillingsID);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtGuestID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillings)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVGuests)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVData)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtBillingsID;
        private System.Windows.Forms.TextBox txtGuestID;
        private System.Windows.Forms.TextBox txtBookingIDFK;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtBarCharge;
        private System.Windows.Forms.TextBox txtWiFiCharge;
        private System.Windows.Forms.TextBox txtGuestIDFK;
        private System.Windows.Forms.TextBox txtTelephoneCharge;
        private System.Windows.Forms.TextBox txtBillingID;
        private System.Windows.Forms.DataGridView dgvBillings;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnAddGuest;
        private System.Windows.Forms.DateTimePicker txtBookingDate;
        private System.Windows.Forms.DateTimePicker txtCheckOut;
        private System.Windows.Forms.DateTimePicker txtCheckIn;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtNumberOfGuests;
        private System.Windows.Forms.TextBox txtRoomBooked;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView DGVGuests;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.DateTimePicker txtBookingTo;
        private System.Windows.Forms.Button btnDeleteBooking;
        private System.Windows.Forms.Button btnAddBooking;
        private System.Windows.Forms.DateTimePicker txtBookingFrom;
        private System.Windows.Forms.TextBox txtRoomIDFK;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.DataGridView dgvBookings;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView DGVData;
        private System.Windows.Forms.TextBox txtNumSingleBeds;
        private System.Windows.Forms.TextBox txtNumDoubleBeds;
        private System.Windows.Forms.TextBox txtExtraFeatures;
        private System.Windows.Forms.TextBox txtTariffSinglePerson;
        private System.Windows.Forms.TextBox txtTariffExtraPerson;
        private System.Windows.Forms.TextBox txtTariff2People;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDeleteRoom;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnAddBilling;
        private System.Windows.Forms.Label txtRoomCost;
        private System.Windows.Forms.Button btnDeleteGuest;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label txtBookingID2;
        private System.Windows.Forms.TextBox txtRoomID;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnUpdateBookings;
        private System.Windows.Forms.Button btnUpdateGuest;
    }
}

