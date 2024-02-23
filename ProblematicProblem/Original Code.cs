//namespace ProblematicProblem
//{
//    internal class Original_Code
//    {
//        List instantiation of activities
//            public static List<string> activities = new List<string>()
//                { "Movies", "Paintball", "Bowling", "Laser Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };

//        Main Method
//            static void Main(string[] args)
//        {

//            Console.WriteLine("Hello, welcome to the random activity generator!");

//            bool generateActivityBool = false;
//            Console.Write("\nWould you like to generate a random activity? yes/no.\n");
//            do
//            {
//                int userAge;
//                // Ask to generate an activity
//                string userInputGenerateActivity = Console.ReadLine().Trim().ToLower();
//                bool generateActivityYes = userInputGenerateActivity == "yes" || userInputGenerateActivity == "y";

//                // Yes to generate activity
//                if (generateActivityYes)
//                {
//                    // Code to generate a random activity below
//                    Console.WriteLine("\nWe are going to need your information first!");
//                    bool userNameBool = true;
//                    do
//                    {
//                        // Get user NAME
//                        Console.Write("\nWhat is your name?\n");
//                        string userName = Console.ReadLine();
//                        if (userName != null && userName.All(char.IsLetter))
//                        {

//                            bool ageIsInteger = false;
//                            do
//                            {
//                                // Get user AGE
//                                Console.Write("\nWhat is your age?\n");
//                                ageIsInteger = int.TryParse(Console.ReadLine(), out userAge);

//                                if (ageIsInteger)
//                                {
//                                    Console.WriteLine("\nThat can be a fun age.");
//                                }
//                                else
//                                {
//                                    // Handle invalid input for AGE
//                                    Console.WriteLine("\nNot a valid input, try again.");
//                                }
//                            } while (!ageIsInteger);


//                            // VIEW activities?
//                            bool generateActivityIsBool = false;
//                            do
//                            {
//                                Console.Write("\nWould you like to see the current list of activities? Enter Yes or No.\n");

//                                // Get answer to view activities.
//                                string userInputSeeList = Console.ReadLine().Trim().ToLower();
//                                bool seeCurrentListYes = userInputSeeList == "yes" || userInputSeeList == "y";
//                                bool seeCurrentListNo = userInputSeeList == "no" || userInputSeeList == "n";

//                                // YES to VIEW LIST
//                                if (seeCurrentListYes)
//                                {
//                                    Console.WriteLine("\nSure thing, Here is the current list of activities!\n");

//                                    // Loop through current list.
//                                    foreach (string activity in activities)
//                                    {

//                                        Console.WriteLine($"{activity}, ");
//                                        Thread.Sleep(250);
//                                    }

//                                    // Add a new activity to list?
//                                    Console.Write("\nWould you like to add any activities before we generate one? yes/no:\n");
//                                    string userInputAddToListQuestion = Console.ReadLine().Trim().ToLower();
//                                    bool addToCurrentList = userInputAddToListQuestion == "yes" || userInputAddToListQuestion == "y";

//                                    // Yes to add a new activity
//                                    while (addToCurrentList)
//                                    {
//                                        // Get name of activity to add to the list
//                                        Console.Write("\nWhat would you like to add? ");
//                                        string UserAdditionToList = Console.ReadLine();
//                                        activities.Add(UserAdditionToList);

//                                        Console.WriteLine("\nHere is an updated list of all the activities.\n");

//                                        // Loop through the updated list
//                                        foreach (string activity in activities)
//                                        {
//                                            Console.WriteLine($"{activity}, ");
//                                            Thread.Sleep(250);
//                                        }

//                                        // Add additional items to list?
//                                        Console.WriteLine("\nWould you like to add more? yes/no:");
//                                        string userInputAddAnotherToListQuestion = Console.ReadLine().Trim().ToLower();
//                                        bool addAnotherToList = userInputAddAnotherToListQuestion == "yes" || userInputAddAnotherToListQuestion == "y";

//                                        // Yes to add additional item
//                                        if (addAnotherToList)
//                                        {
//                                            Console.Write("\nWhat would you like to add? ");
//                                            string UserSecondAdditionToList = Console.ReadLine();
//                                            activities.Add(UserSecondAdditionToList);
//                                        }

//                                        break;
//                                    }

//                                    if (userInputAddToListQuestion == "no" || userInputAddToListQuestion == "n")
//                                    {
//                                        generateActivityBool = true;

//                                    }
//                                    else
//                                    {
//                                        Console.WriteLine("Not a valid input. Please type yes or no.");
//                                    }
//                                }
//                                // NO to VIEW LIST
//                                else if (seeCurrentListNo)
//                                {
//                                    //user does not want to view list, just play now

//                                    Console.WriteLine("\nNo problem. Lets get started.");

//                                    // Connect to database
//                                    //Console.Write("Connecting to the database");
//                                    //for (int i = 0; i < 10; i++)
//                                    //{
//                                    //    Console.Write(". ");
//                                    //    Thread.Sleep(500);
//                                    //}

