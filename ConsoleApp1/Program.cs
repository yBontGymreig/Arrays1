using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* The Main method automatically gets called when the program is run. */
                        
            // Call the procedure named Activity1 and pass into it 0 parameters
            Activity1();

            // Call the procedure named Activity2 and pass into it a string parameter
            Activity2("Could you speak differently please");

            // To begin with the following procedure calls are 'commented out'
            // char[] arrayOfChars = {'p', 'o', 't', 'a', 't', 'o'};
            // Activity3(arrayOfChars);
            // Activity3(arrayOfChars);
            // Activity4(arrayOfChars);
            // Activity5("slipup");

            // This allows the program to pause before closing...
            WaitForEnter();
        }

        static void Activity1()
        {
            /* Replace this comment with a description of what you think this procedure will do
            then rename the procedure with a more semantic (i.e. meaningful) name. */

            char[] letters = { 'h', 'e', 'l', 'l', 'o' };
            foreach (char letter in letters)
            {
                Console.WriteLine(letter);
            }

        }

        static void Activity2(string inputString)
        {
            // Procedure to...
            foreach (char letter in inputString)
            {
                Console.WriteLine(letter);
            }
        }
        
        static void Activity3(char[] inputChars)
        {
            /* Replace this comment with a description of what you think this procedure will do
            then rename the procedure with a more semantic (i.e. meaningful) name. */

            for (int i = 0; i < inputChars.Length; i++)
            {
                Console.WriteLine(inputChars[i]);
            }
            for (int i = 0; i < inputChars.Length; i++)
            {
                Console.WriteLine(inputChars[i]);
            }
        }

        static void Activity4(char[] inputChars)
        {
            /* Replace this comment with a description of what you think this procedure will do
            then rename the procedure with a more semantic (i.e. meaningful) name. */

            for (int i = inputChars.Length-1; i >=0 ; i--)
            {
                Console.WriteLine(inputChars[i]);
            }
            for (int i = 0; i < inputChars.Length; i++)
            {
                Console.WriteLine(inputChars[i]);
            }
        }

        static void Activity5(string input)
        {
            string tempString = "";
            for(int i=input.Length-1; i>=0 ; i--)
            {
                tempString += input[i];
            }
            Console.WriteLine(tempString);
        }

        static void WaitForEnter()
        {
            Console.Write("Press enter when done...");
            Console.ReadLine();
        }
    }
}
