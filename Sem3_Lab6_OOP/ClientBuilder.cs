using System;

namespace Lab6.Client
{
    public class ClientBuilder : Builder
    {
        private Client _client = new Client();

        private bool[] _requiredFieldsAreSet = new[] { false, false };

        public override ClientBuilder SetFirstName(string name)
        {
            _client.SetFN(name);
            return this;
        }
        public override ClientBuilder SetSecondName(string name)
        {
            _client.SetSN(name);
            return this;
        }
        public override ClientBuilder SetAddress(string name)
        {
            _client.SetAd(name);

            return this;
        }
        public override ClientBuilder SetDocsInfo(string name)
        {
            _client.SetDoc(name);
            return this;
        }




        public override Client Spawn()
        {
            if (_requiredFieldsAreSet[0] == false && _requiredFieldsAreSet[1] == false)
            {
                throw new Exception("First name and last name are required");
            }

            return _client;
        }

        
    }   
}