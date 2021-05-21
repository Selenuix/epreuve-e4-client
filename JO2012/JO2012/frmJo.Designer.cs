namespace JO2012
{
    partial class FrmTest
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
            this.btnConnecter = new System.Windows.Forms.Button();
            this.btnNbreAthlete = new System.Windows.Forms.Button();
            this.btSportLePlusRecent = new System.Windows.Forms.Button();
            this.btnSuperAthlete = new System.Windows.Forms.Button();
            this.btnLesAthletes = new System.Windows.Forms.Button();
            this.btnFermerConnectionSql = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnecter
            // 
            this.btnConnecter.Location = new System.Drawing.Point(71, 12);
            this.btnConnecter.Name = "btnConnecter";
            this.btnConnecter.Size = new System.Drawing.Size(101, 42);
            this.btnConnecter.TabIndex = 0;
            this.btnConnecter.Text = "Connexion à la base de données";
            this.btnConnecter.UseVisualStyleBackColor = true;
            this.btnConnecter.Click += new System.EventHandler(this.btnConnecter_Click);
            // 
            // btnNbreAthlete
            // 
            this.btnNbreAthlete.Location = new System.Drawing.Point(71, 60);
            this.btnNbreAthlete.Name = "btnNbreAthlete";
            this.btnNbreAthlete.Size = new System.Drawing.Size(101, 42);
            this.btnNbreAthlete.TabIndex = 1;
            this.btnNbreAthlete.Text = "Afficher le nombre d\'athlètes";
            this.btnNbreAthlete.UseVisualStyleBackColor = true;
            this.btnNbreAthlete.Click += new System.EventHandler(this.button2_Click);
            // 
            // btSportLePlusRecent
            // 
            this.btSportLePlusRecent.Location = new System.Drawing.Point(71, 108);
            this.btSportLePlusRecent.Name = "btSportLePlusRecent";
            this.btSportLePlusRecent.Size = new System.Drawing.Size(101, 50);
            this.btSportLePlusRecent.TabIndex = 2;
            this.btSportLePlusRecent.Text = "Date d\'entrée du sport le plus récent";
            this.btSportLePlusRecent.UseVisualStyleBackColor = true;
            this.btSportLePlusRecent.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSuperAthlete
            // 
            this.btnSuperAthlete.Location = new System.Drawing.Point(71, 164);
            this.btnSuperAthlete.Name = "btnSuperAthlete";
            this.btnSuperAthlete.Size = new System.Drawing.Size(101, 50);
            this.btnSuperAthlete.TabIndex = 3;
            this.btnSuperAthlete.Text = "Je suis un super athlète";
            this.btnSuperAthlete.UseVisualStyleBackColor = true;
            this.btnSuperAthlete.Click += new System.EventHandler(this.btnSuperAthlete_Click);
            // 
            // btnLesAthletes
            // 
            this.btnLesAthletes.Location = new System.Drawing.Point(71, 220);
            this.btnLesAthletes.Name = "btnLesAthletes";
            this.btnLesAthletes.Size = new System.Drawing.Size(101, 50);
            this.btnLesAthletes.TabIndex = 4;
            this.btnLesAthletes.Text = "Les athlètes";
            this.btnLesAthletes.UseVisualStyleBackColor = true;
            this.btnLesAthletes.Click += new System.EventHandler(this.btnLesAthletes_Click);
            // 
            // btnFermerConnectionSql
            // 
            this.btnFermerConnectionSql.Location = new System.Drawing.Point(71, 276);
            this.btnFermerConnectionSql.Name = "btnFermerConnectionSql";
            this.btnFermerConnectionSql.Size = new System.Drawing.Size(101, 50);
            this.btnFermerConnectionSql.TabIndex = 5;
            this.btnFermerConnectionSql.Text = "Fermer la connection";
            this.btnFermerConnectionSql.UseVisualStyleBackColor = true;
            this.btnFermerConnectionSql.Click += new System.EventHandler(this.btnFermerConnectionSql_Click);
            // 
            // FrmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 342);
            this.Controls.Add(this.btnFermerConnectionSql);
            this.Controls.Add(this.btnLesAthletes);
            this.Controls.Add(this.btnSuperAthlete);
            this.Controls.Add(this.btSportLePlusRecent);
            this.Controls.Add(this.btnNbreAthlete);
            this.Controls.Add(this.btnConnecter);
            this.Name = "FrmTest";
            this.Text = "Base De Données";
            this.Load += new System.EventHandler(this.FrmTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnecter;
        private System.Windows.Forms.Button btnNbreAthlete;
        private System.Windows.Forms.Button btSportLePlusRecent;
        private System.Windows.Forms.Button btnSuperAthlete;
        private System.Windows.Forms.Button btnLesAthletes;
        private System.Windows.Forms.Button btnFermerConnectionSql;
    }
}

