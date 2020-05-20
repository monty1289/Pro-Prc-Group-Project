/*AI Doctor
 * Monty, Sam, Joseph, Tyler
 * This program will ask the user questions continuously forever. The questions will repeat and evolve based on previous answers.
 * The program will try to find inconsistencies in the users answers.
 */
using System;

namespace Dr_Randy_Savage_AI
{
    class AI_Interviewer
    {
        public static void Endless()
        {
            char play = 'y';
            
            while (play == 'y' || play == 'Y')
            {
                Interview();
            }

            Console.ReadLine();
        }

        public static void Interview()
        {
            string temp;
            int count;

            string[] question = new string[10];
            string[] answers = new string[10];
            string[] newquestions = new string[10];
            string[] newanswers = new string[10];

            question[0] = "what is your full name?";
            question[1] = "Are you an active person?";
            question[2] = "Do you smoke";
            question[3] = "Do you have a strong punch";
            question[4] = "How many badgers could you fight?";
            question[5] = "How far can you throw a toddler or toddler sized object?";
            question[6] = "How many hits to the head have you had?";

            for (int i = 0; i < question.Length; i++)
            {
                Console.WriteLine(question[i]);
                temp = Console.ReadLine();
                answers[i] = temp;

                /*add content to newquestions array
                if (answers[1] == "yes")
                {
                    Console.WriteLine(newquestions[1]);
                    temp = Console.ReadLine();
                    newanswers[1] = temp;
                }
                else
                {

                }
                */
            }

            for (int i = 0; i < newquestions.Length; i++)
            {
                Console.WriteLine(question[2]);
                temp = Console.ReadLine();
                answers[2] = temp;

            }
        }

        static void Main()
        {
            Console.WriteLine("Welcome to the Dr Randy Savage AI question Program");
            Console.WriteLine("press enter to contine");
            Console.ReadLine();
            Endless();
        }
    }
}
