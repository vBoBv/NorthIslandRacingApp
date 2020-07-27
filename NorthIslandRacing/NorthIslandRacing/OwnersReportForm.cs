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
    public partial class OwnersReportForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private int amountOfOwnersPrinted, pagesAmountExpected;
        private DataRow[] ownersForPrint;

        public OwnersReportForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrintOwners_Click(object sender, EventArgs e)
        {
            amountOfOwnersPrinted = 0;                          //To keep count of the number of owners
           
            string strFilter = "COUNT(Child.OwnerID) > 0";      //To check if the owner has 1 or more horses
            string strSort = "OwnerID";                         //Variable to store the sort parameter
            ownersForPrint = DM.dsNorthIslandRacing.Tables["OWNER"].Select(strFilter, strSort, DataViewRowState.CurrentRows);       //In the Owner table, select OwnerID with owner that has horses
            pagesAmountExpected = ownersForPrint.Length;        //Amount of page that needs to be printed
            prvOwners.Show();                                   //Show the Print Preview Dialog
        }

        private void printOwners_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Instantiate the Graphic and add style to the print preview page
            Graphics g = e.Graphics;
            int linesSoFarHeading = 0;
            Font textFont = new Font("Arial", 10, FontStyle.Regular);
            Font textFontCenter = new Font("Arial", 10, FontStyle.Regular);
            Font totalSubtotal = new Font("Arial", 10, FontStyle.Bold);
            Font headingFont = new Font("Arial", 10, FontStyle.Bold);

            DataRow drOwner = ownersForPrint[amountOfOwnersPrinted];
            CurrencyManager cmOwner;
            CurrencyManager cmHorse;
            CurrencyManager cmRace;

            cmOwner = (CurrencyManager)this.BindingContext[DM.dsNorthIslandRacing, "Owner"];
            cmHorse = (CurrencyManager)this.BindingContext[DM.dsNorthIslandRacing, "Horse"];
            cmRace = (CurrencyManager)this.BindingContext[DM.dsNorthIslandRacing, "Race"];

            
            Brush brush = new SolidBrush(Color.Black);
            //Page margins
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int headingLeftMargin = 50;
            int topMarginDetails = topMargin + 70;
            int rightMargin = e.MarginBounds.Right;

            //Get the horses record which is the child of the Owner table
            DataRow[] drHorses = drOwner.GetChildRows(DM.dtOwner.ChildRelations["OWNER_HORSE"]);
            
            if(drHorses.Length == 0)            //Check to see if owner does not have a horse
            {
                g.DrawString("This owner has no horses.", headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            }
            else
            {
                //Draw out Owner Information
                //OwnerID
                g.DrawString("Owner ID: " + drOwner["OwnerID"], headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;
                linesSoFarHeading++;

                //LastName and FirstName
                g.DrawString(drOwner["LastName"] + " " + drOwner["FirstName"], headingFont, brush, leftMargin +
                headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;

                //Street Address
                g.DrawString(drOwner["StreetAddress"] + "", headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;

                //Suburb
                g.DrawString(drOwner["Suburb"] + "", headingFont, brush, leftMargin + headingLeftMargin, topMargin +
                (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;

                //City
                g.DrawString(drOwner["City"] + "", headingFont, brush, leftMargin + headingLeftMargin, topMargin +
                (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;
                linesSoFarHeading++;

                //Horses(heading)
                g.DrawString("Horses:", headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;
                linesSoFarHeading++;

                foreach (DataRow drHorse in drHorses)
                {

                    DateTime dateOfBirth = (DateTime)drHorse["DateOfBirth"];      //Implement built-in DateTime to use the ToShortDateString format funciton

                    //Draw out Horse Information
                    //HorseID, HorseName, DateOfBirth, Gender
                    g.DrawString(drHorse["HorseID"] + "\t" + drHorse["HorseName"] + "\t\t" + dateOfBirth.ToShortDateString() + "\t" + drHorse["Gender"], headingFont, brush, leftMargin + headingLeftMargin, topMargin +
                    (linesSoFarHeading * textFont.Height));
                    linesSoFarHeading++;
                    linesSoFarHeading++;

                    //RaceID, RaceName
                    g.DrawString("\tRace ID" + "\t\t" + "RaceName", headingFont, brush, leftMargin + headingLeftMargin,
                    topMargin + (linesSoFarHeading * textFont.Height));
                    linesSoFarHeading++;

                    //Get the entries record which is the child of the Horse table
                    DataRow[] drEntries = drHorse.GetChildRows(DM.dtHorse.ChildRelations["FK_HORSE_ENTRY"]);

                    if (drEntries.Length == 0)            //Check to see if horse does not have a race
                    {
                        g.DrawString("\tThis horse has no races.", headingFont, brush, leftMargin + headingLeftMargin,
                        topMargin + (linesSoFarHeading * textFont.Height));
                        linesSoFarHeading++;
                    }
                    else
                    {
                        foreach (DataRow drEntry in drEntries)
                        {
                            //Get Race record from the Race table using RaceID from Entry
                            int aRaceID = Convert.ToInt32(drEntry["RaceID"].ToString());
                            cmRace.Position = DM.raceView.Find(aRaceID);
                            DataRow drRace = DM.dtRace.Rows[cmRace.Position];

                            //Draw out Entry and Race information for each horse
                            //RaceID(from Entry), RaceName(from Race)
                            g.DrawString("\t      " + drEntry["RaceID"] + "\t\t" + drRace["RaceName"] + "\n", headingFont, brush, leftMargin + headingLeftMargin, topMargin +
                            (linesSoFarHeading * textFont.Height));
                            linesSoFarHeading++;

                        }
                    }
                    
                    linesSoFarHeading++; //Make space between the horse and another horse
                }
            }

            //Print Page method to print each owner 
            amountOfOwnersPrinted++;
            if (amountOfOwnersPrinted < pagesAmountExpected)        //If amount to be printed is less than the expected
            {
                e.HasMorePages = true;                              //More page to print
            }
            else
            {
                e.HasMorePages = false;                             //No more page to print and return
                return;
            }
        }

    }
}
