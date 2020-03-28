using System;
using System.Collections.Generic; // b/c im using the collections library 

namespace Quiz09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is C Sharp Quiz 9!");
            // here is the stack 
            Console.WriteLine("Here is the stack");
            Stack<string> s = new Stack<string>();
            s.Push("one\n");
            s.Push("two");
            s.Push("three");

            foreach (string number in s)
            {
                Console.WriteLine(number);
            }


            //here is the queue 
            Console.WriteLine("Here is the queue");
            Queue<string> q = new Queue<string>();
            q.Enqueue("one");
            q.Enqueue("two");
            q.Enqueue("three\n");
            Queue<string> queueCopy = new Queue<string>(q.ToArray());
            foreach (string number in queueCopy)
            {
                Console.WriteLine(number);
            }

            // end queue 

            //// here is the dictionary 
            //Console.WriteLine("Here is the dictionary");
            //Dictionary<int, string> dict = new Dictionary<int, string>();
            //dict.Add(1, "One");
            //dict.Add(2, "Two");
            //dict.Add(3, "Three");

            Dictionary<string, int> d = new Dictionary<string, int>();
            d.Add("one", 1);  // this is 0 
            d.Add("two", 2);
            d.Add("three", 3);

            foreach (KeyValuePair<string, int> kvp in d)
            {
                Console.WriteLine("{0}, {1}", kvp.Key, kvp.Value );
            }

        }
    }
}
