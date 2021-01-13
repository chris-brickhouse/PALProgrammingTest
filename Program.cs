using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

using PALConsoleTest.Models;

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
            //// first, explain main, console.writeline and console.read   
            //// explain comments

            //// simple string
            //string my_string = "hello world!";
            //Console.WriteLine(my_string);
            //Console.ReadLine();

            //// do 99 beers exercise. explain how to write a function and what the static does - ie makes it so doesn't need instatiation
            //NintyNineBottles();

            //// console input
            //Console.WriteLine("Enter Your Name:");

            //// Create a string variable and get user input from the keyboard and store it in the variable
            //string user_name = Console.ReadLine();

            //// Print the value of the variable (userName), which will display the input value
            //Console.WriteLine("Your username is: " + user_name);
            //Console.ReadLine();

            //// messing with strings
            //// explain concatentaion
            //string my_string_c = "hello there, PAL teacher (" + user_name + ")";
            //Console.WriteLine(my_string_c);
            //Console.ReadLine();

            //string my_string_concat_1 = "first part of sentence";
            //string my_string_concat_2 = "second part of sentence";

            //Console.WriteLine(my_string_concat_1 + " - " + my_string_concat_2);
            //Console.ReadLine();

            //// explain indexof, split, 1 and 0 space
            //bool has_space = user_name.IndexOf(" ") > -1;
            //string[] reversed_name = user_name.Split(' ');
            //Console.WriteLine(has_space ? reversed_name[1] + ", " + reversed_name[0] : reversed_name[0]);
            //Console.ReadLine();

            //// how many spaces? introduce array length
            //int num_spaces = my_string_concat_1.Split(' ').Length;
            //Console.WriteLine("'" + my_string_concat_1 + "' has " + num_spaces + " spaces in it.");
            //Console.ReadLine();

            ////arrays and lists of strings            
            //string[] my_split = my_string_c.Split(',');

            //// explain array 0
            //Console.WriteLine("First half of sentence split by comma: " + my_split[0]);
            //Console.WriteLine("Second half of sentence split by comma: " + my_split[1]);
            //Console.ReadLine();

            //// explain arrays + lists of string
            //string[] my_string_array = new string[] { "First", "Second", "Third" };
            //List<string> my_string_list = new List<string>() { "First List Item", "Second List Item", "Third List Item", "Fourth List Item" };

            //foreach (string item in my_string_array) {
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("This array had " + my_string_array.Length + " items in it.");
            //Console.ReadLine();


            //foreach (string item in my_string_list) {
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("This array had " + my_string_list.Count + " items in it.");
            //Console.ReadLine();

            //// messing with numbers
            //int my_number = 4;
            //int my_second_number = 10;

            //// explain that everything within quotes is a string
            //Console.WriteLine(my_number + " + " + my_second_number + " = " + (my_number + my_second_number));
            //Console.ReadLine();

            //int[] my_int_array = new int[] { 1, 2, 3 };
            //List<int> my_int_list = new List<int>() { 1, 2, 3 };

            //foreach (int item in my_int_array) {
            //    Console.WriteLine(item);
            //}

            //foreach (int item in my_int_list) {
            //    Console.WriteLine("List item #:" + item);
            //}

            //// reading files - explain the @
            //string text = File.ReadAllText(@"C:\Source\Workspaces\PALProgramming\PALConsoleTest\text\test.txt");

            //// display. explain params.
            //Console.WriteLine("Contents of test.txt = {0}", text);
            //Console.ReadLine();

            //// ease into string interpolation
            //Console.WriteLine($"Contents of test.txt {text}");
            //Console.ReadLine();

            //// make new class then explain namespace, class, add nn function to that
            //NintyNineBottles nn = new NintyNineBottles();
            //nn.Run99();

            //// finish with get99
            //string from_class = nn.Get99();
            //Console.WriteLine(from_class);
            //Console.ReadLine();

            List<Bottle> bl = new List<Bottle>();

            for (int i = 0; i <= 99; i++) {
                Array values = Enum.GetValues(typeof(BottleType));
                Random random = new Random();
                BottleType type = (BottleType)values.GetValue(random.Next(values.Length));
                bl.Add(new Bottle() { Number = i, Type = type });
            }
            bl = bl.OrderByDescending(x => x.Number).ToList();

            foreach (Bottle b in bl) {
                Console.WriteLine($"{b.Number} bottles of {b.Type}, {b.Number} bottles of {b.Type}, take one down and pass it around, {b.Number - 1} bottles of {b.Type} on the wall!");
            }

            // different kind of loop
            bl.ForEach(x => {
                Console.WriteLine($"{x.Number} bottles of {x.Type}, {x.Number} bottles of {x.Type}, take one down and pass it around, {x.Number - 1} bottles of {x.Type} on the wall!");
            });

            // show how to instatiate object
            Bottle bottle = bl.Where(x => x.Number == 45).FirstOrDefault() ?? new Bottle() { Number = 0, Type = null };
            Console.WriteLine($"Bottle type for bottle #{bottle.Number} - {bottle.Type}");

            Beer beer = new Beer() { Number = 700, ABV = "15%", Size = 40 };

            Console.WriteLine($"Bottle type for bottle #{beer.Number} - {beer.Type}");

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
            for (var i = DateTime.Today.Month; i >= 1; i--) {
                ld.Add(DateTime.Today.AddMonths(-i));
            }
            Console.WriteLine(string.Join(",", ld.ToArray()));
            Console.WriteLine(ld.First());
            Console.ReadLine();

            // into the database
            //// EF: 
            //// 1) add appsettings.json 2) create models class 3) create users model

            //// explain calling the dbcontext

            PALModels db = new PALModels();

            // get list of users - explain ?? for nullable stuff
            List<Users> u = (from user in db.Users select user).ToList() ?? new List<Users>();
            u.ForEach(x => {
                Console.WriteLine($"User Name: {x.FirstName} {x.LastName}");
            });

            // get list teachers
            List<Users> t = (from user in db.Users where (user.IsTeacher ?? false) select user).ToList() ?? new List<Users>();
            t.ForEach(x => {
                Console.WriteLine($"Teacher Name: {x.FirstName} {x.LastName}");
            });

            // get individual
            Users teacher = (from user in db.Users where (user.IsTeacher ?? false) select user).FirstOrDefault() ?? new Users();
            Console.WriteLine($"Individual Teacher Name: {teacher.FirstName} {teacher.LastName}");

            // explain include and theninclude
            List<Users> lu = (from user in db.Users.Include(x => x.UsersAttendance).Include(x=>x.UsersGrades).ThenInclude(x => x.Class) select user).ToList() ?? new List<Users>();
            lu.ForEach(x => {
                Console.WriteLine($"User Name: {x.FirstName} {x.LastName}");
                x.UsersGrades.ForEach(y => {
                    Console.WriteLine($"Grade: {y.Class.Name}: {y.Grade}");
                }); 
            });

            // get user
            Users user1 = (from user in db.Users where user.UserID == 1 select user).FirstOrDefault() ?? new Users();
            Console.WriteLine($"Enter a new password for: {user1.FullName}");
            string new_password = Console.ReadLine();
            
            // update password
            user1.Password = new_password;
            db.Users.Update(user1);
            db.SaveChanges();

            // delete
            user1 = (from user in db.Users where user.UserID == 6 select user).FirstOrDefault() ?? new Users();
            if (user1.UserID > 0) {
                db.Users.Remove(user1);
                db.SaveChanges();
            }

            // insert new + split combined
            Console.WriteLine($"Enter a name user like this: firstname|lastname|email|password|isteacher");
            string new_user = Console.ReadLine();
            string[] new_user_split = new_user.Split("|");

            // install this for hashing - install-package Microsoft.Extensions.Identity.Core
            user1 = new Users() { FirstName = new_user_split[0], LastName = new_user_split[1], Email = new_user_split[2], Password = new PasswordHasher<object?>().HashPassword(null, new_user_split[3]), IsTeacher = Convert.ToBoolean(new_user_split[4]) };
            db.Users.Update(user1);
            db.SaveChanges();
            Console.WriteLine($"New user ID: {user1.UserID} - Password: {user1.Password}");

            Console.ReadLine();
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
