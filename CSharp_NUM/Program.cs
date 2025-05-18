using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_NUM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var salaryTax = new SalaryTaxAppSystem();
            //salaryTax.salaryApp();

            //var scoreManagement = new ScoreManagementSystem();
            //scoreManagement.scoreApp();

            var depositApp = new DepositApplicationSystem();
            depositApp.Run();


            Console.ReadKey();
        }
    }
}
