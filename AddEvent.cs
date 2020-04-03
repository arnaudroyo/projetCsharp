
using System;
using System.Windows.Forms;

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

        
        private void btnOK_Click(object sender, EventArgs e)
        {

            string title = txtTitle.Text;

            string adress = txtAdress.Text;
            string city = txtCity.Text;
            string country = textCountry.Text;
            DateTime date = dtDatePickerDate.Value;
            int nb_participant = 1;
            int id_creator = personLoggedGlobal.id;

            var capacityIsNumeric = int.TryParse(txtCapacity.Text, out int capacity);

            evennement newEvent = new evennement(title, capacity, adress, city, country, date, nb_participant, id_creator);
            if (newEvent != null && capacityIsNumeric == true && title != "" && adress != "" && city != "" && country != "")
            {
                manageEvent.AjouterEvennement(newEvent);
                MessageBox.Show("The event has been created", "Creating event succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualEvent = newEvent;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Error, miss informations", "Creating event failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
