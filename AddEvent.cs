using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsharpB2;

namespace CsharpB2
{
    public partial class AddEvent : Form
    {
        personne personLoggedGlobal = new personne();

        GestionEvenement manageEvent = new GestionEvenement();

        public evennement ActualEvent { get; internal set; }


        public AddEvent(personne personLogged)
        {
            InitializeComponent();
            personLoggedGlobal = personLogged;
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
            int capacity = int.Parse(txtCapacity.Text);
            string adress = txtAdress.Text;
            string city = txtCity.Text;
            string country = textCountry.Text;
            DateTime date = dtDatePickerDate.Value;
            int nb_participant = 1;
            int id_creator = personLoggedGlobal.id;

            evennement newEvent = new evennement(title, capacity, adress, city, country, date, nb_participant, id_creator);
           if (newEvent != null)
            {
                manageEvent.AjouterEvennement(newEvent);
                MessageBox.Show("The event has been created", "Creating event succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualEvent = newEvent;
                this.DialogResult = DialogResult.OK;
            }
           else
                this.DialogResult = DialogResult.Cancel;
        }
    }
}
