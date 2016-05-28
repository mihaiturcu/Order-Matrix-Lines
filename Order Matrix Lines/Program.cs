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
        public static List<int> bubbleSort(List<int> alist)
        {
            int size = alist.Count;
            bool flag = true;
            int temp = 0;
            for (int j = 1; (j <= (size - 1) && flag); j++)
            {
                flag = false;
                for (int i = 0; i < size - 1; i++)
                {
                    if (alist[i] > alist[i + 1])
                    {
                        temp = alist[i + 1];
                        alist[i + 1] = alist[i];
                        alist[i] = temp;
                        flag = true;
                    }
                }
            }
            return alist;
        }

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
        public static List<List<int>> reorder_matrix(List<List<int>> matrix)
        {
            int i = 0;
            /*foreach(List<int> line in matrix)
            {
                matrix[i] = bubbleSort(line);
                i++;
            }
            */
            List<List<int>> newmatrix = new List<List<int>>();
            for (i = 0; i <= matrix.Count - 1; i++)
            {
                List<int> tempList = bubbleSort(matrix[i]);
                newmatrix.Add(tempList);
            }

            return newmatrix;
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
            List<List<int>> mymatrix, newmatrix ;
            mymatrix = read_matrix(args[0].ToString());
            nice_print(mymatrix);
            Console.WriteLine("-----------------");
            newmatrix = reorder_matrix(mymatrix);
            nice_print(newmatrix);
            Console.ReadKey();
            
        }
    }
}
