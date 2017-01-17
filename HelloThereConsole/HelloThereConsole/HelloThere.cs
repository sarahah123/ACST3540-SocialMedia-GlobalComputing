using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Course:          ACST 3540
 * Section:         01
 * Name:            Sarah Hansberry
 * Professor:       Shaw
 * Assignment #:    Lab 01
 */

namespace HelloThereConsole
{
    class HelloThere
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name? ");
            String name = Console.ReadLine();
            Console.WriteLine("Hello {0}!", name);
            Console.ReadKey();
        }
    }
}
