using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemyCsharpPractice
{
    //Section 4 Lectures 26-39 

    //class for Reference and Value types
    public class ReferenceAndValueTypes
    {
        public static void Example()
        {
            valVsRef37.practice();
            valVsRef38.practice();

            Console.ReadLine();

            /*summary 
             * Classes -> Reference Types
             * Strings, Arrayas, Custom Classes
             * 
             * Structures -> Value Types
             * Primitive Types (int, char float), Custom Structures
             * */

        }
    }

    //Section 4 Lecture 37
    public class valVsRef37
    {
        public static void practice()
        {
            //value type
            var a = 10;
            var b = a;
            b++;

            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            //b gets the VALUE of a
            //therefore a does not inherit the increment of b
            //two separate locations of memory holding the value

            //reference type
            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;

            Console.WriteLine(string.Format("ra1: {0}, ra2: {1}", array1[0], array2[0]));

            //in the above scenario, arrays are reference type variables. 
            //they look at a location in memory
            //therefore array1 and array2 are looking at the same point in memory
            //the changes to array2 changed array1, b/c the change took place
            //at the same point in memory
            Console.ReadLine();
        }
    }
    //Section 4 Lecture 38
    public class valVsRef38
    {
        public static void practice()
        {
            //this is number in scope of main
            int number = 1;
            Console.WriteLine(string.Format("number BEFORE method: {0}", number));
            //the "number" in Increment method is only related to its own scope
            //two separate locations in memory
            Increment(number);
            Console.WriteLine(string.Format("number AFTER method: {0}", number));

            //ths person is in scope of main only
            var person = new Person() { Age = 20 };
            Console.WriteLine(string.Format("person.Age BEFORE method: {0}", person.Age));
            //the method makes old references the reference value of person
            //therefore the age change will display
            makeOld(person);
            
            Console.WriteLine(string.Format("person.Age AFTER method: {0}", person.Age));
        }

        //param is a value type
        //the value is never returned, therefore never stored in memory
        public static void Increment(int number) 
        {
            number += 10;
        }

        //param is a reference type
        //the value is not returned, but the change was made at its location in memory
        //therefore the value gets saved
        public static void makeOld(Person person)
        {
            person.Age += 10;
        }
    }
    public class Person
    {
        public int Age;
    }
}
