using System;

namespace POLYMORPHISM
{
    // Create an interface called IQuittable
    interface IQuittable
    {
        // Define a void method called Quit()
        void Quit();
    }

    // Create a class called Employee and inherit from the IQuittable interface
    class Employee : IQuittable
    {
        // Implement the Quit() method from the interface
        public void Quit()
        {
            Console.WriteLine("Employee quits the job.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Use polymorphism to create an object of type IQuittable and instantiate it with an Employee object
            IQuittable quittable = new Employee();

            // Call the Quit() method on the object, which invokes the Quit() method implemented in the Employee class
            quittable.Quit();

            // Wait for user input before closing the console window
            Console.ReadLine(); 
        }
    }
    
}
