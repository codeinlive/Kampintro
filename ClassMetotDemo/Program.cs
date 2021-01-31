using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "ilhan";
            int age = 26;

            Customer customer1 = new Customer();
            customer1.CustomerName = "Jack";
            customer1.Age = 23;
            customer1.Id = "12345678900001";

            Customer customer2 = new Customer();
            customer2.CustomerName = "Kelly";
            customer2.Age = 43;
            customer2.Id = "12345678900002";

            Customer customer3 = new Customer();
            customer3.CustomerName = "Thomas";
            customer3.Age = 34;
            customer3.Id = "12345678900003";

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.CustomerName + " : " + customer.Age + " : " + customer.Id);
            }


            Console.WriteLine("Hello World!");
        }
    }


    class Customer
    {
        public string CustomerName { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }

    }
}
