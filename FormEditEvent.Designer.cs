namespace CsharpB2
{
    partial class FormEditEvent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.dtDatePickerDate = new System.Windows.Forms.DateTimePicker();
            this.Date = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.capacity_max = new System.Windows.Forms.Label();
            this.Adresse = new System.Windows.Forms.Label();
            this.titre = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.participate = new System.Windows.Forms.Button();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.Label();
            this.lvParticipant = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(310, 341);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 36);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(75, 341);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(140, 36);
            this.btnOK.TabIndex = 30;
            this.btnOK.Text = "Valider";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dtDatePickerDate
            // 
            this.dtDatePickerDate.Enabled = false;
            this.dtDatePickerDate.Location = new System.Drawing.Point(207, 226);
            this.dtDatePickerDate.Name = "dtDatePickerDate";
            this.dtDatePickerDate.Size = new System.Drawing.Size(200, 20);
            this.dtDatePickerDate.TabIndex = 27;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(105, 226);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(30, 13);
            this.Date.TabIndex = 26;
            this.Date.Text = "Date";
            // 
            // txtTitle
            // 
            this.txtTitle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTitle.Enabled = false;
            this.txtTitle.Location = new System.Drawing.Point(208, 73);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 19;
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(208, 113);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 21;
            // 
            // txtCapacity
            // 
            this.txtCapacity.Enabled = false;
            this.txtCapacity.Location = new System.Drawing.Point(208, 189);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(100, 20);
            this.txtCapacity.TabIndex = 23;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(208, 35);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 17;
            // 
            // capacity_max
            // 
            this.capacity_max.AutoSize = true;
            this.capacity_max.Location = new System.Drawing.Point(106, 189);
            this.capacity_max.Name = "capacity_max";
            this.capacity_max.Size = new System.Drawing.Size(94, 13);
            this.capacity_max.TabIndex = 22;
            this.capacity_max.Text = "Maximum capacity";
            // 
            // Adresse
            // 
            this.Adresse.AutoSize = true;
            this.Adresse.Location = new System.Drawing.Point(106, 113);
            this.Adresse.Name = "Adresse";
            this.Adresse.Size = new System.Drawing.Size(45, 13);
            this.Adresse.TabIndex = 20;
            this.Adresse.Text = "Address";
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Location = new System.Drawing.Point(106, 73);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(27, 13);
            this.titre.TabIndex = 18;
            this.titre.Text = "Title";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(106, 35);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(16, 13);
            this.id.TabIndex = 16;
            this.id.Text = "Id";
            // 
            // participate
            // 
            this.participate.Location = new System.Drawing.Point(222, 284);
            this.participate.Name = "participate";
            this.participate.Size = new System.Drawing.Size(86, 42);
            this.participate.TabIndex = 32;
            this.participate.Text = "Participate";
            this.participate.UseVisualStyleBackColor = true;
            this.participate.Click += new System.EventHandler(this.participate_Click);
            // 
            // txtCity
            // 
            this.txtCity.Enabled = false;
            this.txtCity.Location = new System.Drawing.Point(208, 148);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 34;
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Location = new System.Drawing.Point(106, 148);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(24, 13);
            this.city.TabIndex = 33;
            this.city.Text = "City";
            // 
            // lvParticipant
            // 
            this.lvParticipant.FullRowSelect = true;
            this.lvParticipant.GridLines = true;
            this.lvParticipant.HideSelection = false;
            this.lvParticipant.Location = new System.Drawing.Point(456, 12);
            this.lvParticipant.Name = "lvParticipant";
            this.lvParticipant.Size = new System.Drawing.Size(111, 365);
            this.lvParticipant.TabIndex = 35;
            this.lvParticipant.UseCompatibleStateImageBehavior = false;
            this.lvParticipant.View = System.Windows.Forms.View.Details;
            this.lvParticipant.Visible = false;
            // 
            // FormEditEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 389);
            this.Controls.Add(this.lvParticipant);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.city);
            this.Controls.Add(this.participate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dtDatePickerDate);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.capacity_max);
            this.Controls.Add(this.Adresse);
            this.Controls.Add(this.titre);
            this.Controls.Add(this.id);
            this.Name = "FormEditEvent";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DateTimePicker dtDatePickerDate;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label capacity_max;
        private System.Windows.Forms.Label Adresse;
        private System.Windows.Forms.Label titre;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Button participate;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.ListView lvParticipant;
    }
}