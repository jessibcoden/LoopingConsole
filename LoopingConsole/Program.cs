//depenentcies, greyed out if not using, delete them if not using them:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingConsole  
{
    //Classes are the blueprint
    class Program
    {
        //void means that it doesn't return anything
        static void Main(string[] args)
        {
            //List is a "generic type", and is used like an array
            var children = new List<Child>
            {
                new Child {Name = "Sawyer", Sick = true},
                new Child {Name = "Sage", Sick = false}
            };


            //instantiate copy of Child instance (class) / initialize object:
            //var sawyer = new Child
            //{
            //    Name = "Sawyer",
            //    Sick = true
            //};

            //var sage = new Child
            //{
            //    Name = "Sage",
            //    Sick = false
            //};

            //add child to children list
            //children.Add(sawyer);
            //children.Add(sage);

            //for (var i = 0; i < children.Count -1; i++)
            //{
            //    Console.WriteLine($" {child.Name} is {(child.Sick ? "sick" : "healthy")}");
            //    Console.WriteLine(child.ForgeASickNote());
            //}

            ////a while loop will continue to loop as long as the statement is true:
            //while (children.Count == 2)
            //{
            //    Console.WriteLine($" {child.Name} is {(child.Sick ? "sick" : "healthy")}");
            //    Console.WriteLine(child.ForgeASickNote());
            //}

            foreach (var child in children)
            {
                if (child.Name == "Sawyer")
                {
                    //"continue" will stop the current itteration of the loop and continue with the next element in the list
                    continue;
                    //"break;" will stop the loop entirely
                }
                //string interpolation with conditional ternary:
                Console.WriteLine($" {child.Name} is {(child.Sick ? "sick" : "healthy")}");
                //call methods from class:
                Console.WriteLine(child.ForgeASickNote());
            }

            Console.WriteLine("This is our second time going over the same creap");

            //Console apps need to be stopped, ReadLine stops and waits, reads a string..
            //will have to type something into the console to stop app
            Console.ReadLine(); 

        }
    }
}
