using System.Security.Cryptography.X509Certificates;

public class Hero
{
    public string _name;
    public string _heroClass;
    public int _heroHealth;

    public Hero(string name, string heroClass, int heroHealth)
    {
        _name = name;
        _heroClass = heroClass;
        _heroHealth = heroHealth;
      
    }

    
        public void DisplayHero()
    {
        Console.WriteLine($"Name: {_name} \nClass: {_heroClass} \nHealth: {_heroHealth}");
    }

    public class Enemy
    {
        
    }
}