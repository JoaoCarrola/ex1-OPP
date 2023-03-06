using System.Collections;
using System.Collections.Generic;
using System.IO;

using System;

abstract class SuperHero
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Power { get; set; }
    public int Defense { get; set; }

    public abstract void UseSuperPower();
    public virtual void GetInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Health: " + Health);
        Console.WriteLine("Power: " + Power);
        Console.WriteLine("Defense: " + Defense);
    }
}

class FlyingSuperhero : SuperHero
{
    public bool CanFly { get; set; }
    public int Agility { get; set; }
    public int Speed { get; set; }

    public override void UseSuperPower()
    {
        Console.WriteLine(Name + " is flying with agility and speed!");
    }

    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine("Can fly: " + CanFly);
        Console.WriteLine("Agility: " + Agility);
        Console.WriteLine("Speed: " + Speed);
    }
}

class SuperStrengthHero : SuperHero
{
    public bool HasSuperStrength { get; set; }
    public int LiftingCapacity { get; set; }

    public override void UseSuperPower()
    {
        Console.WriteLine(Name + " is using super strength to lift heavy objects!");
    }

    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine("Has super strength: " + HasSuperStrength);
        Console.WriteLine("Lifting capacity: " + LiftingCapacity);
    }
}

class App
{
    static void Main(string[] args)
    {
        SuperHero[] heroes = new SuperHero[2];

        FlyingSuperhero flyingHero = new FlyingSuperhero();
        flyingHero.Name = "FlyingMan";
        flyingHero.Health = 100;
        flyingHero.Power = 50;
        flyingHero.Defense = 25;
        flyingHero.CanFly = true;
        flyingHero.Agility = 75;
        flyingHero.Speed = 80;

        SuperStrengthHero strengthHero = new SuperStrengthHero();
        strengthHero.Name = "StrongMan";
        strengthHero.Health = 150;
        strengthHero.Power = 75;
        strengthHero.Defense = 40;
        strengthHero.HasSuperStrength = true;
        strengthHero.LiftingCapacity = 10000;

        heroes[0] = flyingHero;
        heroes[1] = strengthHero;

        foreach (SuperHero hero in heroes)
        {
            hero.UseSuperPower();
            hero.GetInfo();
            Console.WriteLine("");
        }
    }
}

