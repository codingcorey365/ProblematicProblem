using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public bool AskYNQuestion(string question)
        {
            Console.Write(question);
            string answer = Console.ReadLine().Trim().ToLower();
            return answer == "yes" || answer == "y";
        }

    }
}