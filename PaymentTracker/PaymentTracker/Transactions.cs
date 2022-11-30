using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentTracker
{
   
    public class PaymentTracker
    {
        public decimal initialBalanace = ValidateUser.Amount;
 
        public string Owner = ValidateUser.Name;
        
        private List<Transaction> AllTransactions = new List<Transaction>();
        public decimal Balance

        {
            get
            {
                decimal balance = 0;
                foreach (var item in AllTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }


        public void InstallmentPayment(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Invalid Amount to pay");
            }
            if (Balance - amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Not sufficient funds for this withdrawal");
            }
            var Pay = new Transaction(-amount);
            AllTransactions.Add(Pay);
        }
    }


    public class Transaction
    {
        public decimal Amount { get; }

        public Transaction(decimal amount)
        {
            Amount = amount;
        }
    }
}
