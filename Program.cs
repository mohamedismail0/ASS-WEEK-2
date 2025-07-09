//using System.Threading.Channels;

using System.Threading.Channels;

namespace ASS_WEEK_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() {1,6,4,8,2,1,5};
            char input;

            do
            {

            Console.WriteLine("P - Print numbers ");
            Console.WriteLine("A - Add a number");
            Console.WriteLine("M - Display mean of the numbers");
            Console.WriteLine("S - Display the smallest number");
            Console.WriteLine("L - Display the largest number");
            Console.WriteLine("C - Clear the list");
            Console.WriteLine("i - Search for a number and get it's index");
            Console.WriteLine("Q - Quit");

            Console.WriteLine("enter your choice : ");

            input = Convert.ToChar(Console.ReadLine());

              switch(input)
                {
                    case 'p':
                    case 'P':
                        if (nums.Count == 0)
                        {
                            Console.WriteLine("[] - the list is empty");
                        }
                        else
                        {
                            Console.WriteLine("the list elements : \n");
                            Console.WriteLine("[" + string.Join(", ", nums) + "]");

                            //for (int i = 0; i <nums.Count; i++)
                            //{
                            //    Console.WriteLine(nums[i]);
                            //}
                        }

                        break;
//=============================================================================
                    case 'a':
                    case 'A':
                        Console.WriteLine("enter the number you want to add : ");
                        int add_num = Convert.ToInt32(Console.ReadLine());
                        nums.Add(add_num);
                        Console.WriteLine($"{add_num} is added ");
                        break;
//=============================================================================
                    case 'M':
                    case 'm':
                        if (nums.Count == 0)
                        {
                            Console.WriteLine("Unable to calculate the mean - no data");
                        }
                        else
                        {
                            int sum = 0;
                            for (int i = 1; i <= nums.Count; i++)
                            {
                                sum += nums[i];
                            }
                            double average = sum / nums.Count;
                            Console.WriteLine($"the average of the list is {average} ");
                        }
                        break;
//=============================================================================

                    case 'S':
                    case 's':

                        if (nums.Count == 0)
                        {
                            Console.WriteLine("Unable to determine the smallest number - list is empty");
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
                            Console.WriteLine($"the smallest number in the list is {smallest}");
                        }

                        break;

//=============================================================================

                    case 'L':
                    case 'l':
                        if (nums.Count == 0)
                        {
                            Console.WriteLine("Unable to determine the smallest number - list is empty");
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
                            Console.WriteLine($"the largest number in the list is {largest} ");
                        }

                        break;
//=============================================================================
                    case 'C':
                    case 'c':
                        if (nums.Count == 0)
                        {
                            Console.WriteLine("the list is already empty ");
                        }
                        else
                        {
                            nums.Clear();
                            Console.WriteLine("the list is empty now ");
                        }
                        break;

//=============================================================================

                    case 'I':
                    case 'i':
                        if (nums.Count == 0)
                        {
                            Console.WriteLine("the list is empty ");
                        }
                        else
                        {
                            Console.WriteLine("enter the number you want to find ");
                            int x = Convert.ToInt32(Console.ReadLine());

                            int check = 0;
                            for(int i = 0; i < nums.Count; i++)
                            {
                                if (x == nums[i])
                                {
                                    Console.WriteLine($"{x} is found at index {i}");
                                    check += 1;
                                }                     
                            }
                            if (check != 0)
                            {
                                Console.WriteLine($"the number is found in the list {check} times ");

                            }
                            else
                            {
                                Console.WriteLine("the number is not found ");
                            }
                                
                        }
                        break;
//=============================================================================
                    case 'Q':
                    case 'q':
                        Console.WriteLine("goodbye :)");

                        break;
//=============================================================================

                    default:
                        Console.WriteLine("wrong input , try again ");
                        break;


                }
                
            } while (input != 'q'&& input !='Q');
        }
    }
}
