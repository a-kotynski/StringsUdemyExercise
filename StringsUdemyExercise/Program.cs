using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.udemy.com/course/csharp-tutorial-for-beginners/learn/lecture/2984160#content
namespace StringsUdemyExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Abe Cede  ";
            Console.WriteLine($"Full name: '{fullName}'\n");
            Console.WriteLine($"Trim: '{fullName.Trim()}'\n");
            Console.WriteLine($"ToUpper: '{fullName.ToUpper().Trim()}'\n");

            // Dividing full name into first name and second name
            // Substring method
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1); // if ending point isn't assigned it creates a substring to the end of string

            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);

            // Split method
            var names = fullName.Split(' ');
            Console.WriteLine("First Name: " + names[0]);
            Console.WriteLine("Last Name: " + names[1]);
            Console.WriteLine("Empty Name: " + names[2]); // space
            Console.WriteLine("Empty Name: " + names[3]); // second space
            //Console.WriteLine("Empty Name: " + names[4]); // crash

            // Replace method
            fullName.Replace("Abe", "Abeagh"); //it creates new string, it doesn't overwrite first one
            fullName.Replace('e','E');
            Console.WriteLine(fullName.Replace("Abe", "Abeagh"));

            Console.WriteLine();

            // validation of user input
            if (String.IsNullOrEmpty(" ".Trim()))
            {
                //Console.WriteLine("Invalid");
            }
            //is the same as:
            if (String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Invalid");
            }
            Console.WriteLine();

            var str = "25"; // user input
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C0"));
        }
    }
}