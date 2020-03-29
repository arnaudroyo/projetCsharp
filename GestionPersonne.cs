using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpB2
{
    class GestionPersonne
    {
        private Model1 model = new Model1();
        // Rechercher une personne avec mail et mdp
        public personne RechercherPersonne(string mail, string password)
        {
            var p1 = model.personnes.Where(p => p.mail.Equals(mail)).Where(p => p.password.Equals(password));
            return p1.FirstOrDefault<personne>();
        }
        public personne AfficherPersonneLogged(string mail, string password)
        {
            var p1 = model.personnes.Where(p => p.mail.Equals(mail)).Where(p => p.password.Equals(password));
            return p1.FirstOrDefault<personne>();
        }
    }
}
