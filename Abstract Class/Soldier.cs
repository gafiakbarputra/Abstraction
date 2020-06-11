using System;
using System.Collections.Generic;
using System.Text;

namespace abstrction.Abstract_Class
{
    public class Soldier : Characters
    {
        public override void CharacterJob()
        {
            health = 20;
            attack=5;
            defense = 7;
            Console.WriteLine("Job yang anda pilih : Soldier");
            Console.WriteLine("Health : " + health);
            Console.WriteLine("Attack Power : "+attack);
            Console.WriteLine("Defense : " + defense);
        }
    }
}
