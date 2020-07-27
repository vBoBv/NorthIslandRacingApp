namespace NorthIslandRacing
{
    partial class RaceForm
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
            this.txtRaceCapacity = new System.Windows.Forms.TextBox();
            this.lblRaceCapacity = new System.Windows.Forms.Label();
            this.txtRaceStatus = new System.Windows.Forms.TextBox();
            this.lblRaceStatus = new System.Windows.Forms.Label();
            this.txtRaceTime = new System.Windows.Forms.TextBox();
            this.lblRaceTime = new System.Windows.Forms.Label();
            this.txtRaceMeetingName = new System.Windows.Forms.TextBox();
            this.lblRaceMeetingName = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDeleteRace = new System.Windows.Forms.Button();
            this.btnUpdateRace = new System.Windows.Forms.Button();
            this.btnAddRace = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.txtRaceMeetingID = new System.Windows.Forms.TextBox();
            this.txtRaceName = new System.Windows.Forms.TextBox();
            this.lblRaceMeetingID = new System.Windows.Forms.Label();
            this.lblRaceName = new System.Windows.Forms.Label();
            this.lblRaceID = new System.Windows.Forms.Label();
            this.lblRaceNo = new System.Windows.Forms.Label();
            this.lstRaces = new System.Windows.Forms.ListBox();
            this.btnMarkRaceAsFinished = new System.Windows.Forms.Button();
            this.btnMarkRaceAsComplete = new System.Windows.Forms.Button();
            this.pnlAddRace = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveRace = new System.Windows.Forms.Button();
            this.npAddRaceCapacity = new System.Windows.Forms.NumericUpDown();
            this.cboAddRaceStatus = new System.Windows.Forms.ComboBox();
            this.txtAddRaceTime = new System.Windows.Forms.TextBox();
            this.cboAddRaceMeetingName = new System.Windows.Forms.ComboBox();
            this.cboAddRaceMeetingID = new System.Windows.Forms.ComboBox();
            this.txtAddRaceName = new System.Windows.Forms.TextBox();
            this.lblAddRaceCapacity = new System.Windows.Forms.Label();
            this.lblAddRaceStatus = new System.Windows.Forms.Label();
            this.lblAddRaceTime = new System.Windows.Forms.Label();
            this.lblAddRaceMeeting = new System.Windows.Forms.Label();
            this.lblAddRaceName = new System.Windows.Forms.Label();
            this.pnlUpdateRace = new System.Windows.Forms.Panel();
            this.npUpdateRaceCapacity = new System.Windows.Forms.NumericUpDown();
            this.btnCancelUpdateRace = new System.Windows.Forms.Button();
            this.btnSaveUpdateRace = new System.Windows.Forms.Button();
            this.txtUpdateRaceStatus = new System.Windows.Forms.TextBox();
            this.txtUpdateRaceTime = new System.Windows.Forms.TextBox();
            this.lblUpdateRaceMeetingName = new System.Windows.Forms.Label();
            this.txtUpdateRaceMeetingName = new System.Windows.Forms.TextBox();
            this.txtUpdateRaceName = new System.Windows.Forms.TextBox();
            this.txtUpdateRaceID = new System.Windows.Forms.TextBox();
            this.lblUpdateRaceCapacity = new System.Windows.Forms.Label();
            this.lblUpdateRaceStatus = new System.Windows.Forms.Label();
            this.lblUpdateRaceTime = new System.Windows.Forms.Label();
            this.lblUpdateRaceName = new System.Windows.Forms.Label();
            this.lblUpdateRaceID = new System.Windows.Forms.Label();
            this.pnlAddRace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npAddRaceCapacity)).BeginInit();
            this.pnlUpdateRace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npUpdateRaceCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRaceCapacity
            // 
            this.txtRaceCapacity.Location = new System.Drawing.Point(456, 227);
            this.txtRaceCapacity.Name = "txtRaceCapacity";
            this.txtRaceCapacity.ReadOnly = true;
            this.txtRaceCapacity.Size = new System.Drawing.Size(229, 20);
            this.txtRaceCapacity.TabIndex = 76;
            // 
            // lblRaceCapacity
            // 
            this.lblRaceCapacity.AutoSize = true;
            this.lblRaceCapacity.Location = new System.Drawing.Point(373, 227);
            this.lblRaceCapacity.Name = "lblRaceCapacity";
            this.lblRaceCapacity.Size = new System.Drawing.Size(51, 13);
            this.lblRaceCapacity.TabIndex = 74;
            this.lblRaceCapacity.Text = "Capacity:";
            // 
            // txtRaceStatus
            // 
            this.txtRaceStatus.Location = new System.Drawing.Point(455, 192);
            this.txtRaceStatus.Name = "txtRaceStatus";
            this.txtRaceStatus.ReadOnly = true;
            this.txtRaceStatus.Size = new System.Drawing.Size(229, 20);
            this.txtRaceStatus.TabIndex = 73;
            // 
            // lblRaceStatus
            // 
            this.lblRaceStatus.AutoSize = true;
            this.lblRaceStatus.Location = new System.Drawing.Point(384, 195);
            this.lblRaceStatus.Name = "lblRaceStatus";
            this.lblRaceStatus.Size = new System.Drawing.Size(40, 13);
            this.lblRaceStatus.TabIndex = 72;
            this.lblRaceStatus.Text = "Status:";
            // 
            // txtRaceTime
            // 
            this.txtRaceTime.Location = new System.Drawing.Point(455, 159);
            this.txtRaceTime.Name = "txtRaceTime";
            this.txtRaceTime.ReadOnly = true;
            this.txtRaceTime.Size = new System.Drawing.Size(230, 20);
            this.txtRaceTime.TabIndex = 71;
            // 
            // lblRaceTime
            // 
            this.lblRaceTime.AutoSize = true;
            this.lblRaceTime.Location = new System.Drawing.Point(362, 162);
            this.lblRaceTime.Name = "lblRaceTime";
            this.lblRaceTime.Size = new System.Drawing.Size(62, 13);
            this.lblRaceTime.TabIndex = 70;
            this.lblRaceTime.Text = "Race Time:";
            // 
            // txtRaceMeetingName
            // 
            this.txtRaceMeetingName.Location = new System.Drawing.Point(455, 129);
            this.txtRaceMeetingName.Name = "txtRaceMeetingName";
            this.txtRaceMeetingName.ReadOnly = true;
            this.txtRaceMeetingName.Size = new System.Drawing.Size(230, 20);
            this.txtRaceMeetingName.TabIndex = 69;
            // 
            // lblRaceMeetingName
            // 
            this.lblRaceMeetingName.AutoSize = true;
            this.lblRaceMeetingName.Location = new System.Drawing.Point(345, 132);
            this.lblRaceMeetingName.Name = "lblRaceMeetingName";
            this.lblRaceMeetingName.Size = new System.Drawing.Size(79, 13);
            this.lblRaceMeetingName.TabIndex = 68;
            this.lblRaceMeetingName.Text = "Meeting Name:";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(747, 403);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(151, 23);
            this.btnReturn.TabIndex = 67;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDeleteRace
            // 
            this.btnDeleteRace.Location = new System.Drawing.Point(747, 358);
            this.btnDeleteRace.Name = "btnDeleteRace";
            this.btnDeleteRace.Size = new System.Drawing.Size(151, 23);
            this.btnDeleteRace.TabIndex = 66;
            this.btnDeleteRace.Text = "Delete Race";
            this.btnDeleteRace.UseVisualStyleBackColor = true;
            this.btnDeleteRace.Click += new System.EventHandler(this.btnDeleteRace_Click);
            // 
            // btnUpdateRace
            // 
            this.btnUpdateRace.Location = new System.Drawing.Point(572, 358);
            this.btnUpdateRace.Name = "btnUpdateRace";
            this.btnUpdateRace.Size = new System.Drawing.Size(151, 23);
            this.btnUpdateRace.TabIndex = 65;
            this.btnUpdateRace.Text = "Update Race";
            this.btnUpdateRace.UseVisualStyleBackColor = true;
            this.btnUpdateRace.Click += new System.EventHandler(this.btnUpdateRace_Click);
            // 
            // btnAddRace
            // 
            this.btnAddRace.Location = new System.Drawing.Point(391, 358);
            this.btnAddRace.Name = "btnAddRace";
            this.btnAddRace.Size = new System.Drawing.Size(151, 23);
            this.btnAddRace.TabIndex = 64;
            this.btnAddRace.Text = "Add Race";
            this.btnAddRace.UseVisualStyleBackColor = true;
            this.btnAddRace.Click += new System.EventHandler(this.btnAddRace_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(211, 358);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(151, 23);
            this.btnNext.TabIndex = 63;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(29, 358);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(151, 23);
            this.btnPrevious.TabIndex = 62;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // txtRaceMeetingID
            // 
            this.txtRaceMeetingID.Location = new System.Drawing.Point(455, 98);
            this.txtRaceMeetingID.Name = "txtRaceMeetingID";
            this.txtRaceMeetingID.ReadOnly = true;
            this.txtRaceMeetingID.Size = new System.Drawing.Size(229, 20);
            this.txtRaceMeetingID.TabIndex = 61;
            this.txtRaceMeetingID.TextChanged += new System.EventHandler(this.txtRaceMeetingID_TextChanged);
            // 
            // txtRaceName
            // 
            this.txtRaceName.Location = new System.Drawing.Point(455, 68);
            this.txtRaceName.Name = "txtRaceName";
            this.txtRaceName.ReadOnly = true;
            this.txtRaceName.Size = new System.Drawing.Size(229, 20);
            this.txtRaceName.TabIndex = 60;
            // 
            // lblRaceMeetingID
            // 
            this.lblRaceMeetingID.AutoSize = true;
            this.lblRaceMeetingID.Location = new System.Drawing.Point(362, 101);
            this.lblRaceMeetingID.Name = "lblRaceMeetingID";
            this.lblRaceMeetingID.Size = new System.Drawing.Size(62, 13);
            this.lblRaceMeetingID.TabIndex = 59;
            this.lblRaceMeetingID.Text = "Meeting ID:";
            // 
            // lblRaceName
            // 
            this.lblRaceName.AutoSize = true;
            this.lblRaceName.Location = new System.Drawing.Point(357, 71);
            this.lblRaceName.Name = "lblRaceName";
            this.lblRaceName.Size = new System.Drawing.Size(67, 13);
            this.lblRaceName.TabIndex = 58;
            this.lblRaceName.Text = "Race Name:";
            // 
            // lblRaceID
            // 
            this.lblRaceID.AutoSize = true;
            this.lblRaceID.Location = new System.Drawing.Point(452, 45);
            this.lblRaceID.Name = "lblRaceID";
            this.lblRaceID.Size = new System.Drawing.Size(23, 13);
            this.lblRaceID.TabIndex = 57;
            this.lblRaceID.Text = "null";
            // 
            // lblRaceNo
            // 
            this.lblRaceNo.AutoSize = true;
            this.lblRaceNo.Location = new System.Drawing.Point(374, 45);
            this.lblRaceNo.Name = "lblRaceNo";
            this.lblRaceNo.Size = new System.Drawing.Size(50, 13);
            this.lblRaceNo.TabIndex = 56;
            this.lblRaceNo.Text = "Race ID:";
            // 
            // lstRaces
            // 
            this.lstRaces.FormattingEnabled = true;
            this.lstRaces.Location = new System.Drawing.Point(28, 20);
            this.lstRaces.Name = "lstRaces";
            this.lstRaces.Size = new System.Drawing.Size(267, 303);
            this.lstRaces.TabIndex = 55;
            // 
            // btnMarkRaceAsFinished
            // 
            this.btnMarkRaceAsFinished.Location = new System.Drawing.Point(29, 403);
            this.btnMarkRaceAsFinished.Name = "btnMarkRaceAsFinished";
            this.btnMarkRaceAsFinished.Size = new System.Drawing.Size(333, 23);
            this.btnMarkRaceAsFinished.TabIndex = 77;
            this.btnMarkRaceAsFinished.Text = "Mark Race as Finished";
            this.btnMarkRaceAsFinished.UseVisualStyleBackColor = true;
            this.btnMarkRaceAsFinished.Click += new System.EventHandler(this.btnMarkRaceAsFinished_Click);
            // 
            // btnMarkRaceAsComplete
            // 
            this.btnMarkRaceAsComplete.Location = new System.Drawing.Point(391, 403);
            this.btnMarkRaceAsComplete.Name = "btnMarkRaceAsComplete";
            this.btnMarkRaceAsComplete.Size = new System.Drawing.Size(333, 23);
            this.btnMarkRaceAsComplete.TabIndex = 78;
            this.btnMarkRaceAsComplete.Text = "Mark Race as Complete";
            this.btnMarkRaceAsComplete.UseVisualStyleBackColor = true;
            this.btnMarkRaceAsComplete.Click += new System.EventHandler(this.btnMarkRaceAsComplete_Click);
            // 
            // pnlAddRace
            // 
            this.pnlAddRace.Controls.Add(this.btnCancel);
            this.pnlAddRace.Controls.Add(this.btnSaveRace);
            this.pnlAddRace.Controls.Add(this.npAddRaceCapacity);
            this.pnlAddRace.Controls.Add(this.cboAddRaceStatus);
            this.pnlAddRace.Controls.Add(this.txtAddRaceTime);
            this.pnlAddRace.Controls.Add(this.cboAddRaceMeetingName);
            this.pnlAddRace.Controls.Add(this.cboAddRaceMeetingID);
            this.pnlAddRace.Controls.Add(this.txtAddRaceName);
            this.pnlAddRace.Controls.Add(this.lblAddRaceCapacity);
            this.pnlAddRace.Controls.Add(this.lblAddRaceStatus);
            this.pnlAddRace.Controls.Add(this.lblAddRaceTime);
            this.pnlAddRace.Controls.Add(this.lblAddRaceMeeting);
            this.pnlAddRace.Controls.Add(this.lblAddRaceName);
            this.pnlAddRace.Location = new System.Drawing.Point(313, 20);
            this.pnlAddRace.Name = "pnlAddRace";
            this.pnlAddRace.Size = new System.Drawing.Size(615, 251);
            this.pnlAddRace.TabIndex = 79;
            this.pnlAddRace.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(434, 191);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(151, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveRace
            // 
            this.btnSaveRace.Location = new System.Drawing.Point(78, 191);
            this.btnSaveRace.Name = "btnSaveRace";
            this.btnSaveRace.Size = new System.Drawing.Size(151, 23);
            this.btnSaveRace.TabIndex = 11;
            this.btnSaveRace.Text = "Save Race";
            this.btnSaveRace.UseVisualStyleBackColor = true;
            this.btnSaveRace.Click += new System.EventHandler(this.btnSaveRace_Click);
            // 
            // npAddRaceCapacity
            // 
            this.npAddRaceCapacity.Location = new System.Drawing.Point(201, 144);
            this.npAddRaceCapacity.Name = "npAddRaceCapacity";
            this.npAddRaceCapacity.Size = new System.Drawing.Size(179, 20);
            this.npAddRaceCapacity.TabIndex = 10;
            // 
            // cboAddRaceStatus
            // 
            this.cboAddRaceStatus.FormattingEnabled = true;
            this.cboAddRaceStatus.Items.AddRange(new object[] {
            "Scheduled",
            "Finished",
            "Completed"});
            this.cboAddRaceStatus.Location = new System.Drawing.Point(201, 113);
            this.cboAddRaceStatus.Name = "cboAddRaceStatus";
            this.cboAddRaceStatus.Size = new System.Drawing.Size(179, 21);
            this.cboAddRaceStatus.TabIndex = 9;
            this.cboAddRaceStatus.Text = "Scheduled";
            // 
            // txtAddRaceTime
            // 
            this.txtAddRaceTime.Location = new System.Drawing.Point(201, 85);
            this.txtAddRaceTime.Name = "txtAddRaceTime";
            this.txtAddRaceTime.Size = new System.Drawing.Size(179, 20);
            this.txtAddRaceTime.TabIndex = 8;
            // 
            // cboAddRaceMeetingName
            // 
            this.cboAddRaceMeetingName.FormattingEnabled = true;
            this.cboAddRaceMeetingName.Location = new System.Drawing.Point(259, 52);
            this.cboAddRaceMeetingName.Name = "cboAddRaceMeetingName";
            this.cboAddRaceMeetingName.Size = new System.Drawing.Size(121, 21);
            this.cboAddRaceMeetingName.TabIndex = 7;
            // 
            // cboAddRaceMeetingID
            // 
            this.cboAddRaceMeetingID.FormattingEnabled = true;
            this.cboAddRaceMeetingID.Location = new System.Drawing.Point(201, 52);
            this.cboAddRaceMeetingID.Name = "cboAddRaceMeetingID";
            this.cboAddRaceMeetingID.Size = new System.Drawing.Size(42, 21);
            this.cboAddRaceMeetingID.TabIndex = 6;
            // 
            // txtAddRaceName
            // 
            this.txtAddRaceName.Location = new System.Drawing.Point(201, 22);
            this.txtAddRaceName.Name = "txtAddRaceName";
            this.txtAddRaceName.Size = new System.Drawing.Size(179, 20);
            this.txtAddRaceName.TabIndex = 5;
            // 
            // lblAddRaceCapacity
            // 
            this.lblAddRaceCapacity.AutoSize = true;
            this.lblAddRaceCapacity.Location = new System.Drawing.Point(82, 146);
            this.lblAddRaceCapacity.Name = "lblAddRaceCapacity";
            this.lblAddRaceCapacity.Size = new System.Drawing.Size(51, 13);
            this.lblAddRaceCapacity.TabIndex = 4;
            this.lblAddRaceCapacity.Text = "Capacity:";
            // 
            // lblAddRaceStatus
            // 
            this.lblAddRaceStatus.AutoSize = true;
            this.lblAddRaceStatus.Location = new System.Drawing.Point(93, 116);
            this.lblAddRaceStatus.Name = "lblAddRaceStatus";
            this.lblAddRaceStatus.Size = new System.Drawing.Size(40, 13);
            this.lblAddRaceStatus.TabIndex = 3;
            this.lblAddRaceStatus.Text = "Status:";
            // 
            // lblAddRaceTime
            // 
            this.lblAddRaceTime.AutoSize = true;
            this.lblAddRaceTime.Location = new System.Drawing.Point(71, 85);
            this.lblAddRaceTime.Name = "lblAddRaceTime";
            this.lblAddRaceTime.Size = new System.Drawing.Size(62, 13);
            this.lblAddRaceTime.TabIndex = 2;
            this.lblAddRaceTime.Text = "Race Time:";
            // 
            // lblAddRaceMeeting
            // 
            this.lblAddRaceMeeting.AutoSize = true;
            this.lblAddRaceMeeting.Location = new System.Drawing.Point(85, 55);
            this.lblAddRaceMeeting.Name = "lblAddRaceMeeting";
            this.lblAddRaceMeeting.Size = new System.Drawing.Size(48, 13);
            this.lblAddRaceMeeting.TabIndex = 1;
            this.lblAddRaceMeeting.Text = "Meeting:";
            // 
            // lblAddRaceName
            // 
            this.lblAddRaceName.AutoSize = true;
            this.lblAddRaceName.Location = new System.Drawing.Point(66, 25);
            this.lblAddRaceName.Name = "lblAddRaceName";
            this.lblAddRaceName.Size = new System.Drawing.Size(67, 13);
            this.lblAddRaceName.TabIndex = 0;
            this.lblAddRaceName.Text = "Race Name:";
            // 
            // pnlUpdateRace
            // 
            this.pnlUpdateRace.Controls.Add(this.npUpdateRaceCapacity);
            this.pnlUpdateRace.Controls.Add(this.btnCancelUpdateRace);
            this.pnlUpdateRace.Controls.Add(this.btnSaveUpdateRace);
            this.pnlUpdateRace.Controls.Add(this.txtUpdateRaceStatus);
            this.pnlUpdateRace.Controls.Add(this.txtUpdateRaceTime);
            this.pnlUpdateRace.Controls.Add(this.lblUpdateRaceMeetingName);
            this.pnlUpdateRace.Controls.Add(this.txtUpdateRaceMeetingName);
            this.pnlUpdateRace.Controls.Add(this.txtUpdateRaceName);
            this.pnlUpdateRace.Controls.Add(this.txtUpdateRaceID);
            this.pnlUpdateRace.Controls.Add(this.lblUpdateRaceCapacity);
            this.pnlUpdateRace.Controls.Add(this.lblUpdateRaceStatus);
            this.pnlUpdateRace.Controls.Add(this.lblUpdateRaceTime);
            this.pnlUpdateRace.Controls.Add(this.lblUpdateRaceName);
            this.pnlUpdateRace.Controls.Add(this.lblUpdateRaceID);
            this.pnlUpdateRace.Location = new System.Drawing.Point(310, 20);
            this.pnlUpdateRace.Name = "pnlUpdateRace";
            this.pnlUpdateRace.Size = new System.Drawing.Size(615, 276);
            this.pnlUpdateRace.TabIndex = 13;
            this.pnlUpdateRace.Visible = false;
            // 
            // npUpdateRaceCapacity
            // 
            this.npUpdateRaceCapacity.Location = new System.Drawing.Point(183, 186);
            this.npUpdateRaceCapacity.Name = "npUpdateRaceCapacity";
            this.npUpdateRaceCapacity.Size = new System.Drawing.Size(100, 20);
            this.npUpdateRaceCapacity.TabIndex = 14;
            // 
            // btnCancelUpdateRace
            // 
            this.btnCancelUpdateRace.Location = new System.Drawing.Point(434, 227);
            this.btnCancelUpdateRace.Name = "btnCancelUpdateRace";
            this.btnCancelUpdateRace.Size = new System.Drawing.Size(151, 23);
            this.btnCancelUpdateRace.TabIndex = 13;
            this.btnCancelUpdateRace.Text = "Cancel";
            this.btnCancelUpdateRace.UseVisualStyleBackColor = true;
            this.btnCancelUpdateRace.Click += new System.EventHandler(this.btnCancelUpdateRace_Click);
            // 
            // btnSaveUpdateRace
            // 
            this.btnSaveUpdateRace.Location = new System.Drawing.Point(78, 227);
            this.btnSaveUpdateRace.Name = "btnSaveUpdateRace";
            this.btnSaveUpdateRace.Size = new System.Drawing.Size(151, 23);
            this.btnSaveUpdateRace.TabIndex = 12;
            this.btnSaveUpdateRace.Text = "Save Changes";
            this.btnSaveUpdateRace.UseVisualStyleBackColor = true;
            this.btnSaveUpdateRace.Click += new System.EventHandler(this.btnSaveUpdateRace_Click);
            // 
            // txtUpdateRaceStatus
            // 
            this.txtUpdateRaceStatus.Location = new System.Drawing.Point(183, 156);
            this.txtUpdateRaceStatus.Name = "txtUpdateRaceStatus";
            this.txtUpdateRaceStatus.ReadOnly = true;
            this.txtUpdateRaceStatus.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateRaceStatus.TabIndex = 10;
            // 
            // txtUpdateRaceTime
            // 
            this.txtUpdateRaceTime.Location = new System.Drawing.Point(183, 126);
            this.txtUpdateRaceTime.Name = "txtUpdateRaceTime";
            this.txtUpdateRaceTime.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateRaceTime.TabIndex = 9;
            // 
            // lblUpdateRaceMeetingName
            // 
            this.lblUpdateRaceMeetingName.AutoSize = true;
            this.lblUpdateRaceMeetingName.Location = new System.Drawing.Point(37, 94);
            this.lblUpdateRaceMeetingName.Name = "lblUpdateRaceMeetingName";
            this.lblUpdateRaceMeetingName.Size = new System.Drawing.Size(79, 13);
            this.lblUpdateRaceMeetingName.TabIndex = 8;
            this.lblUpdateRaceMeetingName.Text = "Meeting Name:";
            // 
            // txtUpdateRaceMeetingName
            // 
            this.txtUpdateRaceMeetingName.Location = new System.Drawing.Point(183, 91);
            this.txtUpdateRaceMeetingName.Name = "txtUpdateRaceMeetingName";
            this.txtUpdateRaceMeetingName.ReadOnly = true;
            this.txtUpdateRaceMeetingName.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateRaceMeetingName.TabIndex = 7;
            // 
            // txtUpdateRaceName
            // 
            this.txtUpdateRaceName.Location = new System.Drawing.Point(183, 57);
            this.txtUpdateRaceName.Name = "txtUpdateRaceName";
            this.txtUpdateRaceName.Size = new System.Drawing.Size(152, 20);
            this.txtUpdateRaceName.TabIndex = 6;
            // 
            // txtUpdateRaceID
            // 
            this.txtUpdateRaceID.Location = new System.Drawing.Point(183, 26);
            this.txtUpdateRaceID.Name = "txtUpdateRaceID";
            this.txtUpdateRaceID.ReadOnly = true;
            this.txtUpdateRaceID.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateRaceID.TabIndex = 5;
            // 
            // lblUpdateRaceCapacity
            // 
            this.lblUpdateRaceCapacity.AutoSize = true;
            this.lblUpdateRaceCapacity.Location = new System.Drawing.Point(60, 188);
            this.lblUpdateRaceCapacity.Name = "lblUpdateRaceCapacity";
            this.lblUpdateRaceCapacity.Size = new System.Drawing.Size(51, 13);
            this.lblUpdateRaceCapacity.TabIndex = 4;
            this.lblUpdateRaceCapacity.Text = "Capacity:";
            // 
            // lblUpdateRaceStatus
            // 
            this.lblUpdateRaceStatus.AutoSize = true;
            this.lblUpdateRaceStatus.Location = new System.Drawing.Point(71, 159);
            this.lblUpdateRaceStatus.Name = "lblUpdateRaceStatus";
            this.lblUpdateRaceStatus.Size = new System.Drawing.Size(40, 13);
            this.lblUpdateRaceStatus.TabIndex = 3;
            this.lblUpdateRaceStatus.Text = "Status:";
            // 
            // lblUpdateRaceTime
            // 
            this.lblUpdateRaceTime.AutoSize = true;
            this.lblUpdateRaceTime.Location = new System.Drawing.Point(49, 129);
            this.lblUpdateRaceTime.Name = "lblUpdateRaceTime";
            this.lblUpdateRaceTime.Size = new System.Drawing.Size(62, 13);
            this.lblUpdateRaceTime.TabIndex = 2;
            this.lblUpdateRaceTime.Text = "Race Time:";
            // 
            // lblUpdateRaceName
            // 
            this.lblUpdateRaceName.AutoSize = true;
            this.lblUpdateRaceName.Location = new System.Drawing.Point(49, 60);
            this.lblUpdateRaceName.Name = "lblUpdateRaceName";
            this.lblUpdateRaceName.Size = new System.Drawing.Size(67, 13);
            this.lblUpdateRaceName.TabIndex = 1;
            this.lblUpdateRaceName.Text = "Race Name:";
            // 
            // lblUpdateRaceID
            // 
            this.lblUpdateRaceID.AutoSize = true;
            this.lblUpdateRaceID.Location = new System.Drawing.Point(66, 29);
            this.lblUpdateRaceID.Name = "lblUpdateRaceID";
            this.lblUpdateRaceID.Size = new System.Drawing.Size(50, 13);
            this.lblUpdateRaceID.TabIndex = 0;
            this.lblUpdateRaceID.Text = "Race ID:";
            // 
            // RaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 446);
            this.Controls.Add(this.pnlUpdateRace);
            this.Controls.Add(this.pnlAddRace);
            this.Controls.Add(this.btnMarkRaceAsComplete);
            this.Controls.Add(this.btnMarkRaceAsFinished);
            this.Controls.Add(this.txtRaceCapacity);
            this.Controls.Add(this.lblRaceCapacity);
            this.Controls.Add(this.txtRaceStatus);
            this.Controls.Add(this.lblRaceStatus);
            this.Controls.Add(this.txtRaceTime);
            this.Controls.Add(this.lblRaceTime);
            this.Controls.Add(this.txtRaceMeetingName);
            this.Controls.Add(this.lblRaceMeetingName);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteRace);
            this.Controls.Add(this.btnUpdateRace);
            this.Controls.Add(this.btnAddRace);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtRaceMeetingID);
            this.Controls.Add(this.txtRaceName);
            this.Controls.Add(this.lblRaceMeetingID);
            this.Controls.Add(this.lblRaceName);
            this.Controls.Add(this.lblRaceID);
            this.Controls.Add(this.lblRaceNo);
            this.Controls.Add(this.lstRaces);
            this.Name = "RaceForm";
            this.Text = "Race Maintenance";
            this.pnlAddRace.ResumeLayout(false);
            this.pnlAddRace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npAddRaceCapacity)).EndInit();
            this.pnlUpdateRace.ResumeLayout(false);
            this.pnlUpdateRace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npUpdateRaceCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRaceCapacity;
        private System.Windows.Forms.Label lblRaceCapacity;
        private System.Windows.Forms.TextBox txtRaceStatus;
        private System.Windows.Forms.Label lblRaceStatus;
        private System.Windows.Forms.TextBox txtRaceTime;
        private System.Windows.Forms.Label lblRaceTime;
        private System.Windows.Forms.TextBox txtRaceMeetingName;
        private System.Windows.Forms.Label lblRaceMeetingName;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDeleteRace;
        private System.Windows.Forms.Button btnUpdateRace;
        private System.Windows.Forms.Button btnAddRace;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.TextBox txtRaceMeetingID;
        private System.Windows.Forms.TextBox txtRaceName;
        private System.Windows.Forms.Label lblRaceMeetingID;
        private System.Windows.Forms.Label lblRaceName;
        private System.Windows.Forms.Label lblRaceID;
        private System.Windows.Forms.Label lblRaceNo;
        private System.Windows.Forms.ListBox lstRaces;
        private System.Windows.Forms.Button btnMarkRaceAsFinished;
        private System.Windows.Forms.Button btnMarkRaceAsComplete;
        private System.Windows.Forms.Panel pnlAddRace;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveRace;
        private System.Windows.Forms.NumericUpDown npAddRaceCapacity;
        private System.Windows.Forms.ComboBox cboAddRaceStatus;
        private System.Windows.Forms.TextBox txtAddRaceTime;
        private System.Windows.Forms.ComboBox cboAddRaceMeetingName;
        private System.Windows.Forms.ComboBox cboAddRaceMeetingID;
        private System.Windows.Forms.TextBox txtAddRaceName;
        private System.Windows.Forms.Label lblAddRaceCapacity;
        private System.Windows.Forms.Label lblAddRaceStatus;
        private System.Windows.Forms.Label lblAddRaceTime;
        private System.Windows.Forms.Label lblAddRaceMeeting;
        private System.Windows.Forms.Label lblAddRaceName;
        private System.Windows.Forms.Panel pnlUpdateRace;
        private System.Windows.Forms.Button btnSaveUpdateRace;
        private System.Windows.Forms.TextBox txtUpdateRaceStatus;
        private System.Windows.Forms.TextBox txtUpdateRaceTime;
        private System.Windows.Forms.Label lblUpdateRaceMeetingName;
        private System.Windows.Forms.TextBox txtUpdateRaceMeetingName;
        private System.Windows.Forms.TextBox txtUpdateRaceName;
        private System.Windows.Forms.TextBox txtUpdateRaceID;
        private System.Windows.Forms.Label lblUpdateRaceCapacity;
        private System.Windows.Forms.Label lblUpdateRaceStatus;
        private System.Windows.Forms.Label lblUpdateRaceTime;
        private System.Windows.Forms.Label lblUpdateRaceName;
        private System.Windows.Forms.Label lblUpdateRaceID;
        private System.Windows.Forms.Button btnCancelUpdateRace;
        private System.Windows.Forms.NumericUpDown npUpdateRaceCapacity;
    }
}