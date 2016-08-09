using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShakespeareHomeworkAssignment
{
    class shakespear
    {

        public void shakespeareFirstLine()
        {
            StreamReader reader = new StreamReader("shakespeare.txt");

            string line = reader.ReadLine();
            using (reader)
            {
                Console.WriteLine("FIRST LINE FROM FILE\n");
                Console.WriteLine(line);
                Console.WriteLine("\n\n\n\n\n");
            }
        }

        public void shakespeareEntireText()
        {
            StreamReader reader = new StreamReader("shakespeare.txt");
            string line = reader.ReadLine();
            using (reader)
            {
                Console.WriteLine("ENTIRE TEXT");
                Console.WriteLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = reader.ReadLine();
                }
                Console.WriteLine("\n\n\n\n");
            }
        }


        public void shakespeareCapitalVowels()
        {
            StreamReader reader = new StreamReader("shakespeare.txt");
            string line = reader.ReadLine();
            using (reader)
            {
                Console.WriteLine("CAPITAL VOWELS");
                Console.WriteLine();
                while (line != null)
                {
                    string result = line.Replace("a", "A").Replace("e","E").Replace("i","I").Replace("o","O").Replace("U","U");
                    Console.WriteLine(result);
                    line = reader.ReadLine();
                }
            }
        }
    }
}
