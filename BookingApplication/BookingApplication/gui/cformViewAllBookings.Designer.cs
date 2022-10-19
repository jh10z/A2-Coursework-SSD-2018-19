namespace BookingApplication
{
    partial class formAppointments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAppointments));
            this.dGridViewMonthlyBookings = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMonthSelected = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbStaff = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.dTPMonth = new System.Windows.Forms.DateTimePicker();
            this.btnResults = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTitleControl = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.lblSlotsAvailable = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dTPAppointments = new System.Windows.Forms.DateTimePicker();
            this.btnViewDay = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnControls = new System.Windows.Forms.Button();
            this.panelManage = new System.Windows.Forms.Panel();
            this.label65656 = new System.Windows.Forms.Label();
            this.lblSelectedStaff = new System.Windows.Forms.Label();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.lblSelectedCustomer = new System.Windows.Forms.Label();
            this.lblSelectedTime = new System.Windows.Forms.Label();
            this.lblSelectedDate = new System.Windows.Forms.Label();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnVAEBooking = new System.Windows.Forms.Button();
            this.lblSelectedPriority = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewMonthlyBookings)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelAdd.SuspendLayout();
            this.panelManage.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGridViewMonthlyBookings
            // 
            this.dGridViewMonthlyBookings.AllowUserToAddRows = false;
            this.dGridViewMonthlyBookings.AllowUserToDeleteRows = false;
            this.dGridViewMonthlyBookings.AllowUserToResizeColumns = false;
            this.dGridViewMonthlyBookings.AllowUserToResizeRows = false;
            this.dGridViewMonthlyBookings.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dGridViewMonthlyBookings.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGridViewMonthlyBookings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGridViewMonthlyBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGridViewMonthlyBookings.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGridViewMonthlyBookings.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dGridViewMonthlyBookings.Location = new System.Drawing.Point(15, 28);
            this.dGridViewMonthlyBookings.MultiSelect = false;
            this.dGridViewMonthlyBookings.Name = "dGridViewMonthlyBookings";
            this.dGridViewMonthlyBookings.ReadOnly = true;
            this.dGridViewMonthlyBookings.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dGridViewMonthlyBookings.RowHeadersVisible = false;
            this.dGridViewMonthlyBookings.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dGridViewMonthlyBookings.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGridViewMonthlyBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGridViewMonthlyBookings.Size = new System.Drawing.Size(542, 223);
            this.dGridViewMonthlyBookings.TabIndex = 16;
            this.dGridViewMonthlyBookings.TabStop = false;
            this.dGridViewMonthlyBookings.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridViewMonthlyBookings_CellClick);
            this.dGridViewMonthlyBookings.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dGridViewMonthlyBookings_CellFormatting);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Enabled = false;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(12, 60);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(826, 12);
            this.button4.TabIndex = 34;
            this.button4.TabStop = false;
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 24);
            this.label3.TabIndex = 35;
            this.label3.Text = "View Appointments";
            // 
            // lblMonthSelected
            // 
            this.lblMonthSelected.AutoSize = true;
            this.lblMonthSelected.BackColor = System.Drawing.Color.Transparent;
            this.lblMonthSelected.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblMonthSelected.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthSelected.ForeColor = System.Drawing.Color.White;
            this.lblMonthSelected.Location = new System.Drawing.Point(13, 8);
            this.lblMonthSelected.Name = "lblMonthSelected";
            this.lblMonthSelected.Size = new System.Drawing.Size(237, 17);
            this.lblMonthSelected.TabIndex = 37;
            this.lblMonthSelected.Text = "View Bookings of Month: November";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dGridViewMonthlyBookings);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblMonthSelected);
            this.panel1.Location = new System.Drawing.Point(19, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 278);
            this.panel1.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(13, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(216, 15);
            this.label8.TabIndex = 54;
            this.label8.Text = "*Single click a row to manage booking";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.cbPriority);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.cbStatus);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cbStaff);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbCustomer);
            this.panel2.Controls.Add(this.dTPMonth);
            this.panel2.Controls.Add(this.btnResults);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(158, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(436, 69);
            this.panel2.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(177, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Priority";
            // 
            // cbPriority
            // 
            this.cbPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Location = new System.Drawing.Point(216, 40);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(77, 20);
            this.cbPriority.TabIndex = 48;
            this.cbPriority.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbPriority_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(177, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Status";
            // 
            // cbStatus
            // 
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(216, 11);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(77, 20);
            this.cbStatus.TabIndex = 46;
            this.cbStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbStatus_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(12, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Staff";
            // 
            // cbStaff
            // 
            this.cbStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStaff.FormattingEnabled = true;
            this.cbStaff.Location = new System.Drawing.Point(54, 39);
            this.cbStaff.Name = "cbStaff";
            this.cbStaff.Size = new System.Drawing.Size(119, 20);
            this.cbStaff.TabIndex = 44;
            this.cbStaff.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbStaff_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Customer";
            // 
            // cbCustomer
            // 
            this.cbCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(54, 11);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(119, 20);
            this.cbCustomer.TabIndex = 42;
            this.cbCustomer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbCustomer_KeyPress);
            // 
            // dTPMonth
            // 
            this.dTPMonth.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPMonth.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dTPMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPMonth.Location = new System.Drawing.Point(300, 11);
            this.dTPMonth.Name = "dTPMonth";
            this.dTPMonth.Size = new System.Drawing.Size(119, 20);
            this.dTPMonth.TabIndex = 41;
            this.dTPMonth.Value = new System.DateTime(2018, 11, 1, 0, 0, 0, 0);
            // 
            // btnResults
            // 
            this.btnResults.BackColor = System.Drawing.Color.Lime;
            this.btnResults.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResults.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnResults.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnResults.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResults.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResults.ForeColor = System.Drawing.Color.White;
            this.btnResults.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnResults.Location = new System.Drawing.Point(300, 39);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(119, 22);
            this.btnResults.TabIndex = 41;
            this.btnResults.TabStop = false;
            this.btnResults.Text = "Filter Results";
            this.btnResults.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResults.UseVisualStyleBackColor = false;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(418, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "*";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblTitleControl);
            this.panel3.Location = new System.Drawing.Point(605, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(232, 43);
            this.panel3.TabIndex = 43;
            // 
            // lblTitleControl
            // 
            this.lblTitleControl.AutoSize = true;
            this.lblTitleControl.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleControl.ForeColor = System.Drawing.Color.White;
            this.lblTitleControl.Location = new System.Drawing.Point(1, 14);
            this.lblTitleControl.Name = "lblTitleControl";
            this.lblTitleControl.Size = new System.Drawing.Size(122, 24);
            this.lblTitleControl.TabIndex = 0;
            this.lblTitleControl.Text = "Add Section";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(19, 106);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(133, 69);
            this.panel4.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "View \r\nBookings\r\n";
            // 
            // panelAdd
            // 
            this.panelAdd.BackColor = System.Drawing.Color.Gray;
            this.panelAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAdd.Controls.Add(this.lblSlotsAvailable);
            this.panelAdd.Controls.Add(this.label4);
            this.panelAdd.Controls.Add(this.dTPAppointments);
            this.panelAdd.Controls.Add(this.btnViewDay);
            this.panelAdd.Controls.Add(this.label5);
            this.panelAdd.Location = new System.Drawing.Point(605, 181);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(232, 278);
            this.panelAdd.TabIndex = 41;
            // 
            // lblSlotsAvailable
            // 
            this.lblSlotsAvailable.AutoSize = true;
            this.lblSlotsAvailable.BackColor = System.Drawing.Color.Transparent;
            this.lblSlotsAvailable.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblSlotsAvailable.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlotsAvailable.ForeColor = System.Drawing.Color.White;
            this.lblSlotsAvailable.Location = new System.Drawing.Point(72, 254);
            this.lblSlotsAvailable.Name = "lblSlotsAvailable";
            this.lblSlotsAvailable.Size = new System.Drawing.Size(147, 15);
            this.lblSlotsAvailable.TabIndex = 41;
            this.lblSlotsAvailable.Text = "Office Spaces Available: 0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(2, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Select a specific day:";
            // 
            // dTPAppointments
            // 
            this.dTPAppointments.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPAppointments.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dTPAppointments.Location = new System.Drawing.Point(3, 25);
            this.dTPAppointments.Name = "dTPAppointments";
            this.dTPAppointments.Size = new System.Drawing.Size(223, 20);
            this.dTPAppointments.TabIndex = 39;
            this.dTPAppointments.ValueChanged += new System.EventHandler(this.dtpickAppointments_ValueChanged);
            // 
            // btnViewDay
            // 
            this.btnViewDay.BackColor = System.Drawing.Color.Lime;
            this.btnViewDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewDay.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnViewDay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnViewDay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnViewDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDay.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDay.ForeColor = System.Drawing.Color.White;
            this.btnViewDay.Location = new System.Drawing.Point(-1, 215);
            this.btnViewDay.Name = "btnViewDay";
            this.btnViewDay.Size = new System.Drawing.Size(232, 34);
            this.btnViewDay.TabIndex = 36;
            this.btnViewDay.TabStop = false;
            this.btnViewDay.Text = "Book | ";
            this.btnViewDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewDay.UseVisualStyleBackColor = false;
            this.btnViewDay.Click += new System.EventHandler(this.btnViewDay_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(3, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 143);
            this.label5.TabIndex = 38;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // btnControls
            // 
            this.btnControls.BackColor = System.Drawing.Color.Teal;
            this.btnControls.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnControls.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnControls.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnControls.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnControls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControls.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControls.ForeColor = System.Drawing.Color.White;
            this.btnControls.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnControls.Location = new System.Drawing.Point(605, 152);
            this.btnControls.Name = "btnControls";
            this.btnControls.Size = new System.Drawing.Size(232, 26);
            this.btnControls.TabIndex = 49;
            this.btnControls.TabStop = false;
            this.btnControls.Text = "Show Manage Booking Section";
            this.btnControls.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnControls.UseVisualStyleBackColor = false;
            this.btnControls.Click += new System.EventHandler(this.btnControls_Click);
            // 
            // panelManage
            // 
            this.panelManage.BackColor = System.Drawing.Color.Gray;
            this.panelManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelManage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelManage.Controls.Add(this.label65656);
            this.panelManage.Controls.Add(this.lblSelectedStaff);
            this.panelManage.Controls.Add(this.btnReceipt);
            this.panelManage.Controls.Add(this.lblSelectedCustomer);
            this.panelManage.Controls.Add(this.lblSelectedTime);
            this.panelManage.Controls.Add(this.lblSelectedDate);
            this.panelManage.Controls.Add(this.btnCheckIn);
            this.panelManage.Controls.Add(this.label11);
            this.panelManage.Controls.Add(this.btnVAEBooking);
            this.panelManage.Controls.Add(this.lblSelectedPriority);
            this.panelManage.Location = new System.Drawing.Point(605, 181);
            this.panelManage.Name = "panelManage";
            this.panelManage.Size = new System.Drawing.Size(232, 278);
            this.panelManage.TabIndex = 42;
            // 
            // label65656
            // 
            this.label65656.AutoSize = true;
            this.label65656.BackColor = System.Drawing.Color.Transparent;
            this.label65656.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label65656.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65656.ForeColor = System.Drawing.Color.White;
            this.label65656.Location = new System.Drawing.Point(18, 133);
            this.label65656.Name = "label65656";
            this.label65656.Size = new System.Drawing.Size(57, 17);
            this.label65656.TabIndex = 85;
            this.label65656.Text = "Priority:";
            // 
            // lblSelectedStaff
            // 
            this.lblSelectedStaff.AutoSize = true;
            this.lblSelectedStaff.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectedStaff.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblSelectedStaff.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedStaff.ForeColor = System.Drawing.Color.White;
            this.lblSelectedStaff.Location = new System.Drawing.Point(17, 109);
            this.lblSelectedStaff.Name = "lblSelectedStaff";
            this.lblSelectedStaff.Size = new System.Drawing.Size(46, 17);
            this.lblSelectedStaff.TabIndex = 84;
            this.lblSelectedStaff.Text = "Staff: ";
            // 
            // btnReceipt
            // 
            this.btnReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReceipt.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnReceipt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReceipt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceipt.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceipt.ForeColor = System.Drawing.Color.White;
            this.btnReceipt.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnReceipt.Location = new System.Drawing.Point(-1, 238);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(232, 32);
            this.btnReceipt.TabIndex = 83;
            this.btnReceipt.TabStop = false;
            this.btnReceipt.Text = "Generate Receipt";
            this.btnReceipt.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnReceipt.UseVisualStyleBackColor = false;
            this.btnReceipt.Click += new System.EventHandler(this.btnOfficeDiary_Click);
            // 
            // lblSelectedCustomer
            // 
            this.lblSelectedCustomer.AutoSize = true;
            this.lblSelectedCustomer.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectedCustomer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblSelectedCustomer.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedCustomer.ForeColor = System.Drawing.Color.White;
            this.lblSelectedCustomer.Location = new System.Drawing.Point(16, 85);
            this.lblSelectedCustomer.Name = "lblSelectedCustomer";
            this.lblSelectedCustomer.Size = new System.Drawing.Size(81, 17);
            this.lblSelectedCustomer.TabIndex = 82;
            this.lblSelectedCustomer.Text = "Customer: ";
            // 
            // lblSelectedTime
            // 
            this.lblSelectedTime.AutoSize = true;
            this.lblSelectedTime.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectedTime.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblSelectedTime.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedTime.ForeColor = System.Drawing.Color.White;
            this.lblSelectedTime.Location = new System.Drawing.Point(16, 61);
            this.lblSelectedTime.Name = "lblSelectedTime";
            this.lblSelectedTime.Size = new System.Drawing.Size(48, 17);
            this.lblSelectedTime.TabIndex = 81;
            this.lblSelectedTime.Text = "Time: ";
            // 
            // lblSelectedDate
            // 
            this.lblSelectedDate.AutoSize = true;
            this.lblSelectedDate.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectedDate.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblSelectedDate.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedDate.ForeColor = System.Drawing.Color.White;
            this.lblSelectedDate.Location = new System.Drawing.Point(17, 37);
            this.lblSelectedDate.Name = "lblSelectedDate";
            this.lblSelectedDate.Size = new System.Drawing.Size(47, 17);
            this.lblSelectedDate.TabIndex = 80;
            this.lblSelectedDate.Text = "Date: ";
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCheckIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckIn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCheckIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnCheckIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckIn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnCheckIn.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCheckIn.Location = new System.Drawing.Point(-1, 166);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(232, 32);
            this.btnCheckIn.TabIndex = 79;
            this.btnCheckIn.TabStop = false;
            this.btnCheckIn.Text = "Check-In";
            this.btnCheckIn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label11.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(2, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 17);
            this.label11.TabIndex = 77;
            this.label11.Text = "Selected Booking:";
            // 
            // btnVAEBooking
            // 
            this.btnVAEBooking.BackColor = System.Drawing.Color.Purple;
            this.btnVAEBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVAEBooking.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnVAEBooking.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnVAEBooking.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnVAEBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVAEBooking.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVAEBooking.ForeColor = System.Drawing.Color.White;
            this.btnVAEBooking.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnVAEBooking.Location = new System.Drawing.Point(-1, 202);
            this.btnVAEBooking.Name = "btnVAEBooking";
            this.btnVAEBooking.Size = new System.Drawing.Size(232, 32);
            this.btnVAEBooking.TabIndex = 75;
            this.btnVAEBooking.TabStop = false;
            this.btnVAEBooking.Text = "View / Edit Booking";
            this.btnVAEBooking.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnVAEBooking.UseVisualStyleBackColor = false;
            this.btnVAEBooking.Click += new System.EventHandler(this.btnVAEBooking_Click);
            // 
            // lblSelectedPriority
            // 
            this.lblSelectedPriority.AutoSize = true;
            this.lblSelectedPriority.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectedPriority.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblSelectedPriority.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedPriority.ForeColor = System.Drawing.Color.White;
            this.lblSelectedPriority.Location = new System.Drawing.Point(71, 133);
            this.lblSelectedPriority.Name = "lblSelectedPriority";
            this.lblSelectedPriority.Size = new System.Drawing.Size(51, 17);
            this.lblSelectedPriority.TabIndex = 86;
            this.lblSelectedPriority.Text = "Urgent";
            // 
            // formAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 508);
            this.Controls.Add(this.btnControls);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelManage);
            this.Controls.Add(this.panelAdd);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "formAppointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = " ";
            this.Load += new System.EventHandler(this.formAppointments_Load);
            this.MdiChildActivate += new System.EventHandler(this.formAppointments_MdiChildActivate);
            this.VisibleChanged += new System.EventHandler(this.formAppointments_VisibleChanged);
            this.Controls.SetChildIndex(this.panelAdd, 0);
            this.Controls.SetChildIndex(this.panelManage, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.btnControls, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewMonthlyBookings)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.panelManage.ResumeLayout(false);
            this.panelManage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dGridViewMonthlyBookings;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMonthSelected;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTitleControl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnResults;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dTPMonth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbStaff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbPriority;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Label lblSlotsAvailable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dTPAppointments;
        private System.Windows.Forms.Button btnViewDay;
        private System.Windows.Forms.Button btnControls;
        private System.Windows.Forms.Panel panelManage;
        private System.Windows.Forms.Button btnVAEBooking;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Label lblSelectedCustomer;
        private System.Windows.Forms.Label lblSelectedTime;
        private System.Windows.Forms.Label lblSelectedDate;
        private System.Windows.Forms.Button btnReceipt;
        private System.Windows.Forms.Label lblSelectedStaff;
        private System.Windows.Forms.Label label65656;
        private System.Windows.Forms.Label lblSelectedPriority;
    }
}