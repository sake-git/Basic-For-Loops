Console.WriteLine("\n*****************************************************************************************************");
Console.WriteLine("Input a number from user and display the sum of numbers from 1 to the number entered by user.");
Console.WriteLine("*****************************************************************************************************\n");

do
{
    Console.WriteLine("\nEnter a number:"); //Take input from user
    int userInputNumber = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    for (int counter = 1; counter <= userInputNumber; counter++) //for loop to sum the number from 1 to user input number
    { 
        sum += counter;
    }
    Console.WriteLine($"The sum of all numbers from 1 to {userInputNumber} is {sum}");

    Console.WriteLine("\nWould you like to continue (y/n)?"); //Check if user like to continue
} while (Console.ReadLine().ToLower() == "y");

Console.WriteLine("Goodbye!");

Console.ReadKey();