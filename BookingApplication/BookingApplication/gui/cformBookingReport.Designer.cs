namespace BookingApplication.gui
{
    partial class cformBookingReport
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
            this.button4 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.rVBooking = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bookingDetailsTableTableAdapter = new BookingApplication.BookingDetailsTableAdapters.BookingDetailsTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDetailsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDetailsDataSet)).BeginInit();
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
            this.button4.TabIndex = 45;
            this.button4.TabStop = false;
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Lime;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(703, 416);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 31);
            this.btnSave.TabIndex = 49;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Print";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rVBooking
            // 
            this.rVBooking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rVBooking.DocumentMapCollapsed = true;
            this.rVBooking.IsDocumentMapWidthFixed = true;
            reportDataSource1.Name = "BookingDetailsDataSet";
            reportDataSource1.Value = this.bookingDetailsTableBindingSource;
            this.rVBooking.LocalReport.DataSources.Add(reportDataSource1);
            this.rVBooking.LocalReport.ReportEmbeddedResource = "BookingApplication.BookingReport.rdlc";
            this.rVBooking.Location = new System.Drawing.Point(12, 78);
            this.rVBooking.Name = "rVBooking";
            this.rVBooking.ShowBackButton = false;
            this.rVBooking.ShowFindControls = false;
            this.rVBooking.ShowPageNavigationControls = false;
            this.rVBooking.ShowPrintButton = false;
            this.rVBooking.ShowRefreshButton = false;
            this.rVBooking.ShowStopButton = false;
            this.rVBooking.ShowZoomControl = false;
            this.rVBooking.Size = new System.Drawing.Size(826, 381);
            this.rVBooking.TabIndex = 20;
            this.rVBooking.TabStop = false;
            this.rVBooking.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.rVBooking.Load += new System.EventHandler(this.rVBooking_Load);
            // 
            // bookingDetailsTableTableAdapter
            // 
            this.bookingDetailsTableTableAdapter.ClearBeforeFill = true;
            // 
            // cformBookingReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 508);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.rVBooking);
            this.Name = "cformBookingReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "cformBookingReport";
            this.MdiChildActivate += new System.EventHandler(this.cformBookingReport_MdiChildActivate);
            this.Controls.SetChildIndex(this.rVBooking, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bookingDetailsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDetailsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnSave;
        private Microsoft.Reporting.WinForms.ReportViewer rVBooking;
        private BookingDetails bookingDetailsDataSet;
        private BookingDetailsTableAdapters.BookingDetailsTableTableAdapter bookingDetailsTableTableAdapter;
        private System.Windows.Forms.BindingSource bookingDetailsTableBindingSource;
    }
}