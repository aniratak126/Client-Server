using K_Servis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace K_StudentskaSluzba
{
    [ServiceContract]
    public interface IBezbednosniMehanizmi
    {
        [OperationContract]
        [FaultContract(typeof(BezbednosniIzuzetak))]
        string Autentifikacija(string korisnik, string lozinka);
    }
}
