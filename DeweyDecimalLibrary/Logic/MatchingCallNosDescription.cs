using DeweyDecimalLibrary.Json;
using DeweyDecimalLibrary.Other;
using System;
using System.Collections.Generic;

namespace DeweyDecimalLibrary.Logic
{
    public class MatchingCallNosDescription
    {
        int count = 0; // Initialize a counter to keep track of correct answers.

        #region List Description
        public List<ModelIdentifyingCallNos> GetDescription()
        {
            // Check if the JSON file with call number descriptions exists, if not, create it.
            if (!JsonFileUtility.CallNumFileExists())
            {
                JsonFileUtility.CreateCallNumFile();
            }

            // Load the call number descriptions from the JSON file into a dictionary.
            Dictionary<string, string> callNums = JsonFileUtility.GetKeyValuePairs();

            // Initialize a random number generator.
            Random rnd = new Random();

            // Create a list to store random numbers.
            List<int> randomNums = new List<int>();

            // Generate 7 unique random numbers between 0 and 9.
            while (randomNums.Count <= 6)
            {
                int n = rnd.Next(0, 10);

                if (!randomNums.Contains(n))
                {
                    randomNums.Add(n);
                }
            }

            // Create a list to store ModelIdentifyingCallNos objects with random call numbers and their descriptions.
            List<ModelIdentifyingCallNos> lstRandomCallNos = new List<ModelIdentifyingCallNos>();

            // Map random numbers to call numbers and descriptions.
            foreach (int num in randomNums)
            {
                lstRandomCallNos.Add(new ModelIdentifyingCallNos { Key = $"{num}00", Value = callNums.GetValueOrDefault($"{num}00") });
            }

            return lstRandomCallNos;
        }
        #endregion

        #region List Call Numbers
        // Generate 4 call numbers from the generated dictionary of 7 KeyValuePairs (descriptions).
        public List<string> GetCallNos()
        {
            for (int i = 0; i < 4; i++)
            {
                // Get the first 4 call numbers from the shuffled dictionary and add them to the Global list.
                Global.lstCallNos.Add((string)Global.lstDescription.ToList().Select(x => x.Key).ToList().ElementAt(i));
            }

            return Global.lstCallNos;
        }
        #endregion

        #region Check Users Answer
        // Check if the user input matches the dictionary key-value pair.
        public bool CheckAnswer(string callNo, string desc, bool isAlt)
        {
            // Populate the dictionary with the key-value pairs stored in the JSON file.
            Global.dictCallNoDescription = JsonFileUtility.GetKeyValuePairs();

            // Declare a temporary dictionary to store user input.
            Dictionary<string, string> tempDict = new Dictionary<string, string>();

            if (isAlt)
            {
                // Populate the temp dictionary with user input.
                tempDict.Add(callNo, desc);

                // Iterate through the temp dictionary.
                foreach (var x in tempDict)
                {
                    // Iterate through the JSON dictionary (contains all listed key-value pairs).
                    foreach (var y in Global.dictCallNoDescription)
                    {
                        // Check if the user pair matches the predefined pairs.
                        if (x.Key.Equals(y.Key) && x.Value.Equals(y.Value))
                        {
                            count++;
                            return true;
                        }
                    }
                }
                return false;
            }
            else
            {
                // Populate the temp dictionary with user input.
                tempDict.Add(callNo, desc);

                // Iterate through the temp dictionary.
                foreach (var x in tempDict)
                {
                    // Iterate through the JSON dictionary (contains all listed key-value pairs).
                    foreach (var y in Global.dictCallNoDescription)
                    {
                        // Check if the user pair matches the predefined pairs.
                        if (x.Key.Equals(y.Value) && x.Value.Equals(y.Key))
                        {
                            count++;
                            return true;
                        }
                    }
                }
                return false;
            }
        }
        #endregion

        #region Game Finished
        // Method to check if the player has completed the game.
        public bool isGameFinished(int listboxItemsCount)
        {
            if (count == 4 || listboxItemsCount == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
//--------------------------------------------------------------------Kaylox--------------------------------------------------//   
