using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_14
{
    class Calculator : IDisposable
    {
        private bool disposed = true; // creates a field named bool and sets it to false. 
        public int Divide(int first, int second) // class methods have static. this does not 
        {
            return first / second;
        }
        public Calculator()
        {
            Console.WriteLine("[destructor] Calculator being created");
        }
        ~Calculator()
        {
            Console.WriteLine("Calculator being finalized");
            Dispose();
        }
        public void Dispose()
        {
            Console.WriteLine("Dispose method called, Calculator being disposed");
            
            {
                if (!this.disposed) // if false the statement will run 
                    Console.WriteLine("[disposed is false] Calculator being disposed");
                this.disposed = true;
                GC.SuppressFinalize(this);
            }

        }
    }
}
