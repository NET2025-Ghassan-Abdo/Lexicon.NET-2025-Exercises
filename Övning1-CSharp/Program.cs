
public class Employee
{
    //The next two lines Defines attributes  to store employees name and salary inside the class
    public string Name;
    public double Salary;


    //Adding Constructor to create the object Employee and initialize its properties.
    public Employee(string name, double salary)
    {
        
        Name = name;
        Salary = salary;
    }
}

//Adding class Program to write the code inside Main function outside the class 
public class Program
{
    public static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();

        employees.Add(new Employee("Sara", 19000));
        employees.Add(new Employee("Jone", 22000));

        foreach (var emp in employees)
        {
            Console.WriteLine($"Name is: {emp.Name}, Salary is: {emp.Salary}");
        
        }
        Console.ReadLine();
    }
}

