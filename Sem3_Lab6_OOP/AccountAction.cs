using System;
using Lab6.Client;
using Lab6.Exceptions;

namespace Lab6.Accounts.Actions
{
    public abstract class AccountAction
    {
        protected Client.Client _client;
        protected Account _account;
        protected double _actionSum;

        public AccountAction(Account acnt, double actionSum)
        {
            _client = acnt.Client;
            _account = acnt;
            _actionSum = Math.Abs(actionSum);
        }

        protected void CheckAccountSum()
        {
            if (!_account.BalanceCanBeNegative && _account.Balance < _actionSum)
            {
                throw new OperationNotAllowedException("Low on funds");
            }
        }

        protected void SecurityCheck()
        {
            var clientDecorator = new ClientDecorator(_client);
            if (clientDecorator.IsSuspicious() && _actionSum > 15000)
            {
                throw new OperationNotAllowedException("You are suspicious");
            }
        }

        public virtual double CalculateWithdrawalSum()
        {
            return _account.Balance - _actionSum;
        }

        public virtual double CalculateFundsAdditionSum()
        {
            return _account.Balance + _actionSum;
        }

        protected virtual void CustomWithdrawalHook() { }
        protected virtual void CustomAddFundsHook() { }

        public void Withdraw()
        {
            CheckAccountSum();
            SecurityCheck();
            CustomWithdrawalHook();
            var newBalance = CalculateWithdrawalSum();
            _account.UpdateBalance(newBalance);
        }

        public void AddFunds()
        {
            CustomAddFundsHook();
            var newBalance = CalculateFundsAdditionSum();
            _account.UpdateBalance(newBalance);
        }
    }
}