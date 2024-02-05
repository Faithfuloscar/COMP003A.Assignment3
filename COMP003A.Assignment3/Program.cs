/*
*  Author: Oscar Mendez
*  Course: COMP - 003A
*  Purpose: to replicate output assignment
*/


using System.ComponentModel.Design;

namespace COMP003A.Assignment3_
{
    internal class Program
    {
        static void Main()
        {
            {
                Console.WriteLine("Numeric to letter grade using an if-else statement");
            }
            // user input for numeric grade
            Console.WriteLine("Enter numeric grade (0-100): ");
            string input = Console.ReadLine();

            // Convert input to a double
            if (double.TryParse(input, out double numericGrade))
            {
                // Check if number is within range
                if (numericGrade >= 0 && numericGrade <= 100)
                {
                    // Determine letter grade base on range
                    char letterGrade = GetLetterGrade(numericGrade);

                    // Display result
                    Console.WriteLine($"Your letter grade is: {letterGrade}");
                }
                // Display result if number is not within range
                else
                {
                    Console.WriteLine("invalid input. Numeric grade must be between 0 and 100.");
                }
            }
            // Display if a value is not given but rather a variable
            else
            {
                Console.WriteLine("invalid input. Please enter a valid numeric grade.");
            }


            // get letter grade based on numeric grade
            static char GetLetterGrade(double numericGrade)
            {
                // console output letter grade: A
                if (numericGrade >= 90)
                    return 'A';
                // console output letter grade: B
                else if (numericGrade >= 80)
                    return 'B';
                // console output letter grade: C
                else if (numericGrade >= 70)
                    return 'C';
                // console output letter grade: D
                else if (numericGrade >= 60)
                    return 'D';
                // console output letter grade: F
                else
                    return 'F';
            }

            // start of string day with switch statements
            {
                Console.WriteLine("***********************************");
                Console.WriteLine("Integer to string day using an switch statement");
                Console.WriteLine("Enter an integer day of the week (1-7).");
                
                // get input into string
                string userInput = Console.ReadLine();

                // change string into integer
                if (int.TryParse(userInput, out int numericDay))
                {
                    // switch statement based on numericday
                    switch (numericDay)
                    {
                        case 1: Console.WriteLine("Monday");
                            break;
                        case 2: Console.WriteLine("Tuesday");
                            break;
                        case 3: Console.WriteLine("Wednesday");
                            break;
                        case 4: Console.WriteLine("Thursday");
                            break;
                        case 5: Console.WriteLine("Friday");
                            break;
                        case 6: Console.WriteLine("Saturday");
                            break;
                        case 7: Console.WriteLine("Sunday");
                            break;
                    }
                }
                else 
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }
    }
}