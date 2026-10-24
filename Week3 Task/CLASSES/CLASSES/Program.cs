using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSES
{
    class Player
    {
        public string name;
        public double health;
        public double power;
        public double score;

        public Player(string name,double health,double  power,double score)
        {
            this.name = name;
            this.health = health;
            this.power = power;
            this.score = score;
        }

        public void damage_by_monster()
        {
            this.health -= health * 0.1;
            this.score -= score * 0.3;
            Console.WriteLine("Damage By Monster");
            Console.WriteLine("Health: " + this.health);
            Console.WriteLine("Score: " + this.score);
            Console.WriteLine();
        }

        public void attack_someone_player()
        {
            this.power -= power * 0.1;
            this.health += health * 0.3;
            Console.WriteLine("Attack Someone Player");
            Console.WriteLine("Power: " + this.power);
            Console.WriteLine("Health: " + this.health);
            Console.WriteLine("_____________________________________");
            Console.WriteLine();
        }

        public void output()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Power: " + power);
            Console.WriteLine("Score: " + score);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Player p1 = new Player("Abdullah", 100, 100, 100);
            p1.output();
            p1.damage_by_monster();
            p1.attack_someone_player();
            Player p2 = new Player("Danish", 50, 50, 50);
            p2.output();
            p2.damage_by_monster();
            p2.attack_someone_player();
        }
    }
}
