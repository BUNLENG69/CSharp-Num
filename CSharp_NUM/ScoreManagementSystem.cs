using System;

namespace CSharp_NUM
{
    internal class ScoreManagementSystem
    {
        int html = 0, java = 0, csharp = 0, php = 0, sqlServer = 0;
        int totalScore = 0;
        double average = 0;
        string grade = "";

        public void scoreApp()
        {
            Console.WriteLine("Score Management System");

            Console.Write("Enter HTML score: ");
            html = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Java score: ");
            java = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter C# score: ");
            csharp = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter PHP score: ");
            php = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter SQL Server score: ");
            sqlServer = Convert.ToInt32(Console.ReadLine());

            totalScore = html + java + csharp + php + sqlServer;
            average = totalScore / 5.0;

            Console.WriteLine($"\nHTML: {html}");
            Console.WriteLine($"Java: {java}");
            Console.WriteLine($"C#: {csharp}");
            Console.WriteLine($"PHP: {php}");
            Console.WriteLine($"SQL Server: {sqlServer}");

            Console.WriteLine($"Total Score: {totalScore}");
            Console.WriteLine($"Average Score: {average}%");

            if (average < 50)
            {
                grade = "F";
            }
            else if (average < 60)
            {
                grade = "E";
            }
            else if (average < 70)
            {
                grade = "D";
            }
            else if (average < 80)
            {
                grade = "C";
            }
            else if (average < 90)
            {
                grade = "B";
            }
            else if (average <= 100)
            {
                grade = "A";
            }
            else
            {
                grade = "Invalid";
            }

            Console.WriteLine($"Grade: {grade}");
            Console.ReadKey();
        }
    }
}
