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
            //CF_E1_Q1();
            //CF_E1_Q2();
            //CF_E1_Q3();
            CF_E1_Q4();
        }
        public static void CF_E1_Q1()
        {
            Console.WriteLine("Please enter a value between 1 & 10");
            var value = Convert.ToInt32(Console.ReadLine());      
            if ((value >= 1) && (value <= 10))           
                Console.WriteLine("Thank you for the value - " + value);            
            else            
                Console.WriteLine("Value not valid - " + value);                   
        }
        public static void CF_E1_Q2()
        {
            Console.WriteLine("Please Enter a number"); 
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter a second number");
            var b = Convert.ToInt32(Console.ReadLine());
            var max = (a > b) ? a : b;

            Console.WriteLine("Max value = " + max + " of " + a + "," + b);
        }
        public static void CF_E1_Q3()
        {
            Console.WriteLine("What is the width of the picture?");
            var width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the height of the picture?");
            var height = Convert.ToInt32(Console.ReadLine());
            var orientation = (width > height) ? "Landscape" : "Portrait";

            Console.WriteLine("The orientation of your piture is " + orientation);
        }
        public static void CF_E1_Q4()
        {
            Console.WriteLine("What is the speed limit?");
            var limit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What was the speed of the vehicle?");
            var speed = Convert.ToInt32(Console.ReadLine());
            var demerits = 0;
            if (speed <= limit)
                Console.WriteLine("Ok");
            else if (speed > limit)
            {
                demerits = (speed - limit) / 5;
                if (demerits >= 12)
                {
                    Console.WriteLine("License Suspended");
                    Console.WriteLine(demerits + " demerits");
                }                                  
                else
                    Console.WriteLine("Slow down! " + demerits + " demerits added to License");
            }
            CF_E1_Q4();
        }
    }
}
