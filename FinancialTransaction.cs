using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    public abstract class FinancialTransaction : ITransaction
    {
        public int Sum { get; set; }
        public DateTime Time { get; set; }

        public bool Stan { get; set; }

        public FinancialTransaction(int sum)
        {
            Sum = sum;
        }

        public abstract void DoTransaction(int sum);

        public abstract void CheckTransaction();

        public override string ToString()
        {
            return $"Sum: {Sum}\nTime: {Time}\nStan: {Stan}\n";
        }
    }
}
