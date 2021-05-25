namespace JO2012
{
    partial class frmAthletes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAthletes));
            this.lblNbrAthletes = new System.Windows.Forms.Label();
            this.TvNom = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.imageDrapeau = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPaysShow = new System.Windows.Forms.Label();
            this.lblPrenomShow = new System.Windows.Forms.Label();
            this.lblNomShow = new System.Windows.Forms.Label();
            this.lblPays = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageDrapeau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNbrAthletes
            // 
            this.lblNbrAthletes.AutoSize = true;
            this.lblNbrAthletes.Location = new System.Drawing.Point(12, 9);
            this.lblNbrAthletes.Name = "lblNbrAthletes";
            this.lblNbrAthletes.Size = new System.Drawing.Size(35, 13);
            this.lblNbrAthletes.TabIndex = 0;
            this.lblNbrAthletes.Text = "label1";
            // 
            // TvNom
            // 
            this.TvNom.ImageIndex = 0;
            this.TvNom.ImageList = this.imageList1;
            this.TvNom.Location = new System.Drawing.Point(12, 43);
            this.TvNom.Name = "TvNom";
            this.TvNom.SelectedImageIndex = 1;
            this.TvNom.Size = new System.Drawing.Size(227, 395);
            this.TvNom.TabIndex = 1;
            this.TvNom.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TvNom_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "BOOK01A.ICO");
            this.imageList1.Images.SetKeyName(1, "BOOK02.ICO");
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(301, 172);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(451, 266);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.imageDrapeau);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.lblPaysShow);
            this.tabPage1.Controls.Add(this.lblPrenomShow);
            this.tabPage1.Controls.Add(this.lblNomShow);
            this.tabPage1.Controls.Add(this.lblPays);
            this.tabPage1.Controls.Add(this.lblPrenom);
            this.tabPage1.Controls.Add(this.lblNom);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(443, 240);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Athlète";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // imageDrapeau
            // 
            this.imageDrapeau.Location = new System.Drawing.Point(27, 172);
            this.imageDrapeau.Name = "imageDrapeau";
            this.imageDrapeau.Size = new System.Drawing.Size(71, 49);
            this.imageDrapeau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageDrapeau.TabIndex = 9;
            this.imageDrapeau.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(214, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblPaysShow
            // 
            this.lblPaysShow.AutoSize = true;
            this.lblPaysShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPaysShow.Location = new System.Drawing.Point(26, 138);
            this.lblPaysShow.Name = "lblPaysShow";
            this.lblPaysShow.Size = new System.Drawing.Size(37, 15);
            this.lblPaysShow.TabIndex = 8;
            this.lblPaysShow.Text = "label3";
            // 
            // lblPrenomShow
            // 
            this.lblPrenomShow.AutoSize = true;
            this.lblPrenomShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrenomShow.Location = new System.Drawing.Point(244, 43);
            this.lblPrenomShow.Name = "lblPrenomShow";
            this.lblPrenomShow.Size = new System.Drawing.Size(37, 15);
            this.lblPrenomShow.TabIndex = 7;
            this.lblPrenomShow.Text = "label2";
            // 
            // lblNomShow
            // 
            this.lblNomShow.AutoSize = true;
            this.lblNomShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNomShow.Location = new System.Drawing.Point(26, 43);
            this.lblNomShow.Name = "lblNomShow";
            this.lblNomShow.Size = new System.Drawing.Size(37, 15);
            this.lblNomShow.TabIndex = 6;
            this.lblNomShow.Text = "label1";
            // 
            // lblPays
            // 
            this.lblPays.AutoSize = true;
            this.lblPays.Location = new System.Drawing.Point(24, 113);
            this.lblPays.Name = "lblPays";
            this.lblPays.Size = new System.Drawing.Size(30, 13);
            this.lblPays.TabIndex = 5;
            this.lblPays.Text = "Pays";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(241, 20);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblPrenom.TabIndex = 4;
            this.lblPrenom.Text = "Prénom";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(24, 20);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 3;
            this.lblNom.Text = "Nom";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(443, 240);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sports Pratiqués";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(56, 53);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(338, 159);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // frmAthletes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.TvNom);
            this.Controls.Add(this.lblNbrAthletes);
            this.Name = "frmAthletes";
            this.Text = "frmAthletes";
            this.Load += new System.EventHandler(this.frmAthletes_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageDrapeau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNbrAthletes;
        private System.Windows.Forms.TreeView TvNom;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPays;
        private System.Windows.Forms.Label lblPaysShow;
        private System.Windows.Forms.Label lblPrenomShow;
        private System.Windows.Forms.Label lblNomShow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox imageDrapeau;
        private System.Windows.Forms.ListView listView1;
    }
}