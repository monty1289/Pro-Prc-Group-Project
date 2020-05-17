using System;

namespace Dr_Randy_Savage_AI
{
    class Program
    {
        static void Main(string[] args)
        {
            char play = 'y';
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
            question[6] = "where is the pain";

            newquestions[0] = "and your middle name?";
            newquestions[1] = "why?";


            Console.WriteLine("Welcome to the Dr Randy Savage AI question Program");
            Console.WriteLine("press enter to contine");
            Console.ReadLine();

            while (play == 'y' || play == 'Y')
            {
                for (int i = 0; i < question.Length; i++)
                {
                    Console.WriteLine(question[0]);
                    temp = Console.ReadLine();
                    answers[0] = temp;



                    Console.WriteLine(question[1]);
                    temp = Console.ReadLine();
                    answers[1] = temp;

                    if(answers[1] == "yes")
                    {
                        Console.WriteLine(newquestions[1]);
                        temp = Console.ReadLine();
                        newanswers[1] = temp;
                    }
                    else
                    {

                    }

                }

                for (int i = 0; i < question.Length; i++)
                {
                    Console.WriteLine(question[2]);
                    temp = Console.ReadLine();
                    answers[2] = temp;

                }


            }
            Console.ReadLine();
        
        }
    }
}
