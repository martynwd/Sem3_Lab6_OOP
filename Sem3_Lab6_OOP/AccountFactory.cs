using System;

namespace Lab6.Accounts
{
    public class AccountFactory
    {
        private Client.Client _client;

        public AccountFactory(Client.Client clnt)
        {
            _client = clnt;
        }
    
        public Account SpawnAccount(string accountType)
        {
            return accountType.ToLower() switch
            {
                "creditaccount" => (Account)new CreditAccount(_client, 20000),
                "depositaccount" => new DepositAccount(_client, 20000, DateTime.Now,
                    DateTime.Now + TimeSpan.FromDays(30)),
                "regularaccount" => new RegularAccount(_client),
                _ => throw new Exception("Unknown account type")
            };
        }

        public Account SpawnCreditAccount(double negativeLimit)
        {
            return new CreditAccount(_client, negativeLimit);
        }

        public Account SpawnDepositAccount(double startSum, DateTime endDate)
        {
            return new DepositAccount(_client, startSum, DateTime.Now,
                endDate);
        }
    }
}