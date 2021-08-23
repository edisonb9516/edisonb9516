using System;
/**
* 8/23/21
* CSC 253
* Brandon Edison
* This program is going to convert the celsius temperatures to fahrenheit. This will list 0-20 degrees celsius. 
* THis will also list then in a table type format. 
*/
namespace M1HW1_EdisonBrandon
{
    class Program
    {
        static void Main(string[] args)
        {
            //greet the user 
            Console.WriteLine("Welcome to Celsius to Fahrenheit! \n" +
                "This program will list in a table the conversion of Celsius to Fahrenheit from 0 degrees to 20.");

            //Create a table header
            Console.WriteLine();
            Console.WriteLine("Celsius      Fahrenheit");
            Console.WriteLine("------------------------------------");

            //create a for loop to allow the table to be created and the conversion to start
            for (int counter = 0; counter <= 20; counter++){

                //display the celsius first
                Console.WriteLine("     ");
                Console.Write(counter.ToString("0° C"));
                Console.Write("             ");

                //convert the counter degree to fahrenheit
                double fahrenheit = ((1.8) * counter) + 32;
                Console.WriteLine(fahrenheit.ToString(".0° F"));


            }
         
        }
    }
}
