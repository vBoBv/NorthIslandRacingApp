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
    public partial class EnterHorseRaceForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager cmHorse;
        private CurrencyManager cmRace;
        private CurrencyManager cmEntry;

        public EnterHorseRaceForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;

            cmHorse = (CurrencyManager)this.BindingContext[DM.dsNorthIslandRacing, "Horse"];
            cmRace = (CurrencyManager)this.BindingContext[DM.dsNorthIslandRacing, "Race"];
            cmEntry = (CurrencyManager)this.BindingContext[DM.dsNorthIslandRacing, "Entry"];

            BindControls();
        }

        //Bind data from Horse, Race, Entry table to its data grid view
        public void BindControls()
        {
            dgvHorseDetails.DataSource = DM.dsNorthIslandRacing;
            dgvHorseDetails.DataMember = "Horse";

            dgvRaceDetails.DataSource = DM.dsNorthIslandRacing;
            dgvRaceDetails.DataMember = "Race";

            this.dgvRaceDetails.Columns["RaceTime"].DefaultCellStyle.Format = "hh:mm tt";           //Format the DateTime of RaceTime column to time format

            dgvEntryDetails.DataSource = DM.dsNorthIslandRacing;
            dgvEntryDetails.DataMember = "Entry";
        }

        //Function to close the Main HorseRace form panel
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Function that occurs when the content within a cell is clicked
        private void dgvHorseDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            changeHorseSelect();
        }

        //Function that occurs when a row changes state, such as losing or gaining input focus
        private void dgvHorseDetails_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            changeHorseSelect();
        }

        //Function to dynamically change the LastName and FirstName textfield based on the row selected
        private void changeHorseSelect()
        {
            String ownerID = DM.dtHorse.Rows[cmHorse.Position]["OwnerID"].ToString();
            String lastName = DM.dtOwner.Select("OwnerID = " + ownerID)[0]["LastName"].ToString();
            String firstName = DM.dtOwner.Select("OwnerID = " + ownerID)[0]["FirstName"].ToString();
            txtOwnerFirstName.Text = firstName;
            txtOwnerLastName.Text = lastName;
        }

        //Function that occurs when the content within a cell is clicked
        private void dgvRaceDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            changeRaceSelect();
        }

        //Function that occurs when a row changes state, such as losing or gaining input focus
        private void dgvRaceDetails_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            changeRaceSelect();
        }

        //Function to dynamically change the MeetingName textfield based on the row selected
        private void changeRaceSelect()
        {
            String meetingID = DM.dtRace.Rows[cmRace.Position]["MeetingID"].ToString();
            String meetingName = DM.dtMeeting.Select("MeetingID = " + meetingID)[0]["MeetingName"].ToString();
            txtMeetingName.Text = meetingName;
        }

        //Function to add new record to Entry table
        private void btnAddEntry_Click(object sender, EventArgs e)
        {
            DataRow newEntry = DM.dtEntry.NewRow();

            try { 
                if (DM.dtRace.Rows[cmRace.Position]["Status"].ToString() != "Scheduled") {          //Check to see if the selected race in Race Grid View has a status of not equal to Scheduled
                    MessageBox.Show("Horses can only be entered to scheduled races", "Error");
                }else
                {
                    //Set the new record to the new row
                    newEntry["HorseID"] = dgvHorseDetails["HorseID", cmHorse.Position].Value;       //Get the selected HorseID column in Horse Data Grid View and set it to the new HorseID column
                    newEntry["RaceID"] = dgvRaceDetails["RaceID", cmRace.Position].Value;           //Get the selected RaceID column in Race Data Grid View and set it to the new RaceID column
                    newEntry["Status"] = cboStatus.Text;                                            //Get the value from the status combo box and set it to the new Status column

                    DM.dsNorthIslandRacing.Tables["Entry"].Rows.Add(newEntry);
                    DM.UpdateEntry(); //Update database
                    MessageBox.Show("Entry added successfully.", "Success");
                }
            }
            catch (ConstraintException)
            {
                MessageBox.Show("This horse has already been scheduled with this race.", "Error");
            }
        }


        //Function to remove entry record from Entry table
        private void btnRemoveEntry_Click(object sender, EventArgs e)
        {
            DataRow deleteEntryRow = DM.dtEntry.Rows[cmEntry.Position];                             //Get the selected record in Entry Data Grid View
            if(MessageBox.Show("Are you sure you want to delete this record?", "Warining", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                deleteEntryRow.Delete();
                DM.UpdateEntry(); //Update database
                MessageBox.Show("Entry removed successfully.", "Success");
            }
        }
    }
}
