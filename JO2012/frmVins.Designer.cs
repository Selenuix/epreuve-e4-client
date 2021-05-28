namespace JO2012
{
    partial class frmVins
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
            this.TvNom = new System.Windows.Forms.TreeView();
            this.lblAnneeShow = new System.Windows.Forms.Label();
            this.lblCepageShow = new System.Windows.Forms.Label();
            this.lblNomShow = new System.Windows.Forms.Label();
            this.lblAnnee = new System.Windows.Forms.Label();
            this.lblCepage = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPaysShow = new System.Windows.Forms.Label();
            this.lblPays = new System.Windows.Forms.Label();
            this.lblRegionShow = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lblDescriptionShow = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TvNom
            // 
            this.TvNom.Location = new System.Drawing.Point(12, 12);
            this.TvNom.Name = "TvNom";
            this.TvNom.Size = new System.Drawing.Size(227, 426);
            this.TvNom.TabIndex = 1;
            this.TvNom.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TvNom_AfterSelect);
            // 
            // lblAnneeShow
            // 
            this.lblAnneeShow.AutoSize = true;
            this.lblAnneeShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAnneeShow.Location = new System.Drawing.Point(377, 71);
            this.lblAnneeShow.Name = "lblAnneeShow";
            this.lblAnneeShow.Size = new System.Drawing.Size(37, 15);
            this.lblAnneeShow.TabIndex = 8;
            this.lblAnneeShow.Text = "label2";
            // 
            // lblCepageShow
            // 
            this.lblCepageShow.AutoSize = true;
            this.lblCepageShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCepageShow.Location = new System.Drawing.Point(440, 71);
            this.lblCepageShow.Name = "lblCepageShow";
            this.lblCepageShow.Size = new System.Drawing.Size(37, 15);
            this.lblCepageShow.TabIndex = 7;
            this.lblCepageShow.Text = "label3";
            // 
            // lblNomShow
            // 
            this.lblNomShow.AutoSize = true;
            this.lblNomShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNomShow.Location = new System.Drawing.Point(304, 71);
            this.lblNomShow.Name = "lblNomShow";
            this.lblNomShow.Size = new System.Drawing.Size(37, 15);
            this.lblNomShow.TabIndex = 6;
            this.lblNomShow.Text = "label1";
            // 
            // lblAnnee
            // 
            this.lblAnnee.AutoSize = true;
            this.lblAnnee.Location = new System.Drawing.Point(374, 48);
            this.lblAnnee.Name = "lblAnnee";
            this.lblAnnee.Size = new System.Drawing.Size(38, 13);
            this.lblAnnee.TabIndex = 5;
            this.lblAnnee.Text = "Annee";
            this.lblAnnee.Click += new System.EventHandler(this.lblPays_Click);
            // 
            // lblCepage
            // 
            this.lblCepage.AutoSize = true;
            this.lblCepage.Location = new System.Drawing.Point(437, 48);
            this.lblCepage.Name = "lblCepage";
            this.lblCepage.Size = new System.Drawing.Size(44, 13);
            this.lblCepage.TabIndex = 4;
            this.lblCepage.Text = "Cepage";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(302, 48);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 3;
            this.lblNom.Text = "Nom";
            // 
            // lblPaysShow
            // 
            this.lblPaysShow.AutoSize = true;
            this.lblPaysShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPaysShow.Location = new System.Drawing.Point(490, 71);
            this.lblPaysShow.Name = "lblPaysShow";
            this.lblPaysShow.Size = new System.Drawing.Size(37, 15);
            this.lblPaysShow.TabIndex = 10;
            this.lblPaysShow.Text = "label4";
            // 
            // lblPays
            // 
            this.lblPays.AutoSize = true;
            this.lblPays.Location = new System.Drawing.Point(487, 48);
            this.lblPays.Name = "lblPays";
            this.lblPays.Size = new System.Drawing.Size(30, 13);
            this.lblPays.TabIndex = 9;
            this.lblPays.Text = "Pays";
            // 
            // lblRegionShow
            // 
            this.lblRegionShow.AutoSize = true;
            this.lblRegionShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegionShow.Location = new System.Drawing.Point(553, 71);
            this.lblRegionShow.Name = "lblRegionShow";
            this.lblRegionShow.Size = new System.Drawing.Size(37, 15);
            this.lblRegionShow.TabIndex = 12;
            this.lblRegionShow.Text = "label5";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(550, 48);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(41, 13);
            this.lblRegion.TabIndex = 11;
            this.lblRegion.Text = "Region";
            // 
            // lblDescriptionShow
            // 
            this.lblDescriptionShow.AutoSize = true;
            this.lblDescriptionShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescriptionShow.Location = new System.Drawing.Point(305, 136);
            this.lblDescriptionShow.Name = "lblDescriptionShow";
            this.lblDescriptionShow.Size = new System.Drawing.Size(37, 15);
            this.lblDescriptionShow.TabIndex = 14;
            this.lblDescriptionShow.Text = "label6";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(302, 113);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 13;
            this.lblDescription.Text = "Description";
            // 
            // frmVins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 450);
            this.Controls.Add(this.lblDescriptionShow);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblRegionShow);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.lblPaysShow);
            this.Controls.Add(this.lblPays);
            this.Controls.Add(this.lblAnneeShow);
            this.Controls.Add(this.TvNom);
            this.Controls.Add(this.lblCepageShow);
            this.Controls.Add(this.lblNomShow);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblAnnee);
            this.Controls.Add(this.lblCepage);
            this.Name = "frmVins";
            this.Text = "frmVins";
            this.Load += new System.EventHandler(this.frmAthletes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView TvNom;
        private System.Windows.Forms.Label lblCepage;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblAnnee;
        private System.Windows.Forms.Label lblAnneeShow;
        private System.Windows.Forms.Label lblCepageShow;
        private System.Windows.Forms.Label lblNomShow;
        private System.Windows.Forms.Label lblPaysShow;
        private System.Windows.Forms.Label lblPays;
        private System.Windows.Forms.Label lblRegionShow;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Label lblDescriptionShow;
        private System.Windows.Forms.Label lblDescription;
    }
}