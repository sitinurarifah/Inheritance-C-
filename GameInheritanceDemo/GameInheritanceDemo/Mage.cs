using System;
using GameInheritanceDemo;

namespace GameInterhanceDemo
{
    public class Mage  : Character
    {
        public int spellPower;


        public Mage()
        {
            Console.WriteLine("----> Konstruktor default Mage <----");
        }


        public Mage(int spellPower, string id, string name, int basePower, string address)
        : base(id, name, basePower, address)
        {
            Console.WriteLine("----> Konstruktor berparamenter Mage <----");
            this.spellPower = spellPower;
        }

        public virtual void DisplayData()
        {
            base.DisplayBaseData();
            Console.WriteLine("SPELL POWER     = " + spellPower);
            Console.WriteLine("TOTAL POWER     = " + (GetBasePower() + spellPower));
            Console.WriteLine("==========================");
        }
    }
}