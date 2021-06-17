
namespace TravelReservationSystem
{
    partial class Lop_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lop_Main));
            this.lblTitle = new System.Windows.Forms.Label();
            this.tpPassengerInfo = new System.Windows.Forms.TabPage();
            this.btnAutoFill = new System.Windows.Forms.Button();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbFlyerNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFlyerNumber = new System.Windows.Forms.Label();
            this.cbFrequentFlyer = new System.Windows.Forms.CheckBox();
            this.tpSearchFlight = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFlightList = new System.Windows.Forms.ComboBox();
            this.tbDestination = new System.Windows.Forms.TextBox();
            this.tbOrigin = new System.Windows.Forms.TextBox();
            this.dateTimePickerReturnDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerLeaveDate = new System.Windows.Forms.DateTimePicker();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.gbFlightType = new System.Windows.Forms.GroupBox();
            this.rbOneWay = new System.Windows.Forms.RadioButton();
            this.rbRoundTrip = new System.Windows.Forms.RadioButton();
            this.tabMainControl = new System.Windows.Forms.TabControl();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBookFlight = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.tpPassengerInfo.SuspendLayout();
            this.tpSearchFlight.SuspendLayout();
            this.gbFlightType.SuspendLayout();
            this.tabMainControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Uighur", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(85, 57);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Safe";
            // 
            // tpPassengerInfo
            // 
            this.tpPassengerInfo.BackgroundImage = global::TravelReservationSystem.Properties.Resources.background;
            this.tpPassengerInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpPassengerInfo.Controls.Add(this.btnAutoFill);
            this.tpPassengerInfo.Controls.Add(this.tbAge);
            this.tpPassengerInfo.Controls.Add(this.tbLastName);
            this.tpPassengerInfo.Controls.Add(this.tbFirstName);
            this.tpPassengerInfo.Controls.Add(this.tbFlyerNumber);
            this.tpPassengerInfo.Controls.Add(this.label5);
            this.tpPassengerInfo.Controls.Add(this.label4);
            this.tpPassengerInfo.Controls.Add(this.label3);
            this.tpPassengerInfo.Controls.Add(this.lblFlyerNumber);
            this.tpPassengerInfo.Controls.Add(this.cbFrequentFlyer);
            this.tpPassengerInfo.Location = new System.Drawing.Point(4, 29);
            this.tpPassengerInfo.Name = "tpPassengerInfo";
            this.tpPassengerInfo.Size = new System.Drawing.Size(762, 318);
            this.tpPassengerInfo.TabIndex = 1;
            this.tpPassengerInfo.Text = "Passenger Info";
            this.tpPassengerInfo.UseVisualStyleBackColor = true;
            // 
            // btnAutoFill
            // 
            this.btnAutoFill.Location = new System.Drawing.Point(337, 61);
            this.btnAutoFill.Name = "btnAutoFill";
            this.btnAutoFill.Size = new System.Drawing.Size(86, 26);
            this.btnAutoFill.TabIndex = 9;
            this.btnAutoFill.Text = "Auto Fill";
            this.btnAutoFill.UseVisualStyleBackColor = true;
            this.btnAutoFill.Visible = false;
            this.btnAutoFill.Click += new System.EventHandler(this.btnAutoFill_Click);
            // 
            // tbAge
            // 
            this.tbAge.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbAge.Location = new System.Drawing.Point(174, 157);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(49, 26);
            this.tbAge.TabIndex = 8;
            this.tbAge.TextChanged += new System.EventHandler(this.tbAge_TextChanged);
            // 
            // tbLastName
            // 
            this.tbLastName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbLastName.Location = new System.Drawing.Point(429, 105);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(149, 26);
            this.tbLastName.TabIndex = 7;
            this.tbLastName.TextChanged += new System.EventHandler(this.tbLastName_TextChanged);
            // 
            // tbFirstName
            // 
            this.tbFirstName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbFirstName.Location = new System.Drawing.Point(174, 105);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(149, 26);
            this.tbFirstName.TabIndex = 6;
            this.tbFirstName.TextChanged += new System.EventHandler(this.tbFirstName_TextChanged);
            // 
            // tbFlyerNumber
            // 
            this.tbFlyerNumber.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbFlyerNumber.Location = new System.Drawing.Point(174, 61);
            this.tbFlyerNumber.Name = "tbFlyerNumber";
            this.tbFlyerNumber.Size = new System.Drawing.Size(149, 26);
            this.tbFlyerNumber.TabIndex = 2;
            this.tbFlyerNumber.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Age:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "First Name:";
            // 
            // lblFlyerNumber
            // 
            this.lblFlyerNumber.AutoSize = true;
            this.lblFlyerNumber.Location = new System.Drawing.Point(57, 67);
            this.lblFlyerNumber.Name = "lblFlyerNumber";
            this.lblFlyerNumber.Size = new System.Drawing.Size(111, 20);
            this.lblFlyerNumber.TabIndex = 1;
            this.lblFlyerNumber.Text = "Flyer Number: ";
            this.lblFlyerNumber.Visible = false;
            // 
            // cbFrequentFlyer
            // 
            this.cbFrequentFlyer.AutoSize = true;
            this.cbFrequentFlyer.Location = new System.Drawing.Point(37, 18);
            this.cbFrequentFlyer.Name = "cbFrequentFlyer";
            this.cbFrequentFlyer.Size = new System.Drawing.Size(131, 24);
            this.cbFrequentFlyer.TabIndex = 0;
            this.cbFrequentFlyer.Text = "Frequent Flyer";
            this.cbFrequentFlyer.UseVisualStyleBackColor = true;
            this.cbFrequentFlyer.CheckedChanged += new System.EventHandler(this.cbFrequentFlyer_CheckedChanged);
            // 
            // tpSearchFlight
            // 
            this.tpSearchFlight.BackColor = System.Drawing.Color.Transparent;
            this.tpSearchFlight.BackgroundImage = global::TravelReservationSystem.Properties.Resources.background;
            this.tpSearchFlight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpSearchFlight.Controls.Add(this.label2);
            this.tpSearchFlight.Controls.Add(this.cbFlightList);
            this.tpSearchFlight.Controls.Add(this.tbDestination);
            this.tpSearchFlight.Controls.Add(this.tbOrigin);
            this.tpSearchFlight.Controls.Add(this.dateTimePickerReturnDate);
            this.tpSearchFlight.Controls.Add(this.dateTimePickerLeaveDate);
            this.tpSearchFlight.Controls.Add(this.lblReturnDate);
            this.tpSearchFlight.Controls.Add(this.label1);
            this.tpSearchFlight.Controls.Add(this.lblTo);
            this.tpSearchFlight.Controls.Add(this.lblFrom);
            this.tpSearchFlight.Controls.Add(this.gbFlightType);
            this.tpSearchFlight.Location = new System.Drawing.Point(4, 29);
            this.tpSearchFlight.Name = "tpSearchFlight";
            this.tpSearchFlight.Size = new System.Drawing.Size(762, 318);
            this.tpSearchFlight.TabIndex = 0;
            this.tpSearchFlight.Text = "Search Flight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Flights";
            // 
            // cbFlightList
            // 
            this.cbFlightList.FormattingEnabled = true;
            this.cbFlightList.Items.AddRange(new object[] {
            "",
            "AZ3 6DS - Toronto to Japan",
            "JF4 FRE - Vancouver to China",
            "54G F8E - Toronto to China",
            "46F 5DS - Korea to Japan",
            "BNM 978 - London to Toronto"});
            this.cbFlightList.Location = new System.Drawing.Point(136, 101);
            this.cbFlightList.Name = "cbFlightList";
            this.cbFlightList.Size = new System.Drawing.Size(273, 28);
            this.cbFlightList.TabIndex = 19;
            this.cbFlightList.SelectedIndexChanged += new System.EventHandler(this.cbFlightList_SelectedIndexChanged);
            // 
            // tbDestination
            // 
            this.tbDestination.Location = new System.Drawing.Point(442, 157);
            this.tbDestination.Name = "tbDestination";
            this.tbDestination.ReadOnly = true;
            this.tbDestination.Size = new System.Drawing.Size(135, 26);
            this.tbDestination.TabIndex = 18;
            // 
            // tbOrigin
            // 
            this.tbOrigin.Location = new System.Drawing.Point(136, 157);
            this.tbOrigin.Name = "tbOrigin";
            this.tbOrigin.ReadOnly = true;
            this.tbOrigin.Size = new System.Drawing.Size(135, 26);
            this.tbOrigin.TabIndex = 17;
            // 
            // dateTimePickerReturnDate
            // 
            this.dateTimePickerReturnDate.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerReturnDate.Location = new System.Drawing.Point(442, 256);
            this.dateTimePickerReturnDate.Name = "dateTimePickerReturnDate";
            this.dateTimePickerReturnDate.Size = new System.Drawing.Size(99, 26);
            this.dateTimePickerReturnDate.TabIndex = 16;
            this.dateTimePickerReturnDate.Visible = false;
            this.dateTimePickerReturnDate.ValueChanged += new System.EventHandler(this.dateTimePickerReturnDate_ValueChanged);
            // 
            // dateTimePickerLeaveDate
            // 
            this.dateTimePickerLeaveDate.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerLeaveDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerLeaveDate.Location = new System.Drawing.Point(136, 256);
            this.dateTimePickerLeaveDate.Name = "dateTimePickerLeaveDate";
            this.dateTimePickerLeaveDate.Size = new System.Drawing.Size(99, 26);
            this.dateTimePickerLeaveDate.TabIndex = 11;
            this.dateTimePickerLeaveDate.ValueChanged += new System.EventHandler(this.dateTimePickerLeaveDate_ValueChanged);
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Location = new System.Drawing.Point(346, 217);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(83, 20);
            this.lblReturnDate.TabIndex = 8;
            this.lblReturnDate.Text = "Return On";
            this.lblReturnDate.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Leaving On";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(346, 160);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(90, 20);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "Destination";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(71, 163);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(50, 20);
            this.lblFrom.TabIndex = 1;
            this.lblFrom.Text = "Origin";
            // 
            // gbFlightType
            // 
            this.gbFlightType.BackColor = System.Drawing.Color.Transparent;
            this.gbFlightType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbFlightType.Controls.Add(this.rbOneWay);
            this.gbFlightType.Controls.Add(this.rbRoundTrip);
            this.gbFlightType.Location = new System.Drawing.Point(24, 25);
            this.gbFlightType.Name = "gbFlightType";
            this.gbFlightType.Size = new System.Drawing.Size(264, 48);
            this.gbFlightType.TabIndex = 0;
            this.gbFlightType.TabStop = false;
            this.gbFlightType.Text = "Flight Type";
            // 
            // rbOneWay
            // 
            this.rbOneWay.AutoSize = true;
            this.rbOneWay.Location = new System.Drawing.Point(14, 19);
            this.rbOneWay.Name = "rbOneWay";
            this.rbOneWay.Size = new System.Drawing.Size(92, 24);
            this.rbOneWay.TabIndex = 1;
            this.rbOneWay.Text = "One Way";
            this.rbOneWay.UseVisualStyleBackColor = true;
            this.rbOneWay.CheckedChanged += new System.EventHandler(this.rbOneWay_CheckedChanged);
            // 
            // rbRoundTrip
            // 
            this.rbRoundTrip.AutoSize = true;
            this.rbRoundTrip.Location = new System.Drawing.Point(136, 19);
            this.rbRoundTrip.Name = "rbRoundTrip";
            this.rbRoundTrip.Size = new System.Drawing.Size(105, 24);
            this.rbRoundTrip.TabIndex = 0;
            this.rbRoundTrip.Text = "Round Trip";
            this.rbRoundTrip.UseVisualStyleBackColor = true;
            this.rbRoundTrip.CheckedChanged += new System.EventHandler(this.rbRoundTrip_CheckedChanged);
            // 
            // tabMainControl
            // 
            this.tabMainControl.Controls.Add(this.tpSearchFlight);
            this.tabMainControl.Controls.Add(this.tpPassengerInfo);
            this.tabMainControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMainControl.Location = new System.Drawing.Point(18, 63);
            this.tabMainControl.Name = "tabMainControl";
            this.tabMainControl.SelectedIndex = 0;
            this.tabMainControl.Size = new System.Drawing.Size(770, 351);
            this.tabMainControl.TabIndex = 13;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(22, 444);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(95, 29);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnBookFlight
            // 
            this.btnBookFlight.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBookFlight.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnBookFlight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBookFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookFlight.Location = new System.Drawing.Point(689, 444);
            this.btnBookFlight.Name = "btnBookFlight";
            this.btnBookFlight.Size = new System.Drawing.Size(95, 29);
            this.btnBookFlight.TabIndex = 15;
            this.btnBookFlight.Text = "Book Now";
            this.btnBookFlight.UseVisualStyleBackColor = false;
            this.btnBookFlight.Click += new System.EventHandler(this.btnBookFlight_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::TravelReservationSystem.Properties.Resources.logo2;
            this.pictureBox1.Image = global::TravelReservationSystem.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(202, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle2.Font = new System.Drawing.Font("Microsoft Uighur", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTitle2.Location = new System.Drawing.Point(86, 9);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(126, 57);
            this.lblTitle2.TabIndex = 22;
            this.lblTitle2.Text = "Flights";
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblErrorMessage.Location = new System.Drawing.Point(43, 417);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(13, 20);
            this.lblErrorMessage.TabIndex = 23;
            this.lblErrorMessage.Text = " ";
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(219)))), ((int)(((byte)(240)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.tabMainControl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.btnBookFlight);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTitle2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SafeFlight Airlines";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tpPassengerInfo.ResumeLayout(false);
            this.tpPassengerInfo.PerformLayout();
            this.tpSearchFlight.ResumeLayout(false);
            this.tpSearchFlight.PerformLayout();
            this.gbFlightType.ResumeLayout(false);
            this.gbFlightType.PerformLayout();
            this.tabMainControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabPage tpPassengerInfo;
        private System.Windows.Forms.Button btnAutoFill;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbFlyerNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFlyerNumber;
        private System.Windows.Forms.CheckBox cbFrequentFlyer;
        private System.Windows.Forms.TabPage tpSearchFlight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFlightList;
        private System.Windows.Forms.TextBox tbDestination;
        private System.Windows.Forms.TextBox tbOrigin;
        private System.Windows.Forms.DateTimePicker dateTimePickerReturnDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerLeaveDate;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.GroupBox gbFlightType;
        private System.Windows.Forms.RadioButton rbOneWay;
        private System.Windows.Forms.RadioButton rbRoundTrip;
        private System.Windows.Forms.TabControl tabMainControl;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnBookFlight;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblErrorMessage;
    }
}

