using System;
using jogo_de_rpg.src.Entities;

namespace jogo_de_rpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Star", 23, "White Wizard");
            Ninja ninja = new Ninja("Kung", 21, "Ninja");
            Black black = new Black("Vader", 25, "Black Wizard");
            
            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack());
            Console.WriteLine(ninja.Attack());
            Console.WriteLine(black.Attack());
        }
    }
}