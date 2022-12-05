using System.Data;

namespace NBAFantasyLeagueSeasonSchedulerSYS
{


    partial class Teams_File
    {
        partial class TeamsDataTable
        {
            public TeamsDataTable(
                DataColumn columnTEAM_ID, 
                DataColumn columnNAME,
                DataColumn columnHEAD_COACH, 
                DataColumn columnMANAGER,
                DataColumn columnASSISTANT_COACH, 
                DataColumn columnHOME_COURT
                )
            {
                this.columnTEAM_ID = columnTEAM_ID;
                this.columnNAME = columnNAME;
                this.columnHEAD_COACH = columnHEAD_COACH;
                this.columnMANAGER = columnMANAGER;
                this.columnASSISTANT_COACH = columnASSISTANT_COACH;
                this.columnHOME_COURT = columnHOME_COURT;
            }
        }
    }
}
