using System;
namespace BirthdayMonths
{
    class BirthdayMonth
    {
        static string[] months = { "January", "Febuary", "March", "April", "May", "June", "July", "August", "September", "Novemember", "October", "December" };
        static void outputMyBirthday()
        {
            Console.Out.WriteLine(months[5] + "\n");
        }
        static void outputBirthdayFromInt()
        {
            Console.Out.Write("Enter your Birthday month number: ");
            try
            {
                int input = Int16.Parse(Console.In.ReadLine());
                Console.WriteLine("Your birthday is in " + months[input - 1] + "!");
            }
            catch
            {
                Console.WriteLine("Invalid Input!");
                outputBirthdayFromInt();
            }
        }
        static int getNumberofMonth()
        {
            Console.Out.Write("Enter month: ");
            string input = Console.ReadLine();
            for (int i = 0; i < months.Length - 1; i++)
            {
                if (months[i].ToLower() == input.ToLower())
                {
                    Console.WriteLine(i + 1);
                    return i + 1;
                }
            }
            Console.WriteLine("Invalid input!");
            return -1;
        }
        static void outputNumberOfMonth()
        {
            int numberOfMonth;
            do
            {
                numberOfMonth = getNumberofMonth();
            } while (numberOfMonth == -1);
            string suffix;
            switch (numberOfMonth)
            {
                case 1:
                    suffix = "st";
                    break;
                case 2:
                    suffix = "nd";
                    break;
                case 3:
                    suffix = "rd";
                    break;
                default:
                    suffix = "th";
                    break;
            }
            Console.WriteLine("Your birthday is the " + (numberOfMonth) + suffix + " month!");
        }
        static void Main(string[] args)
        {
            outputMyBirthday();
            outputNumberOfMonth();
            outputBirthdayFromInt();
        }
    }
}