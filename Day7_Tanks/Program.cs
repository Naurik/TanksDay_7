using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLib;
//using MyClassLib.WorlOfTanks;

namespace Day7_Tanks
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Tank tank = new Tank("T-34", rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100));
            Tank secondTank = new Tank("Panthera", rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100));


            Console.WriteLine("Name1: " + tank.Name_Tanks);
            Console.WriteLine("Уровень защиты первого танка: " + tank.Armor_Level);
            Console.WriteLine("Уровень боезапаса первого танка: " + tank.Level_Ammunition_load);
            Console.WriteLine("Уровень манёврености первого танка: " + tank.Level_Of_Agility);


            Console.WriteLine("Name2: " + secondTank.Name_Tanks);
            Console.WriteLine("Уровень защиты второго танка: " + secondTank.Armor_Level);
            Console.WriteLine("Уровень боезапаса второго танка: " + secondTank.Level_Ammunition_load);
            Console.WriteLine("Уровень манёврености второго танка: " + secondTank.Level_Of_Agility);

            Tank winTank = tank * secondTank;
            Console.WriteLine("Победитель!");
            Console.WriteLine("Name: " + winTank.Name_Tanks);
            Console.WriteLine("Уровень защиты танка: " + winTank.Armor_Level);
            Console.WriteLine("Уровень боезапаса танка: " + winTank.Level_Ammunition_load);
            Console.WriteLine("Уровень манёврености танка: " + winTank.Level_Of_Agility);
            Console.ReadLine();
        }
    }
}
