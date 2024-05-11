using System;
using System.Collections.Generic;

namespace progFinal
{
    internal class item
    {
        private List<string> oreNames = new List<string>
        {
            "Iron Ore", "Copper Ore", "Silver Ore", "Gold Ore", "Platinum Ore",
            "Diamond Ore", "Emerald Ore", "Ruby Ore", "Sapphire Ore", "Titanium Ore"
        };

        private List<string> qualityMods = new List<string>
        {
            "Crude", "Dull", "Fair", "Grand", "Brilliant", "Perfect"
        };

        private List<double> oreValues = new List<double>
        {
            1, 3, 6, 10, 15, 21, 28, 36, 45, 55 // base values for each ore
        };

        private string itemName;
        private double itemValue;
        private int qualityValue;
        private int oreType;

        public item(string itemData) {

            string[] itemDetails = itemData.Split('-');
            
            itemValue = Convert.ToDouble(itemDetails[2]);
            qualityValue = Int32.Parse(itemDetails[0]);
            oreType = Int32.Parse(itemDetails[1]);

            itemName = qualityMods[qualityValue] + " " + oreNames[oreType];
        }

        public item(int luck, int sellMulti) {
            int oreQualityNum = StaticRandom.Instance.Next(1, 300 - luck); // as the player gets more luck, the odds of getting a lower number increase yielding better ore
            int oreTypeNum = StaticRandom.Instance.Next(1, 500 - luck); // ^^^

            string itemQuality;
            string itemType;

            if (oreQualityNum <= 1) {
                itemQuality = qualityMods[5]; qualityValue = 0; // Crude
            } else if (oreQualityNum <= 5) {
                itemQuality = qualityMods[4]; qualityValue = 1;// Dull
            } else if (oreQualityNum <= 15) {
                itemQuality = qualityMods[3]; qualityValue = 2;// Fair
            } else if (oreQualityNum <= 35) {
                itemQuality = qualityMods[2]; qualityValue = 3;// Grand 
            } else if (oreQualityNum <= 75) {
                itemQuality = qualityMods[1]; qualityValue = 4;// Brilliant
            } else {
                itemQuality = qualityMods[0]; qualityValue = 5;// Perfect 
            }

            if (oreTypeNum <= 1) {
                itemType = oreNames[9]; itemValue = oreValues[9]; oreType = 9; // Titanium Ore 
            } else if (oreTypeNum <= 5) {
                itemType = oreNames[8]; itemValue = oreValues[8]; oreType = 8; // Sapphire Ore 
            } else if (oreTypeNum <= 10) {
                itemType = oreNames[7]; itemValue = oreValues[7]; oreType = 7; // Ruby Ore
            } else if (oreTypeNum <= 18) {
                itemType = oreNames[6]; itemValue = oreValues[6]; oreType = 6; // Emerald Ore
            } else if (oreTypeNum <= 30) {
                itemType = oreNames[5]; itemValue = oreValues[5]; oreType = 5; // Diamond Ore
            } else if (oreTypeNum <= 50) {
                itemType = oreNames[4]; itemValue = oreValues[4]; oreType = 4; // Platinum Ore
            } else if (oreTypeNum <= 75) {
                itemType = oreNames[3]; itemValue = oreValues[3]; oreType = 3; // Gold Ore
            } else if (oreTypeNum <= 100) {
                itemType = oreNames[2]; itemValue = oreValues[2]; oreType = 2; // Silver Ore
            } else if (oreTypeNum <= 200) {
                itemType = oreNames[1]; itemValue = oreValues[1]; oreType = 1; // Copper Ore
            } else {
                itemType = oreNames[0]; itemValue = oreValues[0]; oreType = 0; // Iron Ore 
            }

            // making the ore more valuble based on how good of quality it is
            for (int i = 0; i < (qualityValue + sellMulti); i++) {
                itemValue *= 1.25;
            }

            // Finalizing the item name
            itemName = itemQuality + " " + itemType;
        }


        public string getItemName() {
            return itemName;
        }

        public double getItemValue() {
            return Math.Round(itemValue,1);
        }

        public int getQualityValue() {
            return qualityValue;
        }

        public int getOreType() {
            return oreType;
        }
    }
}
