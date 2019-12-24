using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Client
{
    public abstract class Builder
    {
        public abstract ClientBuilder SetFirstName(string name);
        public abstract ClientBuilder SetSecondName(string name);
        public abstract ClientBuilder SetAddress(string name);
        public abstract ClientBuilder SetDocsInfo(string name);
        public abstract Client Spawn();
    }
}
