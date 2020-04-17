using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpB2
{
    class gestionInscription
    {
        private Model1 model = new Model1();

        GestionEvenement manageEvent = new GestionEvenement();


        public inscri Ajouterinscription(inscri inscription)
        {
            // Ajoute la inscriptionne à l'ORM EF 
            model.inscris.Add(inscription);

            // Valide les changement dans la base de données 
            try
            {

                if (model.SaveChanges() > 0)
                {
                    int nb = manageEvent.CountAllParticipants(inscription.id_evennement);
                    evennement ev = manageEvent.RechercherEvennement(inscription.id_evennement);
                    ev.nb_participant = nb;
                    manageEvent.ModifierEvennement(ev);

                    return inscription;
                }
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

        // Rechercher un enregistrement
        public bool RechercherInscription(int idEvent, int idperson)
        {
            var register = model.inscris.Where(p => p.id_evennement.Equals(idEvent)).Where(p => p.id_personne.Equals(idperson)).ToList();
            if (register.Count == 0)
            {
                return false; // is not registered
            }
            else
                return true; //is registered


        }

        public evennement SupprimerInscription(inscri Inscription)
        {
            if (Inscription != null)
            {

                // Supprime le produit dans l'ORM 
                model.inscris.Remove(Inscription);
                model.SaveChanges();

                int nb = manageEvent.CountAllParticipants(Inscription.id_evennement);
                evennement ev = manageEvent.RechercherEvennement(Inscription.id_evennement);
                ev.nb_participant = nb;
                manageEvent.ModifierEvennement(ev);

                return ev;

            }

            return null;
        }

        public inscri RechercherInscription(evennement Event, personne person)
        {
            try
            {
                var p1 = model.inscris.Where(p => p.id_personne.Equals(person.id)).Where(p => p.id_evennement.Equals(Event.id));
                return p1.FirstOrDefault<inscri>();
            }
            catch
            {
                return null;
            }
        }
    }
}
