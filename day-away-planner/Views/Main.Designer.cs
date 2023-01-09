namespace day_away_planner
{
    partial class Main
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
            this.venueButton = new System.Windows.Forms.Button();
            this.clientButton = new System.Windows.Forms.Button();
            this.activityButton = new System.Windows.Forms.Button();
            this.bookingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // venueButton
            // 
            this.venueButton.Location = new System.Drawing.Point(58, 47);
            this.venueButton.Name = "venueButton";
            this.venueButton.Size = new System.Drawing.Size(75, 23);
            this.venueButton.TabIndex = 0;
            this.venueButton.Text = "Venues";
            this.venueButton.UseVisualStyleBackColor = true;
            this.venueButton.Click += new System.EventHandler(this.venueButton_Click);
            // 
            // clientButton
            // 
            this.clientButton.Location = new System.Drawing.Point(139, 47);
            this.clientButton.Name = "clientButton";
            this.clientButton.Size = new System.Drawing.Size(75, 23);
            this.clientButton.TabIndex = 1;
            this.clientButton.Text = "Clients";
            this.clientButton.UseVisualStyleBackColor = true;
            this.clientButton.Click += new System.EventHandler(this.clientButton_Click);
            // 
            // activityButton
            // 
            this.activityButton.Location = new System.Drawing.Point(219, 47);
            this.activityButton.Margin = new System.Windows.Forms.Padding(2);
            this.activityButton.Name = "activityButton";
            this.activityButton.Size = new System.Drawing.Size(75, 23);
            this.activityButton.TabIndex = 2;
            this.activityButton.Text = "Activities";
            this.activityButton.UseVisualStyleBackColor = true;
            this.activityButton.Click += new System.EventHandler(this.activityButton_Click);
            // 
            // bookingsButton
            // 
            this.bookingsButton.Location = new System.Drawing.Point(298, 47);
            this.bookingsButton.Margin = new System.Windows.Forms.Padding(2);
            this.bookingsButton.Name = "bookingsButton";
            this.bookingsButton.Size = new System.Drawing.Size(75, 23);
            this.bookingsButton.TabIndex = 3;
            this.bookingsButton.Text = "Bookings";
            this.bookingsButton.UseVisualStyleBackColor = true;
            this.bookingsButton.Click += new System.EventHandler(this.bookingsButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bookingsButton);
            this.Controls.Add(this.activityButton);
            this.Controls.Add(this.clientButton);
            this.Controls.Add(this.venueButton);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button venueButton;
        private System.Windows.Forms.Button clientButton;
        private System.Windows.Forms.Button activityButton;
        private System.Windows.Forms.Button bookingsButton;
    }
}

