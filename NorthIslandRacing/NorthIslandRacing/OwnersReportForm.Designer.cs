namespace NorthIslandRacing
{
    partial class OwnersReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OwnersReportForm));
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnPrintOwners = new System.Windows.Forms.Button();
            this.printOwners = new System.Drawing.Printing.PrintDocument();
            this.prvOwners = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(296, 53);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(202, 49);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnPrintOwners
            // 
            this.btnPrintOwners.Location = new System.Drawing.Point(45, 53);
            this.btnPrintOwners.Name = "btnPrintOwners";
            this.btnPrintOwners.Size = new System.Drawing.Size(202, 49);
            this.btnPrintOwners.TabIndex = 2;
            this.btnPrintOwners.Text = "Print Owners";
            this.btnPrintOwners.UseVisualStyleBackColor = true;
            this.btnPrintOwners.Click += new System.EventHandler(this.btnPrintOwners_Click);
            // 
            // printOwners
            // 
            this.printOwners.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printOwners_PrintPage);
            // 
            // prvOwners
            // 
            this.prvOwners.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.prvOwners.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.prvOwners.ClientSize = new System.Drawing.Size(400, 300);
            this.prvOwners.Document = this.printOwners;
            this.prvOwners.Enabled = true;
            this.prvOwners.Icon = ((System.Drawing.Icon)(resources.GetObject("prvOwners.Icon")));
            this.prvOwners.Name = "prvOwners";
            this.prvOwners.Visible = false;
            // 
            // OwnersReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 154);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnPrintOwners);
            this.Name = "OwnersReportForm";
            this.Text = "Owners Report";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnPrintOwners;
        private System.Drawing.Printing.PrintDocument printOwners;
        private System.Windows.Forms.PrintPreviewDialog prvOwners;
    }
}