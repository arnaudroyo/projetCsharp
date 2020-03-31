using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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
            try
            {
                var p1 = model.personnes.Where(p => p.mail.Equals(mail)).Where(p => p.password.Equals(password));
                return p1.FirstOrDefault<personne>();
            }
            catch
            {
                return null;
            }
        }
        public personne AfficherPersonneLogged(string mail, string password)
        {
            var p1 = model.personnes.Where(p => p.mail.Equals(mail)).Where(p => p.password.Equals(password));
            return p1.FirstOrDefault<personne>();
        }

        public personne AjouterPersonne(personne person)
        {
            // Ajoute la personne à l'ORM EF 
            model.personnes.Add(person);

            // Valide les changement dans la base de données 
            try
            {
                if (model.SaveChanges() > 0)
                    return person;
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }


            return null;
        }
    }
}
