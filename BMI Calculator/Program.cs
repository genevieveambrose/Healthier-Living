using System;

namespace BMI_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("                                                        __ ");
                Console.WriteLine(" __    _              _____         _ _   _   _        |  |");
                Console.WriteLine("|  |  |_|_ _ ___     |  |  |___ ___| | |_| |_|_|___ ___|  |");
                Console.WriteLine("|  |__| | | | -_|    |     | -_| .'| |  _|   | | -_|  _|__|");
                Console.WriteLine("|_____|_| _ |___|    |__|__|___|__,|_|_| |_|_|_|___|_| |__|");
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("What would you like to do?");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("     1) Calculate my BMI!");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("     2) Find easy and yummy recipes for healthy snacks!");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("     3) Learn quick tips for staying active and healthy at work!");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("     4) Close the app!");
                Console.ForegroundColor = ConsoleColor.Black;
                string initialInput = Console.ReadLine();

                if (initialInput == "1")
                {
                    bool running = true;
                    while (running)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("Please enter your weight in pounds: ");
                        string weightAsString = Console.ReadLine();
                        int weightAsInt = new int();
                        bool weightIsAnInt = int.TryParse(weightAsString, out weightAsInt);
                        if (weightIsAnInt == false)
                        {
                            Console.WriteLine("This is not a valid weight in pounds. Please hit enter and try again.");
                            Console.ReadLine();
                            break;
                        }
                        Console.Write("Please enter your height in inches: ");
                        string heightAsString = Console.ReadLine();
                        int heightAsInt = new int();
                        bool heightIsAnInt = int.TryParse(heightAsString, out heightAsInt);
                        if (heightIsAnInt == false)
                        {
                            Console.WriteLine("This is not a valid height in inches. Please hit enter and try again.");
                            Console.ReadLine();
                            break;
                        }
                        int yourBMI = (weightAsInt * 703 / (heightAsInt * heightAsInt));
                        if (yourBMI < 19)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine($"Your BMI is {yourBMI} and you are underweight.");
                        }
                        else if (yourBMI < 26)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"Your BMI is {yourBMI} and you are a healthy weight.");
                        }
                        else if (yourBMI < 31)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine($"Your BMI is {yourBMI} and you are overweight.");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine($"Your BMI is {yourBMI} and you are obese.");
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("*********************************************************************");
                        Console.WriteLine("*If your BMI is less than 19, you fall within the underweight range.*");
                        Console.WriteLine("*If your BMI is 19 to 25, you fall within the normal range.         *");
                        Console.WriteLine("*If your BMI is 26 to 30, it falls within the overweight range.     *");
                        Console.WriteLine("*If your BMI is 31 or higher, you fall within the obese range.      *");
                        Console.WriteLine("*********************************************************************");
                        Console.ReadLine();
                        break;
                    }
                    Console.Clear();
                }
                else if (initialInput == "2")
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Please choose a number below to return a recipe!");
                    Console.WriteLine("     1)Baked Kale Chips");
                    Console.WriteLine("     2)Peanut Butter Fruit Dip");
                    Console.WriteLine("     3)Chocolate Chip Protein Cookies");
                    Console.WriteLine("     4)Berry Yogurt Smoothie");
                    string recipeInput = Console.ReadLine();
                    if (recipeInput == "1")
                    {
                        Console.WriteLine("Ingredients");
                        Console.WriteLine("     1 bunch kale; 1 tbsp olive oil; 1 tsp salt");
                        Console.WriteLine();
                        Console.WriteLine("Instructions");
                        Console.WriteLine("     Preheat oven to 350 degrees. Remove the leaves from the thick stems and tear into bite size pieces.");
                        Console.WriteLine("     Drizzle kale with olive oil and sprinkle with salt. Bake until the edges brown, 10 to 15 minutes.");
                        Console.ReadLine();
                    }
                    else if (recipeInput == "2")
                    {
                        Console.WriteLine("Ingredients");
                        Console.WriteLine("     1 heaping cup of vanilla greek yogurt, 1/3 cup creamy peanut butter, 1 tbsp honey.");
                        Console.WriteLine();
                        Console.WriteLine("Instructions");
                        Console.WriteLine("     Add all ingredients to a bowl and whisk to blend until smooth. Serve with fruit.");
                        Console.ReadLine();
                    }
                    else if (recipeInput == "3")
                    {
                        Console.WriteLine("Ingredients");
                        Console.WriteLine("     2 mashed ripe bananas; 3/4 cup vanilla protein powder; 1 cup oats; 2 tbsp peanut butter; 1/3 cup chocolate chips");
                        Console.WriteLine();
                        Console.WriteLine("Instructions");
                        Console.WriteLine("     Preheat oven to 350 degrees. Mix all the ingredients together until just combined.");
                        Console.WriteLine("     Spoon heaping tablespoon fulls onto the baking sheet. Bake 10 - 12 minutes until tops are firm.");
                        Console.ReadLine();
                    }
                    else if (recipeInput == "4")
                    {
                        Console.WriteLine("Ingredients");
                        Console.WriteLine("     3/4 cup blueberries; 3/4 cup blackberries; 5.3 oz plain Greek yogurt; 1 cup vanilla soy milk; 1 whole banana");
                        Console.WriteLine();
                        Console.WriteLine("Instructions");
                        Console.WriteLine("     Add all of the ingredients to a blender. Pulse for 30 seconds, stir and pulse for an additional 30 seconds.");
                        Console.WriteLine("     Pour into two glasses and serve immediately or refrigerate until ready to serve.");

                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("This is not a valid recipe number. Please close the program and try again.");
                        Console.ReadLine();
                    }
                    Console.Clear();
                }
                else if (initialInput == "3")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Please enter a number between 1 and 5 to return a health tip!");
                    string userNumber = Console.ReadLine();
                    if (userNumber == "1")
                    {
                        Console.WriteLine("Make a goal to be up from your desk at least once per hour!");
                        Console.ReadLine();
                    }
                    else if (userNumber == "2")
                    {
                        Console.WriteLine("Volunteer to make the office coffee run!");
                        Console.ReadLine();
                    }
                    else if (userNumber == "3")
                    {
                        Console.WriteLine("Walk instead of calling or emailing!");
                        Console.ReadLine();
                    }
                    else if (userNumber == "4")
                    {
                        Console.WriteLine("Take the stairs instead of the elevator.");
                        Console.ReadLine();
                    }
                    else if (userNumber == "5")
                    {
                        Console.WriteLine("Pack your lunch instead of eating out!");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("This is not a valid option. Please hit enter and try again.");
                        Console.ReadLine();
                    }
                    Console.Clear();
                }
                else if (initialInput == "4")
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Thank you for using this app! Please press enter to exit the app!");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("This is not a valid option... Please hit enter to try again!");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }
}
