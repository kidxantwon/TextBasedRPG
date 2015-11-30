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
            while (start == true);
            {
                Console.WriteLine("Do you want to start the game? y or n?");
                string startOptions = Console.ReadLine();
                if (startOptions == "y")
                {
                    Console.WriteLine("Officer: So tell me how did it all being?");
                    Console.WriteLine("Player: Well I ran out of gum so i went to the store.");
                    Console.WriteLine("Officer: How is this relavate?");
                    Console.WriteLine("Player: Well you did say. So tell me how ddi it all being? And im telling you, now i have to start over.");
                    Console.WriteLine("Officer: Please dont starat over just pick up from where you left off.");
                    Console.WriteLine("Press 1 to Start over or Press 2 to pick up where you left off.");
                    int option = Console.Read();
                    if (option == 1)
                    {
                        Console.WriteLine("Player: Well I ran out of gum so I went to the store.");
                        Console.WriteLine("While I was on my way to the store I ran into Christan");
                    }
                    else
                    {
                        Console.WriteLine("While I was on my way to the store I ran into Christan");
                    }
                    Console.WriteLine("Christan: Yo where are you headed?");
                    Console.WriteLine("Player: Hey man and nothing just heading around the conner to go get some gum. why?");
                    Console.WriteLine("Christan: Can you help me with something real quick?");
                    Console.WriteLine("Press 1 to help out Christan or Press 2 to go to the store.");
                    int options = Console.Read();
                    if (options == 1)
                    {
                        Console.WriteLine("Christan: Thanks man this means alot. Dont worry i'll buy your gum for you.");
                        Console.WriteLine("Player: Yeah you better, where are we heading anyways?");
                        Console.WriteLine("Christan: You'll see when we get there.");
                    }
                    else
                    {
                        Console.WriteLine("Christan: Alright I guess your busy then.");
                        Console.WriteLine("Player: Yeah im sorry i'm really busy today.");
                        Console.WriteLine("Player: After that I went to the store and got my gum and went home");
                        Console.WriteLine("Officer: Thats it?");
                        Console.WriteLine("Player: Yeah thats it. Can I go home now?");
                    }

                }
                else
                {
                    start = false;
                }
            }
        }
    }
}
