namespace NorthIslandRacing
{
    partial class MeetingsReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeetingsReportForm));
            this.btnPrintMeetings = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.printMeetings = new System.Drawing.Printing.PrintDocument();
            this.prvMeetings = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // btnPrintMeetings
            // 
            this.btnPrintMeetings.Location = new System.Drawing.Point(43, 45);
            this.btnPrintMeetings.Name = "btnPrintMeetings";
            this.btnPrintMeetings.Size = new System.Drawing.Size(202, 49);
            this.btnPrintMeetings.TabIndex = 0;
            this.btnPrintMeetings.Text = "Print Meetings";
            this.btnPrintMeetings.UseVisualStyleBackColor = true;
            this.btnPrintMeetings.Click += new System.EventHandler(this.btnPrintMeetings_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(294, 45);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(202, 49);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // printMeetings
            // 
            this.printMeetings.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printMeetings_PrintPage);
            // 
            // prvMeetings
            // 
            this.prvMeetings.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.prvMeetings.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.prvMeetings.ClientSize = new System.Drawing.Size(400, 300);
            this.prvMeetings.Document = this.printMeetings;
            this.prvMeetings.Enabled = true;
            this.prvMeetings.Icon = ((System.Drawing.Icon)(resources.GetObject("prvMeetings.Icon")));
            this.prvMeetings.Name = "prvMeetings";
            this.prvMeetings.Visible = false;
            // 
            // MeetingsReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 154);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnPrintMeetings);
            this.Name = "MeetingsReportForm";
            this.Text = "Meetings Report";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrintMeetings;
        private System.Windows.Forms.Button btnReturn;
        private System.Drawing.Printing.PrintDocument printMeetings;
        private System.Windows.Forms.PrintPreviewDialog prvMeetings;
    }
}