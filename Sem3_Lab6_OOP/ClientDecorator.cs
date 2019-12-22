namespace Lab6.Client
{
    public class ClientDecorator
    {
        private Client _client;

        public ClientDecorator(Client clnt)
        {
            _client = clnt;
        }

        public bool IsSuspicious()
        {
            return _client.Address == null || _client.DocsInfo == null;
        }
    }
}