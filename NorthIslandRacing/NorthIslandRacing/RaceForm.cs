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

    public partial class RaceForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private CurrencyManager cmMeeting;

        public RaceForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();

            pnlAddRace.Left = 313;          // Panel position from the left
            pnlAddRace.Top = 20;            // Panel position from the top
            pnlUpdateRace.Left = 313;       // Panel position from the left
            pnlUpdateRace.Top = 20;         // Panel position from the top
        }

        public void BindControls()
        {
            //Populate data into the Main Race form panel
            lblRaceID.DataBindings.Add("Text", DM.dsNorthIslandRacing, "Race.RaceID");
            txtRaceName.DataBindings.Add("Text", DM.dsNorthIslandRacing, "Race.RaceName");
            txtRaceMeetingID.DataBindings.Add("Text", DM.dsNorthIslandRacing, "Race.MeetingID");
            txtRaceTime.DataBindings.Add("Text", DM.dsNorthIslandRacing, "Race.RaceTime", true, DataSourceUpdateMode.OnValidation, "", "hh:mm tt");     //Format the field into time formart
            txtRaceStatus.DataBindings.Add("Text", DM.dsNorthIslandRacing, "Race.Status");
            txtRaceCapacity.DataBindings.Add("Text", DM.dsNorthIslandRacing, "Race.Capacity");

            //Populate data into Update Race form panel
            txtUpdateRaceID.DataBindings.Add("Text", DM.dsNorthIslandRacing, "Race.RaceID");
            txtUpdateRaceName.DataBindings.Add("Text", DM.dsNorthIslandRacing, "Race.RaceName");
            txtUpdateRaceTime.DataBindings.Add("Text", DM.dsNorthIslandRacing, "Race.RaceTime", true, DataSourceUpdateMode.OnValidation, "", "hh:mm tt"); //Format the field into time formart
            txtUpdateRaceStatus.DataBindings.Add("Text", DM.dsNorthIslandRacing, "Race.Status");
            npUpdateRaceCapacity.DataBindings.Add("Text", DM.dsNorthIslandRacing, "Race.Capacity");

            //Populate Race ID into Race list
            lstRaces.DataSource = DM.dsNorthIslandRacing;
            lstRaces.DisplayMember = "Race.RaceID";
            lstRaces.ValueMember = "Race.RaceID";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsNorthIslandRacing, "Race"];
            cmMeeting = (CurrencyManager)this.BindingContext[DM.dsNorthIslandRacing, "Meeting"];
        }

        //Function to navigate forward for Race list
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        //Function to navigate backward for Race list
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        //Function to close the Main Race form panel
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Function to show the Add Race form panel
        private void btnAddRace_Click(object sender, EventArgs e)
        {
            lstRaces.Visible = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnUpdateRace.Enabled = false;
            btnDeleteRace.Enabled = false;
            btnMarkRaceAsFinished.Enabled = false;
            btnMarkRaceAsComplete.Enabled = false;
            btnReturn.Enabled = false;
            LoadMeetings();
            pnlAddRace.Show();
        }

        //Function to close the Add Race form panel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddRace.Hide();
            lstRaces.Enabled = true;
            lstRaces.Visible = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnUpdateRace.Enabled = true;
            btnDeleteRace.Enabled = true;
            btnMarkRaceAsFinished.Enabled = true;
            btnMarkRaceAsComplete.Enabled = true;
            btnReturn.Enabled = true;

            //Reset textbox field to empty when user decides to cancel operation
            txtAddRaceName.Text = String.Empty;
            txtAddRaceTime.Text = String.Empty;
            npAddRaceCapacity.Text = String.Empty;

        }


        //Function to show the Update Race form panel
        private void btnUpdateRace_Click(object sender, EventArgs e)
        {
            lstRaces.Visible = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnAddRace.Enabled = false;
            btnDeleteRace.Enabled = false;
            btnMarkRaceAsFinished.Enabled = false;
            btnMarkRaceAsComplete.Enabled = false;
            btnReturn.Enabled = false;

            pnlUpdateRace.Show();
        }

        //Function to close the Update Race form panel
        private void btnCancelUpdateRace_Click(object sender, EventArgs e)
        {
            pnlUpdateRace.Hide();
            lstRaces.Enabled = true;
            lstRaces.Visible = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnAddRace.Enabled = true;
            btnDeleteRace.Enabled = true;
            btnMarkRaceAsFinished.Enabled = true;
            btnMarkRaceAsComplete.Enabled = true;
            btnReturn.Enabled = true;
        }

        //Function to get MeetingName from Meeting table when user navigate through Race list
        private void txtRaceMeetingID_TextChanged(object sender, EventArgs e)
        {
            if (txtRaceMeetingID.Text == "")
            {
                txtRaceMeetingName.Text = "";
                txtUpdateRaceMeetingName.Text = "";
            }
            else
            {
                int aMeetingID = Convert.ToInt32(txtRaceMeetingID.Text);                //Get Meeting ID from the text field
                cmMeeting.Position = DM.meetingView.Find(aMeetingID);                   //Get the position of the Meeting ID using the above variable
                DataRow drMeeting = DM.dtMeeting.Rows[cmMeeting.Position];              //Get the Meeting record using the found position in Meeting table

                txtRaceMeetingName.Text = drMeeting["MeetingName"].ToString();          //Set the MeetingName to Main Race form panel
                txtUpdateRaceMeetingName.Text = drMeeting["MeetingName"].ToString();    //Set the MeetingName to Update Race form panel
            }
        }

        //Function to link data in the Meeting Table to the combo boxes
        private void LoadMeetings()
        {
            cboAddRaceMeetingID.DataSource = DM.dsNorthIslandRacing;
            cboAddRaceMeetingID.DisplayMember = "Meeting.MeetingID";
            cboAddRaceMeetingID.ValueMember = "Meeting.MeetingID";
            cboAddRaceMeetingName.DataSource = DM.dsNorthIslandRacing;
            cboAddRaceMeetingName.DisplayMember = "Meeting.MeetingName";
            cboAddRaceMeetingName.ValueMember = "Meeting.MeetingName";
        }

        //Function to delete the Race record
        private void btnDeleteRace_Click(object sender, EventArgs e)
        {
            DataRow deleteRaceRow = DM.dtRace.Rows[currencyManager.Position];
            DataRow[] EntryRow = DM.dtEntry.Select("RaceID = " + lblRaceID.Text);
            if (EntryRow.Length != 0)
            {
                MessageBox.Show("You may only delete a race that has no entries!", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteRaceRow.Delete();
                    DM.UpdateRace(); //Update database
                    MessageBox.Show("Race deleted successfully!", "Success");
                }
            }
        }

        //Function to save the newly added Race record
        private void btnSaveRace_Click(object sender, EventArgs e)
        {
            lblRaceID.Text = null;
            DataRow newRaceRow = DM.dtRace.NewRow();

            if (txtAddRaceName.Text == "" )
            {
                MessageBox.Show("Race Name must not be empty!", "Error");
            }
            else if (txtAddRaceName.Text.Length > 30)
            {
                MessageBox.Show("Race Name must not exceed 30 characters!", "Error");
            }
            else if(txtAddRaceTime.Text == "" )
            {
                MessageBox.Show("Race Time must not be empty!", "Error");

            }
            else if(npAddRaceCapacity.Text == "")
            {
                MessageBox.Show("Race Capacity must not be empty!", "Error");
            }
            else if(Convert.ToInt32(npAddRaceCapacity.Text) <= 1 || Convert.ToInt32(npAddRaceCapacity.Text) >= 40)
            {
                MessageBox.Show("Race Capacity must be between 2 and 39!", "Error");

            }
            else
            {
                try
                {
                    //Set the new record to the new row
                    newRaceRow["RaceName"] = txtAddRaceName.Text;
                    newRaceRow["MeetingID"] = cboAddRaceMeetingID.Text;
                    newRaceRow["RaceTime"] = txtAddRaceTime.Text;
                    newRaceRow["Status"] = cboAddRaceStatus.Text;
                    newRaceRow["Capacity"] = Convert.ToInt32(npAddRaceCapacity.Text);

                    DM.dtRace.Rows.Add(newRaceRow);
                    DM.UpdateRace();
                    MessageBox.Show("Race added successfully.", "Success");

                    //Reset textbox field to empty when user successfully save the operation
                    txtAddRaceName.Text = String.Empty;
                    txtAddRaceTime.Text = String.Empty;
                    npAddRaceCapacity.Text = String.Empty;
                    
                    //Close the Add Race form panel and Reset the buttons to its normal state
                    pnlAddRace.Hide();
                    lstRaces.Enabled = true;
                    lstRaces.Visible = true;
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    btnUpdateRace.Enabled = true;
                    btnDeleteRace.Enabled = true;
                    btnMarkRaceAsFinished.Enabled = true;
                    btnMarkRaceAsComplete.Enabled = true;
                    btnReturn.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please use a time format for Race Time. Ex: 7:00 or 13:00", "Error");
                }
            }
        }

        //Function to save the modified Race record
        private void btnSaveUpdateRace_Click(object sender, EventArgs e)
        {
            DataRow updateRaceRow = DM.dtRace.Rows[currencyManager.Position];

            if (txtUpdateRaceName.Text == "")
            {
                MessageBox.Show("Race Name must not be empty!", "Error");
            }
            else if (txtUpdateRaceName.Text.Length > 30)
            {
                MessageBox.Show("Race Name must not exceed 30 characters!", "Error");
            }
            else if (txtUpdateRaceTime.Text == "")
            {
                MessageBox.Show("Race Time must not be empty!", "Error");

            }
            else if (npUpdateRaceCapacity.Text == "")
            {
                MessageBox.Show("Race Capacity must not be empty!", "Error");
            }
            else if (Convert.ToInt32(npUpdateRaceCapacity.Text) <= 1 || Convert.ToInt32(npUpdateRaceCapacity.Text) >= 40)
            {
                MessageBox.Show("Race Capacity must be between 2 and 39!", "Error");

            }
            else
            {
                try
                {

                    //Add the modified record to the existing record
                    updateRaceRow["RaceName"] = txtUpdateRaceName.Text;
                    updateRaceRow["RaceTime"] = txtUpdateRaceTime.Text;
                    updateRaceRow["Capacity"] = npUpdateRaceCapacity.Text;

                    currencyManager.EndCurrentEdit();
                    DM.UpdateRace(); //Update database
                    MessageBox.Show("Race updated successfully.", "Success");

                    //Close Update Race Course Panel and Reset the buttons to its normal state
                    pnlUpdateRace.Hide();
                    lstRaces.Enabled = true;
                    lstRaces.Visible = true;
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    btnAddRace.Enabled = true;
                    btnDeleteRace.Enabled = true;
                    btnMarkRaceAsFinished.Enabled = true;
                    btnMarkRaceAsComplete.Enabled = true;
                    btnReturn.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please use a time format for Race Time. Ex: 7:00 or 13:00", "Error");
                }
            }
        }

        //Function to mark race as finished
        private void btnMarkRaceAsFinished_Click(object sender, EventArgs e)
        {
            DataRow updateRaceRow = DM.dtRace.Rows[currencyManager.Position];           //Get the current position of the race record that needs to be updated

            if (txtRaceStatus.Text == "Finished" || txtRaceStatus.Text == "Completed")
            {
                MessageBox.Show("Only scheduled races can be marked as finished!", "Error");
            }
            else
            {
                    //Update Status column value to Finished
                    updateRaceRow["Status"] = "Finished";
                   
                    currencyManager.EndCurrentEdit();
                    DM.UpdateRace();
                    MessageBox.Show("Race marked as finished.", "Success");
            }

        }

        //Function to mark race as completed
        private void btnMarkRaceAsComplete_Click(object sender, EventArgs e)
        {
            DataRow updateRaceRow = DM.dtRace.Rows[currencyManager.Position];           //Get the current position of the race record that needs to be updated

            if (txtRaceStatus.Text == "Scheduled" || txtRaceStatus.Text == "Completed")
            {
                MessageBox.Show("Only finished races can be marked as completed!", "Error");
            }
            else
            {
                //Update Status column value to Completed
                updateRaceRow["Status"] = "Completed";

                currencyManager.EndCurrentEdit();
                DM.UpdateRace();
                MessageBox.Show("Race marked as completed.", "Success");
            }
        }
    }
}
