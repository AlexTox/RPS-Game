using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace RPSGame
{
    public static class ConsoleWriter
    {
        public static void WriteJoinInformation()
        {
            Console.WriteLine("|------------------------------------|");
            Console.WriteLine("|--- For start game write /start --- |");
            Console.WriteLine("|- For exit from game write /exit  - |");
            Console.WriteLine("|------------------------------------|");
        }

        public static void WriteGameStarted()
        {
            Console.WriteLine("|------------------------------------|");
            Console.WriteLine($"|---------- Game Started ---------- |");
            Console.WriteLine("|------------------------------------|");
        }
        public static void WriteChoosePlayerType()
        {
            Console.WriteLine("|------------------------------------|");
            Console.WriteLine($"|---------- Choose player type ---------- |");
            Console.WriteLine($"|---------- 1 - Human  ------------ |");
            Console.WriteLine($"|--------- 2 - CPU (Robot) -------- |");
            Console.WriteLine("|------------------------------------|");
        }

        public static void WriteUnknownCommand()
        {
            Console.WriteLine("|------------------------------------|");
            Console.WriteLine($"|------- Unknown Command ---------- |");
            Console.WriteLine("|------------------------------------|");
        }

        public static void WriteGetName(Player player)
        {
            Console.WriteLine("|------------------------------------|");
            Console.WriteLine($"|------- Hello player {player.Name} ------- |");
            Console.WriteLine($"|------- Write you name ----------- |");
            Console.WriteLine("|------------------------------------|");
        }

        public static void WriteGetChoose(Player player)
        {
            Console.WriteLine("|------------------------------------|");
            Console.WriteLine($"|------- Player {player.Name} ------- |");
            Console.WriteLine("|-------- Write you choose --------- |");
            Console.WriteLine("|------------ 1 -> Rock ------------ |");
            Console.WriteLine("|------------ 2 -> Paper ----------- |");
            Console.WriteLine("|----------- 3 -> Scissors --------- |");
            Console.WriteLine("|------------------------------------|");
        }

        public static void WriteWantNextRound()
        {
            Console.WriteLine("|------------------------------------|");
            Console.WriteLine("|- For start round write /continue - |");
            Console.WriteLine("|-- For end  game write /endgame  -- |");
            Console.WriteLine("|------------------------------------|");
        }

        public static void WriteRoundWinner(Player player)
        {
            Console.WriteLine("|------------------------------------|");
            Console.WriteLine($"|---- Round Winner: {player.Name}, Score: {player.Score} |");
            Console.WriteLine("|------------------------------------|");
        }

        public static void WriteDraw()
        {
            Console.WriteLine("|------------------------------------|");
            Console.WriteLine("|--------------- DRAW ---------------|");
            Console.WriteLine("|------------------------------------|");
        }

        public static void WriteWinner(Player player)
        {
            Console.WriteLine("|------------------------------------|");
            Console.WriteLine($"|---- Game Winner: {player.Name}, Score: {player.Score} |");
            Console.WriteLine("|------------------------------------|");
        }
    }
}
