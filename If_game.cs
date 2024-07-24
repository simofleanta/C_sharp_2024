using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IfGame 
{
    internal class Program
    {
        static void Main(string[] args)
        {// open door game (using ifs and switch to open doors)
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Welcome to our story.");
            Console.WriteLine("It begins on a cold rainy night.You're sitting in your room and hear a noise coming from down the hall.Do you do investigate?");
            Console.WriteLine("Type YES/NO");
            string noiseChoice = Console.ReadLine();
            string uppern = noiseChoice.ToUpper();
            if (uppern == "NO")
            {
                Console.WriteLine("END");
            }
            else if (uppern =="YES")
            {
                Console.WriteLine("walk into hallway");
            }
            Console.WriteLine("Type OPEN/KNOCK");
            string doordecision= Console.ReadLine();
            string upperdec=doordecision.ToUpper();
            if (upperdec == "KNOCK")
            {
                Console.WriteLine("A voice says: Answer this riddle: ");
                Console.Write("Type answer nothing_smth: ");
                string riddline= Console.ReadLine();
                string upperr=riddline.ToUpper();
                if (upperr == "NOTHING")
                {
                    Console.WriteLine("door opens and nothing is here");
                }
                else if (upperr == "SMTH")
                {
                    Console.WriteLine("door doesn't open - END");
                }                
                
            }
            else if(upperdec =="OPEN")
            {
                Console.WriteLine("door is locked, see if one of your 3 keys work. ");

                Console.Write(" enter number one-three: ");
                string keychoice=Console.ReadLine();
                string upperkey=keychoice.ToUpper();                
                switch (upperkey)
                {
                    case "ONE":
                        Console.WriteLine("lucky");
                        break;
                    case "TWO":
                        Console.WriteLine("tell me a joke");
                        break;
                    case "Three":
                        Console.WriteLine("doesn't open");
                        break;
                    default:
                        Console.WriteLine("system is rigged");
                        break;
                }
            }
        }
    }
}
