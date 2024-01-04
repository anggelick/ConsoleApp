using ConsoleApp;
using System;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new AppDbContext())
        {
            var customerRepository = new Repository<Customer>(context);
            var customerService = new CustomerService(customerRepository);

            // Add a new customer
            var newCustomer = new Customer { FirstName = "John", LastName = "Doe" };
            customerService.AddCustomer(newCustomer);

            // Display all customers
            Console.WriteLine("All Customers:");
            var allCustomers = customerService.GetAllCustomers();
            foreach (var customer in allCustomers)
            {
                Console.WriteLine($"Customer: {customer.FirstName} {customer.LastName}");
            }

            // Update the first customer (assuming there is at least one customer)
            var firstCustomer = allCustomers.FirstOrDefault();
            if (firstCustomer != null)
            {
                firstCustomer.LastName = "UpdatedLastName";
                customerService.UpdateCustomer(firstCustomer);
                Console.WriteLine($"Updated customer: {firstCustomer.FirstName} {firstCustomer.LastName}");
            }

            // Delete a customer by ID (assuming there is at least one customer)
            var customerIdToDelete = 1; // Change this to the actual customer ID
            customerService.DeleteCustomer(customerIdToDelete);
            Console.WriteLine($"Customer with ID {customerIdToDelete} deleted.");

            // Display all customers after modifications
            Console.WriteLine("\nAll Customers after modifications:");
            var modifiedCustomers = customerService.GetAllCustomers();
            foreach (var customer in modifiedCustomers)
            {
                Console.WriteLine($"Customer: {customer.FirstName} {customer.LastName}");
            }
        }
    }
}
