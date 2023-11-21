using DeweyDecimalLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeweyDecimalLibrary.Other
{
    public class GameConverter
    {
        // Convert a single DeweyPair object to a DeweyPairGameModel object
        public static DeweyPairGameModel ConvertToGameModel(DeweyPair deweyPair)
        {
            // Create a new DeweyPairGameModel using the properties of the DeweyPair
            return new DeweyPairGameModel { Number = deweyPair.Number, Description = deweyPair.Description };
        }
        // Convert a list of DeweyPair objects to a list of DeweyPairGameModel objects
        public static List<DeweyPairGameModel> ConvertListToGameModel(List<DeweyPair> pairs)
        {
            List<DeweyPairGameModel> gmList = new List<DeweyPairGameModel>();

            // Iterate through the list of DeweyPair objects and convert each to DeweyPairGameModel
            pairs.ForEach(x => gmList.Add(ConvertToGameModel(x)));

            return gmList;
        }
    }
}
//--------------------------------------------------------------------Kaylox--------------------------------------------------//   
