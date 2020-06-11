using System;
using System.Collections.Generic;
using System.Text;

namespace abstrction.Interface
{
    class Slime : IMonsters
    {
        public void Status()
        {
            string nama = "Slime";
            int Health = 10;
            int attack = 3;
            int defense = 5;
            Console.WriteLine("Anda melihat status Monster : " + nama);
            Console.WriteLine("Monster " + nama + " Memiliki Status : ");
            Console.WriteLine("Attack : " + attack);
            Console.WriteLine("Defense : " + defense);
            Console.WriteLine("Health : " + Health);
        }
    }
}
