using System.Security.AccessControl;

namespace Golden_Papers;

public class Branch
{
    public string Location { get; set; }
    public List<Employee> Employees { get; set; }
    public List<Book> Books { get; set; }
    

    public Branch(string location, List<Employee> employees, List<Book> books)
    {
        this.Location = location;
        this.Employees = employees;
        this.Books = books;
    }

    public Branch()
    {
        throw new NotImplementedException();
    }

    public List<Book> sortedBooks(List<Book> unsorted)
    {
        unsorted.Sort();
        return unsorted;
    }
}