using System.Timers;
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
                Console.WriteLine("2- Group price calculation: ");
                Console.WriteLine("3- Rverse the words : ");
                Console.WriteLine("4- Calculate the average : ");
                Console.WriteLine("5- Calculation of child, Adult and Old : ");


                
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
                                Console.WriteLine("The price is 80kr");
                                totalPrice += 80;
                            }
                            else if (personAge<=64)
                            {
                                Console.WriteLine("The price is 120kr");
                                totalPrice += 120;
                            }
                            else
                            {
                                Console.WriteLine("The price is 90kr");
                                totalPrice += 90;
                            }
                            
                        }
                        Console.WriteLine($"Total cost: {totalPrice} kr");

                        break;
                    case 3:
                        Console.WriteLine("Enter yor sentence to reverse the words: ");
                        string sentence = Console.ReadLine();
                        string[] words = sentence.Split("");
                        for (int i = words.Length - 1; i>=0; i-- )
                        {
                            Console.Write(words[i]+ " ");
                        }
                        Console.WriteLine("\n");
                        break;
                    case 4:
                        Console.WriteLine("How many numbers do you want to enter?");
                        bool validNumber = int.TryParse(Console.ReadLine(), out int numberCount);

                        if (!validNumber || numberCount<=0)
                        {
                            Console.WriteLine("Invalid value");
                            break;
                        }
                        int sum = 0;
                        for(int i = 1 ; i<= numberCount ; i++)
                        {
                            Console.WriteLine($"Write number {i}");
                            string input = Console.ReadLine();
                            bool integer = int.TryParse(input, out int inputNumber);
                            if (!integer)
                            {
                                Console.WriteLine("invalid value");
                                continue;
                            }
                            sum += inputNumber;
                            Console.WriteLine($"The summation of numbers is: {sum}");
                            double average = (double)sum / numberCount;
                            Console.WriteLine($"The average is : {average}");
                        }

                        break;
                    case 5:

                        Console.WriteLine("How many persons will you write their ages?");
                        bool isInteger = int.TryParse(Console.ReadLine(), out int count);
                        if(!isInteger || count<=0 )
                        {
                            Console.WriteLine("Invalid value");
                            break;
                        }
                        int childCount = 0;
                        int adultCount = 0;
                        int seniorCount = 0;
                        

                        for (int i = 1; i<=count; i++)
                        {
                            Console.WriteLine($"Enter the person {i} age: ");
                            bool iscorrect = int.TryParse(Console.ReadLine(), out int personAge);

                            if(!iscorrect)
                            {
                                Console.WriteLine("Invalid value");
                                continue;
                            }


                            if (personAge < 20)
                            {
                                childCount++;
                            }
                            else if(personAge>=20 && personAge<=64)
                            {
                                adultCount++;
                            }
                            else
                            {
                                seniorCount++;
                            }
                        }
                        Console.WriteLine($"Number of children is {childCount}");
                        Console.WriteLine($"Number of adult is {adultCount}");
                        Console.WriteLine($"Number of old is {seniorCount}");

                        break;




                }
            }

        }


    }
}
