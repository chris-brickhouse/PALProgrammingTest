using System;

// explain using and the libraries available
// need the below for lists of strings
using System.Collections.Generic;

// need this for reading text files
using System.IO;

// need this for LINQ
using System.Linq;

// using [namespace].[classname].[staticonly]


namespace PALConsoleTest {
    class Program {
        static void Main(string[] args) {
            // first, explain main, console.writeline and console.read   
            // explain comments

            // simple string
            string my_string = "hello world!";
            Console.WriteLine(my_string);
            Console.ReadLine();

            // do 99 beers exercise. explain how to write a function and what the static does - ie makes it so doesn't need instatiation
            NintyNineBottles();            

            // console input
            Console.WriteLine("Enter Your Name:");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string user_name = Console.ReadLine();

            // Print the value of the variable (userName), which will display the input value
            Console.WriteLine("Your username is: " + user_name);
            Console.ReadLine();

            // messing with strings
            // explain concatentaion
            string my_string_c = "hello there, PAL teacher (" + user_name + ")";
            Console.WriteLine(my_string_c);
            Console.ReadLine();

            string my_string_concat_1 = "first part of sentence";
            string my_string_concat_2 = "second part of sentence";

            Console.WriteLine(my_string_concat_1 + " - " + my_string_concat_2);
            Console.ReadLine();

            // explain indexof, split, 1 and 0 space
            bool has_space = user_name.IndexOf(" ") > -1;
            string[] reversed_name = user_name.Split(' ');
            Console.WriteLine(has_space ? reversed_name[1] + ", " + reversed_name[0] : reversed_name[0]);
            Console.ReadLine();

            // how many spaces? introduce array length
            int num_spaces = my_string_concat_1.Split(' ').Length;
            Console.WriteLine("'" + my_string_concat_1 + "' has " + num_spaces + " spaces in it.");
            Console.ReadLine();

            //arrays and lists of strings            
            string[] my_split = my_string_c.Split(',');           

            // explain array 0
            Console.WriteLine("First half of sentence split by comma: " + my_split[0]);
            Console.WriteLine("Second half of sentence split by comma: " + my_split[1]);
            Console.ReadLine();

            // explain arrays + lists of string
            string[] my_string_array = new string[] { "First", "Second", "Third" };
            List<string> my_string_list = new List<string>() { "First List Item", "Second List Item", "Third List Item", "Fourth List Item" };

            foreach (string item in my_string_array) {
                Console.WriteLine(item);
            }
            Console.WriteLine("This array had " + my_string_array.Length + " items in it.");
            Console.ReadLine();


            foreach (string item in my_string_list) {
                Console.WriteLine(item);
            }
            Console.WriteLine("This array had " + my_string_list.Count + " items in it.");
            Console.ReadLine();

            // messing with numbers
            int my_number = 4;
            int my_second_number = 10;

            // explain that everything within quotes is a string
            Console.WriteLine(my_number + " + " + my_second_number + " = " + (my_number + my_second_number));
            Console.ReadLine();

            int[] my_int_array = new int[] { 1, 2, 3 };
            List<int> my_int_list = new List<int>() { 1, 2, 3};

            foreach (int item in my_int_array) {
                Console.WriteLine(item);
            }

            foreach (int item in my_int_list) {
                Console.WriteLine("List item #:" + item);
            }

            // reading files - explain the @
            string text = File.ReadAllText(@"C:\Source\Workspaces\PALProgramming\PALConsoleTest\text\test.txt");

            // display. explain params.
            Console.WriteLine("Contents of test.txt = {0}", text);
            Console.ReadLine();

            // ease into string interpolation
            Console.WriteLine($"Contents of test.txt {text}");
            Console.ReadLine();

            // make new class then explain namespace, class, add nn function to that
            NintyNineBottles nn = new NintyNineBottles();
            nn.Run99();

            // finish with get99
            string from_class = nn.Get99();
            Console.WriteLine(from_class);
            Console.ReadLine();

            // messing with dates
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("MM/dd/yyyy"));
            Console.WriteLine(now.AddDays(30));
            Console.ReadLine();

            // lists of dates
            List<DateTime> ld = new List<DateTime>() { };
            for (var i = DateTime.Today.Month; i>=1; i--) {
                ld.Add(DateTime.Today.AddMonths(-i));
            }
            Console.WriteLine(string.Join(",",  ld.ToArray()));
            Console.WriteLine(ld.First());
            Console.ReadLine();

            // into the database
            //Console.ReadLine();
        }

        static void NintyNineBottles() {

            // explain try catch and how to stop errors

            try {
                int error_zero = 0;
                int error = 100 / error_zero;
            } catch (Exception e) {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }

            // explain for loop
            for (var i = 99; i >= 0; i--) {
                //Console.WriteLine(i + " bottles of beer on the wall, " + i + " bottles of beer, take one down and pass it around, " + (i - 1) + " bottles of beer on the wall");
                //Console.WriteLine(i + " bottles of beer on the wall, " + i + " bottles of beer, take one down and pass it around, " + (i == 0 ? 0 : i - 1) + " bottles of beer on the wall");
                if (i == 50) {
                    Console.WriteLine($"{i} bottles of beer on the wall, we are halfway there!");
                } else {
                    Console.WriteLine($"{i} bottles of beer on the wall, {i} bottles of beer, take one down and pass it around, {(i == 0 ? 0 : i - 1)} bottles of beer on the wall");
                }
            }
            Console.ReadLine();
        }
    }
}
