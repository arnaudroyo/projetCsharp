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
            AddEvent addform = new AddEvent(personneLogged);
            addform.ShowDialog();
        }
    }
}
