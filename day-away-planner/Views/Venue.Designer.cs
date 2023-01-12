namespace day_away_planner.Views
{
    partial class Venue
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
            this.venueGridView = new System.Windows.Forms.DataGridView();
            this.back = new System.Windows.Forms.Button();
            this.venueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.venueGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.venueBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // venueGridView
            // 
            this.venueGridView.AccessibleName = "Venues";
            this.venueGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.venueGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.venueGridView.Location = new System.Drawing.Point(12, 12);
            this.venueGridView.Name = "venueGridView";
            this.venueGridView.ReadOnly = true;
            this.venueGridView.Size = new System.Drawing.Size(776, 411);
            this.venueGridView.TabIndex = 0;
            this.venueGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.venueGridView_RowCellDoubleClick);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 440);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 1;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // venueBindingSource
            // 
            this.venueBindingSource.DataSource = typeof(day_away_planner.Presenter.Venue);
            // 
            // Venue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.back);
            this.Controls.Add(this.venueGridView);
            this.Name = "Venue";
            this.Text = "Venue";
            this.Load += new System.EventHandler(this.Venue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.venueGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.venueBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView venueGridView;
        private System.Windows.Forms.BindingSource venueBindingSource;
        private System.Windows.Forms.Button back;
    }
}