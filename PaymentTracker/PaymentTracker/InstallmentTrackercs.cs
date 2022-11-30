using Baseline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PaymentTracker
{
    
    public class AllInstallments: Installations
    {
        public static string Name = ValidateUser.Name;
        public static decimal Amount = ValidateUser.Amount;
        public static decimal installments;

        PaymentTracker paymenttracker = new PaymentTracker();
        public void InstallmentOptions()
        {
            Console.Clear();
            Console.WriteLine("choose an installment plan\n");
            Console.WriteLine("total number of installments possible is Three(3)\n");
            Console.WriteLine("Enter:\n1 for daily plan \n2 for weekly plan\n3 for Bi-weekly plan\n4 for montly plan\n5 for sixmonths plan. ");
           

            var ValidationOn = true;
            while (ValidationOn)
            {
                var option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("You have chosen daily plan");
                        Dailyinstallment();
                        break;

                    case 2:
                        Console.WriteLine("you have chosen weekly plan");
                        Installations.Weeklyinstallment();
                        break;

                    case 3:
                        Console.WriteLine("you have chosen Bi-weekly plan");
                        Installations.BiWeeklyinstallment();
                        break;

                    case 4:
                        Console.WriteLine("you have chosen Monthly plan");
                        Installations.monthlyinstallment();
                        break;
                    case 5:
                        Console.WriteLine("you have chosen Monthly plan");
                        Installations.sixmonthsinstallment();
                        break;
                }
            }

            Installations.Dailyinstallment();
            
        }

    }

    public class Installations
    {
        private static DateTime Firstdate = DateTime.Now;
        public static string Seconddate;
        public static string Thirddate;

        private static decimal installments;
        public static void Dailyinstallment()
        {
            Console.WriteLine("Daily Plan Dates for {0}", AllInstallments.Name);

            Seconddate = Firstdate.AddDays(1).ToString();
            Thirddate = Firstdate.AddDays(2).ToString();
            OutPut.Display(Firstdate.ToString(),Seconddate,Thirddate,installments);
        }
        public static void Weeklyinstallment()
        {
            Console.WriteLine("Weekly Plan Dates for {0}", AllInstallments.Name);

            Seconddate = Firstdate.AddDays(7).ToString();
            Thirddate = Firstdate.AddDays(14).ToString();

            OutPut.Display(Firstdate.ToString(), Seconddate, Thirddate, installments);
        }
        public static void BiWeeklyinstallment()
        {
            Console.WriteLine("Bi-Weekly Plan Dates for {0}", AllInstallments.Name);

            var Seconddate = Firstdate.AddDays(14).ToString();
            var Thirddate = Firstdate.AddDays(28).ToString();

            OutPut.Display(Firstdate.ToString(), Seconddate, Thirddate, installments);
        }
        public static void monthlyinstallment()
        {
            Console.WriteLine("Monthly Plan Dates for {0}", AllInstallments.Name);

            var Seconddate = Firstdate.AddMonths(1).ToString();
            var Thirddate = Firstdate.AddMonths(2).ToString();

            OutPut.Display(Firstdate.ToString(), Seconddate, Thirddate, installments);
        }
        public static void sixmonthsinstallment()
        {
            Console.WriteLine("Monthly Plan Dates for {0}", AllInstallments.Name);

            var Seconddate = Firstdate.AddMonths(6).ToString();
            var Thirddate = Firstdate.AddMonths(12).ToString();

            OutPut.Display(Firstdate.ToString(), Seconddate, Thirddate, installments);
        }
    }
    public class OutPut
    {
        public static void Display(string Firstdate, string Seconddate, string Thirddate, decimal installments)
        {
            installments = AllInstallments.Amount / 3;
            Console.WriteLine("You are to pay ${0} on:\n first installment:- {1}\n second installment:- {2}\n Third installment:- {3}",
                installments, Firstdate.ToString(), Seconddate, Thirddate);
        }

    }
}
