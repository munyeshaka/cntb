namespace View
{
    partial class ucResident
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tcni = new System.Windows.Forms.TextBox();
            this.rFemme = new System.Windows.Forms.RadioButton();
            this.coNationnalite = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tprenom = new System.Windows.Forms.TextBox();
            this.tnom = new System.Windows.Forms.TextBox();
            this.rHomme = new System.Windows.Forms.RadioButton();
            this.gGenre = new System.Windows.Forms.GroupBox();
            this.gEtatCivil = new System.Windows.Forms.GroupBox();
            this.rDivorce = new System.Windows.Forms.RadioButton();
            this.rVeuf = new System.Windows.Forms.RadioButton();
            this.rMarie = new System.Windows.Forms.RadioButton();
            this.rCelibataire = new System.Windows.Forms.RadioButton();
            this.tLieuNaissance = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.tRechercher = new System.Windows.Forms.TextBox();
            this.tdateNaissance = new System.Windows.Forms.DateTimePicker();
            this.dgvResident = new System.Windows.Forms.DataGridView();
            this.btnActualiser = new System.Windows.Forms.Button();
            this.gGenre.SuspendLayout();
            this.gEtatCivil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResident)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "cni";
            // 
            // tcni
            // 
            this.tcni.Enabled = false;
            this.tcni.Location = new System.Drawing.Point(162, 115);
            this.tcni.Name = "tcni";
            this.tcni.Size = new System.Drawing.Size(173, 20);
            this.tcni.TabIndex = 1;
            // 
            // rFemme
            // 
            this.rFemme.AutoSize = true;
            this.rFemme.Location = new System.Drawing.Point(6, 28);
            this.rFemme.Name = "rFemme";
            this.rFemme.Size = new System.Drawing.Size(59, 17);
            this.rFemme.TabIndex = 2;
            this.rFemme.TabStop = true;
            this.rFemme.Text = "Femme";
            this.rFemme.UseVisualStyleBackColor = true;
            // 
            // coNationnalite
            // 
            this.coNationnalite.FormattingEnabled = true;
            this.coNationnalite.Items.AddRange(new object[] {
            "Burundaise",
            "Francaise",
            "Kenyane",
            "Zairoise",
            "Chinoise"});
            this.coNationnalite.Location = new System.Drawing.Point(824, 107);
            this.coNationnalite.Name = "coNationnalite";
            this.coNationnalite.Size = new System.Drawing.Size(198, 21);
            this.coNationnalite.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(725, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nationnalite";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(725, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Date de naissance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(725, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Lieu de naissance";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(442, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "RESIDENTS";
            // 
            // tprenom
            // 
            this.tprenom.Location = new System.Drawing.Point(162, 186);
            this.tprenom.Name = "tprenom";
            this.tprenom.Size = new System.Drawing.Size(173, 20);
            this.tprenom.TabIndex = 11;
            // 
            // tnom
            // 
            this.tnom.Location = new System.Drawing.Point(162, 150);
            this.tnom.Name = "tnom";
            this.tnom.Size = new System.Drawing.Size(173, 20);
            this.tnom.TabIndex = 12;
            // 
            // rHomme
            // 
            this.rHomme.AutoSize = true;
            this.rHomme.Location = new System.Drawing.Point(6, 51);
            this.rHomme.Name = "rHomme";
            this.rHomme.Size = new System.Drawing.Size(61, 17);
            this.rHomme.TabIndex = 13;
            this.rHomme.TabStop = true;
            this.rHomme.Text = "Homme";
            this.rHomme.UseVisualStyleBackColor = true;
            // 
            // gGenre
            // 
            this.gGenre.Controls.Add(this.rFemme);
            this.gGenre.Controls.Add(this.rHomme);
            this.gGenre.Location = new System.Drawing.Point(376, 107);
            this.gGenre.Name = "gGenre";
            this.gGenre.Size = new System.Drawing.Size(113, 100);
            this.gGenre.TabIndex = 14;
            this.gGenre.TabStop = false;
            this.gGenre.Text = "Genre";
            // 
            // gEtatCivil
            // 
            this.gEtatCivil.Controls.Add(this.rDivorce);
            this.gEtatCivil.Controls.Add(this.rVeuf);
            this.gEtatCivil.Controls.Add(this.rMarie);
            this.gEtatCivil.Controls.Add(this.rCelibataire);
            this.gEtatCivil.Location = new System.Drawing.Point(508, 107);
            this.gEtatCivil.Name = "gEtatCivil";
            this.gEtatCivil.Size = new System.Drawing.Size(200, 100);
            this.gEtatCivil.TabIndex = 15;
            this.gEtatCivil.TabStop = false;
            this.gEtatCivil.Text = "Etat  civil";
            // 
            // rDivorce
            // 
            this.rDivorce.AutoSize = true;
            this.rDivorce.Location = new System.Drawing.Point(109, 55);
            this.rDivorce.Name = "rDivorce";
            this.rDivorce.Size = new System.Drawing.Size(62, 17);
            this.rDivorce.TabIndex = 17;
            this.rDivorce.TabStop = true;
            this.rDivorce.Text = "Divorce";
            this.rDivorce.UseVisualStyleBackColor = true;
            // 
            // rVeuf
            // 
            this.rVeuf.AutoSize = true;
            this.rVeuf.Location = new System.Drawing.Point(109, 28);
            this.rVeuf.Name = "rVeuf";
            this.rVeuf.Size = new System.Drawing.Size(47, 17);
            this.rVeuf.TabIndex = 16;
            this.rVeuf.TabStop = true;
            this.rVeuf.Text = "Veuf";
            this.rVeuf.UseVisualStyleBackColor = true;
            // 
            // rMarie
            // 
            this.rMarie.AutoSize = true;
            this.rMarie.Location = new System.Drawing.Point(9, 56);
            this.rMarie.Name = "rMarie";
            this.rMarie.Size = new System.Drawing.Size(51, 17);
            this.rMarie.TabIndex = 15;
            this.rMarie.TabStop = true;
            this.rMarie.Text = "Marie";
            this.rMarie.UseVisualStyleBackColor = true;
            // 
            // rCelibataire
            // 
            this.rCelibataire.AutoSize = true;
            this.rCelibataire.Location = new System.Drawing.Point(9, 28);
            this.rCelibataire.Name = "rCelibataire";
            this.rCelibataire.Size = new System.Drawing.Size(74, 17);
            this.rCelibataire.TabIndex = 14;
            this.rCelibataire.TabStop = true;
            this.rCelibataire.Text = "Celibataire";
            this.rCelibataire.UseVisualStyleBackColor = true;
            // 
            // tLieuNaissance
            // 
            this.tLieuNaissance.Location = new System.Drawing.Point(824, 183);
            this.tLieuNaissance.Name = "tLieuNaissance";
            this.tLieuNaissance.Size = new System.Drawing.Size(198, 20);
            this.tLieuNaissance.TabIndex = 17;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(162, 265);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 19;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(260, 265);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 20;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(356, 265);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 21;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(824, 263);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(75, 23);
            this.btnRechercher.TabIndex = 23;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // tRechercher
            // 
            this.tRechercher.Location = new System.Drawing.Point(922, 266);
            this.tRechercher.Name = "tRechercher";
            this.tRechercher.Size = new System.Drawing.Size(100, 20);
            this.tRechercher.TabIndex = 24;
            // 
            // tdateNaissance
            // 
            this.tdateNaissance.Location = new System.Drawing.Point(824, 144);
            this.tdateNaissance.Name = "tdateNaissance";
            this.tdateNaissance.Size = new System.Drawing.Size(198, 20);
            this.tdateNaissance.TabIndex = 25;
            // 
            // dgvResident
            // 
            this.dgvResident.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResident.Location = new System.Drawing.Point(162, 314);
            this.dgvResident.Name = "dgvResident";
            this.dgvResident.Size = new System.Drawing.Size(860, 257);
            this.dgvResident.TabIndex = 26;
            // 
            // btnActualiser
            // 
            this.btnActualiser.Location = new System.Drawing.Point(454, 265);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(75, 23);
            this.btnActualiser.TabIndex = 22;
            this.btnActualiser.Text = "Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = true;
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            // 
            // ucResident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvResident);
            this.Controls.Add(this.tdateNaissance);
            this.Controls.Add(this.tRechercher);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.btnActualiser);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.tLieuNaissance);
            this.Controls.Add(this.gEtatCivil);
            this.Controls.Add(this.gGenre);
            this.Controls.Add(this.tnom);
            this.Controls.Add(this.tprenom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.coNationnalite);
            this.Controls.Add(this.tcni);
            this.Controls.Add(this.label1);
            this.Name = "ucResident";
            this.Size = new System.Drawing.Size(1064, 586);
            this.Load += new System.EventHandler(this.ucResident_Load);
            this.gGenre.ResumeLayout(false);
            this.gGenre.PerformLayout();
            this.gEtatCivil.ResumeLayout(false);
            this.gEtatCivil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResident)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tcni;
        private System.Windows.Forms.RadioButton rFemme;
        private System.Windows.Forms.ComboBox coNationnalite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tprenom;
        private System.Windows.Forms.TextBox tnom;
        private System.Windows.Forms.RadioButton rHomme;
        private System.Windows.Forms.GroupBox gGenre;
        private System.Windows.Forms.GroupBox gEtatCivil;
        private System.Windows.Forms.RadioButton rDivorce;
        private System.Windows.Forms.RadioButton rVeuf;
        private System.Windows.Forms.RadioButton rMarie;
        private System.Windows.Forms.RadioButton rCelibataire;
        private System.Windows.Forms.TextBox tLieuNaissance;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.TextBox tRechercher;
        private System.Windows.Forms.DateTimePicker tdateNaissance;
        private System.Windows.Forms.DataGridView dgvResident;
        private System.Windows.Forms.Button btnActualiser;
    }
}
