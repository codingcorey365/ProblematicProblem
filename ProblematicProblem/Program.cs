using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Threading;

namespace ProblematicProblem
{
    public class Program
    {
        // Variable Declarations
        public static Random rng;
        static bool count1 = true;

        // List instantiation of activities
        private static List<string> activities = new List<string>()
            { "Movies", "Paintball", "Bowling", "Laser Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };

        // Main Method
        static void Main(string[] args)
        {
            // Ask to generate an activity
            Console.Write("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ");
            string userInputGenerateActivity = Console.ReadLine().Trim().ToLower();
            bool generateActivityYes = userInputGenerateActivity == "yes" || userInputGenerateActivity == "y";

            // Yes to generate activity
            if (generateActivityYes)
            {
                // Code to generate a random activity below
                
                // Get username
                Console.Write("We are going to need your information first! What is your name? ");
                string userName = Console.ReadLine();
                
                // Get user age
                Console.Write("What is your age? ");
                var AgeIsInteger = int.TryParse(Console.ReadLine(), out int userAge);

                // View activities?
                Console.Write("Would you like to see the current list of activities? Enter Yes or No. ");
                
                // Get answer to view activities.
                string userInputSeeList = Console.ReadLine().Trim().ToLower();
                bool seeCurrentList = userInputSeeList == "yes" || userInputSeeList == "y";
                
                // Yes to view list of activies
                if (seeCurrentList)
                {
                    foreach (string activity in activities)
                    {
                        Console.Write($"{activity} ");
                        Thread.Sleep(250);
                    }

                    Console.Write("Would you like to add any activities before we generate one? yes/no: ");
                    var addToListIsBool = bool.TryParse(Console.ReadLine(), out bool addToListYesOrNo);

                    while (addToListYesOrNo)
                    {
                        Console.Write("What would you like to add? ");
                        string UserAdditionToList = Console.ReadLine();
                        activities.Add(UserAdditionToList);

                        Console.WriteLine("Here is an updated list of all the activities.");

                        foreach (string activity in activities)
                        {
                            Console.Write($"{activity} ");
                            Thread.Sleep(250);
                        }

                        Console.WriteLine("Would you like to add more? yes/no: ");
                        var addToListAgainIsBool = bool.TryParse(Console.ReadLine(), out bool addToListAgainYesOrNo);
                        if (addToListAgainYesOrNo)
                        {
                            Console.Write("What would you like to add? ");
                            string UserSecondAdditionToList = Console.ReadLine();
                            activities.Add(UserSecondAdditionToList);
                        }

                        break;
                    }
                }
                // User wants to play now
                else if (userInputGenerateActivity == "no" || userInputGenerateActivity == "n")
                {
                    //user does not want to view list, just play now
                    Console.WriteLine("No worries, maybe next time we can have some fun playing games.");
                }
                else
                {
                    // Handle invalid input
                    Console.WriteLine("Invalid input. Please enter yes/no or y/n.");
                }
                else
                {
                    Console.WriteLine("No problem. Lets get started.");

                    while (activityIsBool)
                    {
                        Console.Write("Connecting to the database");
                        for (int i = 0; i < 10; i++)
                        {
                            Console.Write(". ");
                            Thread.Sleep(500);
                        }
                        Console.Write("Choosing your random activity");
                        for (int i = 0; i < 9; i++)
                        {
                            Console.Write(". ");
                            Thread.Sleep(500);
                        }

                        int randomNumber = rng.Next(activities.Count);
                        string randomActivity = activities[randomNumber];
                        if (userAge > 21 && randomActivity == "Wine Tasting")
                        {
                            Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
                            Console.WriteLine("I'll pick something else!");
                            activities.Remove(randomActivity);
                            //string randomNumber = rng.Next(activities.Count);
                            //string randomActivity = activities[randomNumber];
                        }
                        else
                        {
                            Console.Write($"Ah got it! {userName}, your random activity is: {randomActivity}! Is this ok or do you want to grab another activity? Keep/Redo: ");
                            var keepOrRedoIsBool = bool.TryParse(Console.ReadLine(), out bool keepOrRedoYesOrNo);
                        }
                    }
                }
            }
            // No to generate activity
            else if (userInputGenerateActivity == "no" || userInputGenerateActivity == "n")
            {
                //user does not want to generate activity
                Console.WriteLine("No worries, maybe next time we can have some fun playing games.");
            }
            else
            {
                // Handle invalid input
                Console.WriteLine("Invalid input. Please enter yes/no or y/n.");
            }

        }
    }
}