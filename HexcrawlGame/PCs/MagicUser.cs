using System;
using System.Collections.Generic;
using System.Text;

namespace HexcrawlGame.PCs
{
    internal class MagicUser
    {
        // HD Progression
        // Experience Needed to Level Up
        // Attack Matrix
        // Saving Throws
        public static readonly Dictionary<int, int> HDProgression = new()
        {
            { 1, new Random().Next(1, 7)},
            { 2, new Random().Next(2, 8) },
            { 3, new Random().Next(2, 13) },
            { 4, new Random().Next(3, 19) },
            { 5, new Random().Next(4, 20) },
            { 6, new Random().Next(4, 25) },
            { 7, new Random().Next(5, 31) },
            { 8, new Random().Next(6, 32) },
            { 9, new Random().Next(6, 37) },
            { 10, new Random().Next(7, 43) },
            { 11, new Random().Next(8, 44)  },
            { 12, new Random().Next(9, 45) },
        };

        public static readonly int[] ExpToLevel =
            {
                2500, // Level 2
                5000, // Level 3
                10000, // Level 4
                20000, // Level 5
                35000, // Level 6
                60000, // Level 7
                100000, // Level 8
                200000, // Level 9
                300000, // Level 10
                400000, // Level 11
                500000, // Level 12
            };
    }
}
