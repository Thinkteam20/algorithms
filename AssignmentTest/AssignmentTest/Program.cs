using System;

namespace AssignmentTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ToolCollection[] aToolcolc = new ToolCollection[] {
                new ToolCollection("1. Gardening tools", new string[]{ "Line Trimmers", "Lawn Mowers", "Hand Tools", "Wheelbarrows", "Garden Power Tools"}),
                new ToolCollection("2. Flooring tools",new string[]{ "Scrapers", "Floor Lasers", "Floor Levelling Tools", "Floor Levelling Materials", "Floor Hand Tools", "Tiling Tools"}),
                new ToolCollection("3. Fencing tools",new string[]{ "Hand Tools", "Electric Fencing", "Steel Fencing Tools", "Power Tools", "Fencing Accessories" }),
                new ToolCollection("4. Measuring tools",new string[]{ "Distance Tools", "Lawn Mowers", "Measuring Jugs", "Temperature & Humidity Tools", "Levelling Tools" } ),
                new ToolCollection("5. Cleaning tools",new string[]{ "Draining", "Car Cleaning", "Vacuum", "Pressure Cleaners", "Pool Cleaning", "Floor Cleaning" } ),
                new ToolCollection("6. Painting tools",new string[]{ "Sanding Tools", "Brushes", "Rollers", "Paint Removal Tools", "Paint Scrapers", "Sprayers" } ),
                new ToolCollection("7. Electronic tools",new string[]{ "Voltage Tester", "Oscilloscopes", "Thermal Imaging", "Data Test Tool", "Insulation Testers" }),
                new ToolCollection("8. Electricity tools",new string[]{ "Test Equipment", "Safety Equipment", "Basic Hand tools", "Circuit Protection", "Cable Tools" }),
                new ToolCollection("9. Automotive tools",new string[]{ "Jacks", "Air Compressors", "Battery Chargers", "Socket Tools", "Braking", "Drivetrain" }),
            };

            MainMenu(aToolcolc);
            //Console.WriteLine("");
            //MemberCollection aBSTree = new MemberCollection();
            //aBSTree.add(new Member("Sangpil", "Jung", "0451116035", "0411"));
            //aBSTree.add(new Member("Malcom", "tunbull", "03412333", "1123"));
            //aBSTree.add(new Member("Turnbull", "Malcolm", "0451116035", "0411"));
            //aBSTree.IsEmpty();
            //Console.WriteLine(aBSTree.IsEmpty());
            //aBSTree.InOrderTraverse();


            //aToolcolc.add(new Tool("sa sta at", 1, 1, 1));
            //aToolcolc.add(new Tool("asdfasdfsadf", 2, 1, 1));

            //aToolcolc.Display();
            //aToolcolc.delete(new Tool("asdfasdfsadf", 2, 1, 1));
            //aToolcolc.Display();

            //aToolcolc.toArray();

            //aBSTree.Search(new Customer("Turnbull", "Malcolm", 22222222));
            //Console.WriteLine(aBSTree.Search(new Customer("Turnbull", "Malcolm", 22222222)));
            //aBSTree.search(new Member("Sangpil", "Jung", "0451116035", "0411"));

            //Tool aTool = new Tool("sa sta at", 1, 1, 1);
            //Console.WriteLine(aTool);
        }


        static void MainMenu(ToolCollection[] aToolcolc)
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
                    StaffLogin(aToolcolc);
                    break;
                case "2":
                    MemberLogin(aToolcolc);
                    break;
                case "0":
                    Exit();
                    break;
            }
        }
        static void StaffLogin(ToolCollection[] aToolcolc)
        {
            Console.Clear();
            Console.WriteLine("=========Staff menu==========");
            Console.WriteLine("1. Add a new tool");
            Console.WriteLine("2. Add new pieces of an existing tool");
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
                    AddNewTool(aToolcolc);
                    break;
                case "2":
                    AddNewPieceOfExistingTool(aToolcolc);
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
                    MainMenu(aToolcolc);
                    break;
            }
        }
        static void MemberLogin(ToolCollection[] aToolcolc)
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
                    break;
                case "2":
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
                    MainMenu(aToolcolc);
                    break;
            }
        }
        static void AddNewTool(ToolCollection[] aToolcolc) {
            Console.Clear();
            Console.WriteLine("Enter name for the new tool: ");
            String newToolName = Console.ReadLine();
            Console.WriteLine("Select the category");
            foreach (ToolCollection tool in aToolcolc) {
                Console.WriteLine(tool);
            }
            Console.WriteLine("Select the option from menu");
            int category = Convert.ToInt32(Console.ReadLine())-1;
            Console.WriteLine("");
            Console.WriteLine("Select the tool type");
            Console.WriteLine("-----------------------------");
            aToolcolc[category].ShowAllType();
            Console.WriteLine("Select the option from menu");



            MainMenu(aToolcolc);
        }
        static void AddNewPieceOfExistingTool(ToolCollection[] aToolcolc)
        {
            Console.Clear();
            Console.WriteLine("Please select the tools to add");
            aToolcolc.Display();
            int index = Convert.ToInt32(Console.ReadLine())+1;
            aToolcolc[index]
            Console.WriteLine("Enter the number of piece to add for the selected tools");
        }
        static void Exit()
        {
            System.Environment.Exit(0);
        }

        
    }
}
