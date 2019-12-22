using Lab6.BasicClasses;

namespace Lab6.Accounts.Requests
{
    public class PayInterestRequest : ChainOfResponsibility<Account>
    {
        public override Account Handle(ref Account request)
        {
            var newBalance = request.Balance + request.Interest;
            request.UpdateBalance(newBalance);
            return request;
        }
    }
}