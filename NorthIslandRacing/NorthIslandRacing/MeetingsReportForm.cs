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
    public partial class MeetingsReportForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private int amountOfMeetingsPrinted, pagesAmountExpected;
        private DataRow[] meetingsForPrint;

        public MeetingsReportForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrintMeetings_Click(object sender, EventArgs e)
        {
            amountOfMeetingsPrinted = 0;                            //To keep count of the number of owners
            string strFilter = "COUNT(Child.MeetingID) >= 0";       //To get all of the meetings
            string strSort = "MeetingID";                           //Variable to store the sort parameter
            meetingsForPrint = DM.dsNorthIslandRacing.Tables["MEETING"].Select(strFilter, strSort, DataViewRowState.CurrentRows);               //In the Meeting table, select all the meetings
            pagesAmountExpected = meetingsForPrint.Length;          //Amount of page that needs to be printed
            prvMeetings.Show();                                     //Show the Print Preview Dialog
        }

        private void printMeetings_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Instantiate the Graphic and add style to the print preview page
            Graphics g = e.Graphics;
            int linesSoFarHeading = 0;
            Font textFont = new Font("Arial", 10, FontStyle.Regular);
            Font textFontCenter = new Font("Arial", 10, FontStyle.Regular);
            Font totalSubtotal = new Font("Arial", 10, FontStyle.Bold);
            Font headingFont = new Font("Arial", 10, FontStyle.Bold);
            DataRow drMeeting = meetingsForPrint[amountOfMeetingsPrinted];
            CurrencyManager cmMeeting;
            CurrencyManager cmRaceCourse;

            cmMeeting = (CurrencyManager)this.BindingContext[DM.dsNorthIslandRacing, "Meeting"];
            cmRaceCourse = (CurrencyManager)this.BindingContext[DM.dsNorthIslandRacing, "RaceCourse"];

            Brush brush = new SolidBrush(Color.Black);
            //Page margins
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int headingLeftMargin = 50;
            int topMarginDetails = topMargin + 70;
            int rightMargin = e.MarginBounds.Right;

            //Draw out Meeting Information
            //MeetingID
            g.DrawString("Meeting ID: " + drMeeting["MeetingID"], headingFont, brush, leftMargin + headingLeftMargin,
                 topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;

            //MeetingName
            g.DrawString(drMeeting["MeetingName"] + "", headingFont, brush, leftMargin + headingLeftMargin,
            topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;

            //Get Race Course record from the Race Course table using RaceCourseID from Meeting
            int aRaceCourseID = Convert.ToInt32(drMeeting["RaceCourseID"].ToString());
            cmRaceCourse.Position = DM.raceCourseView.Find(aRaceCourseID);
            DataRow drRaceCourseMeeting = DM.dtRaceCourse.Rows[cmRaceCourse.Position];

            //Race Course Name
            g.DrawString(drRaceCourseMeeting["RaceCourseName"] + "", headingFont, brush, leftMargin + headingLeftMargin,
            topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;

            //Street Address
            g.DrawString(drRaceCourseMeeting["StreetAddress"] + "", headingFont, brush, leftMargin + headingLeftMargin,
            topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;

            //Suburb
            g.DrawString(drRaceCourseMeeting["Suburb"] + "", headingFont, brush, leftMargin + headingLeftMargin,
            topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;

            //City
            g.DrawString(drRaceCourseMeeting["City"] + "", headingFont, brush, leftMargin + headingLeftMargin,
            topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;

            //Meeting date
            DateTime meetingDate = (DateTime)drMeeting["MeetingDate"];      //Implement built-in DateTime to use the ToShortDateString format funciton
            //g.DrawString("Meeting Date: " + drMeeting["MeetingDate"], headingFont, brush, leftMargin + headingLeftMargin,
            g.DrawString("Meeting Date: " + meetingDate.ToShortDateString(), headingFont, brush, leftMargin + headingLeftMargin,
            topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;

            //Races(heading)
            g.DrawString("Races:", headingFont, brush, leftMargin + headingLeftMargin,
            topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;

            //ID, Name, Time (heading)
            g.DrawString("\tID\t" + "Name\t\t\t" + "Time", headingFont, brush, leftMargin + headingLeftMargin,
            topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;

            //Get the races record which is the child of the Meeting table
            DataRow[] drRaces = drMeeting.GetChildRows(DM.dtMeeting.ChildRelations["FK_MEETING_RACE"]);
            if(drRaces.Length == 0)         //Check to see if meeting does not have a race
            {
                g.DrawString("\tThis meeting has no races schedule.", headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            }
            else
            {
                foreach (DataRow drRace in drRaces)
                {
                    DateTime raceTime = (DateTime)drRace["RaceTime"];      //Implement built-in DateTime to use the ToLongTimeString format funciton

                    //Draw out Race Information
                    //RaceID, RaceName, RaceTime
                    g.DrawString("\t" + drRace["RaceID"] + "\t" + drRace["RaceName"] + "\t\t" + raceTime.ToLongTimeString(), headingFont, brush, leftMargin + headingLeftMargin,
                    topMargin + (linesSoFarHeading * textFont.Height));
                    linesSoFarHeading++;      
                }
            }

            //Print Page method to print each owner 
            amountOfMeetingsPrinted++;
            if (amountOfMeetingsPrinted < pagesAmountExpected)              //If amount to be printed is less than the expected
            {
                e.HasMorePages = true;                                      //More page to print
            }
            else
            {
                e.HasMorePages = false;                                     //No more page to print and return
                return;
            }
        }
    }
}
