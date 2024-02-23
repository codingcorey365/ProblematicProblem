using ProblematicProblem.TestClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ProblematicProblem
{
    public class Refactor
    {
        private Activities activities = new Activities();

        // List instantiation of activityList
        private List<string> activityList;

        public Refactor()
        {
            activityList = activities.GetActivityList();

        }


        public void GetActivity()
        {

            UserInput user = new UserInput();
            bool generateActivityBool = true;
            Console.WriteLine("Hello, welcome to the random activity generator!");

            while (generateActivityBool)
            {

                if (user.AskYNQuestion("\nWould you like to generate a random activity? yes/no.\n"))
                {
                    Console.WriteLine("\nWe are going to need your information first!");
                    string userName = user.GetName();
                    int userAge = user.GetAge();

                    if (userAge < 21)
                    {
                        // remove restricted activites
                        activityList.Remove("Wine Tasting");
                        activityList.Remove("Cigar Smoking");
                    }


                    if (user.AskYNQuestion("\nWould you like to see the current list of activityList? Enter Yes or No.\n"))
                    {
                        Console.WriteLine("\nSure thing, Here is the current list of activityList!\n");

                        // Loop through current list.
                        foreach (string activity in activityList)
                        {
                            Console.WriteLine($"{activity}, ");
                            Thread.Sleep(250);
                        }

                        bool addActivity;
                        do
                        {
                            addActivity = user.AskYNQuestion("\nWould you like to add another activity before we generate one? yes/no:\n");
                            if (addActivity)
                            {
                                // Get name of activity to add to the list
                                Console.Write("\nWhat would you like to add? ");
                                string userAdditionToList = Console.ReadLine();
                                activityList.Add(userAdditionToList);

                                Console.WriteLine("\nHere is an updated list of all the activityList.\n");

                                // Loop through the updated list
                                foreach (string activity in activityList)
                                {
                                    Console.WriteLine($"{activity}, ");
                                    Thread.Sleep(250);
                                }
                            }
                        } while (addActivity);
                    }

                    Console.WriteLine("\nNo problem. Lets get started.");

                    // Random activity generator-----------------------------------------------------------------------------
                    bool keepOrRedoBool = false;
                    do
                    {
                        var test = RandomGenerator.RandomNumber(activityList);

                        // If user is UNDER 21
                        if (userAge < 21 && test == "Wine Tasting")
                        {
                            Console.WriteLine($"\nOh no! Looks like you are too young to do {test}");
                            Console.WriteLine("\nI'll pick something else!");
                            activityList.Remove(test);

                            // Keep or Redo if user is UNDER 21
                            bool keepOrRedoUnder21Bool = false;
                            do
                            {
                                // New random after item removed from list.


                                //int randomNumberUnder21 = activityList.Count;
                                //string randomActivityUnder21 = activityList[randomNumberUnder21];
                                string randomActivityUnder21 = RandomGenerator.RandomNumber(activityList);


                                if (user.AskYNQuestion($"\nAh got it! {userName}, your random activity is: {randomActivityUnder21}! Do you want to play this activity? Enter Yes or No."))
                                {
                                    Console.WriteLine($"\nAwesome {userName}, you are now playing {randomActivityUnder21}!");
                                    keepOrRedoUnder21Bool = true;
                                    return;
                                }
                                else
                                {
                                    Console.WriteLine($"\nOkay {userName}, Lets pick a new random activity!");

                                }

                            } while (!keepOrRedoUnder21Bool);
                        }
                        else
                        {
                            bool keepOrRedoInvalidBool = false;
                            do
                            {
                                // Keep activity OVER 21?

                                if (user.AskYNQuestion($"\nOkay got it! {userName}, your random activity is: {test}! Do you want to play this activity? Enter Yes or No."))
                                {
                                    Console.WriteLine($"\nAwesome {userName}, you are now playing {test}!");
                                    keepOrRedoBool = true;
                                    return;
                                }
                                else
                                {
                                    Console.WriteLine($"\nOkay {userName}, Lets pick a new random activity!");
                                    keepOrRedoInvalidBool = true;
                                    keepOrRedoBool = false;
                                }

                            } while (!keepOrRedoInvalidBool);
                        }
                    } while (!keepOrRedoBool);
                }
                else
                {
                    Console.WriteLine("No worries, maybe next time we can have some fun playing games.");
                    generateActivityBool = false;
                }

            }

        }
    }
}