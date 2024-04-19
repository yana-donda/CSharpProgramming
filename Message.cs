using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Визначення події для сповіщення про успішне або неуспішне завершення транзакції та організація взаємодії об'єктів через цю подію.

namespace Module2
{
    class Message
    {
        public event EventHandler my_transaction;

        protected virtual void MyTransaction()
        {
            my_transaction.Invoke(this, EventArgs.Empty);
        }

        public void Transaction(FinancialTransaction trans)
        {
            Console.WriteLine("Transaction:");
            trans.CheckTransaction();
            MyTransaction();
        }
    }
}
