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
    public partial class Signup : Form
    {

        GestionPersonne managePerson = new GestionPersonne();

        public Signup()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string Fname = txtFname.Text;
            string city = txtCity.Text;
            string mail = txtMail.Text;
            string password = txtPassword.Text;


            personne newPerson = new personne(name, Fname, city, mail, password);
            if (newPerson != null)
            {
                managePerson.AjouterPersonne(newPerson);
                MessageBox.Show("The account has been created", "Creating event succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
                this.DialogResult = DialogResult.Cancel;
        }
    }
}
