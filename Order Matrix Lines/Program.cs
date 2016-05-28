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
            bool flag = true;
            int temp;
            int numLength = alist.Count;
            for (int passnum=1; (passnum <= (numLength-1) && flag); passnum++)
            {
                flag = false;
                for(int i=1;i<(numLength-1);i++)
                {
                    if(alist[i+1] > alist[i])
                    {
                        temp = alist[i];
                        alist[i] = alist[i + 1];
                        alist[i + 1] = temp;
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
            foreach(var line in matrix)
            {
                matrix[i] = bubbleSort(line);
                i++;
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
