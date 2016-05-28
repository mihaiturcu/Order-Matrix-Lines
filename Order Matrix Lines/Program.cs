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
            List<List<int>> matrix = new List<List<int>>();
            String buffer;
            using (StreamReader sr = new StreamReader(arg))
            {
                while ((buffer = sr.ReadLine()) != null)
                {
                    List<int> line = new List<int>();
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
                    Console.Write(elem + ",");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            List<List<int>> mymatrix;
            mymatrix = read_matrix(args[0].ToString());
            nice_print(mymatrix);
            Console.ReadKey();
            
        }
    }
}
