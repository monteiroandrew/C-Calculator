using System;
using System.Data;
using System.Formats.Tar;
using System.Linq;

class program
{
    public static void Main(string[] args)
        {
    start:
        Console.WriteLine("Basic Calculator");
        Console.WriteLine();
        Console.WriteLine("Choose Operator:");
        Console.WriteLine("1 for +");
        Console.WriteLine("2 for -");
        Console.WriteLine("3 for x");
        Console.WriteLine("4 for /");
        Console.WriteLine("5 for %");
        Console.Write("Enter: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num == 1)
        {
            Console.Clear();
            string num1 = "";
            int total = 0;

            while (num1 != "e")
            {
                Console.WriteLine("input e to exit");
                Console.Write("Enter a number: ");
                num1 = Console.ReadLine();
                if (num1 != "e")
                {
                    total = total + Convert.ToInt32(num1);
                }
                Console.Clear();
                Console.WriteLine("Total: " + total);
            }

            Console.Clear();
            Console.WriteLine("Put x to exit, t to continue:");
            Console.Write("Enter: ");
            string choice = Console.ReadLine();
            if (choice == "t")
            {
                Console.Clear();
                goto start;
            }
        }

        else if (num == 2)
        {
            Console.Clear();
            string num1 = "";
            int total = 0;
            Console.WriteLine("Input e to Exit");
            Console.Write("Enter a number: ");
            total = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Total: " + total);

            while (num1 != "e")
            {
                Console.WriteLine("Input e to exit");
                Console.Write("Enter a number: ");
                num1 = Console.ReadLine();
                if (num1 != "e")
                {
                    total = total - Convert.ToInt32(num1);

                }
                Console.Clear();
                Console.WriteLine("Total: " + total);
            }

            Console.Clear();
            Console.WriteLine("Put x to exit, t to continue:");
            Console.Write("Enter: ");
            string choice = Console.ReadLine();
            if (choice == "t")
            {
                Console.Clear();
                goto start;
            }

        }

        else if (num == 3)
        {
            Console.Clear();
            string num1 = "";
            int total;
            Console.WriteLine("Input e to Exit");
            Console.Write("Enter a number: ");
            total = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Total: " + total);

            while (num1 != "e")
            {
                Console.WriteLine("Input e to Exit");
                Console.Write("Enter a number: ");
                num1 = Console.ReadLine();
                if (num1 != "e")
                {
                    total = Convert.ToInt32(num1) * total;

                }
                Console.Clear();
                Console.WriteLine("Total: " + total);
            }

            Console.Clear();
            Console.WriteLine("Put x to exit, t to continue:");
            Console.Write("Enter: ");
            string choice = Console.ReadLine();
            if (choice == "t")
            {
                Console.Clear();
                goto start;
            }

        }

        else if (num == 4)
        {
            Console.Clear();
            string num1 = "";
            int total;
            Console.WriteLine("Input e to Exit");
            Console.Write("Enter a number: ");
            total = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Total: " + total);

            while (num1 != "e")
            {
                Console.WriteLine("Input e to Exit");
                Console.Write("Enter a number: ");
                num1 = Console.ReadLine();
                if (num1 != "e")
                {
                    total = total / Convert.ToInt32(num1);
                }
                Console.Clear();
                Console.WriteLine("Total: " + total);
            }

            Console.Clear();
            Console.WriteLine("Put x to exit, t to continue:");
            Console.Write("Enter: ");
            string choice = Console.ReadLine();
            if (choice == "t")
            {
                Console.Clear();
                goto start;
            }
        }

        else if (num == 5)
        {
            Console.Clear();
            string num1 = "";
            int total;
            Console.WriteLine("Input e to Exit");
            Console.Write("Enter a number: ");
            total = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Total: " + total);

            while (num1 != "e")
            {
                Console.WriteLine("Input e to Exit");
                Console.Write("Enter a number: ");
                num1 = Console.ReadLine();
                if (num1 != "e")
                {
                    total = total % Convert.ToInt32(num1);
                }
                Console.Clear();
                Console.WriteLine("Total: " + total);
            }

            Console.Clear();
            Console.WriteLine("Put x to exit, t to continue:");
            Console.Write("Enter: ");
            string choice = Console.ReadLine();
            if (choice == "t")
            {
                Console.Clear();
                goto start;
            }
        }

        else
        {
            Console.Clear();
            Console.Write("Invalid input.. try again!");
            Console.ReadKey();
            goto start;
        }

        Console.Clear();
        Console.WriteLine("Thankyou!");
        Console.WriteLine("Press any key to exit..");
        Console.ReadKey();

    }

}