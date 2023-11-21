using System;
using System.Collections.Generic;

namespace DeweyDecimalLibrary.Other
{
    public static class Global
    {
        // Game-related properties
        public static int CountdownTime { get; set; } = 60;
        public static int BonusPoints { get; set; } = 0;
        public static int Points { get; set; } = 0;
        public static int countAlt { get; set; }
        public static bool UpdateUserControl { get; set; } = false;

        // Game mode flags
        public static bool SortCallingNos { get; set; } = false;
        public static bool IdentifyingAreas { get; set; } = false;
        public static bool FindCallingNos { get; set; } = false;
        public static bool SaveScore { get; set; } = false;
        public static string Username { get; set; } = null;
        public static bool isAltGame { get; set; } = false;
        public static bool Game1 { get; set; } = false;
        public static bool Game2 { get; set; } = false;
        public static bool Game3 { get; set; } = false;

        // Collections
        public static List<ModelIdentifyingCallNos> lstDescription = new List<ModelIdentifyingCallNos>();
        public static List<string> lstCallNos = new List<string>();
        public static Dictionary<string, string> dictCallNoDescription = new Dictionary<string, string>();
    }
}
//--------------------------------------------------------------------Kaylox--------------------------------------------------//   
