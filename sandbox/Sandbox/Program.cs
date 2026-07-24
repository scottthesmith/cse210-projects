using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {

        Hero bruce = new Hero("Bruce", "Bard", 50);
        Hero tom = new Hero("Tom", "Fighter", 80);
        tom.DisplayHero();
        bruce.DisplayHero();

    }
}