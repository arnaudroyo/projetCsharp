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
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.lvEvennement2 = new System.Windows.Forms.ListView();
            this.All = new System.Windows.Forms.Label();
            this.My = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Logged
            // 
            this.Logged.AutoSize = true;
            this.Logged.Location = new System.Drawing.Point(692, 24);
            this.Logged.Name = "Logged";
            this.Logged.Size = new System.Drawing.Size(29, 13);
            this.Logged.TabIndex = 6;
            this.Logged.Text = "hello";
            // 
            // lvEvennement
            // 
            this.lvEvennement.FullRowSelect = true;
            this.lvEvennement.GridLines = true;
            this.lvEvennement.HideSelection = false;
            this.lvEvennement.Location = new System.Drawing.Point(12, 56);
            this.lvEvennement.Name = "lvEvennement";
            this.lvEvennement.Size = new System.Drawing.Size(800, 219);
            this.lvEvennement.TabIndex = 9;
            this.lvEvennement.UseCompatibleStateImageBehavior = false;
            this.lvEvennement.View = System.Windows.Forms.View.Details;
            this.lvEvennement.SelectedIndexChanged += new System.EventHandler(this.lvEvennement_DoubleClick);
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddEvent.Location = new System.Drawing.Point(672, 477);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(140, 36);
            this.btnAddEvent.TabIndex = 16;
            this.btnAddEvent.Text = "Create new event";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // lvEvennement2
            // 
            this.lvEvennement2.FullRowSelect = true;
            this.lvEvennement2.GridLines = true;
            this.lvEvennement2.HideSelection = false;
            this.lvEvennement2.Location = new System.Drawing.Point(12, 301);
            this.lvEvennement2.Name = "lvEvennement2";
            this.lvEvennement2.Size = new System.Drawing.Size(800, 170);
            this.lvEvennement2.TabIndex = 17;
            this.lvEvennement2.UseCompatibleStateImageBehavior = false;
            this.lvEvennement2.View = System.Windows.Forms.View.Details;
            this.lvEvennement2.SelectedIndexChanged += new System.EventHandler(this.lvEvennement2_DoubleClick);

            // 
            // All
            // 
            this.All.AutoSize = true;
            this.All.Location = new System.Drawing.Point(12, 40);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(74, 13);
            this.All.TabIndex = 18;
            this.All.Text = "All the events:";
            // 
            // My
            // 
            this.My.AutoSize = true;
            this.My.Location = new System.Drawing.Point(12, 285);
            this.My.Name = "My";
            this.My.Size = new System.Drawing.Size(59, 13);
            this.My.TabIndex = 19;
            this.My.Text = "My events:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 516);
            this.Controls.Add(this.My);
            this.Controls.Add(this.All);
            this.Controls.Add(this.lvEvennement2);
            this.Controls.Add(this.btnAddEvent);
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
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.ListView lvEvennement2;
        private System.Windows.Forms.Label All;
        private System.Windows.Forms.Label My;
    }
}

