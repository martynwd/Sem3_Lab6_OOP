using System;

namespace Lab6.Client
{
    public class ClientBuilder
    {
        private Client _client = new Client();

        private bool[] _requiredFieldsAreSet = new[] { false, false };

        public ClientBuilder SetFirstName(string name)
        {
            SetProp("FirstName", name);
            _requiredFieldsAreSet[0] = true;
            return this;
        }

        public ClientBuilder SetLastName(string name)
        {
            SetProp("LastName", name);
            _requiredFieldsAreSet[1] = true;
            return this;
        }

        public ClientBuilder SetAddress(string name)
        {
            SetProp("Address", name);
            return this;
        }

        public ClientBuilder SetDocsInfo(string name)
        {
            SetProp("DocsInfo", name);
            return this;
        }

        public Client Spawn()
        {
            if (_requiredFieldsAreSet[0] == false && _requiredFieldsAreSet[1] == false)
            {
                throw new Exception("First name and last name are required");
            }

            return _client;
        }

        private void SetProp<T>(string name, T value)
        {
            _client.GetType().GetField(name).SetValue(_client, value);
        }
    }
}