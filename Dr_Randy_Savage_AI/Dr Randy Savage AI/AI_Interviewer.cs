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
        public static void MakeQuestions()
        {

        }
        public static void Endless()
        {
            char play = 'y';
            
            while (play == 'y')
            {
                Interview();
                MakeQuestions();
            }

            Console.ReadLine();
        }

        public static void Interview()
        {
            string temp;
            int count;

            string[] question = new string[20];
            string[] answers = new string[20];
            string[] newquestions = new string[20];
            string[] newanswers = new string[20];

            //questions for interview
            question[0] = "what is your full name?";
            question[1] = "Are you an active person?";
            question[2] = "Do you smoke";
            question[3] = "Do you have a strong punch";
            question[4] = "How many badgers could you fight?";
            question[5] = "How far can you throw a toddler or toddler sized object?";
            question[6] = "How many hits to the head have you had?";
            question[7] = "what car do u drive?";
            question[8] = "when did you lose your verginity?";
            question[9] = "Are you experiencing pain?";
            question[10] = "How many Bones have you broken?";
            question[11] = "how much MMA fighting have you done?";
            question[12] = "how much protein do you consume?";
            question[13] = "do you take steroids?";
            question[14] = "which spider man do you prefer?";
            question[15] = "what type of car do you drive?";
            question[16] = "when did you lose your virginity? ";
            question[17] = "what religion do you follow?";
            question[18] = "what type of Gym do you go too?";
            question[19] = "what's your favorite drug?";


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
