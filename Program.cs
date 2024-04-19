using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Реалізація системи для обробки фінансових транзакцій
  Ваша програма повинна містити наступні елементи:
  - Створення інтерфейсу ITransaction, який містить методи для здійснення транзакції та перевірки стану транзакції.
  - Створення класу FinancialTransaction, який реалізує інтерфейс ITransaction та містить інформацію про фінансову транзакцію (сума, дата тощо).
  - Побудова ієрархії класів для різних типів транзакцій: базовий клас Transaction, який містить загальні властивості, та похідні класи, наприклад,
    DepositTransaction, WithdrawalTransaction тощо.
  - Використання конструкторів для ініціалізації об'єктів класів та деструкторів для звільнення ресурсів.
  - Асинхронний виклик методів через делегат для здійснення транзакцій.
  - Визначення події для сповіщення про успішне або неуспішне завершення транзакції та організація взаємодії об'єктів через цю подію.
  - Розробка класу винятків для обробки помилок під час виконання фінансових транзакцій.*/

namespace Module2
{
    public interface ITransaction
    {
        void DoTransaction(int sum);
        void CheckTransaction();
    }
    class Program
    {
        static void Main(string[] args)
        {
            DepositTransaction dep_transaction = new DepositTransaction(500);
            WithdrawalTransaction wit_transaction = new WithdrawalTransaction(1000);
            dep_transaction.DoTransaction(100);
            dep_transaction.CheckTransaction();
            Console.WriteLine(dep_transaction);
            wit_transaction.DoTransaction(2000);
            wit_transaction.CheckTransaction();
            Console.WriteLine(wit_transaction);

            Console.ReadLine();

        }
    }
}
