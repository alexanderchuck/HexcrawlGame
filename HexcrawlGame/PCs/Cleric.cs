using System;
using System.Collections.Generic;
using System.Text;

namespace HexcrawlGame.PCs
{
    public class Cleric
    {
        // HD Progression
        // Experience Needed to Level Up
        // Attack Matrix
        // Saving Throws
        public static readonly Dictionary<int, int> HDProgression = new()
        {
            { 1, new Random().Next(1, 7) },
            { 2, new Random().Next(2, 13) },
            { 3, new Random().Next(3, 14) },
            { 4, new Random().Next(3, 19) },
            { 5, new Random().Next(4, 25) },
            { 6, new Random().Next(5, 31) },
            { 7, new Random().Next(6, 32) },
            { 8, new Random().Next(6, 37) },
            { 9, new Random().Next(7, 43) },
            { 10, new Random().Next(8, 44) },
            { 11, new Random().Next(9, 45) },
            { 12, new Random().Next(8, 49) },
        };

        // Key is Cleric level and paired value is number to hit AC 9
        public static readonly Dictionary<int, int> AttackMatrix = new()
        {
            { 1, 10 },
            { 2, 9 },
            { 3, 9 },
            { 4, 8 },
            { 5, 7 },
            { 6, 7 },
            { 7, 6 },
            { 8, 6 },
            { 9, 5 },
            { 10, 5 },
            { 11, 5 },
            { 12, 5 },
        };

        public static readonly Dictionary<int, int[]> SavingThrows = new()
        {
            { 1, [11, 12, 14, 16, 15] },
            { 2, [10, 11, 13, 15, 14] },
            { 3, [10, 11, 13, 15, 14] },
            { 4, [9, 10, 12, 14, 13] },
            { 5, [9, 10, 12, 14, 13] },
            { 6, [8, 9, 11, 13, 12] },
            { 7, [8, 9, 11, 13, 12] },
            { 8, [7, 8, 10, 12, 11] },
            { 9, [7, 8, 10, 12, 11] },
            { 10, [6, 7, 9, 11, 10] },
            { 11, [6, 7, 9, 11, 10] },
            { 12, [5, 6, 8, 10, 9] },
        };

        public static readonly int[] ExpToLevel = 
        {
            1500, // Level 2
            3000, // Level 3
            6000, // Level 4
            12000, // Level 5
            25000, // Level 6
            50000, // Level 7
            90000, // Level 8
            160000, // Level 9
            240000, // Level 10
            320000, // Level 11
            400000, // Level 12
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
