using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemyCsharpPractice
{
    //Section 5 lectures 40-50
    public class ControlFlow
    {
        public static void Example()
        {
            //ifElse.Practice();
            //boolIfElse.Practice();
            //conditionals.Practice();
            ControlFlowExcerciseOne.Practice();
            Console.ReadLine();
        }
    }
    public class ifElse
    {
        public static void Practice()
        {
            int hour = 10;
            CheckTime(hour);
            hour = 14;
            CheckTime(hour);
            hour = 20;
            CheckTime(hour);
        }

        public static void CheckTime(int hour)
        {
            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon");
            }
            else
            {
                Console.WriteLine("It's evening");
            }
        }
    }
    public class boolIfElse
    {
        public static void Practice()
        {
            bool isGoldCustomer = false;

            float price;
            //if else block
            /*
            if (isGoldCustomer)
            {
                price = 19.99;
            }
            else
            {
                price = 29.99;
            }*/

            //alternative method
            price = (isGoldCustomer) ? 19.99f : 29.99f;
            Console.WriteLine("is this a gold customer? " + isGoldCustomer);
            Console.WriteLine("Price is: " + price);
            Console.WriteLine();

            //lets switch to true
            isGoldCustomer = true;
            price = (isGoldCustomer) ? 19.99f : 29.99f;
            Console.WriteLine("is this a gold customer? " + isGoldCustomer);
            Console.WriteLine("Price is: " + price);

        }
    }
    public class conditionals
    {
        public static void Practice()
        {
            var season = Season.Autumn;
            switch(season)
            {
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("We have our Summer/Fall Promotion available");
                    break;
                default:
                    Console.WriteLine("No Promotion Currently Available");
                    break;
            }
        }
    }
    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    public class ControlFlowExcerciseOne
    {
        public static void Practice()
        {
            CF_E1_Q1();

        }
        public static void CF_E1_Q1()
        {
            var value ="";
            Console.WriteLine("Please enter a value between 1 & 10");
            value = Console.ReadLine();         
            switch(value)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                    Console.WriteLine("Thank you for entering a number between 1 & 10 - " + value);
                    break;
                default:
                    Console.WriteLine("The Entry: " + value + " is not between 1 & 10");
                    Practice();
                    break;
            }          
        }
    }
}
