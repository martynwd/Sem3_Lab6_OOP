using Lab6.Accounts.Actions;

namespace Lab6.Accounts
{
    public class CreditAccount : Account
    {
        public readonly double NegativeLimit;

        public CreditAccount(Client.Client clnt, double negativeLimit) : base(clnt, true, 0.0, 12.0)
        {
            NegativeLimit = negativeLimit;
        }

        public override void Withdraw(double sum)
        {
            (new CreditAccountAction(this, sum)).Withdraw();
        }

        public override void AddFunds(double sum)
        {
            (new CreditAccountAction(this, sum)).AddFunds();
        }
    }
}