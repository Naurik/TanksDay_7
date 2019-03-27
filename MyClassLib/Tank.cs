using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib
{
    public class Tank
    {
        public string Name_Tanks { get; set; }
        public int Level_Ammunition_load { get; set; }
        public int Armor_Level { get; set; }
        public int Level_Of_Agility { get; set; }

        public Tank(string name_Tanks, int level_Ammunition_load, int armor_Level, int level_Of_Agility)
        {
            Name_Tanks = name_Tanks;
            Level_Ammunition_load = level_Ammunition_load;
            Armor_Level = armor_Level;
            Level_Of_Agility = level_Of_Agility;
        }

        public static Tank operator *(Tank firstTank, Tank secondTank)
        {
            if (firstTank.Armor_Level > secondTank.Armor_Level &&
                firstTank.Level_Ammunition_load > secondTank.Level_Ammunition_load
                || firstTank.Armor_Level > secondTank.Armor_Level &&
                firstTank.Level_Of_Agility > secondTank.Level_Of_Agility
                || firstTank.Level_Ammunition_load > secondTank.Level_Ammunition_load &&
                firstTank.Level_Of_Agility > secondTank.Level_Of_Agility)
            {
                return new Tank(firstTank.Name_Tanks, firstTank.Armor_Level, firstTank.Level_Ammunition_load, firstTank.Level_Of_Agility);
            }
            else
            {
                return new Tank(secondTank.Name_Tanks, secondTank.Armor_Level, secondTank.Level_Ammunition_load, secondTank.Level_Of_Agility);
            }
        }
    }
}
