using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    class DepositTransaction : FinancialTransaction
    {
        public DepositTransaction(int sum) : base(sum) { }
        public override void DoTransaction(int sum)
        {
            Sum += sum;
            Time = DateTime.Now;
            Stan = true;
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
            return $"DepositTransaction\nSum: {Sum}\nTime: {Time}\nStan: {Stan}\n";
        }
    }
}
