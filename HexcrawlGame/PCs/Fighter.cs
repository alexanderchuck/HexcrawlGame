using System;
using System.Collections.Generic;
using System.Text;

namespace HexcrawlGame.PCs
{
    internal class Fighter
    {
        // HD Progression
        // Experience Needed to Level Up
        // Attack Matrix
        // Saving Throws
        public static readonly Dictionary<int, int> HDProgression = new()
        {
            { 1, new Random().Next(3, 9)},
            { 2, new Random().Next(3, 14) },
            { 3, new Random().Next(3, 19) },
            { 4, new Random().Next(4, 25) },
            { 5, new Random().Next(5, 31) },
            { 6, new Random().Next(6, 37) },
            { 7, new Random().Next(7, 43) },
            { 8, new Random().Next(9, 50) },
            { 9, new Random().Next(11, 57) },
            { 10, new Random().Next(10, 61) },
            { 11, new Random().Next(12, 63)  },
            { 12, new Random().Next(11, 67) },
        };

        public static readonly int[] ExpToLevel =
            {
                2000, // Level 2
                4000, // Level 3
                8000, // Level 4
                16000, // Level 5
                32000, // Level 6
                65000, // Level 7
                130000, // Level 8
                240000, // Level 9
                360000, // Level 10
                480000, // Level 11
                600000, // Level 12
            };
    }
}
