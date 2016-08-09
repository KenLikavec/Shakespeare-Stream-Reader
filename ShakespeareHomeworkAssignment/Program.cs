using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShakespeareHomeworkAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            shakespear William = new shakespear();

            William.shakespeareFirstLine();
            William.shakespeareEntireText();
            William.shakespeareCapitalVowels();



            Console.ReadKey();
        }
    }
}
