using System;
namespace AssignmentTest
{
    public class Tool : iTool, IComparable<Tool>
    {
        // what would be private instance variable for this class ?
        // name quantity membercollection n of borrowings
        // private string name;
        // private MemberCollection member; // go to MemberCollection and call the instructor and create object class

        //to create a object
        //in the constructor you are going to initialize the variable
        // iMemberCollection which says binary search tree
        //so all i need to do is create a new object
        // in the constructor create a new object of membercollection

        // compare
        // just simple comparison of string compare and return 1 or 0 -1 
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int AvailableQuantity { get; set; }
        public int NoBorrowings { get; set; }

        public Tool(string name, int quantity, int availablequantity, int noborrowings)
        {
            //constructor
            this.Name = name;
            this.Quantity = quantity;
            this.AvailableQuantity = availablequantity;
            this.NoBorrowings = noborrowings;
        }

        MemberCollection iTool.GetBorrowers { get; }

        public void addBorrower(Member aMember)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(Tool other)
        {
            throw new NotImplementedException();
        }

        public void deleteBorrower(Member aMember)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return (Name + " " + Quantity.ToString() + " " + AvailableQuantity.ToString() + " " + NoBorrowings.ToString() + "\n");
        }


    }
}
