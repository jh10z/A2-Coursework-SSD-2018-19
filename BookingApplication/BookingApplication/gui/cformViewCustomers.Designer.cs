namespace BookingApplication.gui
{
    partial class cformViewCustomers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button4 = new System.Windows.Forms.Button();
            this.listBoxCustomers = new System.Windows.Forms.ListBox();
            this.txtbListSearch = new System.Windows.Forms.TextBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.panelControls = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelCustName = new System.Windows.Forms.Panel();
            this.btnEditDel = new System.Windows.Forms.Button();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblTitleAdress = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblTown = new System.Windows.Forms.Label();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.lblTitleEmail = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.panelCustView = new System.Windows.Forms.Panel();
            this.lblIndicator = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dGridViewUpcoming = new System.Windows.Forms.DataGridView();
            this.panelControls.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelCustName.SuspendLayout();
            this.panelCustView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewUpcoming)).BeginInit();
            this.SuspendLayout();
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
            this.button4.TabIndex = 35;
            this.button4.TabStop = false;
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // listBoxCustomers
            // 
            this.listBoxCustomers.BackColor = System.Drawing.Color.Silver;
            this.listBoxCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxCustomers.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCustomers.FormattingEnabled = true;
            this.listBoxCustomers.ItemHeight = 17;
            this.listBoxCustomers.Location = new System.Drawing.Point(4, 38);
            this.listBoxCustomers.Name = "listBoxCustomers";
            this.listBoxCustomers.ScrollAlwaysVisible = true;
            this.listBoxCustomers.Size = new System.Drawing.Size(240, 255);
            this.listBoxCustomers.TabIndex = 38;
            this.listBoxCustomers.SelectedIndexChanged += new System.EventHandler(this.listBoxCustomers_SelectedIndexChanged);
            // 
            // txtbListSearch
            // 
            this.txtbListSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbListSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtbListSearch.Location = new System.Drawing.Point(5, 5);
            this.txtbListSearch.Name = "txtbListSearch";
            this.txtbListSearch.Size = new System.Drawing.Size(238, 26);
            this.txtbListSearch.TabIndex = 39;
            this.txtbListSearch.TextChanged += new System.EventHandler(this.txtbListSearch_TextChanged);
            this.txtbListSearch.Enter += new System.EventHandler(this.txtbListSearch_Enter);
            this.txtbListSearch.Leave += new System.EventHandler(this.txtbListSearch_Leave);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.Lime;
            this.btnAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCustomer.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAddCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnAddCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddCustomer.Location = new System.Drawing.Point(19, 425);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(250, 34);
            this.btnAddCustomer.TabIndex = 40;
            this.btnAddCustomer.TabStop = false;
            this.btnAddCustomer.Text = "Add New Customer";
            this.btnAddCustomer.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // panelControls
            // 
            this.panelControls.BackColor = System.Drawing.Color.Gray;
            this.panelControls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelControls.Controls.Add(this.txtbListSearch);
            this.panelControls.Controls.Add(this.listBoxCustomers);
            this.panelControls.Location = new System.Drawing.Point(19, 121);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(250, 300);
            this.panelControls.TabIndex = 39;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(3, 8);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(111, 27);
            this.lblName.TabIndex = 45;
            this.lblName.Text = "First Last";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "List of Customers";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(19, 76);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 43);
            this.panel4.TabIndex = 45;
            // 
            // panelCustName
            // 
            this.panelCustName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelCustName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelCustName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCustName.Controls.Add(this.lblName);
            this.panelCustName.Controls.Add(this.btnEditDel);
            this.panelCustName.Location = new System.Drawing.Point(280, 103);
            this.panelCustName.Name = "panelCustName";
            this.panelCustName.Size = new System.Drawing.Size(557, 41);
            this.panelCustName.TabIndex = 46;
            // 
            // btnEditDel
            // 
            this.btnEditDel.BackColor = System.Drawing.Color.Red;
            this.btnEditDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditDel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditDel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnEditDel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnEditDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditDel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDel.ForeColor = System.Drawing.Color.White;
            this.btnEditDel.Location = new System.Drawing.Point(379, 4);
            this.btnEditDel.Name = "btnEditDel";
            this.btnEditDel.Size = new System.Drawing.Size(173, 32);
            this.btnEditDel.TabIndex = 56;
            this.btnEditDel.TabStop = false;
            this.btnEditDel.Text = "More Options";
            this.btnEditDel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnEditDel.UseVisualStyleBackColor = false;
            this.btnEditDel.Click += new System.EventHandler(this.btnEditDel_Click);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.Transparent;
            this.lblAge.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.Color.White;
            this.lblAge.Location = new System.Drawing.Point(85, 28);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(60, 17);
            this.lblAge.TabIndex = 47;
            this.lblAge.Text = "Age | 19";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.BackColor = System.Drawing.Color.Transparent;
            this.lblDOB.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.ForeColor = System.Drawing.Color.White;
            this.lblDOB.Location = new System.Drawing.Point(85, 48);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(172, 17);
            this.lblDOB.TabIndex = 48;
            this.lblDOB.Text = "Date of Birth | 21/10/2000";
            // 
            // lblTitleAdress
            // 
            this.lblTitleAdress.AutoSize = true;
            this.lblTitleAdress.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleAdress.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleAdress.ForeColor = System.Drawing.Color.White;
            this.lblTitleAdress.Location = new System.Drawing.Point(5, 83);
            this.lblTitleAdress.Name = "lblTitleAdress";
            this.lblTitleAdress.Size = new System.Drawing.Size(66, 17);
            this.lblTitleAdress.TabIndex = 49;
            this.lblTitleAdress.Text = "Address:\r\n";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(85, 83);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(133, 17);
            this.lblAddress.TabIndex = 50;
            this.lblAddress.Text = "20, Courtside Drive";
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.BackColor = System.Drawing.Color.Transparent;
            this.lblTown.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTown.ForeColor = System.Drawing.Color.White;
            this.lblTown.Location = new System.Drawing.Point(85, 102);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(98, 17);
            this.lblTown.TabIndex = 51;
            this.lblTown.Text = "Town | Belfast";
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.BackColor = System.Drawing.Color.Transparent;
            this.lblPostcode.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostcode.ForeColor = System.Drawing.Color.White;
            this.lblPostcode.Location = new System.Drawing.Point(85, 122);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(139, 17);
            this.lblPostcode.TabIndex = 52;
            this.lblPostcode.Text = "Postcode | BT6 8SA";
            // 
            // lblTitleEmail
            // 
            this.lblTitleEmail.AutoSize = true;
            this.lblTitleEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleEmail.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleEmail.ForeColor = System.Drawing.Color.White;
            this.lblTitleEmail.Location = new System.Drawing.Point(295, 28);
            this.lblTitleEmail.Name = "lblTitleEmail";
            this.lblTitleEmail.Size = new System.Drawing.Size(63, 17);
            this.lblTitleEmail.TabIndex = 53;
            this.lblTitleEmail.Text = "Contact:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(364, 28);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(168, 17);
            this.lblEmail.TabIndex = 54;
            this.lblEmail.Text = "PatariCoo20@gmailcom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 57;
            this.label1.Text = "Future Appointments";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 59;
            this.label3.Text = "Basic Info:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(6, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(542, 5);
            this.button1.TabIndex = 47;
            this.button1.TabStop = false;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.BackColor = System.Drawing.Color.Transparent;
            this.lblTelNo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelNo.ForeColor = System.Drawing.Color.White;
            this.lblTelNo.Location = new System.Drawing.Point(364, 47);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(96, 17);
            this.lblTelNo.TabIndex = 60;
            this.lblTelNo.Text = "07791954753";
            // 
            // panelCustView
            // 
            this.panelCustView.BackColor = System.Drawing.Color.Gray;
            this.panelCustView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelCustView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCustView.Controls.Add(this.lblIndicator);
            this.panelCustView.Controls.Add(this.button2);
            this.panelCustView.Controls.Add(this.lblTelNo);
            this.panelCustView.Controls.Add(this.button1);
            this.panelCustView.Controls.Add(this.label3);
            this.panelCustView.Controls.Add(this.label1);
            this.panelCustView.Controls.Add(this.lblEmail);
            this.panelCustView.Controls.Add(this.lblTitleEmail);
            this.panelCustView.Controls.Add(this.lblPostcode);
            this.panelCustView.Controls.Add(this.lblTown);
            this.panelCustView.Controls.Add(this.lblAddress);
            this.panelCustView.Controls.Add(this.lblTitleAdress);
            this.panelCustView.Controls.Add(this.lblDOB);
            this.panelCustView.Controls.Add(this.lblAge);
            this.panelCustView.Controls.Add(this.dGridViewUpcoming);
            this.panelCustView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCustView.Location = new System.Drawing.Point(280, 146);
            this.panelCustView.Name = "panelCustView";
            this.panelCustView.Size = new System.Drawing.Size(557, 313);
            this.panelCustView.TabIndex = 43;
            // 
            // lblIndicator
            // 
            this.lblIndicator.AutoSize = true;
            this.lblIndicator.BackColor = System.Drawing.Color.DarkGray;
            this.lblIndicator.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicator.ForeColor = System.Drawing.Color.White;
            this.lblIndicator.Location = new System.Drawing.Point(165, 234);
            this.lblIndicator.Name = "lblIndicator";
            this.lblIndicator.Size = new System.Drawing.Size(225, 24);
            this.lblIndicator.TabIndex = 57;
            this.lblIndicator.Text = "No Upcoming Bookings";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(151, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(397, 5);
            this.button2.TabIndex = 61;
            this.button2.TabStop = false;
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // dGridViewUpcoming
            // 
            this.dGridViewUpcoming.AllowUserToAddRows = false;
            this.dGridViewUpcoming.AllowUserToDeleteRows = false;
            this.dGridViewUpcoming.AllowUserToResizeColumns = false;
            this.dGridViewUpcoming.AllowUserToResizeRows = false;
            this.dGridViewUpcoming.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dGridViewUpcoming.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGridViewUpcoming.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dGridViewUpcoming.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGridViewUpcoming.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGridViewUpcoming.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGridViewUpcoming.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGridViewUpcoming.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dGridViewUpcoming.Location = new System.Drawing.Point(6, 179);
            this.dGridViewUpcoming.MultiSelect = false;
            this.dGridViewUpcoming.Name = "dGridViewUpcoming";
            this.dGridViewUpcoming.ReadOnly = true;
            this.dGridViewUpcoming.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGridViewUpcoming.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGridViewUpcoming.RowHeadersVisible = false;
            this.dGridViewUpcoming.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dGridViewUpcoming.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGridViewUpcoming.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dGridViewUpcoming.Size = new System.Drawing.Size(542, 126);
            this.dGridViewUpcoming.TabIndex = 62;
            this.dGridViewUpcoming.TabStop = false;
            this.dGridViewUpcoming.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dGridViewUpcoming_CellFormatting);
            this.dGridViewUpcoming.SelectionChanged += new System.EventHandler(this.dGridViewUpcoming_SelectionChanged);
            // 
            // cformViewCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 508);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.panelCustName);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelCustView);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.button4);
            this.Name = "cformViewCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = " ";
            this.MdiChildActivate += new System.EventHandler(this.cformViewCustomers_MdiChildActivate);
            this.VisibleChanged += new System.EventHandler(this.cformViewCustomers_VisibleChanged);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.panelControls, 0);
            this.Controls.SetChildIndex(this.panelCustView, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panelCustName, 0);
            this.Controls.SetChildIndex(this.btnAddCustomer, 0);
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelCustName.ResumeLayout(false);
            this.panelCustName.PerformLayout();
            this.panelCustView.ResumeLayout(false);
            this.panelCustView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewUpcoming)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listBoxCustomers;
        private System.Windows.Forms.TextBox txtbListSearch;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelCustName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblTitleAdress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblTitleEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditDel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.Panel panelCustView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dGridViewUpcoming;
        private System.Windows.Forms.Label lblIndicator;
    }
}