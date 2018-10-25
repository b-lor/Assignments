using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("It's 11:59 PM on a Friday night and your own your way to a party in the middle of nowhere\n");
                Console.WriteLine("You are all alone and it is snowing so hard you can barely see out the windows...\n");
                Console.WriteLine("Your phone has no signal and while you try to get your GPS to work, you hit a deer ***BOOOMMMMMM****\n");
                Console.WriteLine("Your car lands in a ditch in a remote area with heavy front end damage. The car is totaled and your phone is missing.\n");
                Console.WriteLine("You hit your head during the accident and have no idea where you are. The deer is also injured but managed to limp off.\n");
                Console.WriteLine("You look around and see lights coming from a very large house a short walk away.\n");
                Console.WriteLine("This is first house you've seen in miles. What do you do next........\n");
                System.Threading.Thread.Sleep(10000);
                Console.WriteLine("Type (1) to go to the house and ask for help.");
                Console.WriteLine("Type (2) wait in the car and hope someone drives in the blizzard.");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        GoToHouse();
                        break;
                    case "2":
                        WaitInCar();
                        break;
                    default:
                        break;
                }
                Console.WriteLine("\nMan, I should've stayed home!!!\n");
                System.Threading.Thread.Sleep(8000);
                Console.Clear();
            }
        }

        public static void GoToHouse()
        {
            Console.Clear();
            Console.WriteLine("You kick out your car door window and climb out of the car.\n");
            Console.WriteLine("You walk in knee high snow for half an hour and finally reach the front porch of the house.\n");
            Console.WriteLine("The door is slightly opened.  Do you.....\n");
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine("Type (1) Ring the doorbell.");
            Console.WriteLine("Type (2) Knock on the door.");
            Console.WriteLine("Type (3) Let yourself in.");
            string goToHouseInput = Console.ReadLine();

            switch (goToHouseInput)
            {
                case "1":
                    RingDoorBell();
                    break;
                case "2":
                    KnockOnDoor();
                    break;
                case "3":
                    EnterHouse();
                    break;
                default:
                    break;
            }
        }
        public static void RingDoorBell()
        {
            Console.Clear();
            Console.WriteLine("You ring the doorbell and wait....\n");
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine("No one answers. You decide what to do next\n");
            Console.WriteLine("Type (1) Try knocking on the door.");
            Console.WriteLine("Type (2) Go ahead and let yourself in the house.");
            string ringDoorBellInput = Console.ReadLine();

            switch (ringDoorBellInput)
            {
                case "1":
                    KnockOnDoor();
                    break;
                case "2":
                    EnterHouse();
                    break;
                default:
                    break;
            }
        }
        public static void KnockOnDoor()
        {
            Console.Clear();
            Console.WriteLine("You knock on the door and you wait.\n");
            Console.WriteLine("Silence, no one answers. What else can you do now?\n");
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine("Type (1) Go ahead and let yourself in the house.");
            string knockOnDoorInput = Console.ReadLine();

            switch (knockOnDoorInput)
            {
                case "1":
                    EnterHouse();
                    break;
                default:
                    break;
            }
        }
        public static void EnterHouse()
        {
            Console.Clear();
            Console.WriteLine("You open the door slowyly and say 'Hello, is there anyone home?' No one answers.\n");
            Console.WriteLine("You step inside and close the door behind you.\n");
            Console.WriteLine("All of the lights suddenly turns off and you hear a loud scream coming from up the stairs in front of you.\n");
            Console.WriteLine("You heart stops and you are paralyzed with fear, glanced up at the stairs. You see pair of red eyes flying towards you in the darkness.\n");
            Console.WriteLine("Without even blinking, you swing the door back open and........\n");
            System.Threading.Thread.Sleep(8000);
            Console.WriteLine("Type (1) run like hell to your car.\n");
            string enterHouseInput = Console.ReadLine();

            switch (enterHouseInput)
            {
                case "1":
                    ContinueToWaitInCar();
                    break;
                default:
                    break;
            }
        }
        public static void WaitInCar()
        {
            Console.Clear();
            Console.WriteLine("You decide to wait in the car and pray someone drives by.\n");
            Console.WriteLine("The car will not start and you find anything you can to keep warm.\n");
            Console.WriteLine("A few hours later still no cars in sight.  You're cold and the car is now covered with snow.\n");
            System.Threading.Thread.Sleep(6000);
            Console.WriteLine("Type (1) Get out and go to the house for help.");
            Console.WriteLine("Type (2) Continue to wait in the car.");
            string waitInCarInput = Console.ReadLine();

            switch (waitInCarInput)
            {
                case "1":
                    GoToHouse();
                    break;
                case "2":
                    ContinueToWaitInCar();
                    break;
                default:
                    break;
            }
        }

        public static void ContinueToWaitInCar()
        {
            Console.Clear();
            Console.WriteLine("You fall asleep while waiting for someone to drive by.\n");
            Console.WriteLine("2 months later, someone finally drives by.....\n");
            System.Threading.Thread.Sleep(6000);
            Console.WriteLine("They find you, but it's too late.  RIP!\n");
        }
    }
}
