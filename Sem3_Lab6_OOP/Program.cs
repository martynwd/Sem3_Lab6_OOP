using System;
using Lab6.Accounts;
using Lab6.Accounts.Requests;
using Lab6.Client;

namespace Lab6
{

    class Program
    {
        static void Main(string[] args)
        {
            var client = Client.Client.Build()
                .SetFirstName("FistName")
                .SetSecondName("Second Name")
                .SetAddress("Street Name")
                .SetDocsInfo("Четырнадацать две восьмерочки:)")
                .Spawn();
            Console.WriteLine(client.FirstName);

            var account = new AccountFactory(client).SpawnDepositAccount(20000, DateTime.Now + TimeSpan.FromDays(30));
            account.AddFunds(15000);
            Console.WriteLine($"funds should be {20000 + 15000}: {account.Balance}");

            account.Withdraw(34000);

            try
            {
                account.Withdraw(34000);
            }
            catch (Exception e)
            {
                Console.WriteLine("You don't have money");
            }

            var req1 = new PayInterestRequest();
            req1.Next = new TakeFeeRequest();
            req1.Handle(ref account);

            Console.WriteLine(account.Balance);
        }
    }
}