﻿namespace CsharpB2
{
    partial class AddEvent
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
            this.Country = new System.Windows.Forms.Label();
            this.dtDatePickerDate = new System.Windows.Forms.DateTimePicker();
            this.Date = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.City = new System.Windows.Forms.Label();
            this.capacity = new System.Windows.Forms.Label();
            this.Adress = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.textCountry = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.Location = new System.Drawing.Point(197, 220);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(43, 13);
            this.Country.TabIndex = 29;
            this.Country.Text = "Country";
            // 
            // dtDatePickerDate
            // 
            this.dtDatePickerDate.Location = new System.Drawing.Point(299, 266);
            this.dtDatePickerDate.Name = "dtDatePickerDate";
            this.dtDatePickerDate.Size = new System.Drawing.Size(200, 20);
            this.dtDatePickerDate.TabIndex = 27;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(197, 266);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(30, 13);
            this.Date.TabIndex = 26;
            this.Date.Text = "Date";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(299, 172);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 25;
            // 
            // txtTitle
            // 
            this.txtTitle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTitle.Location = new System.Drawing.Point(299, 92);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 19;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(299, 132);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(100, 20);
            this.txtAdress.TabIndex = 21;
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(299, 313);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(100, 20);
            this.txtCapacity.TabIndex = 23;
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Location = new System.Drawing.Point(197, 172);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(24, 13);
            this.City.TabIndex = 24;
            this.City.Text = "City";
            // 
            // capacity
            // 
            this.capacity.AutoSize = true;
            this.capacity.Location = new System.Drawing.Point(197, 313);
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(94, 13);
            this.capacity.TabIndex = 22;
            this.capacity.Text = "Maximum capacity";
            // 
            // Adress
            // 
            this.Adress.AutoSize = true;
            this.Adress.Location = new System.Drawing.Point(197, 132);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(39, 13);
            this.Adress.TabIndex = 20;
            this.Adress.Text = "Adress";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(197, 92);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(27, 13);
            this.Title.TabIndex = 18;
            this.Title.Text = "Title";
            // 
            // textCountry
            // 
            this.textCountry.Location = new System.Drawing.Point(299, 217);
            this.textCountry.Name = "textCountry";
            this.textCountry.Size = new System.Drawing.Size(100, 20);
            this.textCountry.TabIndex = 32;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(382, 364);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 36);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOK.Location = new System.Drawing.Point(151, 364);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(140, 36);
            this.btnOK.TabIndex = 33;
            this.btnOK.Text = "Ok";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // AddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.textCountry);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.dtDatePickerDate);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.City);
            this.Controls.Add(this.capacity);
            this.Controls.Add(this.Adress);
            this.Controls.Add(this.Title);
            this.Name = "AddEvent";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Country;
        private System.Windows.Forms.DateTimePicker dtDatePickerDate;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.Label capacity;
        private System.Windows.Forms.Label Adress;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox textCountry;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}