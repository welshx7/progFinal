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
            1, 3, 6, 10, 15, 21, 28, 36, 45, 55
        };

        private string itemName;
        private double itemValue;

        public item(int luck, int sellMulti) {
            int oreQualityNum = StaticRandom.Instance.Next(1, 300 - luck);
            int oreTypeNum = StaticRandom.Instance.Next(1, 500 - luck);

            int oreQualityValue;
            string itemQuality;
            string itemType;

            if (oreQualityNum <= 1) {
                itemQuality = qualityMods[5]; oreQualityValue = 0; // Crude
            } else if (oreQualityNum <= 5) {
                itemQuality = qualityMods[4]; oreQualityValue = 1;// Dull
            } else if (oreQualityNum <= 15) {
                itemQuality = qualityMods[3]; oreQualityValue = 2;// Fair
            } else if (oreQualityNum <= 35) {
                itemQuality = qualityMods[2]; oreQualityValue = 3;// Grand 
            } else if (oreQualityNum <= 75) {
                itemQuality = qualityMods[1]; oreQualityValue = 4;// Brilliant
            } else {
                itemQuality = qualityMods[0]; oreQualityValue = 5;// Perfect 
            }

            if (oreTypeNum <= 1) {
                itemType = oreNames[9]; itemValue = oreValues[9]; // Titanium Ore 
            } else if (oreTypeNum <= 5) {
                itemType = oreNames[8]; itemValue = oreValues[8]; // Sapphire Ore 
            } else if (oreTypeNum <= 10) {
                itemType = oreNames[7]; itemValue = oreValues[7]; // Ruby Ore
            } else if (oreTypeNum <= 18) {
                itemType = oreNames[6]; itemValue = oreValues[6]; // Emerald Ore
            } else if (oreTypeNum <= 30) {
                itemType = oreNames[5]; itemValue = oreValues[5]; // Diamond Ore
            } else if (oreTypeNum <= 50) {
                itemType = oreNames[4]; itemValue = oreValues[4]; // Platinum Ore
            } else if (oreTypeNum <= 75) {
                itemType = oreNames[3]; itemValue = oreValues[3]; // Gold Ore
            } else if (oreTypeNum <= 100) {
                itemType = oreNames[2]; itemValue = oreValues[2]; // Silver Ore
            } else if (oreTypeNum <= 200) {
                itemType = oreNames[1]; itemValue = oreValues[1]; // Copper Ore
            } else {
                itemType = oreNames[0]; itemValue = oreValues[0]; // Iron Ore 
            }

            // making the ore more valuble based on how good of quality it is
            for (int i = 0; i < (oreQualityValue + sellMulti); i++) {
                itemValue = itemValue * 1.25;
            }

            // Finalizing the item name
            itemName = itemQuality + " " + itemType;
        }


        public string getItemName() {
            return itemName;
        }

        public double getItemValue() {
            return itemValue;
        }
    }
}
