namespace Golden_Papers;

public class Employee
{
    public int Number { get; set; }
    public string Name { get; set; }
    public string Ssn { get; set; }
    public double Salary { get; set; }
    public string Address { get; set; }
    public bool IsManager { get; set; }

    public Employee(int number, string name, string ssn, double salary, string address, bool isManager)
    {
        this.Name = name;
        this.Number = number;
        this.Ssn = ssn;
        this.Salary = salary;
        this.Address = address;
        this.IsManager = isManager;
    }

    public Employee()
    {
        throw new NotImplementedException();
    }
}