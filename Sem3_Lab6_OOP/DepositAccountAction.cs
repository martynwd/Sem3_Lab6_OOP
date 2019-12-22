using System;
using Lab6.Exceptions;

namespace Lab6.Accounts.Actions
{
    public class DepositAccountAction : AccountAction
    {
        public DepositAccountAction(Account acnt, double actionSum) : base(acnt, actionSum) { }

        protected override void CustomWithdrawalHook()
        {
            var acc = (DepositAccount)_account;

            if (acc.EndDate < DateTime.Now)
            {
                throw new OperationNotAllowedException("Can't withdraw deposit account. Too early.");
            }
        }
    }
}