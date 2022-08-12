using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrabble
{
    class Program
    {
        // In the assignment it says that the word "Citron" should give 18 points, but becuase we set "r" to give 1 point instead of 2 it will make "Citron" only give 17 points.
        static string word;
        static int score;
        static void Main(string[] args)
        {
            // We call our methods
            Program.Gui();
            Program.Controller();
            Program.Output();

            Console.ReadLine();
        }

        static void Gui()
        {
            Console.WriteLine("Indtast et ord for at finde ud af hvormange points det er:");
        }

        static void Output()
        {
                Console.WriteLine(word + " giver så mange point: " + score);
        }

        static void Module()
        {
            word = Console.ReadLine();
        }

        static void Controller()
        {
            Program.Module();

            // We change the string to lowercase and use ToCharArray so we can use a foreach loop.
            word.ToLower();
            char[] letters = word.ToCharArray();

            // We loop through each char in the array and give it points based on a swtch that check what points should be added to the score based on the letter.
            foreach (char letter in letters)
            {
                switch (letter)
                {
                    case 'a':
                    case 'e':
                    case 'n':
                    case 'r':
                        score += 1;
                        break;

                    case 'd':
                    case 'l':
                    case 'o':
                    case 's':
                    case 't':
                        score += 2;
                        break;

                    case 'b':
                    case 'i':
                    case 'k':
                    case 'f':
                    case 'g':
                    case 'm':
                    case 'u':
                    case 'v':
                        score += 3;
                        break;

                    case 'h':
                    case 'j':
                    case 'p':
                    case 'y':
                    case 'æ':
                    case 'ø':
                    case 'å':
                        score += 4;
                        break;

                    case 'c':
                    case 'x':
                    case 'z':
                    case 'w':
                    case 'q':
                        score += 8;
                        break;
                }
            }
        }
    }
}
