using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello user, what are you in the mood for?");
            Console.WriteLine("Here are your options:");

            // populate dictionary holding all activities
            Dictionary<string, string> activities = new Dictionary<string, string>() {
                { "Action", "Stock Car Racing" },
                { "Chilling", "Hiking" },
                { "Danger", "Skydiving" },
                { "Good Food", "Taco Bell" }
            };

            // loop through keys of the dictionary and print to screen
            for (int i=0; i < activities.Count(); i++)
            {
                Console.WriteLine($"{i+1}) {activities.Keys.ToList()[i].ToString()}");
            }

            // read in user input and convert to int, then find it in the list of values
            string selection = activities.Keys.ToList()[Convert.ToInt32(Console.ReadLine()) - 1].ToString();
            string activity = activities[selection];

            // read in user input for number of passengers
            Console.WriteLine("So how many people are you bringing with you?");
            int numberOfPassengers = Convert.ToInt32(Console.ReadLine());

            // set default transportation to sneakers
            string transportation = "sneakers";
            
            // check if input is greater than zero
            if (numberOfPassengers > 0 && numberOfPassengers < 5)
            {
                transportation = "a sedan";
            }
            else if (numberOfPassengers > 4 && numberOfPassengers < 11)
            {
                transportation = "a Volkswagen bus";
            }
            else if(numberOfPassengers > 11)
            {
                transportation = "an airplane";
            }
            
            // output results
            Console.WriteLine($"Okay, if you're in the mood for {selection}, then you should go to {activity} and travel in {transportation}!");
            
            Console.WriteLine("Goodbye.");
        }
    }
}
