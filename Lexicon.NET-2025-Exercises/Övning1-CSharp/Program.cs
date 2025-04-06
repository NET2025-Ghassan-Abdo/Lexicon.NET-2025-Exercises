
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

//Adding class Program to write the code inside Main function 
public class Program
{
    public static void Main(string[] args)
    {
        //Create a list to kkep the employees information inside it
        List<Employee> employees = new List<Employee>();

        employees.Add(new Employee("Sara", 19000));
        employees.Add(new Employee("Jone", 22000));
// using foreach to loop inside the list employees and print them to the Console
        foreach (var emp in employees)
        {
            Console.WriteLine($"Name is: {emp.Name}, Salary is: {emp.Salary}");
        
        }
        Console.ReadLine();
    }
}

