using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_NUM
{
    internal class Electricity
    {
        double oldNum, newNum, powerUsed = 0, payment = 0;
        int price = 0;

        public void electricityApplication()
        {
            Console.WriteLine("EDC Application System");
            Console.Write("Old Number ");
            oldNum = Convert.ToDouble(Console.ReadLine());
            Console.Write("New Number ");
            newNum = Convert.ToDouble(Console.ReadLine());

            if (oldNum < 0 || newNum < 0)
            {
                Console.WriteLine("Invalid data input\nYou can't input value as negative number in this system");
                Console.ReadKey();
                return;
            }

            if(oldNum > newNum)
            {
                Console.WriteLine("Invalid data input of old number");
                Console.ReadKey();
                return;
            }

            powerUsed = newNum - oldNum;

            if (powerUsed >= 0 && powerUsed < 11)
            {
                price = 300;
            } else if(powerUsed >= 11 && price < 51)
            {
                price = 400;
            } else if (powerUsed >= 51 && price <= 201)
            {
                price = 610;
            } else if (powerUsed > 201)
            {
                price = 740;
            }

            payment = price * powerUsed;
            Console.WriteLine($"Power used {powerUsed.ToString("##0.00")}kw/h");
            Console.WriteLine($"Payment {payment.ToString("##0.00")}KHR");
            Console.ReadKey();
        }
    }
}
