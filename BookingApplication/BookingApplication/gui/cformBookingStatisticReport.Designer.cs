namespace BookingApplication.gui
{
    partial class cformBookingStatisticReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.bookingDetailsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingDetailsDataSet = new BookingApplication.BookingDetails();
            this.rVBooking = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button4 = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBackMonth = new System.Windows.Forms.Button();
            this.lblMonth = new System.Windows.Forms.Label();
            this.bookingDetailsTableTableAdapter = new BookingApplication.BookingDetailsTableAdapters.BookingDetailsTableTableAdapter();
            this.panelFinalise = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDetailsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDetailsDataSet)).BeginInit();
            this.panel4.SuspendLayout();
            this.panelFinalise.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookingDetailsTableBindingSource
            // 
            this.bookingDetailsTableBindingSource.DataMember = "BookingDetailsTable";
            this.bookingDetailsTableBindingSource.DataSource = this.bookingDetailsDataSet;
            // 
            // bookingDetailsDataSet
            // 
            this.bookingDetailsDataSet.DataSetName = "BookingDetails";
            this.bookingDetailsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rVBooking
            // 
            this.rVBooking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rVBooking.IsDocumentMapWidthFixed = true;
            reportDataSource1.Name = "BookingDetails";
            reportDataSource1.Value = this.bookingDetailsTableBindingSource;
            this.rVBooking.LocalReport.DataSources.Add(reportDataSource1);
            this.rVBooking.LocalReport.ReportEmbeddedResource = "BookingApplication.BookingStatistics.rdlc";
            this.rVBooking.Location = new System.Drawing.Point(12, 127);
            this.rVBooking.Name = "rVBooking";
            this.rVBooking.ShowBackButton = false;
            this.rVBooking.ShowContextMenu = false;
            this.rVBooking.ShowCredentialPrompts = false;
            this.rVBooking.ShowDocumentMapButton = false;
            this.rVBooking.ShowExportButton = false;
            this.rVBooking.ShowFindControls = false;
            this.rVBooking.ShowPageNavigationControls = false;
            this.rVBooking.ShowParameterPrompts = false;
            this.rVBooking.ShowPrintButton = false;
            this.rVBooking.ShowProgress = false;
            this.rVBooking.ShowPromptAreaButton = false;
            this.rVBooking.ShowRefreshButton = false;
            this.rVBooking.ShowStopButton = false;
            this.rVBooking.ShowToolBar = false;
            this.rVBooking.ShowZoomControl = false;
            this.rVBooking.Size = new System.Drawing.Size(826, 332);
            this.rVBooking.TabIndex = 21;
            this.rVBooking.TabStop = false;
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
            this.button4.TabIndex = 46;
            this.button4.TabStop = false;
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(3, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(181, 25);
            this.lblTitle.TabIndex = 49;
            this.lblTitle.Text = "Monthly Statistics";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblTitle);
            this.panel4.Location = new System.Drawing.Point(12, 78);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(319, 43);
            this.panel4.TabIndex = 69;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnNext.Location = new System.Drawing.Point(351, 8);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(103, 25);
            this.btnNext.TabIndex = 107;
            this.btnNext.TabStop = false;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBackMonth
            // 
            this.btnBackMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBackMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackMonth.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnBackMonth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBackMonth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBackMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackMonth.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackMonth.ForeColor = System.Drawing.Color.White;
            this.btnBackMonth.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnBackMonth.Location = new System.Drawing.Point(45, 8);
            this.btnBackMonth.Name = "btnBackMonth";
            this.btnBackMonth.Size = new System.Drawing.Size(103, 25);
            this.btnBackMonth.TabIndex = 106;
            this.btnBackMonth.TabStop = false;
            this.btnBackMonth.Text = "Back";
            this.btnBackMonth.UseVisualStyleBackColor = false;
            this.btnBackMonth.Click += new System.EventHandler(this.btnBackMonth_Click);
            // 
            // lblMonth
            // 
            this.lblMonth.BackColor = System.Drawing.Color.Transparent;
            this.lblMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMonth.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.ForeColor = System.Drawing.Color.White;
            this.lblMonth.Location = new System.Drawing.Point(0, 0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(499, 41);
            this.lblMonth.TabIndex = 50;
            this.lblMonth.Text = "November 2019";
            this.lblMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bookingDetailsTableTableAdapter
            // 
            this.bookingDetailsTableTableAdapter.ClearBeforeFill = true;
            // 
            // panelFinalise
            // 
            this.panelFinalise.BackColor = System.Drawing.Color.Gray;
            this.panelFinalise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelFinalise.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFinalise.Controls.Add(this.btnNext);
            this.panelFinalise.Controls.Add(this.btnBackMonth);
            this.panelFinalise.Controls.Add(this.lblMonth);
            this.panelFinalise.Location = new System.Drawing.Point(337, 78);
            this.panelFinalise.Name = "panelFinalise";
            this.panelFinalise.Size = new System.Drawing.Size(501, 43);
            this.panelFinalise.TabIndex = 103;
            // 
            // cformBookingStatisticReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 508);
            this.Controls.Add(this.panelFinalise);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.rVBooking);
            this.DoubleBuffered = false;
            this.Name = "cformBookingStatisticReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "cformBookingStatisticReport";
            this.MdiChildActivate += new System.EventHandler(this.cformBookingStatisticReport_MdiChildActivate);
            this.Shown += new System.EventHandler(this.cformBookingStatisticReport_Shown);
            this.Controls.SetChildIndex(this.rVBooking, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panelFinalise, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bookingDetailsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDetailsDataSet)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelFinalise.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rVBooking;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBackMonth;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.BindingSource bookingDetailsTableBindingSource;
        private BookingDetails bookingDetailsDataSet;
        private BookingDetailsTableAdapters.BookingDetailsTableTableAdapter bookingDetailsTableTableAdapter;
        private System.Windows.Forms.Panel panelFinalise;
    }
}