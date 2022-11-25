using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        public class CreateNewUser
        {
            public int TotalPricesOfGoods;

            Hashtable numberNames = new Hashtable()
            {
                { "germaine", "television"}, {"ositadimma", "radio"}
            };
            Hashtable Enteredgoods = new Hashtable();

            Hashtable EnteredgoodsAndPrice = new Hashtable()
            {
                {"Laptop",1000 }, {"phone",200}, {"generator",500}
            };

            ArrayList prices = new ArrayList();

            public void CreateUserPurchase()
            {
                Console.WriteLine("Create a new purchase record ");

                Console.WriteLine("Enter Customer's name");
                string username = Console.ReadLine();

                Console.WriteLine("How many items bought ? ");
                var AmountOfGoods = int.Parse(Console.ReadLine());

                for(int i=0; i <= AmountOfGoods; i++)
                {
                    Console.WriteLine("Enter item name");
                    string Item = Console.ReadLine();

                    foreach(DictionaryEntry price in EnteredgoodsAndPrice.Keys)
                    {
                        if(Item == price.Key)
                        {
                            prices.Add(price.Value);
                        }
                    }
                }


                //foreach (DictionaryEntry kvp in numberNames)


                    Console.WriteLine("Enter goods bought");
                string password = Console.ReadLine();


                bool StillAlive = true;
                while (StillAlive)
                {
                    if (password.Length != 4 || int.TryParse(password, out _) == false)
                    {
                        Console.WriteLine("password should be only 4 digits");
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
                    else if (User.ContainsKey(username))
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
                    else
                    {
                        User.Add(username, password);
                        Console.WriteLine("Account Created Successfully, you can Login now");
                        break;
                    }
                }
            }
}
