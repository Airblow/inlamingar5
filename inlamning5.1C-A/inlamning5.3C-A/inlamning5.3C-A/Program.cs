using System;
namespace inlamning5._3CA
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] questions = new string[4];
            questions[0] = "Vad är världens mest folkrika land?";
            questions[1] = "Vad heter världens största land till ytan?";
            questions[2] = "Vilken av världens kontinenter är störst till ytan?";
            questions[3] = "Vilken kontinent är Sverige del av?";

            string[] questionAnswers = new string[4];
            questionAnswers[0] = "indien";
            questionAnswers[1] = "ryssland";
            questionAnswers[2] = "asien";
            questionAnswers[3] = "europa";

            bool shutdown = false;
            while (shutdown != true)
            {
                Console.WriteLine("Välj en utav frågorna nedan som du vill svara på.");
                Console.WriteLine();

                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine($"Fråga {i + 1}: {questions[i]}");

                }

                int userQuestionChoice = 0;
                bool answerLoop = true;
                while (answerLoop != false)
                {
                    try
                    {
                        userQuestionChoice = int.Parse(Console.ReadLine());

                        if (userQuestionChoice <= 4 && userQuestionChoice > 0)
                        {
                            answerLoop = false;

                        }
                        else
                        {
                            Console.WriteLine("Ogiltligt nummer. Försök igen.");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Ogiltligt tecken. Försök igen.");

                    }

                }

                Console.WriteLine();
                Console.WriteLine($"Du valde att svara på frågan:");
                Console.WriteLine(questions[userQuestionChoice - 1]);
                Console.WriteLine("vad är ditt svar?");

                bool questionAnswerLoop = true;
                while (questionAnswerLoop != false)
                {

                    string userQuestionAnswer = Console.ReadLine().ToLower();

                    if (userQuestionAnswer == questionAnswers[userQuestionChoice - 1])
                    {
                        Console.WriteLine();
                        Console.WriteLine("Grattis, du svarade rätt!");
                        questionAnswerLoop = false;
                    }
                    else
                    {
                        Console.WriteLine("Svaret är tyvärr fel. Försök igen");
                    }

                }

                Console.WriteLine("Vill du köra igen? tryck 'j' för ja och 'n' för nej.");

                bool shutdownLoop = true;
                while (shutdownLoop != false)
                {
                    string shutdownRequest = Console.ReadLine().ToLower();
                    if (shutdownRequest == "n")
                    {
                        shutdown = true;
                        shutdownLoop = false;
                        Console.WriteLine("Avslutar programmet. Tack för att du spelade.");
                    }
                    else if(shutdownRequest == "j")
                    {
                        shutdownLoop = false;

                    }
                    else
                    {
                        Console.WriteLine("Ogiltligt svar, försök igen.");
                    }
                }

            }

            Console.ReadKey();
        }

    }

}
