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
            String buffer;
            using (StreamReader sr = new StreamReader(arg))
            {
                while ((buffer = sr.ReadLine()) != null)
                {
                    string[] elements = buffer.Split(',');
                    foreach(string elem in elements)
                    {
                        int tempCastvalue;
                        int.TryParse(elem,out tempCastvalue);
                        line.Add(tempCastvalue);
                    }
                    matrix.Add(line);
                }

            }
            return matrix;

        }

        public static void nice_print(List<List<int>> matrix)
        {
            foreach(List<int> list in matrix)
            {
                foreach(int elem in list)
                {
                    Console.Write(elem);
                }
                Console.Write("\n");
            }
        }

        static void Main(string[] args)
        {
            read_matrix(args[0].ToString());
            
        }
    }
}
