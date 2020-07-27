/*
    ISCG6421 - GUI Programming, Semester 1 2020
    By: Ponhvath Vann, 1502538
*/
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
    public partial class MainForm : Form
    {
        private DataModule DM;
        private RaceCourseForm frmRaceCourse;
        private MeetingForm frmMeeting;
        private RaceForm frmRace;
        private OwnerForm frmOwner;
        private HorseForm frmHorse;
        private EnterHorseRaceForm frmEnterHorseRace;
        private MeetingsReportForm frmMeetingsReport;
        private OwnersReportForm frmOwnersReport;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DM = new DataModule();
        }

        //Function to open the Race Course Form Panel
        private void btnRaceCourse_Click(object sender, EventArgs e)
        {
            if(frmRaceCourse == null)
            {
                frmRaceCourse = new RaceCourseForm(DM, this);
            }
            frmRaceCourse.ShowDialog();
        }

        //Function to close the Main Menu dialog
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Function to open the Owner Form Panel
        private void btnOwner_Click(object sender, EventArgs e)
        {
            if (frmOwner == null)
            {
                frmOwner = new OwnerForm(DM, this);
            }
            frmOwner.ShowDialog();
        }

        //Function to open the Horse Form Panel
        private void btnHorse_Click(object sender, EventArgs e)
        {
            if (frmHorse == null)
            {
                frmHorse = new HorseForm(DM, this);
            }
            frmHorse.ShowDialog();
        }

        //Function to open the Race Form Panel
        private void btnRace_Click(object sender, EventArgs e)
        {
            if (frmRace == null)
            {
                frmRace = new RaceForm(DM, this);
            }
            frmRace.ShowDialog();
        }

        //Function to open the Meeting Form Panel
        private void btnMeeting_Click(object sender, EventArgs e)
        {
            if (frmMeeting == null)
            {
                frmMeeting = new MeetingForm(DM, this);
            }
            frmMeeting.ShowDialog();
        }

        //Function to open the Enter Horse Race Form Panel
        private void btnEnterHorseRace_Click(object sender, EventArgs e)
        {
            if (frmEnterHorseRace == null)
            {
                frmEnterHorseRace = new EnterHorseRaceForm(DM, this);
            }
            frmEnterHorseRace.ShowDialog();
        }

        //Function to open the Meeting Report Form Panel
        private void btnMeetingsReport_Click(object sender, EventArgs e)
        {
            if (frmMeetingsReport == null)
            {
                frmMeetingsReport = new MeetingsReportForm(DM, this);
            }
            frmMeetingsReport.ShowDialog();
        }

        //Function to open the Owner Report Form Panel
        private void btnOwnersReport_Click(object sender, EventArgs e)
        {
            if (frmOwnersReport == null)
            {
                frmOwnersReport = new OwnersReportForm(DM, this);
            }
            frmOwnersReport.ShowDialog();
        }
    }
}
