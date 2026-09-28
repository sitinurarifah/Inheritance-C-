using System;
using GameInterhanceDemo;

namespace GameInheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== DEMO INTERHANCE ===\n");

            Console.WriteLine("1. Membuat objek Warrior (dengan konstruktor berparamenter)");
            Warrior warrior = new Warrior(50, "W-001", "Arthas", 100, "Stormwind");
            warrior.DisplayData();


            Console.WriteLine("\n2. Membuat objek Mage (dengan konstruktor berparamenter)");
            Mage mage = new Mage(80, "M-001", "Jaina", 90, "Dalaran");
            mage.DisplayData();


            Console.WriteLine("\n3. Membuat objek ArchMage (dengan konstruktor berparamenter)");
            ArchMage archMage = new ArchMage(120, 80, "AM-001", "Khadgar", 110, "Karazhan");

            Console.WriteLine("\n4. Membuat objek Warrior dengan konstruktor default");
            Warrior defaultWarrior = new Warrior();
            defaultWarrior.DisplayData();
           
            archMage.DisplayData();

            Console.ReadKey();
        }
    }
}