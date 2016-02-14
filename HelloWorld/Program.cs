using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        string theWord;

        public Program(string word)
        {
            theWord = word;
        }

        void Run()
        {
            Console.WriteLine("Whats up world?");
            Console.WriteLine("Let's play Hangman, shall we?");
            

        }
        static void Main(string[] args)
        {
            string[] words = { "water", "computer", "keyboard", "microphone" };
            Random r = new Random();
            string aWord = words[r.Next(0, words.Length)];
            Program prog = new Program(aWord);
            prog.Run();
        }
    }
}
