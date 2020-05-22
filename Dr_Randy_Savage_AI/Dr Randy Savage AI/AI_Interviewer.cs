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
        public static void Makequestions(string[] questions, string[] answers, string[] newQuestions, string[] newAnswers)
        {
             
            for (int i = 0; i < questions.Length; i++)
            {
                if (answers[i] != newAnswers[i])
                {
                    string tempQ = questions[i];
                    string tempA = answers[i];
                    string tempNA = newAnswers[i];
                    newQuestions[i] = ($"When I asked you {tempQ} you replied {tempA}, but when I asked you this question again you contradicted yourself by answering {tempNA}. Why do you lie?");
                }
            }
        }
        public static void Endless()
        {
            char play = 'y';
            
            while (play == 'y')
            {
                Interview();
            }

            Console.ReadLine();
        }

        public static void Interview()
        {
            string temp;
            int count;

            string[] questions = new string[20];
            string[] answers = new string[20];
            string[] newquestions = new string[20];
            string[] newAnswers = new string[20];

            //questions for interview
            questions[0] = "what is your full name?";
            questions[1] = "Are you an active person?";
            questions[2] = "Do you smoke";
            questions[3] = "Do you have a strong punch";
            questions[4] = "How many badgers could you fight?";
            questions[5] = "How far can you throw a toddler or toddler sized object?";
            questions[6] = "How many hits to the head have you had?";
            questions[7] = "what car do u drive?";
            questions[8] = "when did you lose your verginity?";
            questions[9] = "Are you experiencing pain?";
            questions[10] = "How many Bones have you broken?";
            questions[11] = "how much MMA fighting have you done?";
            questions[12] = "how much protein do you consume?";
            questions[13] = "do you take steroids?";
            questions[14] = "which spider man do you prefer?";
            questions[15] = "what type of car do you drive?";
            questions[16] = "when did you lose your virginity? ";
            questions[17] = "what religion do you follow?";
            questions[18] = "what type of Gym do you go too?";
            questions[19] = "what's your favorite drug?";


            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]);
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
                Console.WriteLine(questions[i]);
                temp = Console.ReadLine();
                answers[i] = temp;

            }
            Makequestions(questions, answers, newquestions, newAnswers);
            for (int i = 0; i < newquestions.Length; i++)
            {
                Console.WriteLine(newquestions[i]);
                temp = Console.ReadLine();
                newAnswers[i] = temp;

            }
        }

        static void Main()
        {
            Console.WriteLine("Welcome to the Dr Randy Savage AI questions Program");
            Console.WriteLine("press enter to contine");
            Console.ReadLine();
            Endless();
        }
    }
}
