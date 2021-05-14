using System;

namespace AssignmentTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            MainMenu();
        }
        static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("=========main menu==========");
            Console.WriteLine("1. Staff Login");
            Console.WriteLine("2. Member Login");
            Console.WriteLine("0. Exit");
            Console.WriteLine("===========================");
            Console.WriteLine("");
            Console.WriteLine("Please Make a selection (1-2, or 0 to exit):");
            string myoption;
            myoption = Console.ReadLine();
            switch (myoption)
            {
                case "1":
                    StaffLogin();
                    break;
                case "2":
                    MemberLogin();
                    break;
                case "0":
                    Exit();
                    break;
            }
        }
        static void StaffLogin()
        {
            Console.Clear();
            Console.WriteLine("=========Staff menu==========");
            Console.WriteLine("1. Add a new tool");
            Console.WriteLine("2. add new pieces of an existing tool");
            Console.WriteLine("3. Remove some pieces of a tool");
            Console.WriteLine("4. Register a new member");
            Console.WriteLine("5. Remove a member");
            Console.WriteLine("6. Find the contact number of a member");
            Console.WriteLine("0. Return to main menu");
            Console.WriteLine("===============================");
            Console.WriteLine("");
            Console.WriteLine("Please Make a selection (1-6, or 0 to return to the main menu):");
            string myoption;
            myoption = Console.ReadLine();
            switch (myoption)
            {
                case "1":
                    StaffLogin();
                    break;
                case "2":
                    MemberLogin();
                    break;
                case "3":
                    Exit();
                    break;
                case "4":
                    Exit();
                    break;
                case "5":
                    Exit();
                    break;
                case "6":
                    Exit();
                    break;
                case "0":
                    MainMenu();
                    break;
            }
        }
        static void MemberLogin()
        {
            Console.Clear();
            Console.WriteLine("=========Member menu==========");
            Console.WriteLine("1. Display all the tools of a tool type");
            Console.WriteLine("2. Borrow a tool");
            Console.WriteLine("3. Return a tool");
            Console.WriteLine("4. List all the tools that I am renting");
            Console.WriteLine("5. Display top three (3) most frequentely rented tools");
            Console.WriteLine("0. Return to main menu");
            Console.WriteLine("===============================");
            Console.WriteLine("");
            Console.WriteLine("Please Make a selection (1-6, or 0 to return to the main menu):");
            string myoption;
            myoption = Console.ReadLine();
            switch (myoption)
            {
                case "1":
                    StaffLogin();
                    break;
                case "2":
                    MemberLogin();
                    break;
                case "3":
                    Exit();
                    break;
                case "4":
                    Exit();
                    break;
                case "5":
                    Exit();
                    break;
                case "0":
                    MainMenu();
                    break;
            }
        }
        static void Exit()
        {
            System.Environment.Exit(0);
        }
    }
}
