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



        public Form1(personne personneLogged)
        {
            InitializeComponent();

            
            this.personneLogged = personneLogged;
            Logged.Text = "Bonjour " + personneLogged.prenom;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GestionEvenement gestion = new GestionEvenement();
            var evennements = gestion.TrouverTousLesEvennements();
            lvEvennement.Columns.Clear();
            lvEvennement.Columns.Add(new ColumnHeader() { Name = "titre", Text = "Titre", Width = 120 });
            lvEvennement.Columns.Add(new ColumnHeader() { Name = "capacité_max", Text = "Capacité_max", Width = 100 });
            lvEvennement.Columns.Add(new ColumnHeader() { Name = "adresse", Text = "Adresse", Width = 80 });
            lvEvennement.Columns.Add(new ColumnHeader() { Name = "date", Text = "Date", Width = 80 });
            lvEvennement.Items.Clear();
            foreach (evennement evennement in evennements)
            {
                Console.WriteLine(evennement.capacité_max);
                lvEvennement.AddEvennement(evennement);
            }
        }
    }


    static class ListviewExtensions
    {
        public static ListViewItem AddEvennement(this ListView lv, evennement evennement)
        {
            if (evennement == null)
                return null;

            ListViewItem lvi = new ListViewItem(new string[] { evennement.titre, evennement.capacité_max.ToString("C"), evennement.adresse, evennement.date.ToString("yyyy/MM/dd") });
            // On stocke l'objet Personne pour le réutiliser plus tard
            lvi.Tag = evennement;
            lv.Items.Add(lvi);

            return lvi;
        }


    }


}
