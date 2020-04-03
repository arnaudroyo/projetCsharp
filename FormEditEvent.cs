﻿using System;
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


    public partial class FormEditEvent : Form
    {

        private evennement eventClicked = null;

        GestionEvenement manageEvent = new GestionEvenement();
        gestionInscription manageInscription = new gestionInscription();

        personne personLogged;

        public evennement ActualEvent { get; internal set; }


        public FormEditEvent(evennement eventClicked, personne personneLogged)
        {
            InitializeComponent();
            this.eventClicked = eventClicked;

            this.personLogged = personneLogged;

            // On vérifie si nous avons bien un objet Personne
            if (eventClicked != null)
            {
                this.eventClicked = eventClicked;
                this.txtId.Text = eventClicked.id.ToString();
                this.txtTitle.Text = eventClicked.titre;
                this.txtAddress.Text = eventClicked.adresse;
                this.txtCapacity.Text = eventClicked.capacité_max.ToString();
                this.dtDatePickerDate.Value = eventClicked.date;

                if (eventClicked.id_createur == personneLogged.id)
                {
                    this.txtTitle.Enabled = true;
                    this.txtAddress.Enabled = true;
                    this.txtCapacity.Enabled = true;
                    this.dtDatePickerDate.Enabled = true;
                    this.btnOK.Enabled = true;
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            eventClicked.titre = this.txtTitle.Text;
            eventClicked.adresse = this.txtAddress.Text;
            eventClicked.capacité_max = Int16.Parse(this.txtCapacity.Text);
            eventClicked.date = this.dtDatePickerDate.Value;

            if (eventClicked != null)
            {
                manageEvent.ModifierEvennement(eventClicked);

                this.DialogResult = DialogResult.OK;
            }
            else
                this.DialogResult = DialogResult.Cancel;
        }

        private void participate_Click(object sender, EventArgs e)
        {
            bool alreadyRegistered = manageInscription.RechercherInscription(eventClicked.id, personLogged.id);
            if (alreadyRegistered == false)
            {
                if (eventClicked.nb_participant < eventClicked.capacité_max)
                {
                    inscri newInscription = new inscri();
                    newInscription.id_evennement = eventClicked.id;
                    newInscription.id_personne = this.personLogged.id;
                    manageInscription.Ajouterinscription(newInscription);

                    eventClicked.nb_participant++;
                    manageEvent.ModifierEvennement(eventClicked);

                    MessageBox.Show("You now participate in this event", "registration succed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("There is too much participant in this event", "registration failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                MessageBox.Show("You already participate in this event", "registration ok", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
