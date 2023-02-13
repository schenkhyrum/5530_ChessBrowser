using System;

namespace ChessTools
{
    public class ChessGame
    {

        public ChessGame(string eventName, string siteName, string round, string whitePlayer, string blackPlayer,
                         int whiteElo, int blackElo, char result, DateTime date, string moves)
        {
            this.eventName = eventName;
            this.siteName = siteName;
            this.round = round;
            this.whitePlayer = whitePlayer;
            this.blackPlayer = blackPlayer;
            this.whiteElo = whiteElo;
            this.blackElo = blackElo;
            this.result = result;
            this.date = date;
            this.moves = moves;
        }
        
        public string getName()
        {
            return eventName;
        }
        public string getSite()
        {
            return siteName;
        }
        public string getRound()
        {
            return round;
        }
        public string getWhitePlayer()
        {
            return whitePlayer;
        }
        public string getBlackPlayer()
        {
            return blackPlayer;
        }
        public int getWhiteElo()
        {
            return whiteElo;
        }
        public int getBlackElo()
        {
            return blackElo;
        }
        public char getResult()
        {
            return result;
        }
        public DateTime getDate()
        {
            return date;
        }
        public string getMoves()
        {
            return moves;
        }


        /*
        public ChessGame()
        {
 
        }
        public string EventName   // property
        {
            get { return eventName; }   // get method
            set { eventName = value; }  // set method
        }
        public string SiteName
        {
            get { return siteName; }
            set { siteName = value; }
        }
        public string Round
        {
            get { return round; }
            set { round = value; }
        }
        public string WhitePlayer
        {
            get { return whitePlayer; }
            set { whitePlayer = value; }
        }
        public string BlackPlayer
        {
            get { return blackPlayer; }
            set { blackPlayer = value; }
        }
        public int WhiteElo
        {
            get { return whiteElo; }
            set { whiteElo = value; }
        }
        public int BlackElo
        {
            get { return blackElo; }
            set { blackElo = value; }
        }
        public char Result
        {
            get { return result; }
            set { result = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public string Moves
        {
            get { return moves; }
            set { moves = value; }
        }

        public void ResetData()
        {
            eventName = "?";
            siteName = "?";
            round = "?";
            whitePlayer = "?";
            blackPlayer = "?";
            whiteElo = 0;
            blackElo = 0;
            result = 'U';
            date = DateTime.Parse("01.01.0001");
            moves = "";
        }
        */

        private string eventName = "?";
        private string siteName = "?";
        private string round = "?";
        private string whitePlayer = "?";
        private string blackPlayer = "?";
        private int whiteElo = 0;
        private int blackElo = 0;
        private char result = 'U';
        private DateTime date = DateTime.Parse("01.01.0001");
        private string moves = "";
    }
}
