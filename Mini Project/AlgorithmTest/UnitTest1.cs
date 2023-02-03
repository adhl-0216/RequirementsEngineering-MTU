using NBAFantasyLeagueSeasonSchedulerSYS.Games;
using NBAFantasyLeagueSeasonSchedulerSYS.Teams;

namespace AlgorithmTest
{
    [TestClass]
    public class UnitTest1
    {
        private static Team t1 = new Team("'95-96 Chicago Bulls", "Jerry Krause", "Phil Jackson", "Jim Cleamons", "United Centre, 1901 W Madison St, Chicago, IL 60612, United States");

        private static Team t2 = new Team("'16-17 Golden State Warriors", "Bob Myers", "Steve Kerr", "Mike Brown", "Oracle Arena");

        private static Team t3 = new Team("'70-71 Milwaukee Bucks", "Ray Patterson", "Larry Costello", "Tom Nissalke", "Milwaukee Arena");

        private static Team t4 = new Team("'07-08 Boston Celtics", "Danny Ainge", "Doc Rivers", "Tom Thibodeau", "TD Banknorth Garden");

        private static Team t5 = new Team("'08-09 Cleveland Cavaliers", "Danny Ferry", "Mike Brown", "Michael Malone", "Quicken Loans Arena");

        private static Team t6 = new Team("'12-13 Oklahoma City Thunder", "Sam Presti", "Scott Brooks", "Maurice Cheeks", "Chesapeake Energy Arena");

        private static Team t7 = new Team("'88-89 Detroit Pistons", "Jack McCloskey", "Chuck Daly", "Brendan Malone", "The Palace of Auburn Hills");

        private static Team t8 = new Team("'86-87 Los Angeles Lakers", "Jerry West", "Pat Riley", "Bill Bertka", "The Forum");

        private static Team t9 = new Team("'82-83 Philadelphia 76ers", "Pat Williams", "Billy Cunningham", "Jack Mcmahon", "The Spectrum");

        private static Team t10 = new Team("'98-99 San Antonio Spurs", "Gregg Popovich", "Gregg Popovich", "Mike Budenholzer", "Alamodome");

        private Team[] allTeams = { t1, t2, t3, t4, t5, t6, t7, t8, t9, t10 };

        private List<string> allGameID = new List<string>();

        private List<Game> allGames = new List<Game>();
        
        private Random rand = new Random();

        [TestMethod]
        public void generateGameIDTest()
        {
            generateGameID(new Queue<Team>(allTeams), ref allGameID);

            Assert.AreEqual(135, allGameID.Count);
            //Console.WriteLine(string.Join("\n", allGameID));
        }

        private void generateGameID(Queue<Team> teamsQueue, ref List<string> allGameID)
        {
            if (teamsQueue.Count == 0) return;

            Team t1 = teamsQueue.Dequeue();
            foreach (Team t2 in teamsQueue)
            {
                allGameID.Add($"{t1.TeamID}@{t2.TeamID}:1");
                allGameID.Add($"{t2.TeamID}@{t1.TeamID}:2");
                allGameID.Add($"{t1.TeamID}@{t2.TeamID}:3");
            }

            generateGameID(teamsQueue, ref allGameID);
        }

        [TestMethod]
        public void generateDatesTest()
        {
            generateGameIDTest();
            int actual = generateDates(DateTime.Now, allGameID);
            Assert.AreEqual(135, allGames.Count);
            Assert.AreEqual(135, actual);
        
        
        }
        public void Shuffle<T>(ref List<T> values)
        {
            for (int i = values.Count - 1; i > 0; i--)
            {
                int k = rand.Next(i + 1);
                T value = values[k];
                values[k] = values[i];
                values[i] = value;
            }
        }
        int generateDates(DateTime seasonStart, List<string> allGameID)
        {
            int count = 0;
            DateTime gameDate = seasonStart;
            Shuffle(ref allGameID);
            foreach (string gameID in allGameID)
            {
                if (gameID == allGameID[0])
                {
                    allGames.Add(new Game(gameID, gameDate));
                }
                else
                {
                    gameDate = gameDate.AddDays(rand.Next(1,4));
                    allGames.Add(new Game(gameID, gameDate));
                }
                    count++;
            }

            return count;
        }
    }
}