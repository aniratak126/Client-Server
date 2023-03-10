using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace K_StudentskaSluzba
{
    [DataContract]
    public enum EStanjeServera
    {
        [EnumMemberAttribute]
        Nepoznato,
        [EnumMemberAttribute]
        Primarni,
        [EnumMemberAttribute]
        Sekundarni
    }
    [ServiceContract]
    public interface IStanjeServisa
    {
        [OperationContract]
        [FaultContract(typeof(ServisFizickaLicaIzuzetak))]
        EStanjeServera ProveraStanja();
        [OperationContract]
        [FaultContract(typeof(ServisFizickaLicaIzuzetak))]
        void AzuriranjeStanja(EStanjeServera stanje);
    }
}
