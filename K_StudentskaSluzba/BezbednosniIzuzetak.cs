using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace K_Servis
{
    [DataContract]

    public class BezbednosniIzuzetak
    {
        string razlog;
        public BezbednosniIzuzetak(string poruka)
        {
            Razlog = poruka;
        }
        [DataMember]
        public string Razlog { get => razlog; set => razlog = value; }
    }
}
