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
    public partial class Signin : Form
    {

        GestionPersonne GestionP = new GestionPersonne();

        public personne personneLogged = null;
        public Signin()
        {
            InitializeComponent();
        }



        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtMail.Text != "" && txtPassword.Text != "")
            {
                string mailTest = txtMail.Text;
                string passwordTest = txtPassword.Text;

                personneLogged = GestionP.RechercherPersonne(mailTest, passwordTest);
                if (personneLogged != null)
                    {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Bad mail or password", "login failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Entrez un mail et un mot de passe valide", "empty field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void Signin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Signup SignUpForm = new Signup();
            SignUpForm.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Environment.Exit(1);

        }
    }
}
