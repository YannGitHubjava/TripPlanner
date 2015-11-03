namespace TripPlanner
{
    partial class frmNewTrip
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.cboDestination = new System.Windows.Forms.ComboBox();
            this.cboHotel = new System.Windows.Forms.ComboBox();
            this.lstAttractions = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblHotelRating = new System.Windows.Forms.Label();
            this.lblHotelCost = new System.Windows.Forms.Label();
            this.picHotel = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.picAttraction = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHotel)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAttraction)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "End:";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(278, 37);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(121, 20);
            this.dtpEnd.TabIndex = 5;
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(145, 37);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(121, 20);
            this.dtpStart.TabIndex = 3;
            // 
            // cboDestination
            // 
            this.cboDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDestination.FormattingEnabled = true;
            this.cboDestination.Location = new System.Drawing.Point(9, 36);
            this.cboDestination.Name = "cboDestination";
            this.cboDestination.Size = new System.Drawing.Size(121, 21);
            this.cboDestination.TabIndex = 1;
            this.cboDestination.Tag = "destination";
            this.cboDestination.SelectedIndexChanged += new System.EventHandler(this.UpdateForm);
            // 
            // cboHotel
            // 
            this.cboHotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHotel.FormattingEnabled = true;
            this.cboHotel.Location = new System.Drawing.Point(9, 19);
            this.cboHotel.Name = "cboHotel";
            this.cboHotel.Size = new System.Drawing.Size(257, 21);
            this.cboHotel.TabIndex = 0;
            this.cboHotel.Tag = "hotel";
            this.cboHotel.SelectedIndexChanged += new System.EventHandler(this.UpdateHotelInfo);
            // 
            // lstAttractions
            // 
            this.lstAttractions.FormattingEnabled = true;
            this.lstAttractions.Location = new System.Drawing.Point(9, 19);
            this.lstAttractions.Name = "lstAttractions";
            this.lstAttractions.Size = new System.Drawing.Size(257, 69);
            this.lstAttractions.TabIndex = 0;
            this.lstAttractions.SelectedIndexChanged += new System.EventHandler(this.UpdateAttractionPicture);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Destination:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblHotelRating);
            this.groupBox2.Controls.Add(this.lblHotelCost);
            this.groupBox2.Controls.Add(this.picHotel);
            this.groupBox2.Controls.Add(this.cboHotel);
            this.groupBox2.Location = new System.Drawing.Point(12, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(590, 230);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hotel";
            // 
            // lblHotelRating
            // 
            this.lblHotelRating.AutoSize = true;
            this.lblHotelRating.Location = new System.Drawing.Point(6, 53);
            this.lblHotelRating.Name = "lblHotelRating";
            this.lblHotelRating.Size = new System.Drawing.Size(0, 13);
            this.lblHotelRating.TabIndex = 1;
            // 
            // lblHotelCost
            // 
            this.lblHotelCost.AutoSize = true;
            this.lblHotelCost.Location = new System.Drawing.Point(6, 76);
            this.lblHotelCost.Name = "lblHotelCost";
            this.lblHotelCost.Size = new System.Drawing.Size(0, 13);
            this.lblHotelCost.TabIndex = 2;
            // 
            // picHotel
            // 
            this.picHotel.Location = new System.Drawing.Point(284, 19);
            this.picHotel.Name = "picHotel";
            this.picHotel.Size = new System.Drawing.Size(284, 196);
            this.picHotel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHotel.TabIndex = 12;
            this.picHotel.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.picAttraction);
            this.groupBox3.Controls.Add(this.lstAttractions);
            this.groupBox3.Location = new System.Drawing.Point(12, 322);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(590, 231);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Attractions";
            // 
            // picAttraction
            // 
            this.picAttraction.Location = new System.Drawing.Point(284, 19);
            this.picAttraction.Name = "picAttraction";
            this.picAttraction.Size = new System.Drawing.Size(284, 196);
            this.picAttraction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAttraction.TabIndex = 13;
            this.picAttraction.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpStart);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboDestination);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trip Information";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(527, 565);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "&Done";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(12, 565);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(446, 565);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 4;
            this.btnRestart.Text = "&Start Over";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // frmNewTrip
            // 
            this.AcceptButton = this.btnGo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(614, 600);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmNewTrip";
            this.Text = "Trip Planner";
            this.Load += new System.EventHandler(this.frmNewTrip_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHotel)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAttraction)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.ComboBox cboDestination;
        private System.Windows.Forms.ComboBox cboHotel;
        private System.Windows.Forms.ListBox lstAttractions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox picHotel;
        private System.Windows.Forms.PictureBox picAttraction;
        private System.Windows.Forms.Label lblHotelRating;
        private System.Windows.Forms.Label lblHotelCost;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRestart;
    }
}