namespace NorthIslandRacing
{
    partial class MainForm
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
            this.grpReport = new System.Windows.Forms.GroupBox();
            this.btnOwnersReport = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMeetingsReport = new System.Windows.Forms.Button();
            this.grpMaintenance = new System.Windows.Forms.GroupBox();
            this.btnEnterHorseRace = new System.Windows.Forms.Button();
            this.btnHorse = new System.Windows.Forms.Button();
            this.btnOwner = new System.Windows.Forms.Button();
            this.btnRace = new System.Windows.Forms.Button();
            this.btnMeeting = new System.Windows.Forms.Button();
            this.btnRaceCourse = new System.Windows.Forms.Button();
            this.grpReport.SuspendLayout();
            this.grpMaintenance.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpReport
            // 
            this.grpReport.Controls.Add(this.btnOwnersReport);
            this.grpReport.Controls.Add(this.btnExit);
            this.grpReport.Controls.Add(this.btnMeetingsReport);
            this.grpReport.Location = new System.Drawing.Point(410, 28);
            this.grpReport.Name = "grpReport";
            this.grpReport.Size = new System.Drawing.Size(300, 318);
            this.grpReport.TabIndex = 3;
            this.grpReport.TabStop = false;
            this.grpReport.Text = "Reporting";
            // 
            // btnOwnersReport
            // 
            this.btnOwnersReport.Location = new System.Drawing.Point(25, 81);
            this.btnOwnersReport.Name = "btnOwnersReport";
            this.btnOwnersReport.Size = new System.Drawing.Size(251, 23);
            this.btnOwnersReport.TabIndex = 2;
            this.btnOwnersReport.Text = "Owners Report";
            this.btnOwnersReport.UseVisualStyleBackColor = true;
            this.btnOwnersReport.Click += new System.EventHandler(this.btnOwnersReport_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(25, 275);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(251, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMeetingsReport
            // 
            this.btnMeetingsReport.Location = new System.Drawing.Point(25, 35);
            this.btnMeetingsReport.Name = "btnMeetingsReport";
            this.btnMeetingsReport.Size = new System.Drawing.Size(251, 23);
            this.btnMeetingsReport.TabIndex = 0;
            this.btnMeetingsReport.Text = "Meetings Report";
            this.btnMeetingsReport.UseVisualStyleBackColor = true;
            this.btnMeetingsReport.Click += new System.EventHandler(this.btnMeetingsReport_Click);
            // 
            // grpMaintenance
            // 
            this.grpMaintenance.Controls.Add(this.btnEnterHorseRace);
            this.grpMaintenance.Controls.Add(this.btnHorse);
            this.grpMaintenance.Controls.Add(this.btnOwner);
            this.grpMaintenance.Controls.Add(this.btnRace);
            this.grpMaintenance.Controls.Add(this.btnMeeting);
            this.grpMaintenance.Controls.Add(this.btnRaceCourse);
            this.grpMaintenance.Location = new System.Drawing.Point(33, 28);
            this.grpMaintenance.Name = "grpMaintenance";
            this.grpMaintenance.Size = new System.Drawing.Size(300, 318);
            this.grpMaintenance.TabIndex = 2;
            this.grpMaintenance.TabStop = false;
            this.grpMaintenance.Text = "Maintenance";
            // 
            // btnEnterHorseRace
            // 
            this.btnEnterHorseRace.Location = new System.Drawing.Point(17, 275);
            this.btnEnterHorseRace.Name = "btnEnterHorseRace";
            this.btnEnterHorseRace.Size = new System.Drawing.Size(258, 23);
            this.btnEnterHorseRace.TabIndex = 5;
            this.btnEnterHorseRace.Text = "Enter Horses into Races";
            this.btnEnterHorseRace.UseVisualStyleBackColor = true;
            this.btnEnterHorseRace.Click += new System.EventHandler(this.btnEnterHorseRace_Click);
            // 
            // btnHorse
            // 
            this.btnHorse.Location = new System.Drawing.Point(17, 224);
            this.btnHorse.Name = "btnHorse";
            this.btnHorse.Size = new System.Drawing.Size(258, 23);
            this.btnHorse.TabIndex = 4;
            this.btnHorse.Text = "Horse Maintenance";
            this.btnHorse.UseVisualStyleBackColor = true;
            this.btnHorse.Click += new System.EventHandler(this.btnHorse_Click);
            // 
            // btnOwner
            // 
            this.btnOwner.Location = new System.Drawing.Point(17, 175);
            this.btnOwner.Name = "btnOwner";
            this.btnOwner.Size = new System.Drawing.Size(258, 23);
            this.btnOwner.TabIndex = 3;
            this.btnOwner.Text = "Owner Maintenance";
            this.btnOwner.UseVisualStyleBackColor = true;
            this.btnOwner.Click += new System.EventHandler(this.btnOwner_Click);
            // 
            // btnRace
            // 
            this.btnRace.Location = new System.Drawing.Point(17, 126);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(258, 23);
            this.btnRace.TabIndex = 2;
            this.btnRace.Text = "Race Maintenance";
            this.btnRace.UseVisualStyleBackColor = true;
            this.btnRace.Click += new System.EventHandler(this.btnRace_Click);
            // 
            // btnMeeting
            // 
            this.btnMeeting.Location = new System.Drawing.Point(17, 81);
            this.btnMeeting.Name = "btnMeeting";
            this.btnMeeting.Size = new System.Drawing.Size(258, 23);
            this.btnMeeting.TabIndex = 1;
            this.btnMeeting.Text = "Meeting Maintenance";
            this.btnMeeting.UseVisualStyleBackColor = true;
            this.btnMeeting.Click += new System.EventHandler(this.btnMeeting_Click);
            // 
            // btnRaceCourse
            // 
            this.btnRaceCourse.Location = new System.Drawing.Point(17, 35);
            this.btnRaceCourse.Name = "btnRaceCourse";
            this.btnRaceCourse.Size = new System.Drawing.Size(258, 23);
            this.btnRaceCourse.TabIndex = 0;
            this.btnRaceCourse.Text = "Race Course Maintenance";
            this.btnRaceCourse.UseVisualStyleBackColor = true;
            this.btnRaceCourse.Click += new System.EventHandler(this.btnRaceCourse_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 384);
            this.Controls.Add(this.grpReport);
            this.Controls.Add(this.grpMaintenance);
            this.Name = "MainForm";
            this.Text = "Main Menu (By PonhvathVann, 1502538)";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpReport.ResumeLayout(false);
            this.grpMaintenance.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpReport;
        private System.Windows.Forms.Button btnOwnersReport;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMeetingsReport;
        private System.Windows.Forms.GroupBox grpMaintenance;
        private System.Windows.Forms.Button btnEnterHorseRace;
        private System.Windows.Forms.Button btnHorse;
        private System.Windows.Forms.Button btnOwner;
        private System.Windows.Forms.Button btnRace;
        private System.Windows.Forms.Button btnMeeting;
        private System.Windows.Forms.Button btnRaceCourse;
    }
}

