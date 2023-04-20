﻿using NBAFantasyLeagueSeasonSchedulerSYS.Teams;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NBAFantasyLeagueSeasonSchedulerSYS.Games
{
    public partial class frmSchedule : Form
    {
        private static new Form Parent;
        private static List<Team> allTeams;
        private static List<Game> allGames;
        private static bool scheduleExists;
        private static Random rand = new Random();

        public frmSchedule(Form parent)
        {
            InitializeComponent();

            Parent = parent;
        }

        private void frmSchedule_FormClosing(object sender, FormClosingEventArgs e)
        {
            Parent.Show();
        }

        private void frmSchedule_Load(object sender, EventArgs e)
        {
            Team.sqlSelectTeam(ref allTeams);
            checkIfScheduleExists();
            foreach (Team team in allTeams)
            {
                dtgTeamDetails.Rows.Add(team.teamID, team.teamName, team.gm, team.headCoach, team.asstCoach, team.homeCourt);
            }
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            DateTime seasonStart = dtpSeasonStart.Value;
            if (!scheduleExists) {
                if (dtgTeamDetails.Rows.Count < 10)
                {
                    MessageBox.Show("Exactly 10 Teams are required to start scheduling a season.", "Insufficient Teams", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    DialogResult cfm = MessageBox.Show("Proceed with these Teams?", "Teams Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (cfm == DialogResult.Yes)
                    {
                        List<string> allGameID = new List<string>();

                        //scheduling algorithm
                        generateGameID(new Queue<Team>(allTeams), ref allGameID);

                        generateDates(seasonStart, allGameID);

                        foreach (Game game in allGames)
                        {
                            try { game.sqlInsertGame(); }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"{ex.Message}: {ex.StackTrace}");
                                MessageBox.Show("An error with the database has occured. Exiting window.");
                                Close();
                                return;
                            }
                        }

                        MessageBox.Show("Schedule has been auto-generated by algorithm.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        scheduleExists = true;
                    }
                }

            }else
            {
                MessageBox.Show("A Schedule has already been generated, go to [Reschedule Game] to reschedule a specific Game, or [Admin]>[View Schedule] to view the generated Schedule.", "Schedule Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        //check if scheduleExist = true
        private void checkIfScheduleExists()
        {
            Game.sqlSelectAllGames(ref allGames);
            scheduleExists = (allGames.Count > 0) ?  true : false;
        }

        //scheduling algorithm
        private void generateGameID(Queue<Team> teamsQueue, ref List<string> allGameID)
        {
            if (teamsQueue.Count == 0) return;

            Team t1 = teamsQueue.Dequeue();
            foreach (Team t2 in teamsQueue)
            {
                allGameID.Add($"{t1.teamID}@{t2.teamID}:1");
                allGameID.Add($"{t2.teamID}@{t1.teamID}:2");
                allGameID.Add($"{t1.teamID}@{t2.teamID}:3");
            }

            generateGameID(teamsQueue, ref allGameID);
        }

        private void Shuffle<T>(ref List<T> values)
        {
            for (int i = values.Count - 1; i > 0; i--)
            {
                int k = rand.Next(i + 1);
                T value = values[k];
                values[k] = values[i];
                values[i] = value;
            }
        }
        private int generateDates(DateTime seasonStart, List<string> allGameID)
        {
            int count = 0;
            DateTime gameDate = seasonStart;

            allGames = new List<Game>();

            Shuffle(ref allGameID);

            foreach (string gameID in allGameID)
            {
                if (gameID == allGameID[0])
                {
                    allGames.Add(new Game(gameID, gameDate));
                }
                else
                {
                    gameDate = gameDate.AddDays(rand.Next(1, 4));
                    allGames.Add(new Game(gameID, gameDate));
                }
                count++;
            }

            return count;
        }
    }
}
