using System;

namespace CSharp_NUM
{
    internal class DepositApplicationSystem
    {
        private double deposit = 0, interest = 0, interestRate = 0, monthlyInterest = 0;
        private int duration = 0;

        public void Run()
        {
            Console.WriteLine("Deposit Application System");
            Console.Write("Deposit: ");
            if (!double.TryParse(Console.ReadLine(), out deposit))
            {
                Console.WriteLine("Invalid deposit amount.");
                return;
            }

            Console.WriteLine("Currency:\n1. Riel\n2. Dollar");
            if (!int.TryParse(Console.ReadLine(), out int currency) || currency < 1 || currency > 2)
            {
                Console.WriteLine("Invalid currency option.");
                return;
            }

            Console.WriteLine("Duration:\n1. 1 month\n2. 2 months\n3. 3 months\n4. 6 months\n5. 12 months");
            if (!int.TryParse(Console.ReadLine(), out int durationOption) || durationOption < 1 || durationOption > 5)
            {
                Console.WriteLine("Invalid duration option.");
                return;
            }

            interestRate = GetInterestRate(currency, durationOption);
            duration = GetDurationInMonths(durationOption);

            double rawInterest = deposit * interestRate;
            interest = rawInterest - (rawInterest * 0.06);
            double total = deposit + interest;
            monthlyInterest = interest / duration;

            Console.WriteLine($"\nInterest: {interest:0.00} {(currency == 1 ? "R" : "$")}");
            Console.WriteLine($"Total Money: {total:0.00} {(currency == 1 ? "R" : "$")}");
            Console.WriteLine($"Monthly Interest: {monthlyInterest:0.00} {(currency == 1 ? "R" : "$")}");
        }

        private static double GetInterestRate(int currency, int durationOption)
        {
            if (currency == 1)
            {
                switch (durationOption)
                {
                    case 1: return 0.035 / 12;
                    case 2: return 0.04 / 6;
                    case 3: return 0.045 / 4;
                    case 4: return 0.0675 / 2;
                    case 5: return 0.085;
                }
            }
            else if (currency == 2)
            {
                switch (durationOption)
                {
                    case 1: return 0.03 / 12;
                    case 2: return 0.035 / 6;
                    case 3: return 0.04 / 4;
                    case 4: return 0.055 / 2;
                    case 5: return 0.08;
                }
            }

            return 0;
        }
        private static int GetDurationInMonths(int option)
        {
            switch (option)
            {
                case 1: return 1;
                case 2: return 2;
                case 3: return 3;
                case 4: return 6;
                case 5: return 12;
                default: return 0;
            }
        }
    }
}
