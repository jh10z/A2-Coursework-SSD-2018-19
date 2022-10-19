namespace BookingApplication.gui
{
    partial class cform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cform));
            this.panelDragBar = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.picbIcon = new System.Windows.Forms.PictureBox();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.msToolBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upcomingNotificationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crecheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.transportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.afterSchoolClubsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.classesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.userGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelDragBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbIcon)).BeginInit();
            this.msToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDragBar
            // 
            this.panelDragBar.BackColor = System.Drawing.Color.Transparent;
            this.panelDragBar.Controls.Add(this.btnExit);
            this.panelDragBar.Controls.Add(this.picbIcon);
            this.panelDragBar.Controls.Add(this.lblFormTitle);
            this.panelDragBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelDragBar.Location = new System.Drawing.Point(0, 0);
            this.panelDragBar.Name = "panelDragBar";
            this.panelDragBar.Size = new System.Drawing.Size(850, 30);
            this.panelDragBar.TabIndex = 18;
            this.panelDragBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDragBar_MouseDown);
            this.panelDragBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelDragBar_MouseMove);
            this.panelDragBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelDragBar_MouseUp);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(801, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 22);
            this.btnExit.TabIndex = 19;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picbIcon
            // 
            this.picbIcon.Cursor = System.Windows.Forms.Cursors.No;
            this.picbIcon.Enabled = false;
            this.picbIcon.Image = global::BookingApplication.Properties.Resources.BookIcon;
            this.picbIcon.Location = new System.Drawing.Point(7, 4);
            this.picbIcon.Name = "picbIcon";
            this.picbIcon.Size = new System.Drawing.Size(22, 22);
            this.picbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbIcon.TabIndex = 19;
            this.picbIcon.TabStop = false;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFormTitle.Cursor = System.Windows.Forms.Cursors.No;
            this.lblFormTitle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Location = new System.Drawing.Point(33, 8);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(119, 17);
            this.lblFormTitle.TabIndex = 1;
            this.lblFormTitle.Text = "Advice | Staff List";
            // 
            // msToolBar
            // 
            this.msToolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.msToolBar.Dock = System.Windows.Forms.DockStyle.None;
            this.msToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.crecheToolStripMenuItem,
            this.transportToolStripMenuItem,
            this.afterSchoolClubsToolStripMenuItem,
            this.groupsToolStripMenuItem,
            this.classesToolStripMenuItem,
            this.userGuideToolStripMenuItem});
            this.msToolBar.Location = new System.Drawing.Point(6, 33);
            this.msToolBar.Name = "msToolBar";
            this.msToolBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.msToolBar.Size = new System.Drawing.Size(500, 24);
            this.msToolBar.TabIndex = 19;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToMenuToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // backToMenuToolStripMenuItem
            // 
            this.backToMenuToolStripMenuItem.Name = "backToMenuToolStripMenuItem";
            this.backToMenuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.backToMenuToolStripMenuItem.Text = "Back to Home";
            this.backToMenuToolStripMenuItem.Click += new System.EventHandler(this.backToMenuToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.appointmentsToolStripMenuItem,
            this.upcomingNotificationsToolStripMenuItem,
            this.getReportToolStripMenuItem,
            this.staffToolStripMenuItem,
            this.servicesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.helpToolStripMenuItem.Text = "Advice";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // appointmentsToolStripMenuItem
            // 
            this.appointmentsToolStripMenuItem.Name = "appointmentsToolStripMenuItem";
            this.appointmentsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.appointmentsToolStripMenuItem.Text = "Appointments";
            this.appointmentsToolStripMenuItem.Click += new System.EventHandler(this.appointmentsToolStripMenuItem_Click);
            // 
            // upcomingNotificationsToolStripMenuItem
            // 
            this.upcomingNotificationsToolStripMenuItem.Name = "upcomingNotificationsToolStripMenuItem";
            this.upcomingNotificationsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.upcomingNotificationsToolStripMenuItem.Text = "Customers";
            this.upcomingNotificationsToolStripMenuItem.Click += new System.EventHandler(this.upcomingNotificationsToolStripMenuItem_Click);
            // 
            // getReportToolStripMenuItem
            // 
            this.getReportToolStripMenuItem.Name = "getReportToolStripMenuItem";
            this.getReportToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.getReportToolStripMenuItem.Text = "Office Diary";
            this.getReportToolStripMenuItem.Click += new System.EventHandler(this.getReportToolStripMenuItem_Click);
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.staffToolStripMenuItem.Text = "Staff";
            this.staffToolStripMenuItem.Click += new System.EventHandler(this.staffToolStripMenuItem_Click);
            // 
            // servicesToolStripMenuItem
            // 
            this.servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            this.servicesToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.servicesToolStripMenuItem.Text = "Services";
            this.servicesToolStripMenuItem.Click += new System.EventHandler(this.servicesToolStripMenuItem_Click);
            // 
            // crecheToolStripMenuItem
            // 
            this.crecheToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem1});
            this.crecheToolStripMenuItem.Name = "crecheToolStripMenuItem";
            this.crecheToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.crecheToolStripMenuItem.Text = "Creche";
            // 
            // mainMenuToolStripMenuItem1
            // 
            this.mainMenuToolStripMenuItem1.Name = "mainMenuToolStripMenuItem1";
            this.mainMenuToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.mainMenuToolStripMenuItem1.Text = "Main Menu";
            // 
            // transportToolStripMenuItem
            // 
            this.transportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem2});
            this.transportToolStripMenuItem.Name = "transportToolStripMenuItem";
            this.transportToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.transportToolStripMenuItem.Text = "Transport";
            // 
            // mainMenuToolStripMenuItem2
            // 
            this.mainMenuToolStripMenuItem2.Name = "mainMenuToolStripMenuItem2";
            this.mainMenuToolStripMenuItem2.Size = new System.Drawing.Size(135, 22);
            this.mainMenuToolStripMenuItem2.Text = "Main Menu";
            // 
            // afterSchoolClubsToolStripMenuItem
            // 
            this.afterSchoolClubsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem3});
            this.afterSchoolClubsToolStripMenuItem.Name = "afterSchoolClubsToolStripMenuItem";
            this.afterSchoolClubsToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.afterSchoolClubsToolStripMenuItem.Text = "After School Clubs";
            // 
            // mainMenuToolStripMenuItem3
            // 
            this.mainMenuToolStripMenuItem3.Name = "mainMenuToolStripMenuItem3";
            this.mainMenuToolStripMenuItem3.Size = new System.Drawing.Size(135, 22);
            this.mainMenuToolStripMenuItem3.Text = "Main Menu";
            // 
            // groupsToolStripMenuItem
            // 
            this.groupsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem4});
            this.groupsToolStripMenuItem.Name = "groupsToolStripMenuItem";
            this.groupsToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.groupsToolStripMenuItem.Text = "Groups";
            // 
            // mainMenuToolStripMenuItem4
            // 
            this.mainMenuToolStripMenuItem4.Name = "mainMenuToolStripMenuItem4";
            this.mainMenuToolStripMenuItem4.Size = new System.Drawing.Size(135, 22);
            this.mainMenuToolStripMenuItem4.Text = "Main Menu";
            // 
            // classesToolStripMenuItem
            // 
            this.classesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem5});
            this.classesToolStripMenuItem.Name = "classesToolStripMenuItem";
            this.classesToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.classesToolStripMenuItem.Text = "Classes";
            // 
            // mainMenuToolStripMenuItem5
            // 
            this.mainMenuToolStripMenuItem5.Name = "mainMenuToolStripMenuItem5";
            this.mainMenuToolStripMenuItem5.Size = new System.Drawing.Size(135, 22);
            this.mainMenuToolStripMenuItem5.Text = "Main Menu";
            // 
            // userGuideToolStripMenuItem
            // 
            this.userGuideToolStripMenuItem.Name = "userGuideToolStripMenuItem";
            this.userGuideToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.userGuideToolStripMenuItem.Text = "Help";
            this.userGuideToolStripMenuItem.Click += new System.EventHandler(this.userGuideToolStripMenuItem_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Gray;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(731, 465);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(107, 31);
            this.btnBack.TabIndex = 21;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BookingApplication.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(850, 508);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.msToolBar);
            this.Controls.Add(this.panelDragBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cform";
            this.Text = "MainWindow";
            this.panelDragBar.ResumeLayout(false);
            this.panelDragBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbIcon)).EndInit();
            this.msToolBar.ResumeLayout(false);
            this.msToolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDragBar;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picbIcon;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.MenuStrip msToolBar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upcomingNotificationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crecheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afterSchoolClubsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userGuideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem5;
        private System.Windows.Forms.Button btnBack;
    }
}