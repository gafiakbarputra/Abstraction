using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace abstrction.Abstract_Class
{
    public class Archer : Characters
    {
        public override void CharacterJob()
        {
            health = 17;
            attack = 8;
            defense = 3;
            Console.WriteLine("Job yang anda pilih : Archer");
            Console.WriteLine("Health : " + health);
            Console.WriteLine("Attack Power : " + attack);
            Console.WriteLine("Defense : " + defense);
        }
    }
}
