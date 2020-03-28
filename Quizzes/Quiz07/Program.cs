using System;

namespace Quiz_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execute quiz_07");
            IFirearm s = new Shotgun();
            s.doWhat("shotgun", "Boom");
            IFirearm r = new Rifle();
            r.doWhat("rifle", "Bang");
            IFirearm p = new Pistol();
            p.doWhat("Pistol", "Pop");

        }
    }
    interface IFirearm
    {
        void doWhat(string v1, string v2);
    }
    class Shotgun : IFirearm
    {
        public void doWhat(string v1, string v2)
        {
            Console.WriteLine($"I am a {v1} and I go {v2}");
        }
    }
    class Rifle : IFirearm
    {
        public void doWhat(string v1, string v2)
        {
            Console.WriteLine($"I am a {v1} and I go {v2}");
        }
    }
    class Pistol : IFirearm
    {
        public void doWhat(string v1, string v2)
        {
            Console.WriteLine($"I am a {v1} and I go {v2}");
        }
    }
}
