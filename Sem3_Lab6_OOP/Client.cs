namespace Lab6.Client
{
    public class Client
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string DocsInfo { get; set; }

        public static ClientBuilder Build()
        {
            return new ClientBuilder();
        }
        public void SetFN(string FN)
        {
            FirstName = FN;
        }
        public void SetSN(string SN)
        {
            LastName = SN;
        }
        public void SetAd(string Ad)
        {
            Address = Ad;
        }
        public void SetDoc(string Doc)
        {
            DocsInfo = Doc;
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