/*
  Singleton Design Pattern
    Ensures that a class has only one instance
    Provides a global point of acccess to that instance
    Useful when exactly one object is needed to coordinate actions across the system
*/

/*
  Prototype Design Pattern
    (Abstract parent, Children inherit)
    Copy existing objects without making your code dependent on their classes.
    Declares a common interface for all objects that support cloning.
    Interface
      Lets you clone an object without coupling your code to the class of that object (you don't have to have a dependency)
      Usually an interface has a single clone method
    Prototype
      An object that supports cloning
*/

/*
  Proxy Design Pattern
    Provides a substitute or placeholder for another object
    Controls access to the original object
    Allows you to perform something before or after the request gets through to the original object
     Example: Credit card is a proxy to your bank account. 
*/

using System;

class Program
{
    public static void Main(string[] args)
    {
        // Singlton Example

        Person person0 = Person.Instance;

        Console.WriteLine("Data type of person0: " + person0);

        Person person1 = Person.Instance;

        Console.WriteLine("Data type of person1: " + person1);

        if (person0 == person1)
        {
            Console.WriteLine("Equal");
        }

        Console.WriteLine("****************************************");

        // Prototype example

        StoreBranch newYorkBranch = new StoreBranch();

        Console.WriteLine(newYorkBranch.Location); // Empty string as location by default doesn't have a value

        StoreBranch newfoundlandBranch = new StoreBranch("Newfoundland");

        Console.WriteLine(newfoundlandBranch.Location);

        StoreBranch labradorBranch = newfoundlandBranch.Clone();

        Console.WriteLine("Clone of the newfoundlandBranch: " + labradorBranch.Location);

        labradorBranch.Location = "Labrador";

        Console.WriteLine(labradorBranch.Location);

      Console.WriteLine("****************************************");
    }
}

