using System;
using System.Collections.Generic;
using System.Text;

namespace RPSGame
{
    public class Player
    {
        public int Id;
        public int Score;
        public string Name;
        public Choises Choise;
        public PlayerType Type;

    }
    
    public enum PlayerType
    {
        CPU,
        Human
    }
}
