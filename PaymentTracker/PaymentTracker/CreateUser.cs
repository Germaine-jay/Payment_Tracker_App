using System;
using System.Collections;
using System.Collections.Generic;

namespace PaymentTracker
{
    
    public class CreateNewUser
    {
        public static decimal TotalPricesOfGoods;
        public static string NameOfUser;

        public static Dictionary<string, decimal> CustomerAndTotalamount = new Dictionary<string, decimal>()
            {
                { "germaine", 1500}, {"ositadimma", 200}
            };

        public void CreateUser()
        {

            var ValidationOn = true;
            while (ValidationOn)
            {
                Console.WriteLine("Create a new purchase record for a user");
                
                Console.WriteLine("Enter Customer's name");
                string username = Console.ReadLine();

                Console.WriteLine("Enter total price of goods bought:($) ");
                var TotalAmountOfGoods = Console.ReadLine();

                if (CustomerAndTotalamount.ContainsKey(username))
                {
                    Console.WriteLine("username already exist");

                    Console.WriteLine("Try Another Username..........." + "y/n");
                    var option = Console.ReadLine();

                    switch (option)
                    {
                        case "y":
                            CreateUser();
                            break;
                        case "n":
                            break;
                    }
                }


                else if (decimal.TryParse(TotalAmountOfGoods, out decimal value)==false)
                {
                    Console.WriteLine("Invalid price input");

                    Console.WriteLine("Try Again..........." + "y/n");
                    var option = Console.ReadLine();

                    switch (option)
                    {
                        case "y":
                            CreateUser();
                            break;
                        case "n":
                            break;
                        default:
                            Console.WriteLine("invalid input");
                            CreateUser();
                            break;
                    }
                }else
                {
                    CustomerAndTotalamount.Add(username, decimal.Parse(TotalAmountOfGoods));
                    Console.WriteLine("Purchase Record Created Successfully for user {0}", username);
                }
                Console.Clear();

                ValidateUser New = new ValidateUser();
                New.LoginUser(CustomerAndTotalamount);
                break;
            }
        }
        public void UserOption()
        {
            Console.WriteLine("Already hav an account?...........y/n");
            var payoption = Console.ReadLine();

            switch (payoption)
            {
                case "y":
                    ValidateUser New = new ValidateUser();
                    New.LoginUser(CustomerAndTotalamount);
                    break;
                case "n":
                    CreateUser();
                    break;
                default:
                    Console.WriteLine("invalid input"); UserOption();
                    break;
            }
        }
    }

}


