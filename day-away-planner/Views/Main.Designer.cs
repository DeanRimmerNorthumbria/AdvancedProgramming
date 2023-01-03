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
            this.venueButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // clientButton
            // 
            this.clientButton.Location = new System.Drawing.Point(139, 47);
            this.clientButton.Name = "clientButton";
            this.clientButton.Size = new System.Drawing.Size(75, 23);
            this.clientButton.TabIndex = 1;
            this.clientButton.Text = "Clients";
            this.clientButton.UseVisualStyleBackColor = true;
            this.clientButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clientButton);
            this.Controls.Add(this.venueButton);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button venueButton;
        private System.Windows.Forms.Button clientButton;
    }
}

