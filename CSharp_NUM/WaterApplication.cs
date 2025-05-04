using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_NUM
{
    internal class WaterApplication
    {
        double oldNumber = 0, newNumber = 0, usedNumber = 0, payment = 0;

        public void waterApplicationSystem()
        {
            Console.WriteLine("Leng Application System");
            Console.Write("Old Number ");
            oldNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("New Number ");
            newNumber = Convert.ToDouble(Console.ReadLine());

            if (oldNumber < 0 || newNumber < 0)
            {
                Console.WriteLine("Invalid data input\nYou can't input value as negative number in this system");
                Console.ReadKey();
                return;
            }

            if (oldNumber > newNumber)
            {
                Console.WriteLine("Invalid data input of old number");
                Console.ReadKey();
                return;
            }

            usedNumber = newNumber - oldNumber;

            //option 1

            if (usedNumber <= 7)
            {
                payment = 400 * usedNumber;
            }
            else if (usedNumber <= 22)
            {
                payment = (400 * 7) + (720 * (usedNumber - 7));
            }
            else if (usedNumber <= 47)
            {
                payment = (400 * 7) + (720 * 15) + (960 * (usedNumber - 22));
            }
            else if (usedNumber <= 97)
            {
                payment = (400 * 7) + (720 * 15) + (960 * 25) + (1250 * (usedNumber - 47));
            }
            else if (usedNumber <= 197)
            {
                payment = (400 * 7) + (720 * 15) + (960 * 25) + (1250 * 50) + (1900 * (usedNumber - 97));
            }
            else
            {
                payment = (400 * 7) + (720 * 15) + (960 * 25) + (1250 * 50) + (1900 * 100) + (2200 * (usedNumber - 197));
            }


            //option 2

            //double remaining = usedNumber;
            //payment = 0;

            //if (remaining > 0)
            //{
            //    double tier = Math.Min(remaining, 7);
            //    payment += tier * 400;
            //    remaining -= tier;
            //}
            //if (remaining > 0)
            //{
            //    double tier = Math.Min(remaining, 15); // 8–22
            //    payment += tier * 720;
            //    remaining -= tier;
            //}
            //if (remaining > 0)
            //{
            //    double tier = Math.Min(remaining, 25); // 23–47
            //    payment += tier * 960;
            //    remaining -= tier;
            //}
            //if (remaining > 0)
            //{
            //    double tier = Math.Min(remaining, 50); // 48–97
            //    payment += tier * 1250;
            //    remaining -= tier;
            //}
            //if (remaining > 0)
            //{
            //    double tier = Math.Min(remaining, 100); // 98–197
            //    payment += tier * 1900;
            //    remaining -= tier;
            //}
            //if (remaining > 0)
            //{
            //    payment += remaining * 2000; // 198+
            //}


            //payment = price;
            Console.WriteLine($"Water used {usedNumber.ToString("##0.00")}m3");
            Console.WriteLine($"Payment {payment.ToString("##0.00")}KHR");
            Console.ReadKey();
        }
    }
}
