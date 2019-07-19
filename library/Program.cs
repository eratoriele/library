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

            Novel n1 = new Novel("African Folktales	", "Roger D. Abrahams", "9780394721170");

            Music m1 = new Music("Pallet", true, "Future Core");

            Console.WriteLine(n1.ToString() + m1.ToString());

        }
    }
}
