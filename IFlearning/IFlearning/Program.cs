using System;

namespace IFlearning
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<PhysicalProductModel> cart = AddSampleData();
            CustomerModel customer = GetCustomer();

            foreach(PhysicalProductModel prod in cart)
            {
                prod.ShipItem(customer);
            }
            Console.ReadLine();
        }
        private static CustomerModel GetCustomer()
        {
            return new CustomerModel
            {
                FirstName = "Tim",
                LastName = "Corey",
                City = "Brisbane",
                EmailAddress = "tankteam20@gamil.com",
                PhoneNumber = "0451116035"
            };
        }

        private static List<PhysicalProductModel> AddSampleData()
        {
            List<PhysicalProductModel> output = new List<PhysicalProductModel>();

            output.Add(new PhysicalProductModel { Title = "Nerf Football" });
            output.Add(new PhysicalProductModel { Title = "IAmTimCorey T-Shirt" });
            output.Add(new PhysicalProductModel { Title = "Hard Drive" });

            return output;
        }

    }
}
