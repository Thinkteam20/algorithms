using System;
namespace AssignmentTest
{
    public class Member : iMember, IComparable<Member>
    {

        //every class need a constructor
        // write a constructor
        //Member aMember = new Member(); // and pass those variable below 
   
        // if it said just get just use get as it is
        // if it said get set in the interface just use get / set as it is dont add new 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string PIN { get; set; }

        public Member(string firstName, string lastName, string contactNumber, string pin)
        {
            //constructor
            this.FirstName = firstName;
            this.LastName = lastName;
            this.ContactNumber = contactNumber;
            this.PIN = pin;
        }

        public string[] Tools => throw new NotImplementedException();

        public void addTool(Tool aTool)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(Member other)
        {
            //Compare the last name first if last name is same then compare the first name
            //just Ln and Fn no pin mobile dont care
            // compare string 
            if (this.LastName.CompareTo(other.LastName) < 0)
                return -1;
            else
                    if (this.LastName.CompareTo(other.LastName) == 0)
                return this.FirstName.CompareTo(other.FirstName);
            else
                return 1;
        }

        public void deleteTool(Tool aTool)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return (FirstName + " " + LastName + " " + ContactNumber + " " + PIN + "\n");
        }
    }
}
