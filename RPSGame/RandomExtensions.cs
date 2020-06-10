using System;
using System.Collections.Generic;
using System.Text;

namespace RPSGame
{
    public static class RandomExtensions
    {
        public static T NextEnum<T>(this Random random)
        {
            var values = Enum.GetValues(typeof(T));
            return (T)values.GetValue(random.Next(values.Length));
        }
    }
}
