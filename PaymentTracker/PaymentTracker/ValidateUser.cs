using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentTracker
{
    public class ValidateUser
    {
        public Dictionary<string, decimal> CustomerAndTotalamount = CreateNewUser.CustomerAndTotalamount;
        public static string Name;
        public static decimal Amount;

        public void LoginUser(Dictionary<string, decimal> CustomerAndTotalamount)
        {
            Console.WriteLine("Check Customer's Record\n");
            Console.WriteLine("Enter Customer's name");
            string username = Console.ReadLine();


            foreach (KeyValuePair<string, decimal> User in CustomerAndTotalamount)
            {
                if (CustomerAndTotalamount.ContainsKey(username))
                {
                    if(User.Key == username)
                    {
                        Name = (string)User.Key;
                        Amount = (decimal)User.Value;
                        Console.WriteLine("i'm in");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("user does not exist");

                    Console.WriteLine("Try Again..........." + "y/n");
                    var option = Console.ReadLine();

                    switch (option)
                    {
                        case "y":
                            LoginUser(CustomerAndTotalamount);
                            break;
                        case "n":
                            break;
                        default:
                            Console.WriteLine("invalid input");
                            LoginUser(CustomerAndTotalamount);
                            break;
                    }
                    break;
                }
            }

            AllInstallments New = new AllInstallments();
            New.InstallmentOptions();
        }
    }
}
