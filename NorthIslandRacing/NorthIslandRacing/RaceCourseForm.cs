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
    public partial class RaceCourseForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        public RaceCourseForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();

            pnlAddRaceCourse.Left = 308;        // Panel position from the left
            pnlAddRaceCourse.Top = 21;          // Panel position from the top
            pnlUpdateRaceCourse.Left = 308;     // Panel position from the left
            pnlUpdateRaceCourse.Top = 21;       // Panel position from the top
        }

        public void BindControls()
        {
            //Populate data into the Main Race Course form panel
            lblRaceCourseID.DataBindings.Add("Text", DM.dsNorthIslandRacing, "RaceCourse.RaceCourseID");
            txtRaceCourseName.DataBindings.Add("Text", DM.dsNorthIslandRacing, "RaceCourse.RaceCourseName");
            txtRaceCourseStreetAddress.DataBindings.Add("Text", DM.dsNorthIslandRacing, "RaceCourse.StreetAddress");
            txtRaceCourseSuburb.DataBindings.Add("Text", DM.dsNorthIslandRacing, "RaceCourse.Suburb");
            txtRaceCourseCity.DataBindings.Add("Text", DM.dsNorthIslandRacing, "RaceCourse.City");
            txtRaceCoursePhoneNumber.DataBindings.Add("Text", DM.dsNorthIslandRacing, "RaceCourse.PhoneNumber");

            //Populate data into Update Race Course form panel
            txtUpdateRaceCourseName.DataBindings.Add("Text", DM.dsNorthIslandRacing, "RaceCourse.RaceCourseName");
            txtUpdateRaceCourseStreetAddress.DataBindings.Add("Text", DM.dsNorthIslandRacing, "RaceCourse.StreetAddress");
            txtUpdateRaceCourseSuburb.DataBindings.Add("Text", DM.dsNorthIslandRacing, "RaceCourse.Suburb");
            txtUpdateRaceCourseCity.DataBindings.Add("Text", DM.dsNorthIslandRacing, "RaceCourse.City");
            txtUpdateRaceCoursePhoneNumber.DataBindings.Add("Text", DM.dsNorthIslandRacing, "RaceCourse.PhoneNumber");

            //Populate Race Course Name into Race Course list
            lstRaceCourses.DataSource = DM.dsNorthIslandRacing;
            lstRaceCourses.DisplayMember = "RaceCourse.RaceCourseName";
            lstRaceCourses.ValueMember = "RaceCourse.RaceCourseName";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsNorthIslandRacing, "RaceCourse"];
        }

        //Function to navigate forward for Race Course list
        private void btnNext_Click(object sender, EventArgs e)
        {
            if(currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        //Function to navigate backward for Race Course list
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if(currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        //Function to close the Main Race Course form panel
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Function to delete the Race course record
        private void btnDeleteRaceCourse_Click(object sender, EventArgs e)
        {
            DataRow deleteRaceCourseRow = DM.dtRaceCourse.Rows[currencyManager.Position];               //Get the current position of the record in Race Course list
            DataRow[] MeetingRow = DM.dtMeeting.Select("RaceCourseID = " + lblRaceCourseID.Text);       //Get the meeting record that matched with the selected Race Course ID
            if(MeetingRow.Length != 0)
            {
                MessageBox.Show("You may only delete race courses that have no meetings!", "Error");
            }
            else
            {
                if(MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteRaceCourseRow.Delete();
                    DM.UpdateRaceCourse(); //Update database
                    MessageBox.Show("Race course deleted successfully!", "Success");
                }
            }
        }

        //Function to show the Add Race Course form panel
        private void btnAddRaceCourse_Click(object sender, EventArgs e)
        {
            lstRaceCourses.Visible = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnUpdateRaceCourse.Enabled = false;
            btnDeleteRaceCourse.Enabled = false;
            btnReturn.Enabled = false;
            pnlAddRaceCourse.Show();
        }

        //Function to save the newly added Race Course record
        private void btnSaveRaceCourse_Click_1(object sender, EventArgs e)
        {
            lblRaceCourseID.Text = null;
            DataRow newRaceCourseRow = DM.dtRaceCourse.NewRow();

            if (txtAddRaceCourseName.Text == "")
            {
                MessageBox.Show("Race Course Name must not be empty!", "Error");
            }
            else if (txtAddRaceCourseName.Text.Length > 25)
            {
                MessageBox.Show("Race Course Name must not exceed 25 characters!", "Error");
            }
            else if (txtAddRaceCourseStreetAddress.Text == "")
            {
                MessageBox.Show("Race Course Street Address must not be empty!", "Error");
            }
            else if (txtAddRaceCourseStreetAddress.Text.Length > 40)
            {
                MessageBox.Show("Race Course Street Address must not exceed 40 characters!", "Error");
            }
            else if (txtAddRaceCourseSuburb.Text == "")
            {
                MessageBox.Show("Race Course Suburb must not be empty!", "Error");
            }
            else if (txtAddRaceCourseSuburb.Text.Length > 25)
            {
                MessageBox.Show("Race Course Suburb must not exceed 25 characters!", "Error");
            }
            else if (txtAddRaceCourseCity.Text == "")
            {
                MessageBox.Show("Race Course City must not be empty!", "Error");
            }
            else if (txtAddRaceCourseCity.Text.Length > 25)
            {
                MessageBox.Show("Race Course City must not exceed 25 characters!", "Error");
            }
            else if (txtAddRaceCoursePhoneNumber.Text == "")
            {
                MessageBox.Show("Race Course Phone Number must not be empty!", "Error");
            }
            else if (txtAddRaceCoursePhoneNumber.Text.Length > 20)
            {
                MessageBox.Show("Race Course Phone Number must nto exceed 20 characters!", "Error");
            }
            else
            {
                try
                {
                    //Set the new record to the new row
                    newRaceCourseRow["RaceCourseName"] = txtAddRaceCourseName.Text;
                    newRaceCourseRow["StreetAddress"] = txtAddRaceCourseStreetAddress.Text;
                    newRaceCourseRow["Suburb"] = txtAddRaceCourseSuburb.Text;
                    newRaceCourseRow["City"] = txtAddRaceCourseCity.Text;
                    //newRaceCourseRow["PhoneNumber"] = Convert.ToInt32(txtAddRaceCoursePhoneNumber.Text);
                    //Do not need to convert into number format because Phone Number is a Short Text Data type in North_Island_Racing database
                    newRaceCourseRow["PhoneNumber"] = txtAddRaceCoursePhoneNumber.Text; 
                    DM.dtRaceCourse.Rows.Add(newRaceCourseRow); 
                    DM.UpdateRaceCourse(); //Update database
                    MessageBox.Show("Race course added successfully", "Success");

                    //Reset textbox field to empty when user successfully save the operation
                    txtAddRaceCourseName.Text = String.Empty;
                    txtAddRaceCourseStreetAddress.Text = String.Empty;
                    txtAddRaceCourseSuburb.Text = String.Empty;
                    txtAddRaceCourseCity.Text = String.Empty;
                    txtAddRaceCoursePhoneNumber.Text = String.Empty;

                    //Close the Add Race Course Panel and Reset the buttons to its normal state
                    pnlAddRaceCourse.Hide();
                    lstRaceCourses.Enabled = true;
                    lstRaceCourses.Visible = true;
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    btnUpdateRaceCourse.Enabled = true;
                    btnDeleteRaceCourse.Enabled = true;
                    btnReturn.Enabled = true;
                }
                //catch(FormatException ex)
                //{
                //    MessageBox.Show("Please use a number format for phone number!", "Error");
                //}
                catch (Exception ex)
                {
                    MessageBox.Show("There is an error. Please try again!", "Error");
                }
            }
        }

        //Function to close the Add Race Course form panel
        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            pnlAddRaceCourse.Hide();
            lstRaceCourses.Enabled = true;
            lstRaceCourses.Visible = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnUpdateRaceCourse.Enabled = true;
            btnDeleteRaceCourse.Enabled = true;
            btnReturn.Enabled = true;

            //Reset textbox field to empty when user decides to cancel operation
            txtAddRaceCourseName.Text = String.Empty;
            txtAddRaceCourseStreetAddress.Text = String.Empty;
            txtAddRaceCourseSuburb.Text = String.Empty;
            txtAddRaceCourseCity.Text = String.Empty;
            txtAddRaceCoursePhoneNumber.Text = String.Empty;
        }

        //Function to open the Update Race Course form panel
        private void btnUpdateRaceCourse_Click(object sender, EventArgs e)
        {
            lstRaceCourses.Visible = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnAddRaceCourse.Enabled = false;
            btnDeleteRaceCourse.Enabled = false;
            btnReturn.Enabled = false;
            pnlUpdateRaceCourse.Show();
        }

        //Function to close the Update Race Course form panel
        private void btnCancelUpdateRaceCourse_Click(object sender, EventArgs e)
        {
            pnlUpdateRaceCourse.Hide();
            lstRaceCourses.Enabled = true;
            lstRaceCourses.Visible = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnAddRaceCourse.Enabled = true;
            btnDeleteRaceCourse.Enabled = true;
            btnReturn.Enabled = true;
        }

        //Function to save the modified Race Course record
        private void btnSaveUpdateRaceCourse_Click(object sender, EventArgs e)
        {
            DataRow updateRaceCourseRow = DM.dtRaceCourse.Rows[currencyManager.Position];       //Get the current position of the record in Race Course list

            if (txtUpdateRaceCourseName.Text == "")
            {
                MessageBox.Show("Race Course Name must not be empty!", "Error");
            }
            else if (txtUpdateRaceCourseName.Text.Length > 25)
            {
                MessageBox.Show("Race Course Name must not exceed 25 characters!", "Error");
            }
            else if(txtUpdateRaceCourseStreetAddress.Text == "")
            {
                MessageBox.Show("Race Course Street Address must not be empty!", "Error");
            }
            else if (txtUpdateRaceCourseStreetAddress.Text.Length > 40)
            {
                MessageBox.Show("Race Course Street Address must not exceed 40 characters!", "Error");
            }
            else if(txtUpdateRaceCourseSuburb.Text == "")
            {
                MessageBox.Show("Race Course Suburb must not be empty!", "Error");
            }
            else if (txtUpdateRaceCourseSuburb.Text.Length > 25)
            {
                MessageBox.Show("Race Course Suburb must not exceed 25 characters!", "Error");
            }
            else if (txtUpdateRaceCourseCity.Text == "")
            {
                MessageBox.Show("Race Course City must not be empty!", "Error");
            }
            else if (txtUpdateRaceCourseCity.Text.Length > 25)
            {
                MessageBox.Show("Race Course City must not exceed 25 characters!", "Error");
            }
            else if (txtUpdateRaceCoursePhoneNumber.Text == "")
            {
                MessageBox.Show("Race Course Phone Number must not be empty!", "Error");
            }
            else if (txtUpdateRaceCoursePhoneNumber.Text.Length > 20)
            {
                MessageBox.Show("Race Course Phone Number must not exceed 20 characters!", "Error");
            }
            else
            {
                try
                {
                    //Add the modified record to the existing record
                    updateRaceCourseRow["RaceCourseName"] = txtUpdateRaceCourseName.Text;
                    updateRaceCourseRow["StreetAddress"] = txtUpdateRaceCourseStreetAddress.Text;
                    updateRaceCourseRow["Suburb"] = txtUpdateRaceCourseSuburb.Text;
                    updateRaceCourseRow["City"] = txtUpdateRaceCourseCity.Text;
                    //updateRaceCourseRow["PhoneNumber"] = Convert.ToInt32(txtUpdateRaceCoursePhoneNumber.Text);
                    // Do not need to convert into number format because Phone Number is a Short Text Data type in North_Island_Racing database
                    updateRaceCourseRow["PhoneNumber"] = txtUpdateRaceCoursePhoneNumber.Text;

                    currencyManager.EndCurrentEdit();
                    DM.UpdateRaceCourse(); //Update database
                    MessageBox.Show("Race course updated successfully.", "Success");

                    //Close Update Race Course Panel and Reset the buttons to its normal state
                    pnlUpdateRaceCourse.Hide();
                    lstRaceCourses.Enabled = true;
                    lstRaceCourses.Visible = true;
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    btnAddRaceCourse.Enabled = true;
                    btnDeleteRaceCourse.Enabled = true;
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
