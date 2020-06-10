using System;
using System.ComponentModel;
using System.Linq;

namespace RPSGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Program mainProgramClass = new Program();
            while(true)
            {
                ConsoleWriter.WriteJoinInformation();
                string inputString = Console.ReadLine().ToLower();
                if (inputString == "/start")
                {
                    mainProgramClass.RunGame();
                }
                else if (inputString == "/exit")
                {
                    break;
                }
                else
                {
                    Console.Clear();
                }
            }
        }

        public void RunGame()
        {
            Player[] players = new Player[2];

            for (int i = 0; i < players.Length; i++)
            {
                string inputString;
                string name;

                PlayerType typePlayer = PlayerType.CPU;

                Console.Clear();
                ConsoleWriter.WriteChoosePlayerType();

                while (true)
                {
                    inputString = Console.ReadLine().ToLower();

                    try 
                    {
                        int typeNumber = Int32.Parse(inputString);
                        if (typeNumber == 1)
                        {
                            typePlayer = PlayerType.Human;
                        }
                        else if (typeNumber == 2)
                        {
                            typePlayer = PlayerType.CPU;
                        }
                        else
                        {
                            Console.Clear();
                            ConsoleWriter.WriteUnknownCommand();
                            ConsoleWriter.WriteChoosePlayerType();
                        }
                    
                    }
                    catch
                    {
                        Console.Clear();
                        ConsoleWriter.WriteUnknownCommand();
                        ConsoleWriter.WriteChoosePlayerType();
                    }

                    if (typePlayer == PlayerType.CPU)
                    {
                        name = $"CPU - {i}";
                    }
                    else
                    {
                        Console.Clear();
                        ConsoleWriter.WriteGetName(players[i]);
                        name = Console.ReadLine();
                    }

                    players[i] = new Player { Id = i, Name = name, Type = typePlayer, Score = 0, Choise = Choises.Rock };
                    break;
                }
     

            }

            Console.Clear();
            ConsoleWriter.WriteGameStarted();

            while (true)
            {
                string inputString;
                for (int i = 0; i < players.Length; i++)
                {
                    if (players[i].Type == PlayerType.CPU)
                    {
                        var random = new Random();
                        var randomChoise = random.Next(0, 4);
                        if (randomChoise > 0 && randomChoise <= 3)
                        {
                            players[i].Choise = CheckChoise(randomChoise);
                        }
                    }
                    else
                    {
                        while (true)
                        {
                            Console.Clear();
                            ConsoleWriter.WriteGetChoose(players[i]);
                            inputString = Console.ReadLine().ToLower();
                            try
                            {
                                int inputChoose = Int32.Parse(inputString);
                                if (inputChoose > 0 && inputChoose <= 3)
                                {
                                    players[i].Choise = CheckChoise(inputChoose);
                                }
                                else
                                {
                                    Console.Clear();
                                    ConsoleWriter.WriteUnknownCommand();
                                    ConsoleWriter.WriteGetChoose(players[i]);
                                }
                            }
                            catch
                            {
                                Console.Clear();
                                ConsoleWriter.WriteUnknownCommand();
                                ConsoleWriter.WriteGetChoose(players[i]);
                            }
                            break;
                        }
                    }
                }
                Player roundWinner = GameController.CheckRoundWinner(players[0], players[1]);
                Console.Clear();
                if (roundWinner == null)
                {
                    ConsoleWriter.WriteDraw();
                }
                else
                {
                    ConsoleWriter.WriteRoundWinner(roundWinner);
                }
                ConsoleWriter.WriteWantNextRound();

                inputString = Console.ReadLine().ToLower();

                if (inputString == "/continue")
                {
                    continue;
                }
                else if (inputString == "/endgame")
                {
                    break;
                }
                else
                {

                }

            }

            Console.Clear();
            Player gameWinner = GameController.GetGameWinner(players[0], players[1]);
            if (gameWinner == null)
            {
                ConsoleWriter.WriteDraw();
            }
            else
            {
                ConsoleWriter.WriteWinner(gameWinner);
            }
            
        }

        public static Choises CheckChoise(int chooseId)
        {
            Choises choise;

            if (chooseId == 1)
            {
                choise = Choises.Rock;
            }
            else if (chooseId == 2)
            {
                choise = Choises.Paper;
            }
            else if (chooseId == 3)
            {
                choise = Choises.Scissors;
            }
            else
            {
                return Choises.Rock;
            }

            return choise;
        }
    }
}
