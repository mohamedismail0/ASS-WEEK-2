using System;
using System.Collections.Generic;

namespace ASS_WEEK_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 1, 6, 4, 8, 2, 1, 5 };
            char input;

            do
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("P - Print numbers ");
                Console.WriteLine("A - Add a number");
                Console.WriteLine("M - Display mean of the numbers");
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("L - Display the largest number");
                Console.WriteLine("C - Clear the list");
                Console.WriteLine("I - Search for a number and get its index");
                Console.WriteLine("R - Reverse the list");
                Console.WriteLine("Q - Quit");

                Console.Write("\nEnter your choice: ");
                input = Convert.ToChar(Console.ReadLine());

                switch (input)
                {
                    case 'P':
                    case 'p':
                        if (nums.Count == 0)
                        {
                            Console.WriteLine("[] - The list is empty.");
                        }
                        else
                        {
                            Console.WriteLine("The list elements:");
                            Console.WriteLine("[" + string.Join(", ", nums) + "]");
                        }
                        break;

                    case 'A':
                    case 'a':
                        Console.Write("Enter the number you want to add: ");
                        int add_num = Convert.ToInt32(Console.ReadLine());
                        nums.Add(add_num);
                        Console.WriteLine($"{add_num} has been added.");
                        break;
//=============================================================================================
                    case 'M':
                    case 'm':
                        if (nums.Count == 0)
                        {
                            Console.WriteLine("Unable to calculate the mean - no data.");
                        }
                        else
                        {
                            int sum = 0;
                            for (int i = 0; i < nums.Count; i++)  // <== fixed index start
                            {
                                sum += nums[i];
                            }
                            double average = (double)sum / nums.Count;
                            Console.WriteLine($"The average is: {average:F2}");
                        }
                        break;
//=============================================================================================
                    case 'S':
                    case 's':
                        if (nums.Count == 0)
                        {
                            Console.WriteLine("Unable to determine the smallest number - list is empty.");
                        }
                        else
                        {
                            int smallest = nums[0];
                            for (int i = 1; i < nums.Count; i++)
                            {
                                if (nums[i] < smallest)
                                {
                                    smallest = nums[i];
                                }
                            }
                            Console.WriteLine($"The smallest number is: {smallest}");
                        }
                        break;
//=============================================================================================
                    case 'L':
                    case 'l':
                        if (nums.Count == 0)
                        {
                            Console.WriteLine("Unable to determine the largest number - list is empty.");
                        }
                        else
                        {
                            int largest = nums[0];
                            for (int i = 1; i < nums.Count; i++)
                            {
                                if (nums[i] > largest)
                                {
                                    largest = nums[i];
                                }
                            }
                            Console.WriteLine($"The largest number is: {largest}");
                        }
                        break;
//=============================================================================================
                    case 'C':
                    case 'c':
                        nums.Clear();
                        Console.WriteLine("The list has been cleared.");
                        break;
//=============================================================================================
                    case 'I':
                    case 'i':
                        if (nums.Count == 0)
                        {
                            Console.WriteLine("The list is empty.");
                        }
                        else
                        {
                            Console.Write("Enter the number you want to find: ");
                            int x = Convert.ToInt32(Console.ReadLine());
                            int check = 0;
                            for (int i = 0; i < nums.Count; i++)
                            {
                                if (nums[i] == x)
                                {
                                    Console.WriteLine($"{x} is found at index {i}");
                                    check++;
                                }
                            }
                            if (check > 0)
                            {
                                Console.WriteLine($"The number was found {check} time(s).");
                            }
                            else
                            {
                                Console.WriteLine("The number was not found.");
                            }
                        }
                        break;
//=============================================================================================
                    case 'R':
                    case 'r':
                        if (nums.Count == 0)
                        {
                            Console.WriteLine("The list is empty.");
                        }
                        else
                        {
                            List<int> reversed_list = new List<int>();
                            for (int i = nums.Count - 1; i >= 0; i--)
                            {
                                reversed_list.Add(nums[i]);
                            }
                            Console.WriteLine("The reversed list:");
                            Console.WriteLine("[" + string.Join(", ", reversed_list) + "]");
                        }
                        break;
//=============================================================================================
                    case 'Q':
                    case 'q':
                        Console.WriteLine("Goodbye :)");
                        break;
//=============================================================================================
                    default:
                        Console.WriteLine("Invalid input, please try again.");
                        break;
                }

            } while (input != 'Q' && input != 'q');
        }
    }
}
