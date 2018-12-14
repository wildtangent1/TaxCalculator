# TaxCalculator
Tax Calculator
/*Joel Schwaber
IFN501
Mid-September
n10241337
*/
using System;
namespace Project
{
    class PayRateandTax
    {
        //main
        static void Main()
        {
            string name = GetName();
            decimal gross = EnterPay();
            decimal pay = CalcTakeHome(Convert.ToDouble(gross));
            decimal fedtax = CalcFedTax(Convert.ToDouble (pay));
            decimal retirement = CalcRetirement(Convert.ToDouble (pay));
            decimal socialsecurity = CalcSocSec(Convert.ToDouble(pay));
            decimal finalpay = CalcFinalTakeHome(Convert.ToDouble(pay));
            Console.WriteLine("Employee name is: {0}", name);
        }
        public static string GetName()
        {
            Console.WriteLine("Please Type Your Name");
            string name = (Console.ReadLine());
            return name;
            }
        public static decimal EnterPay()
        {
            Console.Write("Please write the total sales figure the shop made, in dollars and cents: ");
            decimal gross = Convert.ToDecimal(Console.ReadLine());
            return gross;
        }
        public static decimal CalcTakeHome(double gross) //using decimal, since this is financial and you need to be as precise as possible.
        {
            Console.WriteLine(string.Format("Your store made: ${0}", Convert.ToDecimal(gross)));//was returning the wrong answer, then switched the line the calculation was on, 
            decimal Commission = Convert.ToDecimal(gross * .08);//had it re - print, and THEN return the value back to top.
             Console.WriteLine(string.Format("Your take home pay, pre-deductions was: ${0}", Convert.ToDecimal(Commission)));
            return Commission;
        }
        public static decimal CalcFedTax(double fedtax)
        {
            Console.WriteLine(string.Format("Your take home pay, you were taxed: ${0}", Convert.ToDecimal (fedtax * 0.12)));
            return Convert.ToDecimal(fedtax * 0.12);
        }
        public static decimal CalcRetirement(double retirement) //It needs a convert, can't convert from decimal to decimal, so it's double-to-decimal
        {
            Console.WriteLine(string.Format("Of your take home pay, you put ${0} into retirement.", Convert.ToDecimal(retirement * 0.1)));
            return Convert.ToDecimal(retirement * 0.1);
        }
        public static decimal CalcSocSec(double socialsecurity)
        {
            Console.WriteLine(string.Format("Of your take home pay, your contributed ${0} to Social Security.", Convert.ToDecimal(socialsecurity * 0.07)));
            return Convert.ToDecimal(socialsecurity * 0.07);
        }
        public static decimal CalcFinalTakeHome(double finalpay)
        {
            Console.WriteLine(string.Format("Of your take home pay post-deductions, is ${0}", Convert.ToDecimal(finalpay - finalpay * (0.07 + 0.12 + 0.1))));
            return Convert.ToDecimal(finalpay);
        }
        public static void DisplayResult(decimal Result)
        {
            Console.WriteLine("The total you were taxed was: {0:C}", Result);
        }
    }
}
