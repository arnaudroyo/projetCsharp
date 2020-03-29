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
    public partial class AddEvent : Form
    {

        int creator_id = 0;

        public AddEvent(personne personLogged)
        {
            InitializeComponent();
            creator_id = personLogged.id;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void textCountry_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtDatePickerDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtCapacity_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            string title = txtTitle.Text;
            //string id = txtTitle.Text;
            string capacity = txtCapacity.Text;
            string adress = txtTitle.Text;
            string city = txtCity.Text;
            string country = textCountry.Text;
            DateTime date = dtDatePickerDate.Value;
            int nb_participant = 1;
            int id_creator = creator_id;
            //evennement event = new evennement(string title, int capacity, string adress, string city, string country, DateTime date, int nb_participant, int id_creator);
            //GestionEvenement.AjouterEvennement(event);
        }
    }
}
