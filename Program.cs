using System;
using abstrction.Abstract_Class;
using abstrction.Interface;

namespace abstrction
{
    class Program
    {
        static void Main(string[] args)
        {
            int pilihan,pilihan1,pilihan2;
            
            int ulang=1;
            Random rand = new Random();
            Characters karakter;
            IMonsters monster;
            Console.WriteLine("Character & Monster Status");
                Console.WriteLine("Pilih Kategori yang anda lihat : (1/2)");
                Console.WriteLine("1.Character Job");
                Console.WriteLine("2.Monster ");
                pilihan = Convert.ToInt32(Console.ReadLine());
            switch (pilihan)
            {
                case 1:
                    Console.WriteLine("Pilih Job Status yang ingin anda lihat :  ");
                    Console.WriteLine("1.Soldier");
                    Console.WriteLine("2.Archer");
                    pilihan1 = Convert.ToInt32(Console.ReadLine());
                    switch (pilihan1)
                    {
                        case 1:
                           
                            karakter = new Soldier();
                            karakter.CharacterJob();
                            break;
                        case 2:
                          
                            karakter = new Archer();
                            karakter.CharacterJob();
                            break;
                    }
            
                    break;
                case 2:
                    Console.WriteLine("Pilih Monsters yang akan discan : (1/2)");
                    Console.WriteLine("1.Slime");
                    Console.WriteLine("2.Orc");
                    pilihan2 = Convert.ToInt32(Console.ReadLine());
                    switch (pilihan2)
                    {
                        case 1:
                            {
                                monster = new Slime();
                                monster.Status();
                            }

                            break;
                        case 2:
                            monster = new ORC();
                            monster.Status();
                            break;
                    }
                    break;
             }
            
            Console.ReadKey();
            
        }
    }
}
