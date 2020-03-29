namespace CsharpB2
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Logged = new System.Windows.Forms.Label();
            this.lvEvennement = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // Logged
            // 
            this.Logged.AutoSize = true;
            this.Logged.Location = new System.Drawing.Point(769, 465);
            this.Logged.Name = "Logged";
            this.Logged.Size = new System.Drawing.Size(0, 13);
            this.Logged.TabIndex = 6;
            // 
            // lvEvennement
            // 
            this.lvEvennement.FullRowSelect = true;
            this.lvEvennement.GridLines = true;
            this.lvEvennement.HideSelection = false;
            this.lvEvennement.Location = new System.Drawing.Point(8, 8);
            this.lvEvennement.Name = "lvEvennement";
            this.lvEvennement.Size = new System.Drawing.Size(800, 219);
            this.lvEvennement.TabIndex = 9;
            this.lvEvennement.UseCompatibleStateImageBehavior = false;
            this.lvEvennement.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 516);
            this.Controls.Add(this.lvEvennement);
            this.Controls.Add(this.Logged);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Logged;
        private System.Windows.Forms.ListView lvEvennement;
    }
}

