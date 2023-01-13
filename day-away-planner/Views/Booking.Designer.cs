namespace day_away_planner.Views
{
    partial class Booking
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
            this.back = new System.Windows.Forms.Button();
            this.bookingGridView = new System.Windows.Forms.DataGridView();
            this.eventUnpaid = new System.Windows.Forms.CheckBox();
            this.bookingProposed = new System.Windows.Forms.CheckBox();
            this.eventPaid = new System.Windows.Forms.CheckBox();
            this.bookingConfirmed = new System.Windows.Forms.CheckBox();
            this.bookingCancelled = new System.Windows.Forms.CheckBox();
            this.bookingCompleted = new System.Windows.Forms.CheckBox();
            this.createNewBooking = new System.Windows.Forms.Button();
            this.Debt_check_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bookingGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(16, 654);
            this.back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(100, 28);
            this.back.TabIndex = 5;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // bookingGridView
            // 
            this.bookingGridView.AccessibleName = "Bookings";
            this.bookingGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.bookingGridView.AllowUserToAddRows = false;
            this.bookingGridView.AllowUserToDeleteRows = false;
            this.bookingGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingGridView.Location = new System.Drawing.Point(16, 128);
            this.bookingGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bookingGridView.Name = "bookingGridView";
            this.bookingGridView.ReadOnly = true;
            this.bookingGridView.RowHeadersWidth = 51;
            this.bookingGridView.Size = new System.Drawing.Size(1577, 506);
            this.bookingGridView.TabIndex = 4;
            this.bookingGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookingGridView_CellContentClick);
            // 
            // eventUnpaid
            // 
            this.eventUnpaid.AutoSize = true;
            this.eventUnpaid.Checked = true;
            this.eventUnpaid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.eventUnpaid.Location = new System.Drawing.Point(1313, 12);
            this.eventUnpaid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eventUnpaid.Name = "eventUnpaid";
            this.eventUnpaid.Size = new System.Drawing.Size(115, 21);
            this.eventUnpaid.TabIndex = 6;
            this.eventUnpaid.Text = "Event Unpaid";
            this.eventUnpaid.UseVisualStyleBackColor = true;
            this.eventUnpaid.CheckedChanged += new System.EventHandler(this.eventUnpaid_CheckedChanged);
            // 
            // bookingProposed
            // 
            this.bookingProposed.AutoSize = true;
            this.bookingProposed.Checked = true;
            this.bookingProposed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bookingProposed.Location = new System.Drawing.Point(1443, 12);
            this.bookingProposed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bookingProposed.Name = "bookingProposed";
            this.bookingProposed.Size = new System.Drawing.Size(146, 21);
            this.bookingProposed.TabIndex = 7;
            this.bookingProposed.Text = "Booking Proposed";
            this.bookingProposed.UseVisualStyleBackColor = true;
            this.bookingProposed.CheckedChanged += new System.EventHandler(this.bookingProposed_CheckedChanged);
            // 
            // eventPaid
            // 
            this.eventPaid.AutoSize = true;
            this.eventPaid.Checked = true;
            this.eventPaid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.eventPaid.Location = new System.Drawing.Point(1313, 41);
            this.eventPaid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eventPaid.Name = "eventPaid";
            this.eventPaid.Size = new System.Drawing.Size(98, 21);
            this.eventPaid.TabIndex = 8;
            this.eventPaid.Text = "Event Paid";
            this.eventPaid.UseVisualStyleBackColor = true;
            this.eventPaid.CheckedChanged += new System.EventHandler(this.eventPaid_CheckedChanged);
            // 
            // bookingConfirmed
            // 
            this.bookingConfirmed.AutoSize = true;
            this.bookingConfirmed.Checked = true;
            this.bookingConfirmed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bookingConfirmed.Location = new System.Drawing.Point(1443, 41);
            this.bookingConfirmed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bookingConfirmed.Name = "bookingConfirmed";
            this.bookingConfirmed.Size = new System.Drawing.Size(149, 21);
            this.bookingConfirmed.TabIndex = 9;
            this.bookingConfirmed.Text = "Booking Confirmed";
            this.bookingConfirmed.UseVisualStyleBackColor = true;
            this.bookingConfirmed.CheckedChanged += new System.EventHandler(this.bookingConfirmed_CheckedChanged);
            // 
            // bookingCancelled
            // 
            this.bookingCancelled.AutoSize = true;
            this.bookingCancelled.Checked = true;
            this.bookingCancelled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bookingCancelled.Location = new System.Drawing.Point(1443, 69);
            this.bookingCancelled.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bookingCancelled.Name = "bookingCancelled";
            this.bookingCancelled.Size = new System.Drawing.Size(147, 21);
            this.bookingCancelled.TabIndex = 10;
            this.bookingCancelled.Text = "Booking Cancelled";
            this.bookingCancelled.UseVisualStyleBackColor = true;
            this.bookingCancelled.CheckedChanged += new System.EventHandler(this.bookingCancelled_CheckedChanged);
            // 
            // bookingCompleted
            // 
            this.bookingCompleted.AutoSize = true;
            this.bookingCompleted.Checked = true;
            this.bookingCompleted.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bookingCompleted.Location = new System.Drawing.Point(1443, 97);
            this.bookingCompleted.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bookingCompleted.Name = "bookingCompleted";
            this.bookingCompleted.Size = new System.Drawing.Size(152, 21);
            this.bookingCompleted.TabIndex = 11;
            this.bookingCompleted.Text = "Booking Completed";
            this.bookingCompleted.UseVisualStyleBackColor = true;
            this.bookingCompleted.CheckedChanged += new System.EventHandler(this.bookingCompleted_CheckedChanged);
            // 
            // createNewBooking
            // 
            this.createNewBooking.Location = new System.Drawing.Point(1421, 654);
            this.createNewBooking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.createNewBooking.Name = "createNewBooking";
            this.createNewBooking.Size = new System.Drawing.Size(172, 28);
            this.createNewBooking.TabIndex = 12;
            this.createNewBooking.Text = "New Booking";
            this.createNewBooking.UseVisualStyleBackColor = false;
            this.createNewBooking.Click += new System.EventHandler(this.createNewBooking_Click);
            // 
            // Debt_check_label
            // 
            this.Debt_check_label.AutoSize = true;
            this.Debt_check_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Debt_check_label.Location = new System.Drawing.Point(544, 657);
            this.Debt_check_label.Name = "Debt_check_label";
            this.Debt_check_label.Size = new System.Drawing.Size(478, 25);
            this.Debt_check_label.TabIndex = 13;
            this.Debt_check_label.Text = "Click any booking to check their Respective debt";
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1609, 777);
            this.Controls.Add(this.Debt_check_label);
            this.Controls.Add(this.createNewBooking);
            this.Controls.Add(this.bookingCompleted);
            this.Controls.Add(this.bookingCancelled);
            this.Controls.Add(this.bookingConfirmed);
            this.Controls.Add(this.eventPaid);
            this.Controls.Add(this.bookingProposed);
            this.Controls.Add(this.eventUnpaid);
            this.Controls.Add(this.back);
            this.Controls.Add(this.bookingGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Booking";
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.Booking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookingGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.DataGridView bookingGridView;
        private System.Windows.Forms.CheckBox eventUnpaid;
        private System.Windows.Forms.CheckBox bookingProposed;
        private System.Windows.Forms.CheckBox eventPaid;
        private System.Windows.Forms.CheckBox bookingConfirmed;
        private System.Windows.Forms.CheckBox bookingCancelled;
        private System.Windows.Forms.CheckBox bookingCompleted;
        private System.Windows.Forms.Button createNewBooking;
        private System.Windows.Forms.Label Debt_check_label;
    }
}