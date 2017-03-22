//Project Prolog
//Name: Vinson L Aiono
//CS 1400 Section 001
//Project: CS1400_Lab_03
//
//I declare that the following code was written by me or provided
//by the instructor for this project. I understand that copying source,
//code from any other source constitutes cheating, and that i will receive
//a zero on this prohect if I am found in violation of this policy
//---------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Lab_03
{
    class Program
    {
        /// <summary>
        /// Lab_03 Ask user some questions and outputs it on screen
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string userName = "";
            int age = 0;
            double money = 0.00;

            Console.WriteLine("Hello there, My Name is Hal");
            Console.Write("Please Enter Your Name: ");

            userName = Console.ReadLine();
            Console.Write("Hello {0}, how old are you? ", userName);    //code reads the input for username and then displays the next question

            age = int.Parse(Console.ReadLine());  //recieves the age input and displays next question.

            Console.Write("How much money do you have? ");
            money = double.Parse(Console.ReadLine());    //this code will read how much money the user has

            Console.WriteLine("Thank you {0}. You are almost {1} years old and you have {2:c}.", userName, age + 1, money);    //Gathers users input and places all info in a string

            Console.ReadLine();
        }//End Main()
    }//End Class Program
}//End namespace

/*
Question 1 - you hold a persons age in an int variable because peoples age does not contain decimals 
Question 2 - {money:c} will output the amount in dollar format with the dollar sign $0.00
*/