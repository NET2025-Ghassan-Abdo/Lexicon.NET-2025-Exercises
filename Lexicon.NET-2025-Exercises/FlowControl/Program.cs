using System.Transactions;

namespace FlowControl
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            while(true)
            {
                Console.WriteLine("Welcome to the main menu");
                Console.WriteLine("You can choose number between 0 and 1 to try it");
                Console.WriteLine("1- check age category");
                Console.WriteLine("0- Exit");


                string input = Console.ReadLine();
                bool correct = int.TryParse (input, out int choice);

                if (!correct)
                {
                    Console.WriteLine("Invalid value");
                    continue;
                    
                }
                switch (choice)
                    {
                    case 0:
                        Console.WriteLine("Exiting program");
                        Environment.Exit(0);
                        break;
                    case 1:
                        Console.WriteLine("Enter your age: ");
                        string ageInput = Console.ReadLine();
                        bool validAge = int.TryParse(ageInput, out int age);
                        

                        if (!validAge)
                        {
                            Console.WriteLine("Invalid age");
                            break;
                        }
                        if(age<20)
                        {
                            Console.WriteLine("Ungdom");
                        }
                        else if (age >= 20 && age<=64)
                        {
                            Console.WriteLine("Vuxen");
                        }

                        else
                        {
                            Console.WriteLine("Pensionär");
                        }
                        break;
                    

                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
                    

            }*/

            bool isRunning = true;
            while(isRunning)
            {
                Console.WriteLine("Welcome to the main menu");
                Console.WriteLine("You can choose number between 0, 1 and 2 to try it");
                Console.WriteLine("1- check age category");
                Console.WriteLine("0- Exit");
                Console.WriteLine("2- Enter the number of persons: ");


                
                bool correct = int.TryParse(Console.ReadLine(), out int choice);

                if(!correct)
                {
                    Console.WriteLine("Invalid value!");
                    continue;
                }
                switch(choice)
                {
                    case 0:
                        isRunning = false;
                        break;

                    case 1:
                        Console.WriteLine("Enter your age: ");
                        bool validAge = int.TryParse(Console.ReadLine(), out int age);
                          if (!validAge)
                          {
                              Console.WriteLine("Invalid age!");
                            break;
                        }                       
                        if (age<20)
                        {
                            Console.WriteLine("Ungdom");
                        }
                        else if (age >= 20 && age <= 64)
                        {
                            Console.WriteLine("Vuxen");
                        }
                        else
                        {
                            Console.WriteLine("Pensionär");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Group price calculation");
                        Console.WriteLine("How many person?");
                        bool number = int.TryParse(Console.ReadLine(), out int PersonsNumber);

                        if(!number)
                        {
                            Console.WriteLine("Invalid value");
                            break;
                        }
                        int totalPrice = 0;
                        for(int i= 1; i<= PersonsNumber; i+=1)
                        {
                            Console.WriteLine($"What is the age of person {i}?");
                            bool validAge1 = int.TryParse(Console.ReadLine(), out int personAge);
                            if(!validAge1)
                            {
                                Console.WriteLine("Invalid value!");
                                continue;
                            }

                            if(personAge<20)
                            {
                                totalPrice += 80;
                            }
                            else if (personAge<=64)
                            {
                                totalPrice += 120;
                            }
                            else
                            {
                                totalPrice += 90;
                            }
                            
                        }
                        Console.WriteLine($"Total cost: {totalPrice} kr");

                        break;
                    
                }
            }

        }


    }
}
