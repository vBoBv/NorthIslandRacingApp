using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthIslandRacing
{
    public partial class MeetingForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private CurrencyManager cmRaceCourse;


        public MeetingForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();

            pnlAddMeeting.Left = 332;           // Panel position from the left
            pnlAddMeeting.Top = 20;             // Panel position from the top
            pnlUpdateMeeting.Left = 332;        // Panel position from the left
            pnlUpdateMeeting.Top = 20;          // Panel position from the top
        }

        public void BindControls()
        {
            //Populate data into the Main Meeting form panel
            lblMeetingID.DataBindings.Add("Text", DM.dsNorthIslandRacing, "Meeting.MeetingID");
            txtMeetingName.DataBindings.Add("Text", DM.dsNorthIslandRacing, "Meeting.MeetingName");
            txtMeetingRaceCourseID.DataBindings.Add("Text", DM.dsNorthIslandRacing, "Meeting.RaceCourseID");
            txtMeetingRaceCourseName.DataBindings.Add("Text", DM.dsNorthIslandRacing, "RaceCourse.RaceCourseName");
            txtMeetingStatus.DataBindings.Add("Text", DM.dsNorthIslandRacing, "Meeting.Status");
            txtMeetingCapacity.DataBindings.Add("Text", DM.dsNorthIslandRacing, "Meeting.Capacity");
            txtMeetingDate.DataBindings.Add("Text", DM.dsNorthIslandRacing, "Meeting.MeetingDate", true, DataSourceUpdateMode.OnValidation, "", "MM/dd/yy"); //Format the field into date formart

            //Populate data into Update Meeting form panel
            txtUpdateMeetingID.DataBindings.Add("Text", DM.dsNorthIslandRacing, "Meeting.MeetingID");
            txtUpdateMeetingName.DataBindings.Add("Text", DM.dsNorthIslandRacing, "Meeting.MeetingName");
            txtUpdateMeetingRaceCourseID.DataBindings.Add("Text", DM.dsNorthIslandRacing, "Meeting.RaceCourseID");
            txtUpdateMeetingRaceCourseName.DataBindings.Add("Text", DM.dsNorthIslandRacing, "RaceCourse.RaceCourseName");
            cboUpdateMeetingStatus.DataBindings.Add("Text", DM.dsNorthIslandRacing, "Meeting.Status");
            npUpdateMeetingCapacity.DataBindings.Add("Text", DM.dsNorthIslandRacing, "Meeting.Capacity");
            dtpUpdateMeetingDate.DataBindings.Add("Text", DM.dsNorthIslandRacing, "Meeting.MeetingDate");     

            //Populate MeetingName into Meeting list
            lstMeetings.DataSource = DM.dsNorthIslandRacing;
            lstMeetings.DisplayMember = "Meeting.MeetingName";
            lstMeetings.ValueMember = "Meeting.MeetingName";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsNorthIslandRacing, "Meeting"];
            cmRaceCourse = (CurrencyManager)this.BindingContext[DM.dsNorthIslandRacing, "RaceCourse"];
        }

        //Function to navigate forward for Meeting list
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        //Function to navigate backward for Meeting list
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        //Function to close the Main Meeting form panel
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Function to show the Add Meeting form panel
        private void btnAddMeeting_Click(object sender, EventArgs e)
        {
            lstMeetings.Visible = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnUpdateMeeting.Enabled = false;
            btnDeleteMeeting.Enabled = false;
            btnReturn.Enabled = false;

            LoadRaceCourses();
            pnlAddMeeting.Show();
        }

        //Function to close the Add Meeting form panel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddMeeting.Hide();
            lstMeetings.Enabled = true;
            lstMeetings.Visible = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnUpdateMeeting.Enabled = true;
            btnDeleteMeeting.Enabled = true;
            btnReturn.Enabled = true;
        }

        //Function to show the Update Meeting form panel
        private void btnUpdateMeeting_Click(object sender, EventArgs e)
        {
            lstMeetings.Visible = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnAddMeeting.Enabled = false;
            btnDeleteMeeting.Enabled = false;
            btnReturn.Enabled = false;
            pnlUpdateMeeting.Show();
        }

        //Function to close the Update Meeting form panel
        private void btnCancelUpdateMeeting_Click_1(object sender, EventArgs e)
        {
            pnlUpdateMeeting.Hide();
            lstMeetings.Enabled = true;
            lstMeetings.Visible = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnAddMeeting.Enabled = true;
            btnDeleteMeeting.Enabled = true;
            btnReturn.Enabled = true;

            //Reset the textbox fields to empty when user decides to cancel operation
            txtAddMeetingName.Text = String.Empty;
        }

        //Function to get RaceCourseName from Race Course table when user navigate through Meeting list
        private void txtMeetingRaceCourseID_TextChanged(object sender, EventArgs e)
        {
            if (txtMeetingRaceCourseID.Text == "")
            {
                txtMeetingRaceCourseName.Text = "";
                txtUpdateMeetingRaceCourseName.Text = "";
            }
            else
            {
                int aRaceCourseID = Convert.ToInt32(txtMeetingRaceCourseID.Text);                   //Get Race Course ID from the text field
                cmRaceCourse.Position = DM.raceCourseView.Find(aRaceCourseID);                      //Get the position of the Race Course ID using the above variable
                DataRow drRaceCourse = DM.dtRaceCourse.Rows[cmRaceCourse.Position];                 //Get the Race Course record using the found position in Race Course table

                txtMeetingRaceCourseName.Text = drRaceCourse["RaceCourseName"].ToString();          //Set the RaceCourseName to Main Meeting form panel
                txtUpdateMeetingRaceCourseName.Text = drRaceCourse["RaceCourseName"].ToString();    //Set the RaceCourseName to Update Meeting form panel
            }
        }

        //Function to delete the Meeting record
        private void btnDeleteMeeting_Click(object sender, EventArgs e)
        {
            DataRow deleteMeetingRow = DM.dtMeeting.Rows[currencyManager.Position];
            DataRow[] RaceCourseRow = DM.dtRaceCourse.Select("RaceCourseID = " + txtMeetingRaceCourseID.Text);
            if (RaceCourseRow.Length != 0)
            {
                MessageBox.Show("You may only delete meetings that have no races!", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteMeetingRow.Delete();
                    DM.UpdateMeeting(); //Update database
                    MessageBox.Show("Meeting deleted successfully!", "Success");
                }
            }
        }

        //Function to link data in the Race Course Table to the combo boxes
        private void LoadRaceCourses()
        {
            cboAddMeetingRaceCourseID.DataSource = DM.dsNorthIslandRacing;
            cboAddMeetingRaceCourseID.DisplayMember = "RaceCourse.RaceCourseID";
            cboAddMeetingRaceCourseID.ValueMember = "RaceCourse.RaceCourseID";

            cboAddMeetingRaceCourseName.DataSource = DM.dsNorthIslandRacing;
            cboAddMeetingRaceCourseName.DisplayMember = "RaceCourse.RaceCourseName";
            cboAddMeetingRaceCourseName.ValueMember = "RaceCourse.RaceCourseName";
        }

        //Function to save the newly added Meeting record
        private void btnSaveMeeting_Click(object sender, EventArgs e)
        {
            lblMeetingID.Text = null;
            DataRow newMeetingRow = DM.dtMeeting.NewRow();

            if (txtAddMeetingName.Text == "")
            {
                MessageBox.Show("Meeting Name must not be empty!", "Error");
            }
            else if (txtAddMeetingName.Text.Length > 30)
            {
                MessageBox.Show("Meeting Name must not exceed 30 characters!", "Error");
            }
            else if (cboAddMeetingRaceCourseID.Text == "")
            {
                MessageBox.Show("Race Course ID must not be empty!", "Error");
            }
            else if (cboAddMeetingRaceCourseName.Text == "")
            {
                MessageBox.Show("Race Name must not be empty!", "Error");
            }
            else if (cboAddMeetingStatus.Text == "")
            {
                MessageBox.Show("Status must not be empty!", "Error");
            }
            else if (npAddMeetingCapacity.Text == "")
            {
                MessageBox.Show("Capacity must not be empty!", "Error");
            }
            else if (Convert.ToInt32(npAddMeetingCapacity.Text) <= 1000 || Convert.ToInt32(npAddMeetingCapacity.Text) >= 20000)
            {
                MessageBox.Show("Meeting Capacity must be between 1001 and 19999!", "Error");
            }
            else
            {
                try
                {
                    //Set the new record to the new row
                    newMeetingRow["MeetingName"] = txtAddMeetingName.Text;
                    newMeetingRow["RaceCourseID"] = cboAddMeetingRaceCourseID.Text;
                    newMeetingRow["Status"] = cboAddMeetingStatus.Text;
                    newMeetingRow["Capacity"] = Convert.ToInt32(npAddMeetingCapacity.Text);
                    newMeetingRow["MeetingDate"] = dtpAddMeetingDate.Text;

                    DM.dtMeeting.Rows.Add(newMeetingRow);
                    DM.UpdateMeeting(); //Update database
                    MessageBox.Show("Meeting added successfully.", "Success");

                    //Reset textbox field to empty when user successfully save the operation
                    txtAddMeetingName.Text = String.Empty;

                    //Close the Add Meeting form panel and Reset the buttons to its normal state
                    pnlAddMeeting.Hide();
                    lstMeetings.Enabled = true;
                    lstMeetings.Visible = true;
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    btnUpdateMeeting.Enabled = true;
                    btnDeleteMeeting.Enabled = true;
                    btnReturn.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There is an error. Please try again!", "Error");
                }
            }
        }

        //Function to save the modified Meeting record
        private void btnSaveUpdateMeeting_Click(object sender, EventArgs e)
        {
            DataRow updateMeetingRow = DM.dtMeeting.Rows[currencyManager.Position];

            if (txtUpdateMeetingName.Text == "")
            {
                MessageBox.Show("Meeting Name must not be empty!", "Error");
            }
            else if (txtUpdateMeetingName.Text.Length > 30)
            {
                MessageBox.Show("Meeting Name must not exceed 30 characters!", "Error");
            }
            else if (cboUpdateMeetingStatus.Text == "")
            {
                MessageBox.Show("Status must not be empty!", "Error");
            }
            else if (npUpdateMeetingCapacity.Text == "")
            {
                MessageBox.Show("Capacity must not be empty!", "Error");
            }
            else if (Convert.ToInt32(npUpdateMeetingCapacity.Text) <= 1000 || Convert.ToInt32(npUpdateMeetingCapacity.Text) >= 20000)
            {
                MessageBox.Show("Meeting Capacity must be between 1001 and 19999!", "Error");

            }
            else
            {
                try
                {
                    //Add the modified record to the existing record
                    updateMeetingRow["MeetingName"] = txtUpdateMeetingName.Text;
                    updateMeetingRow["Status"] = cboUpdateMeetingStatus.Text;
                    updateMeetingRow["Capacity"] = npUpdateMeetingCapacity.Text;
                    updateMeetingRow["MeetingDate"] = dtpUpdateMeetingDate.Text;

                    currencyManager.EndCurrentEdit();
                    DM.UpdateMeeting(); //Update database
                    MessageBox.Show("Meeting updated successfully.", "Success");

                    //Close Update Meeting form panel and Reset the buttons to its normal state
                    pnlUpdateMeeting.Hide();
                    lstMeetings.Enabled = true;
                    lstMeetings.Visible = true;
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    btnAddMeeting.Enabled = true;
                    btnDeleteMeeting.Enabled = true;
                    btnReturn.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There is an error. Please try again!", "Error");
                }
            }
        }
    }
}
