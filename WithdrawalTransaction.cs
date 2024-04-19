using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    class WithdrawalTransaction : FinancialTransaction
    {
        public WithdrawalTransaction(int sum) : base(sum) { }
        public override void DoTransaction(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                Time = DateTime.Now;
                Stan = true;
            }
            else
            {
                Time = DateTime.Now;
                Stan = false;
            }
        }

        public override void CheckTransaction()
        {
            if (Stan)
            {
                Console.WriteLine("Transaction was successful!");
            }
            else
            {
                Console.WriteLine("Transaction was not successful!");
            }
        }

        public override string ToString()
        {
            return $"WithdrawalTransaction\nSum: {Sum}\nTime: {Time}\nStan: {Stan}\n";
        }
    }
}
