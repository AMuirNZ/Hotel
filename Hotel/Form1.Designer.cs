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
            this.DGVData = new System.Windows.Forms.DataGridView();
            this.txtNumSingleBeds = new System.Windows.Forms.TextBox();
            this.txtNumDoubleBeds = new System.Windows.Forms.TextBox();
            this.txtExtraFeatures = new System.Windows.Forms.TextBox();
            this.txtTariffSinglePerson = new System.Windows.Forms.TextBox();
            this.txtTariff2People = new System.Windows.Forms.TextBox();
            this.txtTariffExtraPerson = new System.Windows.Forms.TextBox();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnDeleteRoom = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtRoomID = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtBookingTo = new System.Windows.Forms.DateTimePicker();
            this.btnDeleteBooking = new System.Windows.Forms.Button();
            this.btnAddBooking = new System.Windows.Forms.Button();
            this.txtBookingFrom = new System.Windows.Forms.DateTimePicker();
            this.txtRoomIDFK = new System.Windows.Forms.TextBox();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.dgvBookings = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtCheckIn = new System.Windows.Forms.TextBox();
            this.txtCheckOut = new System.Windows.Forms.TextBox();
            this.txtBookingDate = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtNumberOfGuests = new System.Windows.Forms.TextBox();
            this.txtRoomBooked = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.DGVGuests = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtBarCharge = new System.Windows.Forms.TextBox();
            this.txtWiFiCharge = new System.Windows.Forms.TextBox();
            this.txtGuestIDFK = new System.Windows.Forms.TextBox();
            this.txtTelephoneCharge = new System.Windows.Forms.TextBox();
            this.txtRoomCharge = new System.Windows.Forms.TextBox();
            this.txtBillingID = new System.Windows.Forms.TextBox();
            this.dgvBillings = new System.Windows.Forms.DataGridView();
            this.txtBillingsID = new System.Windows.Forms.Label();
            this.txtGuestID = new System.Windows.Forms.TextBox();
            this.txtBookingIDFK = new System.Windows.Forms.TextBox();
            this.txtRoomCost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVData)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVGuests)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillings)).BeginInit();
            this.SuspendLayout();
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
            this.txtNumSingleBeds.Location = new System.Drawing.Point(6, 197);
            this.txtNumSingleBeds.Name = "txtNumSingleBeds";
            this.txtNumSingleBeds.Size = new System.Drawing.Size(100, 20);
            this.txtNumSingleBeds.TabIndex = 2;
            // 
            // txtNumDoubleBeds
            // 
            this.txtNumDoubleBeds.Location = new System.Drawing.Point(134, 197);
            this.txtNumDoubleBeds.Name = "txtNumDoubleBeds";
            this.txtNumDoubleBeds.Size = new System.Drawing.Size(100, 20);
            this.txtNumDoubleBeds.TabIndex = 3;
            // 
            // txtExtraFeatures
            // 
            this.txtExtraFeatures.Location = new System.Drawing.Point(266, 197);
            this.txtExtraFeatures.Name = "txtExtraFeatures";
            this.txtExtraFeatures.Size = new System.Drawing.Size(100, 20);
            this.txtExtraFeatures.TabIndex = 4;
            // 
            // txtTariffSinglePerson
            // 
            this.txtTariffSinglePerson.Location = new System.Drawing.Point(6, 242);
            this.txtTariffSinglePerson.Name = "txtTariffSinglePerson";
            this.txtTariffSinglePerson.Size = new System.Drawing.Size(100, 20);
            this.txtTariffSinglePerson.TabIndex = 5;
            this.txtTariffSinglePerson.TextChanged += new System.EventHandler(this.txtTariffSinglePerson_TextChanged);
            // 
            // txtTariff2People
            // 
            this.txtTariff2People.Location = new System.Drawing.Point(134, 242);
            this.txtTariff2People.Name = "txtTariff2People";
            this.txtTariff2People.Size = new System.Drawing.Size(100, 20);
            this.txtTariff2People.TabIndex = 6;
            // 
            // txtTariffExtraPerson
            // 
            this.txtTariffExtraPerson.Location = new System.Drawing.Point(266, 242);
            this.txtTariffExtraPerson.Name = "txtTariffExtraPerson";
            this.txtTariffExtraPerson.Size = new System.Drawing.Size(100, 20);
            this.txtTariffExtraPerson.TabIndex = 7;
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
            // txtRoomID
            // 
            this.txtRoomID.AutoSize = true;
            this.txtRoomID.Location = new System.Drawing.Point(581, 96);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(46, 13);
            this.txtRoomID.TabIndex = 11;
            this.txtRoomID.Text = "RoomID";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(17, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(543, 352);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DGVData);
            this.tabPage1.Controls.Add(this.txtNumSingleBeds);
            this.tabPage1.Controls.Add(this.txtNumDoubleBeds);
            this.tabPage1.Controls.Add(this.txtExtraFeatures);
            this.tabPage1.Controls.Add(this.txtTariffSinglePerson);
            this.tabPage1.Controls.Add(this.btnUpdate);
            this.tabPage1.Controls.Add(this.txtTariffExtraPerson);
            this.tabPage1.Controls.Add(this.btnDeleteRoom);
            this.tabPage1.Controls.Add(this.txtTariff2People);
            this.tabPage1.Controls.Add(this.btnAddRoom);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(535, 326);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rooms";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtRoomCost);
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
            this.tabPage2.Size = new System.Drawing.Size(535, 326);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bookings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtBookingTo
            // 
            this.txtBookingTo.Location = new System.Drawing.Point(227, 264);
            this.txtBookingTo.Name = "txtBookingTo";
            this.txtBookingTo.Size = new System.Drawing.Size(200, 20);
            this.txtBookingTo.TabIndex = 16;
            // 
            // btnDeleteBooking
            // 
            this.btnDeleteBooking.Location = new System.Drawing.Point(121, 297);
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
            this.txtRoomIDFK.Location = new System.Drawing.Point(251, 192);
            this.txtRoomIDFK.Name = "txtRoomIDFK";
            this.txtRoomIDFK.Size = new System.Drawing.Size(100, 20);
            this.txtRoomIDFK.TabIndex = 4;
            this.txtRoomIDFK.Visible = false;
            // 
            // txtBookingID
            // 
            this.txtBookingID.Location = new System.Drawing.Point(121, 192);
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtCheckIn);
            this.tabPage3.Controls.Add(this.txtCheckOut);
            this.tabPage3.Controls.Add(this.txtBookingDate);
            this.tabPage3.Controls.Add(this.txtAddress);
            this.tabPage3.Controls.Add(this.txtNumberOfGuests);
            this.tabPage3.Controls.Add(this.txtRoomBooked);
            this.tabPage3.Controls.Add(this.txtName);
            this.tabPage3.Controls.Add(this.DGVGuests);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(535, 326);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Guests";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtCheckIn
            // 
            this.txtCheckIn.Location = new System.Drawing.Point(64, 248);
            this.txtCheckIn.Name = "txtCheckIn";
            this.txtCheckIn.Size = new System.Drawing.Size(100, 20);
            this.txtCheckIn.TabIndex = 9;
            // 
            // txtCheckOut
            // 
            this.txtCheckOut.Location = new System.Drawing.Point(202, 248);
            this.txtCheckOut.Name = "txtCheckOut";
            this.txtCheckOut.Size = new System.Drawing.Size(100, 20);
            this.txtCheckOut.TabIndex = 8;
            // 
            // txtBookingDate
            // 
            this.txtBookingDate.Location = new System.Drawing.Point(336, 248);
            this.txtBookingDate.Name = "txtBookingDate";
            this.txtBookingDate.Size = new System.Drawing.Size(100, 20);
            this.txtBookingDate.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(132, 208);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 5;
            // 
            // txtNumberOfGuests
            // 
            this.txtNumberOfGuests.Location = new System.Drawing.Point(256, 209);
            this.txtNumberOfGuests.Name = "txtNumberOfGuests";
            this.txtNumberOfGuests.Size = new System.Drawing.Size(100, 20);
            this.txtNumberOfGuests.TabIndex = 4;
            // 
            // txtRoomBooked
            // 
            this.txtRoomBooked.Location = new System.Drawing.Point(385, 209);
            this.txtRoomBooked.Name = "txtRoomBooked";
            this.txtRoomBooked.Size = new System.Drawing.Size(100, 20);
            this.txtRoomBooked.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 208);
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
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtBarCharge);
            this.tabPage4.Controls.Add(this.txtWiFiCharge);
            this.tabPage4.Controls.Add(this.txtGuestIDFK);
            this.tabPage4.Controls.Add(this.txtTelephoneCharge);
            this.tabPage4.Controls.Add(this.txtRoomCharge);
            this.tabPage4.Controls.Add(this.txtBillingID);
            this.tabPage4.Controls.Add(this.dgvBillings);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(535, 326);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Billings";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtBarCharge
            // 
            this.txtBarCharge.Location = new System.Drawing.Point(285, 223);
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
            // txtRoomCharge
            // 
            this.txtRoomCharge.Location = new System.Drawing.Point(285, 271);
            this.txtRoomCharge.Name = "txtRoomCharge";
            this.txtRoomCharge.Size = new System.Drawing.Size(100, 20);
            this.txtRoomCharge.TabIndex = 3;
            // 
            // txtBillingID
            // 
            this.txtBillingID.Location = new System.Drawing.Point(34, 223);
            this.txtBillingID.Name = "txtBillingID";
            this.txtBillingID.Size = new System.Drawing.Size(100, 20);
            this.txtBillingID.TabIndex = 1;
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
            // 
            // txtBookingIDFK
            // 
            this.txtBookingIDFK.Location = new System.Drawing.Point(578, 279);
            this.txtBookingIDFK.Name = "txtBookingIDFK";
            this.txtBookingIDFK.Size = new System.Drawing.Size(100, 20);
            this.txtBookingIDFK.TabIndex = 10;
            // 
            // txtRoomCost
            // 
            this.txtRoomCost.AutoSize = true;
            this.txtRoomCost.Location = new System.Drawing.Point(431, 213);
            this.txtRoomCost.Name = "txtRoomCost";
            this.txtRoomCost.Size = new System.Drawing.Size(35, 13);
            this.txtRoomCost.TabIndex = 17;
            this.txtRoomCost.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 453);
            this.Controls.Add(this.txtBookingIDFK);
            this.Controls.Add(this.txtBillingsID);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtRoomID);
            this.Controls.Add(this.txtGuestID);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGVData)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVGuests)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVData;
        private System.Windows.Forms.TextBox txtNumSingleBeds;
        private System.Windows.Forms.TextBox txtNumDoubleBeds;
        private System.Windows.Forms.TextBox txtExtraFeatures;
        private System.Windows.Forms.TextBox txtTariffSinglePerson;
        private System.Windows.Forms.TextBox txtTariff2People;
        private System.Windows.Forms.TextBox txtTariffExtraPerson;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnDeleteRoom;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label txtRoomID;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtRoomIDFK;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.DataGridView dgvBookings;
        private System.Windows.Forms.TextBox txtGuestIDFK;
        private System.Windows.Forms.Label txtBillingsID;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtCheckIn;
        private System.Windows.Forms.TextBox txtCheckOut;
        private System.Windows.Forms.TextBox txtBookingDate;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtNumberOfGuests;
        private System.Windows.Forms.TextBox txtRoomBooked;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView DGVGuests;
        private System.Windows.Forms.TextBox txtGuestID;
        private System.Windows.Forms.TextBox txtBookingIDFK;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgvBillings;
        private System.Windows.Forms.TextBox txtBarCharge;
        private System.Windows.Forms.TextBox txtWiFiCharge;
        private System.Windows.Forms.TextBox txtTelephoneCharge;
        private System.Windows.Forms.TextBox txtRoomCharge;
        private System.Windows.Forms.TextBox txtBillingID;
        private System.Windows.Forms.DateTimePicker txtBookingFrom;
        private System.Windows.Forms.Button btnAddBooking;
        private System.Windows.Forms.Button btnDeleteBooking;
        private System.Windows.Forms.DateTimePicker txtBookingTo;
        private System.Windows.Forms.Label txtRoomCost;
    }
}

