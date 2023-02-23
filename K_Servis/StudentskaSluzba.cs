using K_StudentskaSluzba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_Servis
{
    class StudentskaSluzba : IStudentskaSluzba, IBezbednosniMehanizmi
    {
        static readonly DirektorijumKorisnika direktorijum = new DirektorijumKorisnika();

        public string Autentifikacija(string korisnik, string lozinka)
        {
            return direktorijum.AutentifikacijaKorisnika(korisnik, lozinka);
        }

        public bool DobaviStudenta(string token, string brojIndeksa, out Student student)
        {
            throw new NotImplementedException();
        }

        public bool DodajPredmetStudentu(string token, string brojIndeksa, string nazivPredmeta, int ocena)
        {
            throw new NotImplementedException();
        }

        public void DodajStudenta(string token, Student student)
        {
            throw new NotImplementedException();
        }

        public void IzbrisiStudenta(string token, string brojIndeksa)
        {
            throw new NotImplementedException();
        }

        public void IzmeniStudenta(string token, Student student)
        {
            throw new NotImplementedException();
        }

        public bool ObrisiPredmetStudentu(string token, string brojIndeksa, string nazivPredmeta)
        {
            throw new NotImplementedException();
        }
    }
}
