namespace Lab6.Accounts
{

    public abstract class Account
    {
        public Client.Client Client { get; }
        public double Balance { get; protected set; }
        public double Rate { get; }
        public double Fee { get; }
        public bool BalanceCanBeNegative { get; }

        public virtual double Interest => (Balance * Rate) / (365 * 100);

        protected Account(Client.Client clnt, bool balanceCanBeNegative = false, double rate = 0.0, double fee = 0.0)
        {
            Client = clnt;
            BalanceCanBeNegative = balanceCanBeNegative;
            Rate = rate;
            Fee = fee;
        }

        public void UpdateBalance(double newBalance)
        {
            Balance = newBalance;
        }

        public abstract void Withdraw(double sum);
        public abstract void AddFunds(double sum);

        public void Transfer(Account to, double sum)
        {
            Withdraw(sum);
            to.AddFunds(sum);
        }
    }
}