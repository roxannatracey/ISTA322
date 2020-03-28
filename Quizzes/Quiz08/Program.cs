using System;

namespace Quiz08
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name;
            //string sound;
            //string size;
            Firearm Pistol = new Firearm();
            Console.WriteLine($"I am a {Pistol.name} and I go {Pistol.sound} with a {Pistol.caliber} and we have {Pistol.counter} firearms");
            Firearm Rifle = new Firearm { name = "Rifle", sound = "bang", caliber = "7.62mm" };
            Console.WriteLine($"I am a {Rifle.name} and I go {Rifle.sound} with a {Rifle.caliber} and we have {Rifle.counter} firearms");
            Firearm shotgun = new Firearm { name = "Shotgun", sound = "bang", caliber = "12 gauge" };
            Console.WriteLine($"I am a {Rifle.name} and I go {shotgun.sound} with a {shotgun.caliber} and we have {shotgun.counter} firearms");




        }
        public class Firearm
        {
            public string name { get; set; }
            public string sound { get; set; }
            public string caliber { get; set; }

            public int counter;

            public Firearm()
            {
                this.name = "Pistol";
                this.sound = "pop";
                this.caliber = "9 mm";
                this.counter++;
            }

        }
    }
}





