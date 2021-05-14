
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustCollectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerCollection aCollection = new CustomerCollection();

            aCollection.Insert("Morris", "Scott", 11111111);
            aCollection.Insert("Turnbull", "Malcolm", 22222222);
            aCollection.Insert("Rudd", "Kevin", 33333333);
            aCollection.Insert("Gillard", "Julia", 44444444);
            aCollection.Insert("Howard", "John", 55555555);

            //aCollection.Display();
            //int mobile = aCollection.Find("Morris", "Scott");
            
            //Console.WriteLine("Morris Scott's number is " + mobile.ToString());

            aCollection.Delete("Morris", "Scott");
            aCollection.Display();
        }
    }
}
