// See https://aka.ms/new-console-template for more information

using Golden_Papers;

Publisher Hassoni = new Publisher("Hasooni", null);

Book HarryPotter = new Book("Harry Potter", "1", 100, 7.0, 8.0, "", Hassoni);

Employee Retard = new Employee(1,  "Retard", null, 50.35, "al nozha", false);

Branch AlWehdat = new Branch("Al Wehdat", null, null);

AlWehdat.Employees.Add(Retard);
AlWehdat.Books.Add(HarryPotter);
Hassoni.Books.Add(HarryPotter);

Console.WriteLine("Welocome To Golder Papers\n__________________________________________");
Console.WriteLine("Please Choose your operation:");
Console.WriteLine("1. Create a new Branch");
Console.WriteLine("2. Create a new Book");
Console.WriteLine("3. Create a new Employee");
Console.WriteLine("4. Create a new Publisher");
Console.WriteLine("Enter the number of your action:");
int choice = Console.Read();

switch (choice)
{
    case 1:
        Branch b = new Branch();
        Console.WriteLine("Enter the location of the Branch:");
        b.Location = Console.ReadLine();
        Console.WriteLine("Would you like to add an employee now? (Y/N)");
        char c = Convert.ToChar(Console.ReadLine());
        if (c == 'y' || c == 'Y')
        {
            List<Employee> emp = new List<Employee>();
            Employee emp1 = new Employee();
            Console.WriteLine("Enter the Employee Number");
            
        }
        Console.WriteLine("Enter the location of the Branch:");
        
}
