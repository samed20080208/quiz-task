using System;

class QuizProgram
{
    static void Main()
    {
        string[] questions = {
            " 1. bakinin paytaxti haradir?",
            " 2. xezer nedir?",
            " 3. step it nin bas filiali haradir?",
            " 4. cpu nun acmasi nedir?",
            " 5. c# in babasi kimdir?",
            " 6. cos60 necedir?",
            " 7. oppenheimer haralidir?",
            " 8. п nin qiymeti necedir?",
            " 9. cavid muellimin nece yasi var?",
            " 10. en yuksek IQ ya sahib insan kimdir?"
        };

        string[][] options = {
            new string[] { "A) azerbaycan", "B) novxani", "C) baki", "D) tarqovu" },
            new string[] { "A) deniz", "B) gol", "C) cay", "D) hovuz" },
            new string[] { "A) azerbaycan", "B) amerika", "C) ukrayna", "D) ay" },
            new string[] { "A) central processing unit", "B) computer personal unit", "C) central processor unit", "D) central process unit" },
            new string[] { "A) java", "B) c++", "C) c", "D) python" },
            new string[] { "A) 1/3", "B) 1/4", "C) 1/2", "D) 1" },
            new string[] { "A) alman", "B) amerikan", "C) ingilis", "D) fransiz" },
            new string[] { "A) 3.14", "B) 2.71", "C) 1.61", "D) 4.29" },
            new string[] { "A) 26", "B) 27", "C) 28", "D) 24" },
            new string[] { "A) albert einstein", "B) stephen hawking", "C) leonardo da vinci", "D) marilyn vos savant" }
        };

        string[] correctAnswers = { "A", "B", "C", "A", "C", "C", "B", "A", "A", "D" };

        int score = 0;
        int selectedOptionIndex = 0;

        for (int i = 0; i < questions.Length; i++)
        {
            Console.Clear();
            Console.WriteLine(questions[i]);

            for (int j = 0; j < options[i].Length; j++)
            {
                if (j == selectedOptionIndex)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.WriteLine(options[i][j]);

                Console.ResetColor();
            }

            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey();

                if (key.Key == ConsoleKey.UpArrow && selectedOptionIndex > 0)
                {
                    selectedOptionIndex--;
                }
                else if (key.Key == ConsoleKey.DownArrow && selectedOptionIndex < options[i].Length - 1)
                {
                    selectedOptionIndex++;
                }

                Console.Clear();
                Console.WriteLine(questions[i]);

                for (int j = 0; j < options[i].Length; j++)
                {
                    if (j == selectedOptionIndex)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.WriteLine(options[i][j]);

                    Console.ResetColor();
                }

            } while (key.Key != ConsoleKey.Enter);

            if (options[i][selectedOptionIndex][0].ToString().ToUpper() == correctAnswers[i])
            {
                score++;
            }
        }

        Console.Clear();
        Console.WriteLine($"Quiz tamamlandı! Toplam skorunuz: {score}/{questions.Length}");
        Console.ReadLine();
    }
}
