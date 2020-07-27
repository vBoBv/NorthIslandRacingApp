namespace NorthIslandRacing
{
    partial class EnterHorseRaceForm
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
            this.lblOwnerLastName = new System.Windows.Forms.Label();
            this.lblOwnerFirstName = new System.Windows.Forms.Label();
            this.txtOwnerLastName = new System.Windows.Forms.TextBox();
            this.txtOwnerFirstName = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.txtMeetingName = new System.Windows.Forms.TextBox();
            this.btnAddEntry = new System.Windows.Forms.Button();
            this.btnRemoveEntry = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblMeetingName = new System.Windows.Forms.Label();
            this.dgvHorseDetails = new System.Windows.Forms.DataGridView();
            this.dgvRaceDetails = new System.Windows.Forms.DataGridView();
            this.dgvEntryDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorseDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaceDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntryDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOwnerLastName
            // 
            this.lblOwnerLastName.AutoSize = true;
            this.lblOwnerLastName.Location = new System.Drawing.Point(406, 34);
            this.lblOwnerLastName.Name = "lblOwnerLastName";
            this.lblOwnerLastName.Size = new System.Drawing.Size(95, 13);
            this.lblOwnerLastName.TabIndex = 0;
            this.lblOwnerLastName.Text = "Owner Last Name:";
            // 
            // lblOwnerFirstName
            // 
            this.lblOwnerFirstName.AutoSize = true;
            this.lblOwnerFirstName.Location = new System.Drawing.Point(407, 70);
            this.lblOwnerFirstName.Name = "lblOwnerFirstName";
            this.lblOwnerFirstName.Size = new System.Drawing.Size(94, 13);
            this.lblOwnerFirstName.TabIndex = 1;
            this.lblOwnerFirstName.Text = "Owner First Name:";
            // 
            // txtOwnerLastName
            // 
            this.txtOwnerLastName.Location = new System.Drawing.Point(529, 34);
            this.txtOwnerLastName.Name = "txtOwnerLastName";
            this.txtOwnerLastName.ReadOnly = true;
            this.txtOwnerLastName.Size = new System.Drawing.Size(165, 20);
            this.txtOwnerLastName.TabIndex = 2;
            // 
            // txtOwnerFirstName
            // 
            this.txtOwnerFirstName.Location = new System.Drawing.Point(529, 67);
            this.txtOwnerFirstName.Name = "txtOwnerFirstName";
            this.txtOwnerFirstName.ReadOnly = true;
            this.txtOwnerFirstName.Size = new System.Drawing.Size(165, 20);
            this.txtOwnerFirstName.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(461, 106);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status:";
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Confirmed",
            "Pending",
            "Disqualified"});
            this.cboStatus.Location = new System.Drawing.Point(529, 103);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(121, 21);
            this.cboStatus.TabIndex = 5;
            this.cboStatus.Text = "Confirmed";
            // 
            // txtMeetingName
            // 
            this.txtMeetingName.Location = new System.Drawing.Point(336, 340);
            this.txtMeetingName.Name = "txtMeetingName";
            this.txtMeetingName.ReadOnly = true;
            this.txtMeetingName.Size = new System.Drawing.Size(165, 20);
            this.txtMeetingName.TabIndex = 7;
            // 
            // btnAddEntry
            // 
            this.btnAddEntry.Location = new System.Drawing.Point(30, 377);
            this.btnAddEntry.Name = "btnAddEntry";
            this.btnAddEntry.Size = new System.Drawing.Size(165, 23);
            this.btnAddEntry.TabIndex = 8;
            this.btnAddEntry.Text = "Add Entry";
            this.btnAddEntry.UseVisualStyleBackColor = true;
            this.btnAddEntry.Click += new System.EventHandler(this.btnAddEntry_Click);
            // 
            // btnRemoveEntry
            // 
            this.btnRemoveEntry.Location = new System.Drawing.Point(304, 377);
            this.btnRemoveEntry.Name = "btnRemoveEntry";
            this.btnRemoveEntry.Size = new System.Drawing.Size(165, 23);
            this.btnRemoveEntry.TabIndex = 9;
            this.btnRemoveEntry.Text = "Remove Entry";
            this.btnRemoveEntry.UseVisualStyleBackColor = true;
            this.btnRemoveEntry.Click += new System.EventHandler(this.btnRemoveEntry_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(575, 377);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(165, 23);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblMeetingName
            // 
            this.lblMeetingName.AutoSize = true;
            this.lblMeetingName.Location = new System.Drawing.Point(236, 343);
            this.lblMeetingName.Name = "lblMeetingName";
            this.lblMeetingName.Size = new System.Drawing.Size(79, 13);
            this.lblMeetingName.TabIndex = 11;
            this.lblMeetingName.Text = "Meeting Name:";
            // 
            // dgvHorseDetails
            // 
            this.dgvHorseDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorseDetails.Location = new System.Drawing.Point(13, 13);
            this.dgvHorseDetails.Name = "dgvHorseDetails";
            this.dgvHorseDetails.Size = new System.Drawing.Size(370, 150);
            this.dgvHorseDetails.TabIndex = 12;
            this.dgvHorseDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHorseDetails_CellContentClick);
            this.dgvHorseDetails.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvHorseDetails_RowStateChanged);
            // 
            // dgvRaceDetails
            // 
            this.dgvRaceDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaceDetails.Location = new System.Drawing.Point(13, 182);
            this.dgvRaceDetails.Name = "dgvRaceDetails";
            this.dgvRaceDetails.Size = new System.Drawing.Size(418, 141);
            this.dgvRaceDetails.TabIndex = 13;
            this.dgvRaceDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRaceDetails_CellContentClick);
            this.dgvRaceDetails.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvRaceDetails_RowStateChanged);
            // 
            // dgvEntryDetails
            // 
            this.dgvEntryDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntryDetails.Location = new System.Drawing.Point(450, 182);
            this.dgvEntryDetails.Name = "dgvEntryDetails";
            this.dgvEntryDetails.Size = new System.Drawing.Size(290, 141);
            this.dgvEntryDetails.TabIndex = 14;
            // 
            // EnterHorseRaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 426);
            this.Controls.Add(this.dgvEntryDetails);
            this.Controls.Add(this.dgvRaceDetails);
            this.Controls.Add(this.dgvHorseDetails);
            this.Controls.Add(this.lblMeetingName);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRemoveEntry);
            this.Controls.Add(this.btnAddEntry);
            this.Controls.Add(this.txtMeetingName);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtOwnerFirstName);
            this.Controls.Add(this.txtOwnerLastName);
            this.Controls.Add(this.lblOwnerFirstName);
            this.Controls.Add(this.lblOwnerLastName);
            this.Name = "EnterHorseRaceForm";
            this.Text = "Enter Horses into Races";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorseDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaceDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntryDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOwnerLastName;
        private System.Windows.Forms.Label lblOwnerFirstName;
        private System.Windows.Forms.TextBox txtOwnerLastName;
        private System.Windows.Forms.TextBox txtOwnerFirstName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.TextBox txtMeetingName;
        private System.Windows.Forms.Button btnAddEntry;
        private System.Windows.Forms.Button btnRemoveEntry;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblMeetingName;
        private System.Windows.Forms.DataGridView dgvHorseDetails;
        private System.Windows.Forms.DataGridView dgvRaceDetails;
        private System.Windows.Forms.DataGridView dgvEntryDetails;
    }
}