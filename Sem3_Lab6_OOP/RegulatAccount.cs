using Lab6.Accounts.Actions;

namespace Lab6.Accounts
{
    public class RegularAccount : Account
    {
        public RegularAccount(Client.Client clnt) : base(clnt, false, 12.0) { }

        public override void Withdraw(double sum)
        {
            (new RegularAccountAction(this, sum)).Withdraw();
        }

        public override void AddFunds(double sum)
        {
            (new RegularAccountAction(this, sum)).AddFunds();
        }
    }
}