namespace Golden_Papers;

public class Publisher
{
    public string Name { get; set; }
    public List<Book> Books { get; set; }

    public Publisher(string name, List<Book> books)
    {
        this.Name = name;
        this.Books = books;
    }
}