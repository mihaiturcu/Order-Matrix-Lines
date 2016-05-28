using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_Matrix_Lines
{
    class Program
    {
        public static List<List<int>> read_matrix(string arg)
        {
            List<int> line = null;
            List<List<int>> matrix = null;
            String elem;
            using (StreamReader sr = new StreamReader(arg))
            {
                while ((elem = sr.ReadLine()) != null)
                {
                    Console.WriteLine(elem);
                }

            }

            return matrix;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("test");
            Console.WriteLine(args);
            read_matrix(args[0].ToString());
            
        }
    }
}