//                                    //// Choose random activity
//                                    //Console.Write("\nChoosing your random activity");
//                                    //for (int i = 0; i < 9; i++)
//                                    //{
//                                    //    Console.Write(". ");
//                                    //    Thread.Sleep(500);
//                                    //}

//                                    // Random activity generator-----------------------------------------------------------------------------
//                                    bool keepOrRedoBool = false;
//                                    do
//                                    {
//                                        RandomGenerator.RandomNumber();

//                                        // If user is UNDER 21
//                                        if (userAge < 21 && randomActivity == "Wine Tasting")
//                                        {
//                                            Console.WriteLine(
//                                                $"\nOh no! Looks like you are too young to do {randomActivity}");
//                                            Console.WriteLine("\nI'll pick something else!");
//                                            activities.Remove(randomActivity);

//                                            // Keep or Redo if user is UNDER 21
//                                            bool keepOrRedoUnder21Bool = false;
//                                            do
//                                            {
//                                                // New random after item removed from list.
//                                                int randomNumberUnder21 = rng.Next(activities.Count);
//                                                string randomActivityUnder21 = activities[randomNumberUnder21];

//                                                // Keep activity UNDER 21?
//                                                Console.Write(
//                                                    $"\nAh got it! {userName}, your random activity is: {randomActivityUnder21}! Do you want to play this activity? Enter Yes or No.");
//                                                var keepOrRedoUnder21 = Console.ReadLine().Trim().ToLower();

//                                                // Keep is Yes UNDER 21
//                                                if (keepOrRedoUnder21 == "yes" || keepOrRedoUnder21 == "y")
//                                                {
//                                                    Console.WriteLine(
//                                                        $"\nAwesome {userName}, you are now playing {randomActivityUnder21}!");
//                                                    keepOrRedoUnder21Bool = true;
//                                                    return;
//                                                }

//                                                // Keep is No UNDER 21
//                                                else if (keepOrRedoUnder21 == "no" || keepOrRedoUnder21 == "n")
//                                                {
//                                                    Console.WriteLine(
//                                                        $"\nOkay {userName}, Lets pick a new random activity!");

//                                                }
//                                                else
//                                                {
//                                                    // Handle invalid input for keep activity under 21
//                                                    Console.WriteLine("\nInvalid input. Please enter yes/no or y/n.");

//                                                }
//                                            } while (!keepOrRedoUnder21Bool);

//                                        }
//                                        else
//                                        {
//                                            bool keepOrRedoInvalidBool = false;
//                                            do
//                                            {
//                                                // Keep activity OVER 21?
//                                                Console.Write(
//                                                    $"\nOkay got it! {userName}, your random activity is: {randomActivity}! Do you want to play this activity? Enter Yes or No.");
//                                                var keepOrRedo = Console.ReadLine().Trim().ToLower();

//                                                // Keep activity is YES to OVER 21
//                                                if (keepOrRedo == "yes" || keepOrRedo == "y")
//                                                {
//                                                    Console.WriteLine(
//                                                        $"\nAwesome {userName}, you are now playing {randomActivity}!");
//                                                    keepOrRedoBool = true;
//                                                    return;
//                                                }

//                                                // Keep activity iS NO to OVER 21
//                                                else if (keepOrRedo == "no" || keepOrRedo == "n")
//                                                {
//                                                    Console.WriteLine($"\nOkay {userName}, Lets pick a new random activity!");
//                                                    keepOrRedoInvalidBool = true;
//                                                    keepOrRedoBool = false;
//                                                }
//                                                else
//                                                {
//                                                    // Handle invalid input for keep activity OVER 21
//                                                    Console.WriteLine("\nNot a valid input. This time please enter in a yes or a no.");
//                                                    keepOrRedoInvalidBool = false;
//                                                    keepOrRedoBool = true;
//                                                }
//                                            } while (!keepOrRedoInvalidBool);
//                                        }
//                                    } while (!keepOrRedoBool);


//                                }
//                                else
//                                {
//                                    // Handle invalid input for viewing current list of activities
//                                    Console.WriteLine("\nInvalid input. Please enter yes/no or y/n.\n");
//                                    generateActivityBool = true;
//                                }
//                            } while (generateActivityIsBool);
//                        }
//                        else
//                        {
//                            // Handle invalid input for NAME
//                            Console.WriteLine("\nNot a valid input. Please type your name without numbers or characters.");
//                            userNameBool = false;
//                        }
//                    } while (!userNameBool);
//                }
//                else if (userInputGenerateActivity == "no" || userInputGenerateActivity == "n")
//                {
//                    //user does not want to generate activity
//                    Console.WriteLine("No worries, maybe next time we can have some fun playing games.");
//                    return;
//                }
//                else
//                {
//                    // Handle invalid input to generate activity question
//                    Console.WriteLine("\nInvalid input. Please enter yes/no or y/n.");
//                    generateActivityBool = false;
//                }
//            } while (!generateActivityBool);

//        }
//    }
//}
//}
//}
