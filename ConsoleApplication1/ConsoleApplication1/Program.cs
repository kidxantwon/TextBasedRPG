using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool start = true;
            while (start == true) ;
            {
                Console.WriteLine("Do you want to start the game? y or n?");
                string startOptions = Console.ReadLine();
                if (startOptions == "y")
                {
                    Console.WriteLine("Officer: So tell me how did it all being?");
                    Console.WriteLine("Player: Well I ran out of gum so i went to the store.");


                }
                else
                {
                    start = false;
                }
            }
        }
    }
}
