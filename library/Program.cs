using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace library
{
    class Program
    {
        static void Main(string[] args)
        {

            string connectionString = null;
            SqlConnection cnn;
			connectionString = "Data Source=DESKTOP-3DJI5UM;Initial Catalog=library_csharp;Integrated Security=SSPI;";
            cnn = new SqlConnection(connectionString);
            try
            {
                cnn.Open();
                Console.WriteLine("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can not open connection ! ");
            }
            /*
            Console.WriteLine("To be a library project with MSSQL\n");

            Novel n1 = new Novel("African Folktales", "Roger D. Abrahams", "9780394721170");

            Music m1 = new Music("Pallet", true, "Future Core");

            Console.WriteLine(n1.ToString() + m1.ToString());
            */
        }
    }
}
