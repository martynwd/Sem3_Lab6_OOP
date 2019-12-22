using Lab6.Exceptions;

namespace Lab6.Accounts.Actions
{
    public class CreditAccountAction : AccountAction
    {
        public CreditAccountAction(Account acnt, double actionSum) : base(acnt, actionSum) { }

        public override double CalculateWithdrawalSum()
        {
            if (_account.Balance < 0)
            {
                return _account.Balance - (_actionSum + _actionSum / 100 * _account.Fee);
            }
            return base.CalculateWithdrawalSum();
        }

        public override double CalculateFundsAdditionSum()
        {
            if (_account.Balance < 0)
            {
                return _account.Balance + (_actionSum - _actionSum / 100 * _account.Fee);
            }
            return base.CalculateFundsAdditionSum();
        }

        protected override void CustomWithdrawalHook()
        {
            if (_account.Balance < -((CreditAccount)_account).NegativeLimit)
            {
                throw new OperationNotAllowedException("Out of credit limit");
            }
        }
    }
}