using System;
using System.Linq;

namespace ProblematicProblem
{
    internal class UserInput
    {
        public int GetAge()
        {
            int userAge;
            bool ageIsInteger = false;
            do
            {
                // Get user AGE
                Console.Write("\nWhat is your age?\n");
                ageIsInteger = int.TryParse(Console.ReadLine(), out userAge);

                if (ageIsInteger)
                {
                    Console.WriteLine("\nThat can be a fun age.");
                }
                else
                {
                    // Handle invalid input for AGE
                    Console.WriteLine("\nNot a valid input, try again.");
                }
            } while (!ageIsInteger);

            return userAge;
        }


        public string GetName()
        {
            bool userNameBool = false;
            string userName;
            do
            {
                // Get user NAME
                Console.Write("\nWhat is your name?\n");
                userName = Console.ReadLine();
                if (userName != null && userName.All(char.IsLetter))
                {
                    userNameBool = true;
                }
                else
                {
                    // Handle invalid input for NAME
                    Console.WriteLine("\nNot a valid input. Please type your name without numbers or characters.");
                    userNameBool = false;
                }
            } while (!userNameBool);


            return userName;
        }


        public bool AskYNQuestionTwo(string question)
        {
            bool methodBoolResult = true;

            while (true)
            {
                Console.Write(question);
                string answer = Console.ReadLine().Trim().ToLower();

                switch (answer)
                {
                    case "yes":
                    case "y":
                        return true;
                        return methodBoolResult;

                    case "no":
                    case "n":
                        return false;

                    default:
                        Console.WriteLine("-----------------------");
                        Console.WriteLine("Please enter yes or no.");
                        Console.WriteLine("-----------------------");
                        break;
                }
            }
        }

        public bool AskYNQuestion(string question)
        {
            bool continueLoop = true;
            bool methodBoolResult = true;
            do
            {
                Console.Write(question);
                string answer = Console.ReadLine().Trim().ToLower();
            
                if (answer == "yes" || answer == "y")
                {
                    continueLoop = false;
                }
                else if (answer == "no" || answer == "n")
                {
                    continueLoop = false;
                    methodBoolResult = false;
                }
                else
                {
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("Please enter yes or no.");
                    Console.Write("-----------------------");
                }
            } while (continueLoop);

            return methodBoolResult;
        }

    }
}