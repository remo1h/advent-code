using System;
using System.IO;

namespace dan1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] input = new int[200];
            int counter = 0;
            string num;
            string path = Environment.CurrentDirectory;

            
            string projectDirectory = Directory.GetParent(path).Parent.Parent.FullName;
            System.IO.StreamReader file = new System.IO.StreamReader(projectDirectory + @"\numbers.txt");
            while ((num = file.ReadLine()) != null)
            {
                input[counter++] = int.Parse(num);
            }

            int v = calculate1(input);
            int b = calculate2(input);

            Console.WriteLine(v);
            Console.WriteLine(b);
        }

        private static int calculate1(int[] input)
        {

            foreach (int i in input)
                foreach (int j in input)
                    if (i + j == 2020)
                        return i * j;

            return 0;
        }
        private static int calculate2(int[] input)
        {

            foreach (int i in input)
                foreach (int j in input)
                    foreach (int k in input)
                        if (i + j + k == 2020)
                            return i * j * k;

            return 0;
        }
    }
}
