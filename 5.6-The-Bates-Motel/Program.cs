using System;

namespace _5._6_The_Bates_Motel
{
    // author: Benjamin Daniel Morgan
    // date: 07/02/18

    class Motel
    {
        int[] rooms;
        const int MAX = 21;                                                     // define an integer array called rooms

        static void Main(string[] args)                                         // program starts executing here
        {
            Motel BatesMotel = new Motel();                                     // create a new object called BatesMotel
            BatesMotel.runMotel();                                              // call runMotel method
        }

        public Motel()                                                          // constructor
        {
            rooms = new int[MAX];                                               // allow room numbers from 1 to 20
        }

        public void runMotel()
        {
            string choice = "";

            do
            {
                Console.Clear();
                Console.WriteLine("The Bates Motel");
                Console.WriteLine("=================");
                Console.WriteLine("1. Book a Room");
                Console.WriteLine("2. Vacate a Room");
                Console.WriteLine("3. Display ALL Room Details");
                Console.WriteLine("4. Vacate ALL Rooms");
                Console.WriteLine("5. Quit");

                Console.WriteLine("Enter Your Choice : ");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    bookRoom();                                                 // call bookRoom method if user input is 1
                }

                if (choice == "2")
                {
                    vacateRoom();                                               // call vacateRoom method if user input is 2
                }

                if (choice == "3")
                {
                    roomDetails();                                              // call roomDetails method if user input is 3
                }

                if (choice == "4")
                {
                    vacateAllRooms();                                           // call vacateAllRooms method if user input is 4
                }

                if (choice == "5")
                {
                    quit();                                                     // call quit method if user input is 5
                }
            }
            while (choice != "5");
        }

        public void bookRoom()
        {

            int roomNumber, guests;                                             // declare roomNumber and guests as an integer

            Console.WriteLine("\nThe Bates Motel");
            Console.WriteLine("===================");
            Console.WriteLine("Book a Room");

            Console.Write("Enter the Room Number: ");
            roomNumber = Convert.ToInt32(Console.ReadLine());                   // convert user input into 32bit integer

            Console.Write("How many Guests: ");
            guests = Convert.ToInt32(Console.ReadLine());                       // convert user input into 32bit integer

            rooms[roomNumber] = guests;                                         // make a booking

            Console.WriteLine("Room No." + roomNumber + " booked for " + guests + " people");
            Console.ReadKey();
             
        }

        public void vacateRoom()
        {
            Console.WriteLine("What Room do you want to Vacate?");

            int roomNum = Convert.ToInt32(Console.ReadLine());
            rooms[roomNum] = 0;

            Console.WriteLine("Room No." + roomNum + " has been vacated");
            Console.ReadKey();

        }

        public void roomDetails()
        {
            Console.WriteLine("Bates Motel Room Status");
            Console.WriteLine("========================");
            for (int i = 0; i < MAX; i++)
            {
                Console.WriteLine("Rooms " + (i + 1) + " is " + rooms[i]);
            }
            Console.ReadKey();
        }

        public void vacateAllRooms()
        {
            Console.WriteLine("Vacating All rooms");

            for (int i = 0; i < MAX; i++)
            {
                rooms[i] = 0;
            }

            System.Threading.Thread.Sleep(2000);

            Console.WriteLine("All rooms have been Vacated.");
            Console.ReadKey();
        }

        public void quit()
        {
            Console.WriteLine("Shutting Down The Bates Motel's Booking System ");
            System.Threading.Thread.Sleep(2000);
        }
    } // end of Motel class
}
