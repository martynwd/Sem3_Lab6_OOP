namespace Lab6.Client
{
    public class Client
    {
        public readonly string FirstName;
        public readonly string LastName;
        public readonly string Address;
        public readonly string DocsInfo;

        public static ClientBuilder Build()
        {
            return new ClientBuilder();
        }

        public override string ToString()
        {
            var a = $"{LastName} {FirstName}";
            if (Address != null) a += $", проживает по адресу {Address}";
            if (DocsInfo != null) a += $", паспорт {DocsInfo}";

            return a;
        }
    }
}