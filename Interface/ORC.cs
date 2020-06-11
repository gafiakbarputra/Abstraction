using System;
using System.Collections.Generic;
using System.Text;

namespace abstrction.Interface
{
    class ORC : IMonsters
    {
        public void Status()
        {
            string nama = "ORC";
            int Health = 15;
            int attack = 4;
            int defense = 6;
            Console.WriteLine("Anda melihat status Monster : " + nama);
            Console.WriteLine("Monster " + nama + " Memiliki Status : ");
            Console.WriteLine("Attack : " + attack);
            Console.WriteLine("Defense : " + defense);
            Console.WriteLine("Health : " + Health);
        }
    }
}
