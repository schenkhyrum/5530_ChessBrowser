using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows;

namespace ChessTools
{
    public class PGNReader
    {
        // Main function for PGNReader DOOOOOOONE
        public PGNReader(string PGNfilename)
        {
            string[] fileText = File.ReadAllLines(PGNfilename);
            //ChessGame game = new ChessGame();

            bool readingMoves = false;
            foreach (string s in fileText)
            {
                if (readingMoves == true)
                {
                    if (s == "")
                    {
                        readingMoves = !readingMoves;
                        ChessGame game = new ChessGame(eventName, siteName, round, whitePlayer, blackPlayer,
                                                       whiteElo, blackElo, result, date, moves);

                        games.Add(game);

                        clearData();
                        continue;
                    }
                    //game.Moves += (s + "\n");
                    AddMoves(s);
                }
                if (s.StartsWith("[Event "))
                {
                    AddName(s);
                    //game.EventName = s.Substring(8, s.Length - 10);
                    //Console.WriteLine(game.EventName);
                }
                else if (s.StartsWith("[Site "))
                {
                    AddSite(s);
                    //game.SiteName = s.Substring(7, s.Length - 9);
                    //Console.WriteLine(game.SiteName);
                }
                else if (s.StartsWith("[Round "))
                {
                    AddRound(s);
                    //game.Round = s.Substring(8, s.Length - 10);
                    //Console.WriteLine(game.Round);
                }
                else if (s.StartsWith("[White "))
                {
                    AddWhitePlayer(s);
                    //game.WhitePlayer = s.Substring(8, s.Length - 10);
                    //Console.WriteLine(game.WhitePlayer);
                }
                else if (s.StartsWith("[Black "))
                {
                    AddBlackPlayer(s);
                    //game.BlackPlayer = s.Substring(8, s.Length - 10);
                    //Console.WriteLine(game.BlackPlayer);
                }
                else if (s.StartsWith("[WhiteElo "))
                {
                    AddWhiteElo(s);
                    //game.WhiteElo = int.Parse(s.Substring(11, s.Length - 13));
                    //Console.WriteLine(game.WhiteElo);
                }
                else if (s.StartsWith("[BlackElo "))
                {
                    AddBlackElo(s);
                    //game.BlackElo = int.Parse(s.Substring(11, s.Length - 13));
                    //Console.WriteLine(game.BlackElo);
                }
                else if (s.StartsWith("[Result "))
                {
                    AddResult(s);
                    /*
                    string temp = s.Substring(9, s.Length - 11);
                    if (temp == "1-0")
                        game.Result = 'W';
                    else if (temp == "0-1")
                        game.Result = 'B';
                    else if (temp == "1/2-1/2")
                        game.Result = 'D';
                    else
                        game.Result = '?';
                    */
                    //Console.WriteLine(game.Result);
                }
                else if (s.StartsWith("[EventDate "))
                {
                    AddDate(s);
                    //string temp = s.Substring(12, s.Length - 14);
                    //game.Date = DateTime.Parse(temp);
                    //Console.WriteLine(game.Date);
                    //Console.WriteLine("\n");
                }
                else if (s == "")
                {
                    //Console.WriteLine("BLANK FOUND\n");
                    readingMoves = !readingMoves;
                }
            }
        }

        // Name tag found
        private void AddName(string s)
        {
            eventName = s.Substring(8, s.Length - 10);
        }
        // Site tag found
        private void AddSite(string s)
        {
            siteName = s.Substring(7, s.Length - 9);
        }
        // Round tag found
        private void AddRound(string s)
        {
            round = s.Substring(8, s.Length - 10);
        }
        // whitePlayer tag found
        private void AddWhitePlayer(string s)
        {
            whitePlayer = s.Substring(8, s.Length - 10);
        }
        // blackPlayer tag found
        private void AddBlackPlayer(string s)
        {
            blackPlayer = s.Substring(8, s.Length - 10);
        }
        // whiteElo tag found
        private void AddWhiteElo(string s)
        {
            whiteElo = int.Parse(s.Substring(11, s.Length - 13));
        }
        // blackElo tag found
        private void AddBlackElo(string s)
        {
            blackElo = int.Parse(s.Substring(11, s.Length - 13));
        }
        // result tag found
        private void AddResult(string s)
        {
            string temp = s.Substring(9, s.Length - 11);
            if (temp == "1-0")
                result = 'W';
            else if (temp == "0-1")
                result = 'B';
            else if (temp == "1/2-1/2")
                result = 'D';
            else
                result = '?';
        }
        // DATE tag found
        private void AddDate(string s)
        {
            try
            {
                string temp = s.Substring(12, s.Length - 14);
                date = DateTime.Parse(temp);
            }
            catch
            {
                date = DateTime.MinValue;
            }
        }
        // Moves found
        private void AddMoves(string s)
        {
            moves += (s + "\n");
        }

        // Reset data in preparation of new data
        private void clearData()
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
            moves = moves = "";
        }

        public List<ChessGame> GetGames()
        {
            return games;
        }

        // Declared private variables
        private List<ChessGame> games = new List<ChessGame>();

        private string eventName;
        private string siteName;
        private string round;
        private string whitePlayer;
        private string blackPlayer;
        private int whiteElo;
        private int blackElo;
        private char result;
        private DateTime date;
        private string moves;
    }
}
