using System;
using System.Collections.Generic;

namespace dan2
{
    public class Password
    {
        public int min;
        public int max;
        public char letter;
        public string password;

        public Password(int min, int max, char v, string password)
        {
            this.min = min;
            this.max = max;
            this.letter = v;
            this.password = password;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string line;
            List<Password> Pas = new List<Password>();
  
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"c:\input.txt");
            while ((line = file.ReadLine()) != null)
            {
                //System.Console.WriteLine(line);
                string[] devide = line.Split(' ');
                int min = int.Parse(devide[0].Split('-')[0]);
                int max = int.Parse(devide[0].Split('-')[1]);
                char[] charachter = devide[1].ToCharArray();
                string password = devide[2];

                Pas.Add(new Password(min,max,charachter[0], password));
            }


            file.Close();

            foreach(Password p in Pas)
            {
                //    int charCounter = 0;

                //    for (int i = 0; i < p.password.Length; i++)
                //    {
                //        if (p.password[i] == p.letter) ++charCounter;
                //    }

                //    if (charCounter >= p.min && charCounter <= p.max)
                //        counter++;
                bool positon1 = p.password.Length >= p.min && p.password[p.min - 1] == p.letter;
                bool positon2 = p.password.Length >= p.max && p.password[p.max - 1] == p.letter;

                if (positon1 != positon2) ++counter;
            }
            System.Console.WriteLine("There were {0} correct passwords.", counter);
            
            Console.WriteLine("Hello World!");
        }
    }
}
