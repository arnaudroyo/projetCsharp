using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpB2
{
    public partial class Form1 : Form
    {
        private personne personneLogged;

        GestionEvenement gestionEvent = new GestionEvenement();

        public Form1(personne personneLogged)
        {
            InitializeComponent();

            
            this.personneLogged = personneLogged;
            Logged.Text = "Bonjour " + personneLogged.prenom;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            var evennements = gestionEvent.TrouverTousLesEvennements();


            lvEvennement.Columns.Clear();
            lvEvennement.Columns.Add(new ColumnHeader() { Name = "id", Text = "Id", Width = 30 });
            lvEvennement.Columns.Add(new ColumnHeader() { Name = "title", Text = "Titre", Width = 120 });
            lvEvennement.Columns.Add(new ColumnHeader() { Name = "capacité_max", Text = "Capacité_max", Width = 60 });
            lvEvennement.Columns.Add(new ColumnHeader() { Name = "nb_participant", Text = "Nombre participants", Width = 60 });
            lvEvennement.Columns.Add(new ColumnHeader() { Name = "adresse", Text = "Adresse", Width = 80 });
            lvEvennement.Columns.Add(new ColumnHeader() { Name = "ville", Text = "Ville", Width = 80 });
            lvEvennement.Columns.Add(new ColumnHeader() { Name = "date", Text = "Date", Width = 150 });
            lvEvennement.Columns.Add(new ColumnHeader() { Name = "creator", Text = "Creator", Width = 90 });
            lvEvennement.Columns.Add(new ColumnHeader() { Name = "status", Text = "Status", Width = 50 });
            lvEvennement.Items.Clear();
            foreach (evennement evennement in evennements)
            {
                Console.WriteLine(evennement.capacité_max);
                lvEvennement.AddEvennement(evennement);
            }

        }


        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            AddEvent();

        }


        private void AddEvent()
        {
            // Création du formulaire
            AddEvent addform = new AddEvent(personneLogged);
            // Appel du formualire en mode "Modal"
            if (addform.ShowDialog() == DialogResult.OK)
            {
                // Validation du formulaire : modification dans la listview
                if (lvEvennement.AddEvennement(evennement: addform.ActualEvent) == null)
                {
                    MessageBox.Show("L'event has not been added to the listview, restart app to view change", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void lvEvennement_DoubleClick(object sender, EventArgs e)
        {
            modifierToolStripMenuItem_Click(sender, e);
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Obtention de la liste des éléments sélectionnés
            ListView.SelectedListViewItemCollection selected = lvEvennement.SelectedItems;
            // On regarde si 1 seul élément a été sélectionné
            if (selected.Count == 1)
            {
                // On récupère l'objet dans la propriété Tag pour le "caster" en objet Personne
                ModifyEvent(selected[0].Tag as evennement, personneLogged);
            }

        }

        private void ModifyEvent(evennement eventclicked, personne personneLogged)
        {
            FormEditEvent form = new FormEditEvent(eventclicked, personneLogged);
            if (form.ShowDialog() == DialogResult.OK)
            {
                // Validation du formulaire : modification dans la listview
                if (lvEvennement.UpdateEvent(eventclicked) == null)
                {
                    MessageBox.Show("L'employé n'a pas pu être modifié", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
    }


}
    static class ListviewExtensions
    {

        

        public static ListViewItem AddEvennement(this ListView lv, evennement evennement)
        {
            GestionEvenement gestionEvent = new GestionEvenement();
            personne creator = new personne();
            creator = gestionEvent.RechercherCreateurById(evennement.id_createur);

            string status = gestionEvent.GetStatus(evennement);

            if (evennement == null || creator == null || status == null)
                return null;

            ListViewItem lvi = new ListViewItem(new string[] {evennement.id.ToString(), evennement.titre, evennement.capacité_max.ToString(), evennement.nb_participant.ToString(), evennement.adresse, evennement.ville, evennement.date.ToString(), creator.prenom, status });
            // On stocke l'objet Personne pour le réutiliser plus tard
            lvi.Tag = evennement;
            lv.Items.Add(lvi);

            return lvi;
        }

        public static ListViewItem UpdateEvent(this ListView lv, evennement eventclicked)
        {
            if (eventclicked == null)
                return null;

            ListViewItem lvi = lv.FindItemWithText(eventclicked.id.ToString());
            if (lvi != null)
            {
                lvi.SubItems[1].Text = eventclicked.titre.ToString();
                lvi.SubItems[2].Text = eventclicked.capacité_max.ToString();
                lvi.SubItems[3].Text = eventclicked.nb_participant.ToString();
                lvi.SubItems[4].Text = eventclicked.adresse.ToString();
                lvi.SubItems[5].Text = eventclicked.ville.ToString();
                //lvi.SubItems[6] = eventclicked.date;
                lvi.Tag = eventclicked;
            }
            return lvi;
        }

    }

   
}
