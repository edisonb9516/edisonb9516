using System;
/**
* 8/23/21
* CSC 253
* Brandon Edison
* This program is going to calculate kinetic energy based on user input. it will ask the user to enter mass and velocity
* and then pass those variables to a method and return the result. 
*/
namespace M1HW2_Edison
{
    class Program
    {
        static void Main(string[] args)
        {
            //call the greeting method first to greet the user
            Greeting();

            
            //create the variables to hold the mass and the velocity from the user and ask for the input
            Console.Write("Please enter the velocity (In meters per second) of the object: ");
            double velocity = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Please Enter the mass (In kilograms) of the object: ");
            double mass = double.Parse(Console.ReadLine());
            Console.WriteLine();


            //create a variable to hold the return value
            double total;

            //call the method to calculate the kinetic energy
            total = KineticEnergyCalculator(mass, velocity);

            //display the total for the kientic energy and a message
            Console.WriteLine( "\nThe amount of kinetic energy from the \nmeasurements you have entered is " + total.ToString("n") + " Joules");

        }

        //This method will greet the user and explain what they will need to do 
        static void Greeting() {
            Console.WriteLine("Greetings User! Welcome to the Kinetic Energy Calculator!");
            Console.WriteLine();
            Console.WriteLine("With this calculator, you will be asked to enter the mass(In kilograms) and the \n" +
                "velocity (in meters per second) so that it will calculate the kinetic energy.");
            Console.WriteLine();


        }

        //this method will accept the two numbers and return the kinetic energy total
        static double KineticEnergyCalculator(double weight, double speed) {

            return (.5) * weight * (speed * speed);
        
        }
    }
}
