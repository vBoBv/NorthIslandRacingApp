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
    public partial class HorseForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private CurrencyManager cmOwner;

        public HorseForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();

            pnlAddHorse.Left = 321;             // Panel position from the left
            pnlAddHorse.Top = 20;               // Panel position from the top
            pnlUpdateHorse.Left = 321;          // Panel position from the left
            pnlUpdateHorse.Top = 20;            // Panel position from the top
        }

        public void BindControls()
        {
            //Populate data into the Main Horse form panel
            lblHorseID.DataBindings.Add("Text", DM.dsNorthIslandRacing, "Horse.HorseID");
            txtHorseName.DataBindings.Add("Text", DM.dsNorthIslandRacing, "Horse.HorseName");
            txtHorseGender.DataBindings.Add("Text", DM.dsNorthIslandRacing, "Horse.Gender");
            txtHorseDateOfBirth.DataBindings.Add("Text", DM.dsNorthIslandRacing, "Horse.DateOfBirth", true, DataSourceUpdateMode.OnValidation, "", "MM/dd/yy"); //Format the field into date formart
            txtHorseOwnerID.DataBindings.Add("Text", DM.dsNorthIslandRacing, "Horse.OwnerID");

            //Populate data into Update Horse Panel form
            txtUpdateHorseName.DataBindings.Add("Text", DM.dsNorthIslandRacing, "Horse.HorseName");
            cboUpdateHorseGender.DataBindings.Add("Text", DM.dsNorthIslandRacing, "Horse.Gender");
            dtpUpdateHorseDateOfBirth.DataBindings.Add("Text", DM.dsNorthIslandRacing, "Horse.DateOfBirth");
            txtUpdateHorseOwnerID.DataBindings.Add("Text", DM.dsNorthIslandRacing, "Horse.OwnerID");

            //Populate Horse Name into Horse list
            lstHorses.DataSource = DM.dsNorthIslandRacing;
            lstHorses.DisplayMember = "Horse.HorseName";
            lstHorses.ValueMember = "Horse.HorseName";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsNorthIslandRacing, "Horse"];
            cmOwner = (CurrencyManager)this.BindingContext[DM.dsNorthIslandRacing, "Owner"];
        }

        //Function to navigate forward for Horse list
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        //Function to navigate backward for Horse list
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        //Function to close the Main Horse form panel
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Function to show the Add Horse form panel
        private void btnAddHorse_Click(object sender, EventArgs e)
        {
            lstHorses.Visible = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnUpdateHorse.Enabled = false;
            btnDeleteHorse.Enabled = false;
            btnReturn.Enabled = false;
            LoadOwners();
            pnlAddHorse.Show();
        }

        //Function to close the Add Horse form panel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddHorse.Hide();
            lstHorses.Enabled = true;
            lstHorses.Visible = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnUpdateHorse.Enabled = true;
            btnDeleteHorse.Enabled = true;
            btnReturn.Enabled = true;

            //Reset textbox field to empty when user decides to cancel operation
            txtAddHorseName.Text = String.Empty;
        }

        //Function to show the Update Horse form panel
        private void btnUpdateHorse_Click(object sender, EventArgs e)
        {
            lstHorses.Visible = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnAddHorse.Enabled = false;
            btnDeleteHorse.Enabled = false;
            btnReturn.Enabled = false;

            pnlUpdateHorse.Show();
        }

        //Function to close the Update Horse form panel
        private void btnCancelUpdateHorse_Click(object sender, EventArgs e)
        {
            pnlUpdateHorse.Hide();
            lstHorses.Enabled = true;
            lstHorses.Visible = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnAddHorse.Enabled = true;
            btnDeleteHorse.Enabled = true;
            btnReturn.Enabled = true;

        }

        //Function to get OwnerLastName and OwnerFirstName from Owner table when user navigate through Horse list
        private void txtHorseOwnerID_TextChanged(object sender, EventArgs e)
        {
            if (txtHorseOwnerID.Text == "")
            {
                txtHorseOwnerLastName.Text = "";
                txtHorseOwnerFirstName.Text = "";
            }
            else
            {
                int anOwnerID = Convert.ToInt32(txtHorseOwnerID.Text);                  //Get Owner ID from the text field
                cmOwner.Position = DM.ownerView.Find(anOwnerID);                        //Get the position of the Owner ID using the above variable
                DataRow drOwner = DM.dtOwner.Rows[cmOwner.Position];                    //Get the Owner record using the found position in Owner table

                txtHorseOwnerLastName.Text = drOwner["LastName"].ToString();            //Set the LastName to Main Horse form panel
                txtHorseOwnerFirstName.Text = drOwner["FirstName"].ToString();          //Set the FirstName to Main Horse form panel

                txtUpdateHorseOwnerLastName.Text = drOwner["LastName"].ToString();      //Set the LastName to Update Horse form panel
                txtUpdateHorseOwnerFirstName.Text = drOwner["FirstName"].ToString();    //Set the FirstName to Update Horse form panel
            }
        }

        //Function to delete the Horse record
        private void btnDeleteHorse_Click(object sender, EventArgs e)
        {
            DataRow deleteHorseRow = DM.dtHorse.Rows[currencyManager.Position];
            DataRow[] EntryRow = DM.dtEntry.Select("HorseID = " + lblHorseID.Text);
            if (EntryRow.Length != 0)
            {
                MessageBox.Show("You may only delete horses that have no entries!", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteHorseRow.Delete();
                    DM.UpdateHorse(); //Update database
                    MessageBox.Show("Horse deleted successfully!", "Success");
                }
            }
        }

        //Function to save the newly added Horse record
        private void btnSaveHorse_Click(object sender, EventArgs e)
        {
            lblHorseID.Text = null;
            DataRow newHorseRow = DM.dtHorse.NewRow();

            if (txtAddHorseName.Text == "")
            {
                MessageBox.Show("Horse Name must not be empty!", "Error");
            }
            else if (txtAddHorseName.Text.Length > 30)
            {
                MessageBox.Show("Horse Name must not exceed 30 characters!", "Error");
            }
            else if (cboAddHorseGender.Text == "")
            {
                MessageBox.Show("Horse Gender must not be empty!", "Error");
            }
            else if (cboAddHorseGender.Text.Length > 7)
            {
                MessageBox.Show("Horse Gender must not exceed 7 characters!", "Error");
            }
            else
            {
                try
                {
                    //Set the new record to the new row
                    newHorseRow["HorseName"] = txtAddHorseName.Text;
                    newHorseRow["Gender"] = cboAddHorseGender.Text;
                    newHorseRow["DateOfBirth"] = dtpAddHorseDateOfBirth.Text;
                    newHorseRow["OwnerID"] = Convert.ToInt32(cboAddHorseOwnerID.Text);
                  
                    DM.dtHorse.Rows.Add(newHorseRow);
                    DM.UpdateHorse(); //Update database
                    MessageBox.Show("Horse added successfully.", "Success");

                    //Reset textbox field to empty when user successfully save the operation
                    txtAddHorseName.Text = String.Empty;

                    //Close the Add Race Course Panel and Reset the buttons to its normal state
                    pnlAddHorse.Hide();
                    lstHorses.Enabled = true;
                    lstHorses.Visible = true;
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    btnUpdateHorse.Enabled = true;
                    btnDeleteHorse.Enabled = true;
                    btnReturn.Enabled = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("There is an error. Please try again!", "Error");
                }
            }
        }

        //Function to link data in the Owner Table to the combo boxes
        private void LoadOwners()
        {
            cboAddHorseOwnerID.DataSource = DM.dsNorthIslandRacing;
            cboAddHorseOwnerID.DisplayMember = "Owner.OwnerID";
            cboAddHorseOwnerID.ValueMember = "Owner.OwnerID";

            cboAddHorseOwnerLastName.DataSource = DM.dsNorthIslandRacing;
            cboAddHorseOwnerLastName.DisplayMember = "Owner.LastName";
            cboAddHorseOwnerLastName.ValueMember = "Owner.LastName";

            cboAddHorseOwnerFirstName.DataSource = DM.dsNorthIslandRacing;
            cboAddHorseOwnerFirstName.DisplayMember = "Owner.FirstName";
            cboAddHorseOwnerFirstName.ValueMember = "Owner.FirstName";
        }

        //Function to save the modified Horse record
        private void btnSaveUpdateHorse_Click(object sender, EventArgs e)
        {
            DataRow updateHorseRow = DM.dtHorse.Rows[currencyManager.Position];

            if (txtUpdateHorseName.Text == "")
            {
                MessageBox.Show("Horse Name must not be empty!", "Error");
            }
            else if (txtUpdateHorseName.Text.Length > 30)
            {
                MessageBox.Show("Horse Name must not exceed 30 characters!", "Error");
            }
            else if (cboUpdateHorseGender.Text == "")
            {
                MessageBox.Show("Horse Gender must not be empty!", "Error");
            }
            else if (cboUpdateHorseGender.Text.Length > 7)
            {
                MessageBox.Show("Horse Gender must not exceed 7 characters!", "Error");
            }
            else
            {
                try
                {

                    //Add the modified record to the existing record
                    updateHorseRow["HorseName"] = txtUpdateHorseName.Text;
                    updateHorseRow["Gender"] = cboUpdateHorseGender.Text;
                    updateHorseRow["DateOfBirth"] = dtpUpdateHorseDateOfBirth.Text;

                    currencyManager.EndCurrentEdit();
                    DM.UpdateHorse(); //Update database
                    MessageBox.Show("Horse updated successfully.", "Success");

                    //Close the Update Horse form panel and Reset the buttons to its normal state
                    pnlUpdateHorse.Hide();
                    lstHorses.Enabled = true;
                    lstHorses.Visible = true;
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    btnAddHorse.Enabled = true;
                    btnDeleteHorse.Enabled = true;
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
