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
        public List<List<int>> read_matrix(string arg)
        {
            List<int> line = null;
            List<List<int>> matrix = null;
            String elem;
            using (StreamReader sr = new StreamReader(arg))
            {
                while ((elem = sr.ReadLine().Trim(',')) != null)
                {
                    Console.WriteLine(elem);
                }

            }

            return matrix;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("test");
            
            
        }
    }
}
