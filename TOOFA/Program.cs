using System;

namespace TOOFA
{
    class Program
    {
        static void Main(string[] args)
        {
            //Just playing with some ideas for now...

            var club = new Club(
                "Golden Oldies",
                new Account(100));

            club.Plays(
                new Game(
                    new DateTime(2016, 7, 16)));

            var pool = new PlayerPool();

            var player = pool.Adds(new Player("Dave"));
            pool.Adds(new Player("Fred"));
            pool.Adds(new Player("Matt"));

            var organiser = new Organiser(club);
            organiser.Logs(player, club.LastGamePlayed());

            var treasurer = new Treasurer(club);
            player.Pays(treasurer, 8);
            treasurer.Refunds(player, 4);
        }

        private class Account
        {
            private int v;

            public Account(int v)
            {
                this.v = v;
            }
        }

        private class Club
        {
            private Account account;
            private string v;

            public Club(string v, Account account)
            {
                this.v = v;
                this.account = account;
            }

            internal object LastGamePlayed()
            {
                throw new NotImplementedException();
            }

            internal void Plays(Game game)
            {
                throw new NotImplementedException();
            }
        }

        private class Game
        {
            private DateTime dateTime;

            public Game(DateTime dateTime)
            {
                this.dateTime = dateTime;
            }
        }

        private class Organiser
        {
            private Club club;

            public Organiser(Club club)
            {
                this.club = club;
            }

            internal void Logs(Player player, object v)
            {
                throw new NotImplementedException();
            }
        }

        private class Player
        {
            private string v;

            public Player(string v)
            {
                this.v = v;
            }

            internal void Pays(Treasurer treasurer, int v)
            {
                throw new NotImplementedException();
            }
        }

        private class PlayerPool
        {
            public PlayerPool()
            {
            }

            internal Player Adds(Player player)
            {
                throw new NotImplementedException();
            }
        }

        private class Treasurer
        {
            private Club club;

            public Treasurer(Club club)
            {
                this.club = club;
            }

            internal void Refunds(Player player, int v)
            {
                throw new NotImplementedException();
            }
        }
    }
}
