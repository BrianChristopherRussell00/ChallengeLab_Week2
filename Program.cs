using System.Diagnostics.Metrics;
using static System.Net.Mime.MediaTypeNames;

namespace ChallengeLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Assignment 1
            Console.WriteLine("Weather Reader!");
            Console.WriteLine("How hot/cold is it outside currently?");
            int weatherAnswer = Convert.ToInt32(Console.ReadLine());

            if (weatherAnswer < 10)
            {
                Console.WriteLine("It's freezing");

            }
            else if (weatherAnswer <= 11 || weatherAnswer <= 20)
            {
                Console.WriteLine("It's very cold");

            }
            else if (weatherAnswer <= 36 || weatherAnswer <= 50)
            {
                Console.WriteLine("This is pretty normal weather");
            }
            else if (weatherAnswer <= 51 || weatherAnswer <= 65)
            {
                Console.WriteLine("It's getting hot!");
            }
            else if (weatherAnswer <= 66 || weatherAnswer <= 80)
            {
                Console.WriteLine("It's getting very very hot!");
            }

            //Assignment 2: Write a C# Sharp program that takes userid and password as input (type string).
            //After 3 wrong attempts, user will be rejected.
            int i;
            int count = 0;


            Console.WriteLine("Please enter your {UserID} and {Password}!");
            Console.WriteLine("Warning!!: After 3 wrong attempts you will be rejected");
            Console.Write("UserId: ");

            string userId = Console.ReadLine();
            Console.Write("User Password: ");

            string userPassword = Console.ReadLine();



            for (i = 1; i <= 3; i++)
            {
                Console.WriteLine("Enter the User Id again");
                string testUserId = Console.ReadLine();
                Console.WriteLine("Enter the Password again");
                string testUserPassword = Console.ReadLine();
                count++;
                if (userId == testUserId && userPassword == testUserPassword && count != 3)
                {
                    Console.WriteLine("The User  Authentication successfull");
                    break;
                }
                else if (count == 3)
                {
                    Console.WriteLine("The User  Authentication failed");
                    break;
                }
            }
            Console.ReadLine();



            //Write a C# Sharp program that takes a number and a width also a number, as input and then displays
            //a triangle of that width, using that number.
            //Test Data
            //Enter a number: 6
            //Enter the desired width: 6
            //Expected Output:
            //
            //666666
            //
            //66666
            //
            //6666
            //
            //666
            //
            //66
            //
            //6

            Console.WriteLine("Give me a number?");
            int numberGiven = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the desired width: ");
            int desiredWidth = Convert.ToInt32(Console.ReadLine());
            for ( i=1; i<=desiredWidth; i++)
            {
                for (int j =i; j<=desiredWidth;  j++)
                {
                    Console.Write(numberGiven + " ");
                }
                Console.WriteLine();

            }






        }
    }
}