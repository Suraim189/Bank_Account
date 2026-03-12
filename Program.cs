using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            //Student s1 = new Student(19, "A+");
            //Console.WriteLine("Before Changing");
            //s1.display();
            //Student s2 = new Student(s1);
            //s2.display();
            //Console.WriteLine("After Changing");
            //s2 = new Student(20,"A");
            //s1.display();
            //s2.display();

            //Teacher t1 = new Teacher("Mathematics", 5);
            //Console.WriteLine("--- Data using Constructor ---");
            //t1.DisplayDetails();
            //t1.Subject = "Computer Science";
            //t1.Experience = 10;
            //Console.WriteLine("\n--- Data Using Property ---");
            //t1.DisplayDetails();

            //Car c = new Car("Toyota",25);
            //c.DisplayDetails();
            //c.Year = 26;
            //c.Brand = "BMW";
            //c.DisplayDetails();

            //Employee e = new Employee(1201, 50000);
            //e.DisplayDetails();
            //e.Employeed = 1200;
            //e.Salary = 600000;
            //e.DisplayDetails();

            //Book b1 = new Book("C# Programming", 850.00);
            //Book b2 = new Book(b1);
            //Console.WriteLine("--- b1 (Original) ---");
            //b1.DisplayDetails();
            //Console.WriteLine("--- b2 (Copy of b1) ---");
            //b2.DisplayDetails();

            BankAccount acc1 = new BankAccount("PK-1234", 5000.00);
            BankAccount acc2 = new BankAccount(acc1);

            int choice;
            do
            {
                Console.WriteLine("\n=== Bank Account Management System ===");
                Console.WriteLine("1. Display Account Details");
                Console.WriteLine("2. Deposit Amount");
                Console.WriteLine("3. Withdraw Amount");
                Console.WriteLine("4. Exit");
                Console.Write("Enter Your Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n--- Account Details ---");
                        acc1.DisplayDetails();
                        break;

                    case 2:
                        Console.Write("Enter Deposit Amount: ");
                        double depositAmount = Double.Parse(Console.ReadLine());
                        acc1.Deposit(depositAmount);
                        break;

                    case 3:
                        Console.Write("Enter Withdraw Amount: ");
                        double withdrawAmount = Double.Parse(Console.ReadLine());
                        acc1.Withdraw(withdrawAmount);
                        break;

                    case 4:
                        Console.WriteLine("Exiting... Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Please enter 1-4.");
                        break;
                }

            } while (choice != 4);



        }
    }
}
