using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To be a library project with MSSQL\n");

            Novel n1 = new Novel("bora's bizarre adventures", "22-06-1998", "Bora", 500);

            Console.WriteLine(n1.ToString());

        }
    }
}
