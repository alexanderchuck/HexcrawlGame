using System;
using System.Collections.Generic;
using System.Text;

namespace HexcrawlGame.PCs
{
    public class Fighter
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

        // Key is Fighter level and paired value is number to hit AC 9
        public static readonly Dictionary<int, int> AttackMatrix = new()
        {
            { 1, 9 },
            { 2, 9 },
            { 3, 8 },
            { 4, 7 },
            { 5, 6 },
            { 6, 6 },
            { 7, 5 },
            { 8, 5 },
            { 9, 4 },
            { 10, 4 },
            { 11, 3 },
            { 12, 3 },
        };

        public static readonly Dictionary<int, int[]> SavingThrows = new()
        {
            { 1, [12, 13, 14, 15, 16] },
            { 2, [12, 13, 14, 15, 16] },
            { 3, [10, 11, 12, 15, 14] },
            { 4, [10, 11, 12, 12, 14] },
            { 5, [10, 11, 12, 12, 14] },
            { 6, [8, 9, 10, 12, 12] },
            { 7, [8, 9, 10, 12, 12] },
            { 8, [8, 9, 10, 9, 12] },
            { 9, [6, 7, 8, 9, 10] },
            { 10, [6, 7, 8, 9, 10] },
            { 11, [6, 7, 8, 9, 10] },
            { 12, [4, 5, 6, 6, 8] },
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

        public static readonly Dictionary<string, int> StartingArmor = new()
        {
            {"Unarmored", 0 },
            {"Leather", 10 },
            {"Chainmail", 35 },
            {"Plate", 100 },
        };
    }
}
