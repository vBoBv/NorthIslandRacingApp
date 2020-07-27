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
    public partial class OwnerForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        public OwnerForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();

            pnlAddOwner.Left = 319;         // Panel position from the left
            pnlAddOwner.Top = 23;           // Panel position from the top
            pnlUpdateOwner.Left = 319;      // Panel position from the left
            pnlUpdateOwner.Top = 23;        // Panel position from the top
        }

        public void BindControls()
        {
            //Populate data into the Main Owner form panel
            lblOwnerID.DataBindings.Add("Text", DM.dsNorthIslandRacing, "Owner.OwnerID");
            txtOwnerLastName.DataBindings.Add("Text", DM.dsNorthIslandRacing, "Owner.LastName");
            txtOwnerFirstName.DataBindings.Add("Text", DM.dsNorthIslandRacing, "Owner.FirstName");
            txtOwnerStreetAddress.DataBindings.Add("Text", DM.dsNorthIslandRacing, "Owner.StreetAddress");
            txtOwnerSuburb.DataBindings.Add("Text", DM.dsNorthIslandRacing, "Owner.Suburb");
            txtOwnerCity.DataBindings.Add("Text", DM.dsNorthIslandRacing, "Owner.City");
            txtOwnerEmailAddress.DataBindings.Add("Text", DM.dsNorthIslandRacing, "Owner.EmailAddress");
            txtOwnerPhoneNumber.DataBindings.Add("Text", DM.dsNorthIslandRacing, "Owner.PhoneNumber");

            //Populate data into Update Owner form panel
            txtUpdateOwnerLastName.DataBindings.Add("Text", DM.dsNorthIslandRacing, "Owner.LastName");
            txtUpdateOwnerFirstName.DataBindings.Add("Text", DM.dsNorthIslandRacing, "Owner.FirstName");
            txtUpdateOwnerStreetAddress.DataBindings.Add("Text", DM.dsNorthIslandRacing, "Owner.StreetAddress");
            txtUpdateOwnerSuburb.DataBindings.Add("Text", DM.dsNorthIslandRacing, "Owner.Suburb");
            txtUpdateOwnerCity.DataBindings.Add("Text", DM.dsNorthIslandRacing, "Owner.City");
            txtUpdateOwnerEmailAddress.DataBindings.Add("Text", DM.dsNorthIslandRacing, "Owner.EmailAddress");
            txtUpdateOwnerPhoneNumber.DataBindings.Add("Text", DM.dsNorthIslandRacing, "Owner.PhoneNumber");

            //Populate Owner Last Name into Owner list
            lstOwners.DataSource = DM.dsNorthIslandRacing;
            lstOwners.DisplayMember = "Owner.LastName";
            lstOwners.ValueMember = "Owner.LastName";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsNorthIslandRacing, "Owner"];
        }

        //Function to navigate forward for Owner list
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        //Function to navigate backward for Owner list
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        //Function to close the Main Owner form panel
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Function to delete the Owner record
        private void btnDeleteOwner_Click(object sender, EventArgs e)
        {
            DataRow deleteOwnerRow = DM.dtOwner.Rows[currencyManager.Position];             //Get the current position of the record in Owner list
            DataRow[] HorseRow = DM.dtHorse.Select("OwnerID = " + lblOwnerID.Text);         //Get the horse record that matched with the selected Owner ID
            if (HorseRow.Length != 0)
            {
                MessageBox.Show("You may only delete owners who have no horses!", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteOwnerRow.Delete();
                    DM.UpdateOwner(); //Update database
                    MessageBox.Show("Owner deleted successfully!", "Success");
                }
            }
        }

        //Function to show the Add Owner form panel
        private void btnAddOwner_Click(object sender, EventArgs e)
        {
            lstOwners.Visible = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnUpdateOwner.Enabled = false;
            btnDeleteOwner.Enabled = false;
            btnReturn.Enabled = false;
            pnlAddOwner.Show();
        }

        //Function to close the Add Owner form panel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddOwner.Hide();
            lstOwners.Enabled = true;
            lstOwners.Visible = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnUpdateOwner.Enabled = true;
            btnDeleteOwner.Enabled = true;
            btnReturn.Enabled = true;


            //Reset textbox field to empty when user decides to cancel operation
            txtAddOwnerFirstName.Text = String.Empty;
            txtAddOwnerLastName.Text = String.Empty;
            txtAddOwnerStreetAddress.Text = String.Empty;
            txtAddOwnerSuburb.Text = String.Empty;
            txtAddOwnerCity.Text = String.Empty;
            txtAddOwnerEmailAddress.Text = String.Empty;
            txtAddOwnerPhoneNumber.Text = String.Empty;
        }

        //Function to save the newly added Owner record
        private void btnSaveOwner_Click(object sender, EventArgs e)
        {
            lblOwnerID.Text = null;
            DataRow newOwnerRow = DM.dtOwner.NewRow();

            if (txtAddOwnerLastName.Text == "")
            {
                MessageBox.Show("Last Name must not be empty!", "Error");
            }
            else if (txtAddOwnerLastName.Text.Length > 30)
            {
                MessageBox.Show("Last Name must not exceed 30 characters!", "Error");
            }
            else if(txtAddOwnerFirstName.Text == "")
            {
                MessageBox.Show("First Name must not be empty!", "Error");
            }
            else if (txtAddOwnerFirstName.Text.Length > 30)
            {
                MessageBox.Show("First Name must not exceed 30 characters!", "Error");
            }
            else if (txtAddOwnerStreetAddress.Text == "")
            {
                MessageBox.Show("Street Address must not be empty!", "Error");
            }
            else if (txtAddOwnerStreetAddress.Text.Length > 40)
            {
                MessageBox.Show("Street Address must not exceed 40 characters!", "Error");
            }
            else if (txtAddOwnerSuburb.Text == "")
            {
                MessageBox.Show("Suburb must not be empty!", "Error");
            }
            else if (txtAddOwnerSuburb.Text.Length > 25)
            {
                MessageBox.Show("Suburb must not exceed 25 characters!", "Error");
            }
            else if (txtAddOwnerCity.Text == "")
            {
                MessageBox.Show("City must not be empty!", "Error");
            }
            else if (txtAddOwnerCity.Text.Length > 25)
            {
                MessageBox.Show("City must not exceed 25 character!", "Error");
            }
            else if (txtAddOwnerEmailAddress.Text == "")
            {
                MessageBox.Show("Email Address must not be empty!", "Error");
            }
            else if (txtAddOwnerEmailAddress.Text.Length > 25)
            {
                MessageBox.Show("Email Address must not exceed 25 characters!", "Error");
            }
            else if (txtAddOwnerPhoneNumber.Text == "")
            {
                MessageBox.Show("Phone Number must not be empty!", "Error");
            }
            else if (txtAddOwnerPhoneNumber.Text.Length > 15)
            {
                MessageBox.Show("Phone Number must not exceed 15 characters!", "Error");
            }
            else
            {
                try
                {
                    newOwnerRow["LastName"] = txtAddOwnerLastName.Text;
                    newOwnerRow["FirstName"] = txtAddOwnerFirstName.Text;
                    newOwnerRow["StreetAddress"] = txtAddOwnerStreetAddress.Text;
                    newOwnerRow["Suburb"] = txtAddOwnerSuburb.Text;
                    newOwnerRow["City"] = txtAddOwnerCity.Text;
                    newOwnerRow["EmailAddress"] = txtAddOwnerEmailAddress.Text;
                    //newOwnerRow["PhoneNumber"] = Convert.ToInt32(txtAddOwnerPhoneNumber.Text);
                    // Do not need to convert into number format because Phone Number is a Short Text Data type in North_Island_Racing database
                    newOwnerRow["PhoneNumber"] = txtAddOwnerPhoneNumber.Text;

                    DM.dtOwner.Rows.Add(newOwnerRow);
                    DM.UpdateOwner(); //Update database
                    MessageBox.Show("Owner added successfully.", "Success");

                    //Reset textbox field to empty when user successfully save the operation
                    txtAddOwnerLastName.Text = String.Empty;
                    txtAddOwnerFirstName.Text = String.Empty;
                    txtAddOwnerStreetAddress.Text = String.Empty;
                    txtAddOwnerSuburb.Text = String.Empty;
                    txtAddOwnerCity.Text = String.Empty;
                    txtAddOwnerEmailAddress.Text = String.Empty;
                    txtAddOwnerPhoneNumber.Text = String.Empty;

                    //Close the Owner Panel and Reset the buttons to its normal state
                    pnlAddOwner.Hide();
                    lstOwners.Enabled = true;
                    lstOwners.Visible = true;
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    btnUpdateOwner.Enabled = true;
                    btnDeleteOwner.Enabled = true;
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

        //Function to open the Update Owner form panel
        private void btnUpdateOwner_Click(object sender, EventArgs e)
        {
            lstOwners.Visible = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnAddOwner.Enabled = false;
            btnDeleteOwner.Enabled = false;
            btnReturn.Enabled = false;
            pnlUpdateOwner.Show();
        }

        //Function to close the Update Race Owner form panel
        private void btnCancelUpdateOwner_Click(object sender, EventArgs e)
        {
            pnlUpdateOwner.Hide();
            lstOwners.Enabled = true;
            lstOwners.Visible = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnAddOwner.Enabled = true;
            btnDeleteOwner.Enabled = true;
            btnReturn.Enabled = true;
        }

        //Function to save the modified Owner record
        private void btnSaveUpdateOwner_Click(object sender, EventArgs e)
        {
            DataRow updateOwnerRow = DM.dtOwner.Rows[currencyManager.Position];

            if (txtUpdateOwnerLastName.Text == "")
            {
                MessageBox.Show("Last Name must not be empty!", "Error");
            }
            else if (txtUpdateOwnerLastName.Text.Length > 30)
            {
                MessageBox.Show("Last Name must not exceed 30 characters!", "Error");
            }
            else if (txtUpdateOwnerFirstName.Text == "")
            {
                MessageBox.Show("First Name must not be empty!", "Error");
            }
            else if (txtUpdateOwnerFirstName.Text.Length > 30)
            {
                MessageBox.Show("First Name must not exceed 30 characters!", "Error");
            }
            else if (txtUpdateOwnerStreetAddress.Text == "")
            {
                MessageBox.Show("Street Address must not be empty!", "Error");
            }
            else if (txtUpdateOwnerStreetAddress.Text.Length > 40)
            {
                MessageBox.Show("Street Address must not exceed 40 characters!", "Error");
            }
            else if (txtUpdateOwnerSuburb.Text == "")
            {
                MessageBox.Show("Suburb must not be empty!", "Error");
            }
            else if (txtUpdateOwnerSuburb.Text.Length > 25)
            {
                MessageBox.Show("Suburb must not exceed 25 characters!", "Error");
            }
            else if (txtUpdateOwnerCity.Text == "")
            {
                MessageBox.Show("City must not be empty!", "Error");
            }
            else if (txtUpdateOwnerCity.Text.Length > 25)
            {
                MessageBox.Show("City must not exceed 25 character!", "Error");
            }
            else if (txtUpdateOwnerEmailAddress.Text == "")
            {
                MessageBox.Show("Email Address must not be empty!", "Error");
            }
            else if (txtUpdateOwnerEmailAddress.Text.Length > 25)
            {
                MessageBox.Show("Email Address must not exceed 25 characters!", "Error");
            }
            else if (txtUpdateOwnerPhoneNumber.Text == "")
            {
                MessageBox.Show("Phone Number must not be empty!", "Error");
            }
            else if (txtUpdateOwnerPhoneNumber.Text.Length > 15)
            {
                MessageBox.Show("Phone Number must not exceed 15 characters!", "Error");
            }
            else
            {
                try
                {
                    //Add the modified record to the existing record
                    updateOwnerRow["LastName"] = txtUpdateOwnerLastName.Text;
                    updateOwnerRow["FirstName"] = txtUpdateOwnerFirstName.Text;
                    updateOwnerRow["StreetAddress"] = txtUpdateOwnerStreetAddress.Text;
                    updateOwnerRow["Suburb"] = txtUpdateOwnerSuburb.Text;
                    updateOwnerRow["City"] = txtUpdateOwnerCity.Text;
                    updateOwnerRow["EmailAddress"] = txtUpdateOwnerEmailAddress.Text;
                    //updateOwnerRow["PhoneNumber"] = Convert.ToInt32(txtUpdateOwnerPhoneNumber.Text);
                    // Do not need to convert into number format because Phone Number is a Short Text Data type in North_Island_Racing database
                    updateOwnerRow["PhoneNumber"] = txtUpdateOwnerPhoneNumber.Text;

                    currencyManager.EndCurrentEdit();
                    DM.UpdateOwner(); //Update database
                    MessageBox.Show("Owner updated successfully.", "Success");

                    //Close Update Owner Panel and Reset the buttons to its normal state
                    pnlUpdateOwner.Hide();
                    lstOwners.Enabled = true;
                    lstOwners.Visible = true;
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    btnAddOwner.Enabled = true;
                    btnDeleteOwner.Enabled = true;
                    btnReturn.Enabled = true;
                }
                //catch (FormatException ex)
                //{
                //    MessageBox.Show("Please use number format for phone number", "Error");
                //}
                catch (Exception ex)
                {
                    MessageBox.Show("There is an error. Please try again!", "Error");
                }
            }
        }
    }
}
