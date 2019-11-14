using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinema
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bird eagle = new Eagle();
            //Eagle eagle1 = new Eagle();

            //Shark shark = new Shark();
            //Animal shark1 =  shark;
            //Animal shark2 = new Shark();

            Animal shark5 = new Shark();
            Animal eagle5 = new Eagle();
            Eagle New_eagle = (Eagle)shark5;

            // Biz ancaq Egle tipinin movcud oldugu
            //halda hemin tipden olan yeni bir vareybli
            // 

            #region
            Student cavid = new Student("Cavid", "Beshirov");
            Group p111 = new Group("P111", 17);
            //p111.AddStudent(cavid);
            p111[0] = cavid;
            Manat manat = new Manat();
            Dollar dollar = new Dollar();
            dollar.USD = 1;
            //Manat manat1 = dollar;// implicity method yazanda
            Manat manat1 = (Manat)dollar;
            Console.WriteLine(manat1.AZN);
            #endregion
            Console.ReadLine();

        }
    }
    class Manat
    {


        public int AZN { get; set; }

    }
    class Dollar
    {
        public int USD { get; set; }

        //public static implicit operator Manat(Dollar v)//Method implicity
        public static explicit operator Manat(Dollar v)// Method explicit
        {

            return new Manat { AZN = v.USD * 2 };
        }
    }
    abstract class Animal
    {
        public abstract void Eat();
    }

    abstract class Fish : Animal
    {

    }

    class Shark : Fish
    {
        public override void Eat()
        {
            Console.WriteLine("Sharks eating fishes");        }
    }

    abstract class Bird : Animal
    {
        public abstract void Fly();
        public void CantFly()
        {
            Console.WriteLine("Some of Birds Type can't fly");
        }
    }
    class Eagle : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("Eagles eat birds");
        }

        public override void Fly()
        {
            Console.WriteLine("These can fly");
        }

        public void Hunter()
        {
            Console.WriteLine("I am hunter");
        }

    }

}


