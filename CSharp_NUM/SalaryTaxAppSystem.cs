using System;

namespace CSharp_NUM
{
    internal class SalaryTaxAppSystem
    {
        double grossSalary = 0, netSalary = 0, tax = 0;

        public void salaryApp()
        {
            Console.WriteLine("Salary Tax Application System");
            Console.Write("Gross Salary: ");
            grossSalary = Convert.ToDouble(Console.ReadLine());

            if (grossSalary < 0)
            {
                Console.WriteLine("Invalid input. Gross salary cannot be negative.");
                Console.ReadKey();
                return;
            }

            if (grossSalary <= 1500000)
            {
                tax = 0;
            }
            else if (grossSalary <= 2000000)
            {
                tax = (grossSalary * 0.05) - 75000;
            }
            else if (grossSalary <= 8500000)
            {
                tax = (grossSalary * 0.10) - 172500;
            }
            else if (grossSalary <= 12500000)
            {
                tax = (grossSalary * 0.15) - 600000;
            }
            else
            {
                tax = (grossSalary * 0.20) - 1225000;
            }

            netSalary = grossSalary - tax;

            Console.WriteLine($"Gross-Salary: {grossSalary:N2}R");
            Console.WriteLine($"Net-Salary: {netSalary:N2}R");
            Console.WriteLine($"Tax: {tax:N2}R");
            Console.ReadKey();
        }
    }
}
