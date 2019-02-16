using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Collections.Generic;

namespace lab_10_entity
{
    class Program
    {
        static List <Customer> customers = new List<Customer>();
        static void Main(string[] args)
        {
            // encapsulates the database connection so it's closed cleanly
            using (var db = new NorthwindEntities())
            {
            }
            // CRUD - Create Read Update Delete
            // Select one customer 
            using (var db = new NorthwindEntities())
            {
                //  Linq query = Microsoft : Language Independant Query 
                var customerToUpdate =
                    // select all customers in northwind
                    (from customer in db.Customers
                         // choose where id selected
                     where customer.CustomerID == "ALFKI"
                     // output this one selected
                     select customer).FirstOrDefault();
             //   Console.WriteLine("\n\nfinding one custoemr\n");
             //   Console.WriteLine($"{customerToUpdate.ContactName} lives in {customerToUpdate.Address}");
            }
            // ------------------------------------------| Copy of the one above |-------------
            using (var db = new NorthwindEntities())
            {
                //  Linq query = Microsoft : Language Independant Query 
                var customerToUpdate =
                   db.Customers.Where(c => c.CustomerID == "ALFKI").FirstOrDefault();
                Console.WriteLine("\n\nfinding one customer\n");
                Console.WriteLine($"{customerToUpdate.ContactName} lives in {customerToUpdate.Address}");
                // Update customer
                customerToUpdate.ContactName = "Fred Flintstome";
                // update the database perminantly 
                db.SaveChanges();
            }
            DisplayAll();
            // Insert new customer 
            using (var db = new NorthwindEntities())
            {
                Customer customerToCreate = new Customer
                {
                    CustomerID = "Nadi12",
                    ContactName = "Great Name",
                    City = "London", 
                    CompanyName = "NadiInc"
                };
                // Now addnew customer to the local database
                db.Customers.Add(customerToCreate);
                // write changes perminantly to real databse 
                db.SaveChanges();

            }
            using (var db = new NorthwindEntities())
            {
                Customer CustomerToDelet = db.Customers.Where(c => c.CustomerID == "Nadi45").FirstOrDefault();
                db.Customers.Remove(CustomerToDelet);
                db.SaveChanges();                        
            }

            DisplayAll();

        }
        static void DisplayAll()
        {
            using (var db = new NorthwindEntities())
            {
                // Customers list = (read from north wind)
                //                  (pull out all customers)
                //                  (send to list of customers)               
                customers = db.Customers.ToList<Customer>();
                // var customers2 = db.Customers;
            }
            // Use list 
            foreach (var customer in customers)
            {
                Console.WriteLine($"{customer.ContactName} has ID of {customer.CustomerID} and lives in {customer.Address}");
            }
        }
    }// --------------------------- End OF Class
}
