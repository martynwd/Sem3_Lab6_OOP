using System;
using Lab6.Accounts.Actions;

namespace Lab6.Accounts
{
    public class DepositAccount : Account
    {
        public readonly DateTime StartDate;
        public readonly DateTime EndDate;
        public readonly double StartSum;
        public override double Interest => (StartSum * Rate) / (365 * 100);

        public DepositAccount(Client.Client clnt, double startSum, DateTime startDate, DateTime endDate) :
            base(clnt, false, 12.0)
        {
            StartDate = startDate;
            EndDate = endDate;
            StartSum = startSum;
            Balance = startSum;
        }

        public override void Withdraw(double sum)
        {
            (new DepositAccountAction(this, sum)).Withdraw();
        }

        public override void AddFunds(double sum)
        {
            (new DepositAccountAction(this, sum)).AddFunds();
        }
    }
}