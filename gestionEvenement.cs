using CsharpB2;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Validation;

namespace CsharpB2
{

    public class GestionEvenement
    {
        private Model1 model = new Model1();
        public static DateTime Today { get; }

        // Lister tous les enregistrements
        public List<evennement> ChargerEvennement()
        {
            return model.evennements.Include(a => a.titre).ToList();
        }

        // Ajouter un enregistrement
        public evennement AjouterEvennement(evennement evennement)
        {
            // Ajoute le produit à l'ORM EF 
            model.evennements.Add(evennement);

            // Valide les changement dans la base de données 
            try
            {
                if (model.SaveChanges() > 0)
                    return evennement;
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
        public evennement RechercherEvennement(int id)
        {
            return model.evennements.Find(id);
        }

        // Rechercher des enregistrements
        public List<evennement> RechercherEvennementTitre(string titre)
        {
            var liste = model.evennements.Where(p => p.titre.StartsWith(titre));
            return liste.ToList();
        }
        // Rechercher le créateur de l'event
        public personne RechercherCreateurById(int id_creatoriInEvent)
        {
            var creator = model.personnes.Where(p => p.id.Equals(id_creatoriInEvent));
            return creator.FirstOrDefault();
        }

        public List<evennement> TrouverTousLesEvennements()
        {
            var liste = model.evennements; 
            return liste.OrderByDescending(d => d.date).ToList();
        }


        // Modifier un enregistrement 
        public bool ModifierEvennement(evennement evennement)
        {
            // Mettre le statut de l'entité à "Modifiée" dans l'ORM 
            model.Entry(evennement).State = EntityState.Modified;

            // Valide les changement dans la base de données 
            return (model.SaveChanges() > 0);
        }

        // Supprimer un enregistrement
        public bool SupprimerEvennement(int id)
        {
            evennement p = RechercherEvennement(id);

            if (p == null)
                return false;

            return SupprimerEvennement(p);
        }

        public bool SupprimerEvennement(evennement evennement)
        {
            if (evennement != null)
            {
                // Supprime le produit dans l'ORM 
                model.evennements.Remove(evennement);

                // Valide les changement dans la base de données 
                return (model.SaveChanges() > 0);
            }

            return false;
        }

        // Rechercher le créateur de l'event
        public string GetStatus(evennement Event)
        {
            DateTime thisDay = DateTime.Today;

            if (Event != null){
                int result = DateTime.Compare(Event.date, thisDay);
                if (result < 0)
                {
                    return "Over";
                }
                else if (result == 0)
                {
                    return "Today";
                }
                else if (result > 0)
                {
                    return "Soon";
                }
                else return null;
            }
            else return null;
        }

    }
}
