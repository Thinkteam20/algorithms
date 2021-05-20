using System;

namespace AssignmentTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //MainMenu();
            //Console.WriteLine("");
            MemberCollection aBSTree = new MemberCollection();
            aBSTree.add(new Member("Sangpil", "Jung", "0451116035", "0411"));
            aBSTree.add(new Member("Sangpil", "Jung", "0451116035", "0411"));
            //aBSTree.add(new Member("Turnbull", "Malcolm", "0451116035", "0411"));
            aBSTree.IsEmpty();
            Console.WriteLine(aBSTree.IsEmpty());
            //aBSTree.search(new Member("Sangpil", "Jung", "0451116035", "0411"));

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
            // staff username and password to verify staff
            Console.Clear();
            Console.WriteLine("=========Staff menu==========");
            Console.WriteLine("1. Add a new tool");
            //display all the nine tool categ
            //select a category
            //display all the tool types of the selected category
            //select a tool type
            //display all the tools of the selected tool type ( optional ) 
            // add a new tool th the tool type
            //display all the tools in the selected tool type again.

            //itoolcollection i guess


            Console.WriteLine("2. add new pieces of an existing tool");
            Console.WriteLine("3. Remove some pieces of a tool");
            //controls the member from system how can i call these function and from where ? 
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
                    //Member member1 = new Member("Sangpil", "Jung", "0451116035", "0411");
                    //Console.WriteLine(member1);
          
                    // build a Binary Search Tree (BST)
                    //Initially it is empty
                    //iMemberCollection aBSTree = new MemberCollection();

                    //use the Insert method to insert five Cutomer objects into the BST 
                    //aBSTree.add(new Member("Morris", "Scott", "11111111", "0512"));
                    //aBSTree.add(new Member("Turnbull", "Malcolm", "2222222", "1223"));
                    //aBSTree.add(new Member("Rudd", "Kevin", "3333333", "1231"));
                    //aBSTree.add(new Member("Gillard", "Julia", "4444444", "3333"));
                    // pre-order traversal
                    //aBSTree.PreOrderTraverse();

                    

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
            // first name and lastname and pin number to vertify 
            Console.Clear();
            Console.WriteLine("=========Member menu==========");
            Console.WriteLine("1. Display all the tools of a tool type");
            // click
            // display all the tools of a tool type
            // select tool type
            //display the information about the all the tools of the selected tool type.

            /*
             ex display
            Name: Irwin 125mm orbital sander
            Quantity: 5
            Availablity : 3
            Number of Borrowings: 2

            Name: Rocket sanding block
            Quantity: 2
            Availablity : 1
            Number of Borrowings: 1
             
             */
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
