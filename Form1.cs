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
            Logged.Text = "Hello " + personneLogged.prenom;

        }

        private void btnOK_Click(object sender, EventArgs e)
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
                /*if (lvEvennement.AddEvennement(evennement: addform.ActualEvent) == null)
                {
                    MessageBox.Show("L'event n'a pas pu être ajouté", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
            }
        }
    }
}
