using Lab6.BasicClasses;

namespace Lab6.Accounts.Requests
{
    public class TakeFeeRequest : ChainOfResponsibility<Account>
    {
        public override Account Handle(ref Account request)
        {
            var newBalance = request.Balance - request.Fee;
            request.UpdateBalance(newBalance);
            return request;
        }
    }
}