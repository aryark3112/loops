using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 100; i++)
            //{
            //   if (i % 5 == 0) { break; }
            //   Console.WriteLine(i + "\t");
            //}
            //for (int i = 1; i <= 100; i++)
            //{
            //   if (i % 5 == 0) { continue; }
            //   Console.Write(i + "\t");
            //}

            //int num;
            //string choice;
            //do
            //{

            //Console.WriteLine("Enter Number to find out table of the Number");
            //num = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Table of {num} as follows");
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"{num} * {i} = \t {(num * i)}");
            //}
            //Console.WriteLine("Do you wanna learn more \n If yes press y \n To Exit press any other key");
            //choice = Console.ReadLine().ToLower();
            //}
            //while (choice == "y");

            //Console.WriteLine("Enter username:");
            //string username = Console.ReadLine();

            //Console.WriteLine("Enter password:");
            //string password = Console.ReadLine();

            //if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            //{
            //  Console.WriteLine("Please provide a username and password.");
            //}
            //else if (username == "admin1256" && password == "admin@1256@1256")
            //{
            //  Console.WriteLine("Sign-in successful.");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid user.");
            //}

            //Console.ReadLine();
            //var myNum = 12;
            //var myString = "Sam";
            //var status = true;
            //var grade = "A";
            //Console.WriteLine("Value Stored in myNum is: " + myNum + "\n Data Type :" + myNum.GetType());
            //Console.WriteLine("Value Stored in myString is: " + myString + "\n Data Type :" + myString.GetType());
            //Console.WriteLine("Value Stored in status is: " + status + "\n Data Type :" + status.GetType());
            //Console.WriteLine("Value Stored in grade is: " + grade + "\n Data Type :" + grade.GetType());
            //Console.ReadKey();
            var myNum = 12;
            dynamic myDynamic = 45;
            Console.WriteLine("Value Stored in myDynamic is: " + myDynamic + "\n DataType Stored is:\t" + myDynamic.GetType());
            myDynamic = "I am Sam ";
            Console.WriteLine("Value Stored in myDynamic is: " + myDynamic + "\n DataType Stored is:\t" + myDynamic.GetType());
            myDynamic = "A";
            Console.WriteLine("Value Stored in myDynamic is: " + myDynamic + "\n DataType Stored is:\t" + myDynamic.GetType());
            Console.WriteLine("Value Stored in myNum is: " + myNum + "\n Data Type :" + myNum.GetType());
            Console.ReadKey();
        }
    }
}
