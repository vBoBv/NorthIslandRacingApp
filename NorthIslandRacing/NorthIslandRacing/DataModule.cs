using System;
using System.Data.OleDb;
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
    public partial class DataModule : Form
    {
        public DataTable dtEntry;
        public DataTable dtHorse;
        public DataTable dtMeeting;
        public DataTable dtOwner;
        public DataTable dtRace;
        public DataTable dtRaceCourse;
        public DataView entryView;
        public DataView horseView;
        public DataView meetingView;
        public DataView ownerView;
        public DataView raceView;
        public DataView raceCourseView;

        public DataModule()
        {
            InitializeComponent();
            dsNorthIslandRacing.EnforceConstraints = false;
            daEntry.Fill(dsNorthIslandRacing);
            daHorse.Fill(dsNorthIslandRacing);
            daMeeting.Fill(dsNorthIslandRacing);
            daOwner.Fill(dsNorthIslandRacing);
            daRace.Fill(dsNorthIslandRacing);
            daRaceCourse.Fill(dsNorthIslandRacing);
            dtEntry = dsNorthIslandRacing.Tables["Entry"];
            dtHorse = dsNorthIslandRacing.Tables["Horse"];
            dtMeeting = dsNorthIslandRacing.Tables["Meeting"];
            dtOwner = dsNorthIslandRacing.Tables["Owner"];
            dtRace = dsNorthIslandRacing.Tables["Race"];
            dtRaceCourse = dsNorthIslandRacing.Tables["RaceCourse"];

            horseView = new DataView(dtHorse);
            horseView.Sort = "HorseID";
            meetingView = new DataView(dtMeeting);
            meetingView.Sort = "MeetingID";
            ownerView = new DataView(dtOwner);
            ownerView.Sort = "OwnerID";
            raceView = new DataView(dtRace);
            raceView.Sort = "RaceID";
            raceCourseView = new DataView(dtRaceCourse);
            raceCourseView.Sort = "RaceCourseID";

            dsNorthIslandRacing.EnforceConstraints = true;
        }

        //Functions to Update the database
        public void UpdateRaceCourse()
        {
            daRaceCourse.Update(dtRaceCourse);
        }

        public void UpdateOwner()
        {
            daOwner.Update(dtOwner);
        }

        public void UpdateRace()
        {
            daRace.Update(dtRace);
        }

        public void UpdateHorse()
        {
            daHorse.Update(dtHorse);
        }

        public void UpdateMeeting()
        {
            daMeeting.Update(dtMeeting);
        }
        
        public void UpdateEntry()
        {
            daEntry.Update(dtEntry);
        }


        //Functions to access the new value of each table key field
        private void daRaceCourse_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnNorthIslandRacing);

            if(e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["RaceCourseID"] = newID;
            }
        }

        private void daOwner_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnNorthIslandRacing);

            if(e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["OwnerID"] = newID;
            }
        }

        private void daRace_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnNorthIslandRacing);

            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["RaceID"] = newID;
            }
        }

        private void daHorse_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnNorthIslandRacing);

            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["HorseID"] = newID;
            }
        }

        private void daMeeting_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnNorthIslandRacing);

            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["MeetingID"] = newID;
            }
        }
    }
}
