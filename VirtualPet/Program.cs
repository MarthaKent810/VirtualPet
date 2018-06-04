using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            VirtualPet fidget = new VirtualPet("Fidget", 5, 5, 7);
            Console.WriteLine("Thank you for adopting {0} the mini-moo", fidget.Name);
            Console.WriteLine("She requires special care & needs to be monitored carefully");
            Console.WriteLine("She will need food, naps & exercise if she gets too restless");
            Console.WriteLine("You will get a warning if she gets hungry, tired or too fidgety");
            Console.WriteLine("Type yes if you would like to take care of {0} now?", fidget.Name);
            string userResp = Console.ReadLine().ToLower();

            while (userResp.Equals("yes"))
            {
                fidget.Tick();

                Console.WriteLine();
                Console.WriteLine("{0} the mini-moo:", fidget.Name);
                Console.WriteLine("Hunger is at {0} ", fidget.Hunger);
                Console.WriteLine("Sleepiness is at {0} ", fidget.Sleep);
                Console.WriteLine("Restlessness is at {0}", fidget.Activity);
                if (fidget.Hunger < 3)
                {
                    Console.WriteLine("{0} is hungry, you need to feed her", fidget.Name);
                }
                if (fidget.Sleep < 3)
                {
                    Console.WriteLine("{0} is exhausted; she needs a nap", fidget.Name);
                }
                if (fidget.Activity > 10)
                {
                    Console.WriteLine("{0} is too restless, you need to play with her", fidget.Name);
                }

                Console.WriteLine("Select one of the options below to care for {0} ", fidget.Name);
                Console.WriteLine("1 will let you feed {0}", fidget.Name);
                Console.WriteLine("2 will let you give {0} a nap", fidget.Name);
                Console.WriteLine("3 will give {0} some much needed exercise", fidget.Name);
                int userSel = int.Parse(Console.ReadLine());

                switch (userSel)
                {
                    case 1:
                        fidget.Feed();
                        Console.WriteLine("You gave {0} some food. Thank you!", fidget.Name);
                        break;
                    case 2:
                        fidget.Rest();
                        Console.WriteLine("{0} is now resting.  She'll feel much better", fidget.Name);
                        break;
                    case 3:
                        fidget.Play();
                        Console.WriteLine("{0} got some exercise. She's much happier now", fidget.Name);
                        break;
                    default:
                        break;
                }

                Console.WriteLine("Type yes if you would like to take care of {0} now?", fidget.Name);
                userResp = Console.ReadLine().ToLower();
            }

        }

    }
}




    

