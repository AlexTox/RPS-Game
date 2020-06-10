using System;
using System.Collections.Generic;
using System.Text;

namespace RPSGame
{
    public static class GameController
    {
        public static Player CheckRoundWinner(Player firstPlayer, Player secondPlayer)
        {
            Player winner = null;

            switch (firstPlayer.Choise)
            {
                case Choises.Rock:
                    switch (secondPlayer.Choise)
                    {
                        case Choises.Rock:
                            winner = null;
                            break;
                        case Choises.Paper:
                            winner = secondPlayer;
                            break;
                        case Choises.Scissors:
                            winner = firstPlayer;
                            break;
                    }
                    break;
                case Choises.Paper:
                    switch (secondPlayer.Choise)
                    {
                        case Choises.Rock:
                            winner = firstPlayer;
                            break;
                        case Choises.Paper:
                            winner = null;
                            break;
                        case Choises.Scissors:
                            winner = secondPlayer;
                            break;
                    }
                    break;
                case Choises.Scissors:
                    switch (secondPlayer.Choise)
                    {
                        case Choises.Rock:
                            winner = secondPlayer;
                            break;
                        case Choises.Paper:
                            winner = firstPlayer;
                            break;
                        case Choises.Scissors:
                            winner = null;
                            break;
                    }
                    break;
            }

            if (winner != null)
            {
                winner = IncreaseScore(winner);
            }

            return winner; 
        }

        public static Player IncreaseScore(Player player)
        {
            player.Score++;
            return player;
        }

        public static Player GetGameWinner(Player firstPlayer, Player secondPlayer)
        {
            Player winner = null;
            if (firstPlayer.Score > secondPlayer.Score)
            {
                winner = firstPlayer;
            }
            else if (firstPlayer.Score < secondPlayer.Score)
            {
                winner = secondPlayer;
            }
            else if (firstPlayer.Score == secondPlayer.Score)
            {
                winner = null;
            }

            return winner;
        }
    }

    public enum Choises
    {
        Rock,
        Paper,
        Scissors
    }

}
