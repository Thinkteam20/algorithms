// Array or Arrays 

using System;
namespace AssignmentTest
{
    public class ToolCollection : iToolCollection
    {
        // program.cs is  where create all default the members and tools tool libraries .... 

        // private instance variable ? Tools / Tool array
        //private Tool[] collection;


        private Tool[] tools;
        private string[] yu; 
        public int Number { get; private set; }
        private string name;

        public ToolCollection(String name, string[] categories)
        {
            this.name = name;
            tools = new Tool[30];
            this.categories = categories;
            Number = 0;
        }

        public void Display()
        {
            for (int i = 0; i < Number; i++) {
                Console.WriteLine(i+1 + ". Name: " + tools[i].Name + ", Quantity: " + tools[i].Quantity);

            }
        }

        public void ShowAllType()
        {
            for (int i = 0; i < categories.Length; i++)
            {
                Console.WriteLine(i + 1 + ". " + categories[i]);

            }
        }

        public void add(string name, int quantity, int availablequantity, int noborrowings)
        {
            Tool atool = new Tool(name, quantity, availablequantity, noborrowings);
            tools[Number] = atool;
            Number++;
        }
            public void add(Tool aTool)
        {
            tools[Number] = aTool;
            Number++;
        }

        public void delete(Tool aTool)
        {

        }

        public bool search(Tool aTool)
        {
            throw new NotImplementedException();
        }

        public Tool[] toArray()
        {
            return tools;
        }
    }
}
 