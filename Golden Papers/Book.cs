namespace Golden_Papers;

public class Book
{
    public string Title { get; set; }
    public string ISBN { get; set; }
    public int NumberOfPages { get; set; }
    public double Cost { get; set; }
    public double Price { get; set; }
    public string OtherInfo { get; set; }
    public Publisher Publisher { get; set; }

    public Book(string title, string isbn, int numberOfPages, double cost, double price, string otherInfo, Publisher publisher)
    {
        this.Title = title;
        this.ISBN = isbn;
        this.NumberOfPages = numberOfPages;
        this.Cost = cost;
        this.Price = price;
        this.OtherInfo = otherInfo;
        this.Publisher = publisher;
    }
}