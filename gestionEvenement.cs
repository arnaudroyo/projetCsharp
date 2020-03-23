using CsharpB2;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpB2
{
    public class GestionEvenement
    {
        private Model1 model = new Model1();

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
            if (model.SaveChanges() > 0)
                return evennement;

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

    }
}
