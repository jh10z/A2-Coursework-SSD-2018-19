namespace BookingApplication
{
    partial class formHome
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
            this.components = new System.ComponentModel.Container();
            this.picBanner = new System.Windows.Forms.PictureBox();
            this.btnDiary = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.systemTimer = new System.Windows.Forms.Timer(this.components);
            this.lblDateTime = new System.Windows.Forms.Label();
            this.btnAppointments = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // picBanner
            // 
            this.picBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBanner.Image = global::BookingApplication.Properties.Resources.Banner;
            this.picBanner.Location = new System.Drawing.Point(12, 62);
            this.picBanner.Name = "picBanner";
            this.picBanner.Size = new System.Drawing.Size(826, 180);
            this.picBanner.TabIndex = 5;
            this.picBanner.TabStop = false;
            // 
            // btnDiary
            // 
            this.btnDiary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDiary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiary.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnDiary.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDiary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDiary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiary.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiary.ForeColor = System.Drawing.Color.White;
            this.btnDiary.Location = new System.Drawing.Point(182, 245);
            this.btnDiary.Name = "btnDiary";
            this.btnDiary.Size = new System.Drawing.Size(282, 102);
            this.btnDiary.TabIndex = 9;
            this.btnDiary.TabStop = false;
            this.btnDiary.Text = "Schedule";
            this.btnDiary.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnDiary.UseVisualStyleBackColor = false;
            this.btnDiary.Click += new System.EventHandler(this.btnDiary_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.Lime;
            this.btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomers.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCustomers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnCustomers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.Location = new System.Drawing.Point(182, 351);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(282, 145);
            this.btnCustomers.TabIndex = 10;
            this.btnCustomers.TabStop = false;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnStats
            // 
            this.btnStats.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnStats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStats.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnStats.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnStats.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStats.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStats.ForeColor = System.Drawing.Color.White;
            this.btnStats.Location = new System.Drawing.Point(470, 245);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(282, 145);
            this.btnStats.TabIndex = 11;
            this.btnStats.TabStop = false;
            this.btnStats.Text = "Monthly Statistics";
            this.btnStats.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnStats.UseVisualStyleBackColor = false;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.Color.Fuchsia;
            this.btnStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStaff.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.Color.White;
            this.btnStaff.Location = new System.Drawing.Point(470, 394);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(282, 102);
            this.btnStaff.TabIndex = 12;
            this.btnStaff.TabStop = false;
            this.btnStaff.Text = "Staff / Services";
            this.btnStaff.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnStaff.UseVisualStyleBackColor = false;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Gray;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(758, 245);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 253);
            this.btnBack.TabIndex = 13;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "Menu (Back)";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // systemTimer
            // 
            this.systemTimer.Enabled = true;
            this.systemTimer.Tick += new System.EventHandler(this.systemTimer_Tick);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTime.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblDateTime.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.White;
            this.lblDateTime.Location = new System.Drawing.Point(149, 212);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(92, 22);
            this.lblDateTime.TabIndex = 17;
            this.lblDateTime.Text = "DateTime";
            // 
            // btnAppointments
            // 
            this.btnAppointments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAppointments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAppointments.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAppointments.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnAppointments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppointments.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointments.ForeColor = System.Drawing.Color.White;
            this.btnAppointments.Location = new System.Drawing.Point(12, 245);
            this.btnAppointments.Name = "btnAppointments";
            this.btnAppointments.Size = new System.Drawing.Size(164, 251);
            this.btnAppointments.TabIndex = 18;
            this.btnAppointments.TabStop = false;
            this.btnAppointments.Text = "Appointments";
            this.btnAppointments.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnAppointments.UseVisualStyleBackColor = false;
            this.btnAppointments.Click += new System.EventHandler(this.btnAppointments_Click);
            // 
            // formHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 508);
            this.Controls.Add(this.btnAppointments);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnStaff);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnDiary);
            this.Controls.Add(this.picBanner);
            this.Name = "formHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = " ";
            this.Load += new System.EventHandler(this.formHome_Load);
            this.MdiChildActivate += new System.EventHandler(this.formHome_MdiChildActivate);
            this.Controls.SetChildIndex(this.picBanner, 0);
            this.Controls.SetChildIndex(this.btnDiary, 0);
            this.Controls.SetChildIndex(this.btnCustomers, 0);
            this.Controls.SetChildIndex(this.btnStats, 0);
            this.Controls.SetChildIndex(this.btnStaff, 0);
            this.Controls.SetChildIndex(this.btnBack, 0);
            this.Controls.SetChildIndex(this.lblDateTime, 0);
            this.Controls.SetChildIndex(this.btnAppointments, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picBanner;
        private System.Windows.Forms.Button btnDiary;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Timer systemTimer;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Button btnAppointments;
    }
}

