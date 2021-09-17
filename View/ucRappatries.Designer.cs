namespace View
{
    partial class ucRappatries
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
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lblRap = new System.Windows.Forms.Label();
            this.lblIdR = new System.Windows.Forms.Label();
            this.lblNomR = new System.Windows.Forms.Label();
            this.lblPrenomR = new System.Windows.Forms.Label();
            this.gbGenre = new System.Windows.Forms.GroupBox();
            this.rbtnMasculin = new System.Windows.Forms.RadioButton();
            this.rbtnFeminin = new System.Windows.Forms.RadioButton();
            this.gbEC = new System.Windows.Forms.GroupBox();
            this.rbtnDivorce = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.rbtnMarie = new System.Windows.Forms.RadioButton();
            this.rbtnCelibataire = new System.Windows.Forms.RadioButton();
            this.lblNomPR = new System.Windows.Forms.Label();
            this.lblNomMR = new System.Windows.Forms.Label();
            this.lblLNR = new System.Windows.Forms.Label();
            this.lblNBE = new System.Windows.Forms.Label();
            this.lblProv = new System.Windows.Forms.Label();
            this.lblComm = new System.Windows.Forms.Label();
            this.lblDateR = new System.Windows.Forms.Label();
            this.tId = new System.Windows.Forms.TextBox();
            this.tNom = new System.Windows.Forms.TextBox();
            this.tPren = new System.Windows.Forms.TextBox();
            this.tNp = new System.Windows.Forms.TextBox();
            this.tNm = new System.Windows.Forms.TextBox();
            this.tLn = new System.Windows.Forms.TextBox();
            this.tnbe = new System.Windows.Forms.TextBox();
            this.cboPro = new System.Windows.Forms.ComboBox();
            this.cboCo = new System.Windows.Forms.ComboBox();
            this.dateTimePickerRa = new System.Windows.Forms.DateTimePicker();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnActualiser = new System.Windows.Forms.Button();
            this.btnReinitialiser = new System.Windows.Forms.Button();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.dgvRappatries = new System.Windows.Forms.DataGridView();
            this.zonerecherche = new System.Windows.Forms.ComboBox();
            this.gbGenre.SuspendLayout();
            this.gbEC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRappatries)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(122, 253);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // lblRap
            // 
            this.lblRap.AutoSize = true;
            this.lblRap.Location = new System.Drawing.Point(334, 24);
            this.lblRap.Name = "lblRap";
            this.lblRap.Size = new System.Drawing.Size(58, 13);
            this.lblRap.TabIndex = 1;
            this.lblRap.Text = "Rappatries";
            // 
            // lblIdR
            // 
            this.lblIdR.AutoSize = true;
            this.lblIdR.Location = new System.Drawing.Point(21, 73);
            this.lblIdR.Name = "lblIdR";
            this.lblIdR.Size = new System.Drawing.Size(53, 13);
            this.lblIdR.TabIndex = 2;
            this.lblIdR.Text = "Identifiant";
            // 
            // lblNomR
            // 
            this.lblNomR.AutoSize = true;
            this.lblNomR.Location = new System.Drawing.Point(21, 102);
            this.lblNomR.Name = "lblNomR";
            this.lblNomR.Size = new System.Drawing.Size(29, 13);
            this.lblNomR.TabIndex = 3;
            this.lblNomR.Text = "Nom";
            // 
            // lblPrenomR
            // 
            this.lblPrenomR.AutoSize = true;
            this.lblPrenomR.Location = new System.Drawing.Point(21, 137);
            this.lblPrenomR.Name = "lblPrenomR";
            this.lblPrenomR.Size = new System.Drawing.Size(43, 13);
            this.lblPrenomR.TabIndex = 4;
            this.lblPrenomR.Text = "Prenom";
            // 
            // gbGenre
            // 
            this.gbGenre.Controls.Add(this.rbtnMasculin);
            this.gbGenre.Controls.Add(this.rbtnFeminin);
            this.gbGenre.Location = new System.Drawing.Point(319, 66);
            this.gbGenre.Name = "gbGenre";
            this.gbGenre.Size = new System.Drawing.Size(113, 139);
            this.gbGenre.TabIndex = 5;
            this.gbGenre.TabStop = false;
            this.gbGenre.Text = "Genre";
            // 
            // rbtnMasculin
            // 
            this.rbtnMasculin.AutoSize = true;
            this.rbtnMasculin.Location = new System.Drawing.Point(6, 62);
            this.rbtnMasculin.Name = "rbtnMasculin";
            this.rbtnMasculin.Size = new System.Drawing.Size(67, 17);
            this.rbtnMasculin.TabIndex = 1;
            this.rbtnMasculin.TabStop = true;
            this.rbtnMasculin.Text = "Masculin";
            this.rbtnMasculin.UseVisualStyleBackColor = true;
            // 
            // rbtnFeminin
            // 
            this.rbtnFeminin.AutoSize = true;
            this.rbtnFeminin.Location = new System.Drawing.Point(6, 29);
            this.rbtnFeminin.Name = "rbtnFeminin";
            this.rbtnFeminin.Size = new System.Drawing.Size(61, 17);
            this.rbtnFeminin.TabIndex = 0;
            this.rbtnFeminin.TabStop = true;
            this.rbtnFeminin.Text = "Feminin";
            this.rbtnFeminin.UseVisualStyleBackColor = true;
            // 
            // gbEC
            // 
            this.gbEC.Controls.Add(this.rbtnDivorce);
            this.gbEC.Controls.Add(this.radioButton5);
            this.gbEC.Controls.Add(this.rbtnMarie);
            this.gbEC.Controls.Add(this.rbtnCelibataire);
            this.gbEC.Location = new System.Drawing.Point(438, 66);
            this.gbEC.Name = "gbEC";
            this.gbEC.Size = new System.Drawing.Size(203, 139);
            this.gbEC.TabIndex = 6;
            this.gbEC.TabStop = false;
            this.gbEC.Text = "Etat-Civil";
            // 
            // rbtnDivorce
            // 
            this.rbtnDivorce.AutoSize = true;
            this.rbtnDivorce.Location = new System.Drawing.Point(112, 62);
            this.rbtnDivorce.Name = "rbtnDivorce";
            this.rbtnDivorce.Size = new System.Drawing.Size(62, 17);
            this.rbtnDivorce.TabIndex = 5;
            this.rbtnDivorce.TabStop = true;
            this.rbtnDivorce.Text = "Divorcé";
            this.rbtnDivorce.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(112, 25);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(47, 17);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Veuf";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // rbtnMarie
            // 
            this.rbtnMarie.AutoSize = true;
            this.rbtnMarie.Location = new System.Drawing.Point(6, 62);
            this.rbtnMarie.Name = "rbtnMarie";
            this.rbtnMarie.Size = new System.Drawing.Size(51, 17);
            this.rbtnMarie.TabIndex = 3;
            this.rbtnMarie.TabStop = true;
            this.rbtnMarie.Text = "Marié";
            this.rbtnMarie.UseVisualStyleBackColor = true;
            // 
            // rbtnCelibataire
            // 
            this.rbtnCelibataire.AutoSize = true;
            this.rbtnCelibataire.Location = new System.Drawing.Point(6, 25);
            this.rbtnCelibataire.Name = "rbtnCelibataire";
            this.rbtnCelibataire.Size = new System.Drawing.Size(74, 17);
            this.rbtnCelibataire.TabIndex = 2;
            this.rbtnCelibataire.TabStop = true;
            this.rbtnCelibataire.Text = "Celibataire";
            this.rbtnCelibataire.UseVisualStyleBackColor = true;
            // 
            // lblNomPR
            // 
            this.lblNomPR.AutoSize = true;
            this.lblNomPR.Location = new System.Drawing.Point(21, 172);
            this.lblNomPR.Name = "lblNomPR";
            this.lblNomPR.Size = new System.Drawing.Size(69, 13);
            this.lblNomPR.TabIndex = 7;
            this.lblNomPR.Text = "Nom du Père";
            // 
            // lblNomMR
            // 
            this.lblNomMR.AutoSize = true;
            this.lblNomMR.Location = new System.Drawing.Point(21, 199);
            this.lblNomMR.Name = "lblNomMR";
            this.lblNomMR.Size = new System.Drawing.Size(81, 13);
            this.lblNomMR.TabIndex = 8;
            this.lblNomMR.Text = "Nom de la mère";
            this.lblNomMR.Click += new System.EventHandler(this.lblNomMR_Click);
            // 
            // lblLNR
            // 
            this.lblLNR.AutoSize = true;
            this.lblLNR.Location = new System.Drawing.Point(647, 66);
            this.lblLNR.Name = "lblLNR";
            this.lblLNR.Size = new System.Drawing.Size(93, 13);
            this.lblLNR.TabIndex = 9;
            this.lblLNR.Text = "Lieu de naissance";
            // 
            // lblNBE
            // 
            this.lblNBE.AutoSize = true;
            this.lblNBE.Location = new System.Drawing.Point(647, 96);
            this.lblNBE.Name = "lblNBE";
            this.lblNBE.Size = new System.Drawing.Size(93, 13);
            this.lblNBE.TabIndex = 10;
            this.lblNBE.Text = "Nombre d\'enfants ";
            // 
            // lblProv
            // 
            this.lblProv.AutoSize = true;
            this.lblProv.Location = new System.Drawing.Point(647, 125);
            this.lblProv.Name = "lblProv";
            this.lblProv.Size = new System.Drawing.Size(49, 13);
            this.lblProv.TabIndex = 11;
            this.lblProv.Text = "Province";
            // 
            // lblComm
            // 
            this.lblComm.AutoSize = true;
            this.lblComm.Location = new System.Drawing.Point(647, 152);
            this.lblComm.Name = "lblComm";
            this.lblComm.Size = new System.Drawing.Size(54, 13);
            this.lblComm.TabIndex = 12;
            this.lblComm.Text = "Commune";
            // 
            // lblDateR
            // 
            this.lblDateR.AutoSize = true;
            this.lblDateR.Location = new System.Drawing.Point(647, 182);
            this.lblDateR.Name = "lblDateR";
            this.lblDateR.Size = new System.Drawing.Size(75, 13);
            this.lblDateR.TabIndex = 13;
            this.lblDateR.Text = "Date de retour";
            // 
            // tId
            // 
            this.tId.Location = new System.Drawing.Point(122, 66);
            this.tId.Name = "tId";
            this.tId.Size = new System.Drawing.Size(191, 20);
            this.tId.TabIndex = 14;
            // 
            // tNom
            // 
            this.tNom.Location = new System.Drawing.Point(122, 99);
            this.tNom.Name = "tNom";
            this.tNom.Size = new System.Drawing.Size(191, 20);
            this.tNom.TabIndex = 15;
            // 
            // tPren
            // 
            this.tPren.Location = new System.Drawing.Point(122, 131);
            this.tPren.Name = "tPren";
            this.tPren.Size = new System.Drawing.Size(191, 20);
            this.tPren.TabIndex = 16;
            // 
            // tNp
            // 
            this.tNp.Location = new System.Drawing.Point(122, 162);
            this.tNp.Name = "tNp";
            this.tNp.Size = new System.Drawing.Size(191, 20);
            this.tNp.TabIndex = 17;
            // 
            // tNm
            // 
            this.tNm.Location = new System.Drawing.Point(122, 192);
            this.tNm.Name = "tNm";
            this.tNm.Size = new System.Drawing.Size(191, 20);
            this.tNm.TabIndex = 18;
            // 
            // tLn
            // 
            this.tLn.Location = new System.Drawing.Point(790, 66);
            this.tLn.Name = "tLn";
            this.tLn.Size = new System.Drawing.Size(200, 20);
            this.tLn.TabIndex = 19;
            // 
            // tnbe
            // 
            this.tnbe.Location = new System.Drawing.Point(790, 96);
            this.tnbe.Name = "tnbe";
            this.tnbe.Size = new System.Drawing.Size(200, 20);
            this.tnbe.TabIndex = 20;
            // 
            // cboPro
            // 
            this.cboPro.FormattingEnabled = true;
            this.cboPro.Items.AddRange(new object[] {
            "Bubanza",
            "Bujumbura",
            "Bururi",
            "Cankuzo",
            "Cibitoke",
            "Gitega",
            "Karusi",
            "Kayanza",
            "Muramvya",
            "Mwaro",
            "Ngozi",
            "Ruyigi",
            ""});
            this.cboPro.Location = new System.Drawing.Point(790, 122);
            this.cboPro.Name = "cboPro";
            this.cboPro.Size = new System.Drawing.Size(200, 21);
            this.cboPro.TabIndex = 21;
            // 
            // cboCo
            // 
            this.cboCo.FormattingEnabled = true;
            this.cboCo.Items.AddRange(new object[] {
            "Muha",
            "Mukaza",
            "Ntahangwa",
            "Kayokwe",
            "Rutovu",
            "Kibuye",
            "Mbuye"});
            this.cboCo.Location = new System.Drawing.Point(790, 149);
            this.cboCo.Name = "cboCo";
            this.cboCo.Size = new System.Drawing.Size(200, 21);
            this.cboCo.TabIndex = 22;
            // 
            // dateTimePickerRa
            // 
            this.dateTimePickerRa.Location = new System.Drawing.Point(790, 176);
            this.dateTimePickerRa.Name = "dateTimePickerRa";
            this.dateTimePickerRa.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerRa.TabIndex = 23;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(203, 253);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 24;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(284, 253);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 25;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnActualiser
            // 
            this.btnActualiser.Location = new System.Drawing.Point(365, 253);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(75, 23);
            this.btnActualiser.TabIndex = 26;
            this.btnActualiser.Text = "Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = true;
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            // 
            // btnReinitialiser
            // 
            this.btnReinitialiser.Location = new System.Drawing.Point(446, 253);
            this.btnReinitialiser.Name = "btnReinitialiser";
            this.btnReinitialiser.Size = new System.Drawing.Size(75, 23);
            this.btnReinitialiser.TabIndex = 27;
            this.btnReinitialiser.Text = "Reinitialiser";
            this.btnReinitialiser.UseVisualStyleBackColor = true;
            this.btnReinitialiser.Click += new System.EventHandler(this.btnReinitialiser_Click);
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(650, 250);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(75, 23);
            this.btnRechercher.TabIndex = 28;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // dgvRappatries
            // 
            this.dgvRappatries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRappatries.Location = new System.Drawing.Point(24, 309);
            this.dgvRappatries.Name = "dgvRappatries";
            this.dgvRappatries.Size = new System.Drawing.Size(966, 210);
            this.dgvRappatries.TabIndex = 30;
            // 
            // zonerecherche
            // 
            this.zonerecherche.FormattingEnabled = true;
            this.zonerecherche.Location = new System.Drawing.Point(790, 253);
            this.zonerecherche.Name = "zonerecherche";
            this.zonerecherche.Size = new System.Drawing.Size(121, 21);
            this.zonerecherche.TabIndex = 31;
            this.zonerecherche.SelectedIndexChanged += new System.EventHandler(this.zonerecherche_SelectedIndexChanged);
            // 
            // ucRappatries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.zonerecherche);
            this.Controls.Add(this.dgvRappatries);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.btnReinitialiser);
            this.Controls.Add(this.btnActualiser);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.dateTimePickerRa);
            this.Controls.Add(this.cboCo);
            this.Controls.Add(this.cboPro);
            this.Controls.Add(this.tnbe);
            this.Controls.Add(this.tLn);
            this.Controls.Add(this.tNm);
            this.Controls.Add(this.tNp);
            this.Controls.Add(this.tPren);
            this.Controls.Add(this.tNom);
            this.Controls.Add(this.tId);
            this.Controls.Add(this.lblDateR);
            this.Controls.Add(this.lblComm);
            this.Controls.Add(this.lblProv);
            this.Controls.Add(this.lblNBE);
            this.Controls.Add(this.lblLNR);
            this.Controls.Add(this.lblNomMR);
            this.Controls.Add(this.lblNomPR);
            this.Controls.Add(this.gbEC);
            this.Controls.Add(this.gbGenre);
            this.Controls.Add(this.lblPrenomR);
            this.Controls.Add(this.lblNomR);
            this.Controls.Add(this.lblIdR);
            this.Controls.Add(this.lblRap);
            this.Controls.Add(this.btnAjouter);
            this.Name = "ucRappatries";
            this.Size = new System.Drawing.Size(1005, 560);
            this.Load += new System.EventHandler(this.ucRappatries_Load);
            this.gbGenre.ResumeLayout(false);
            this.gbGenre.PerformLayout();
            this.gbEC.ResumeLayout(false);
            this.gbEC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRappatries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label lblRap;
        private System.Windows.Forms.Label lblIdR;
        private System.Windows.Forms.Label lblNomR;
        private System.Windows.Forms.Label lblPrenomR;
        private System.Windows.Forms.GroupBox gbGenre;
        private System.Windows.Forms.GroupBox gbEC;
        private System.Windows.Forms.Label lblNomPR;
        private System.Windows.Forms.Label lblNomMR;
        private System.Windows.Forms.Label lblLNR;
        private System.Windows.Forms.Label lblNBE;
        private System.Windows.Forms.Label lblProv;
        private System.Windows.Forms.Label lblComm;
        private System.Windows.Forms.Label lblDateR;
        private System.Windows.Forms.RadioButton rbtnMasculin;
        private System.Windows.Forms.RadioButton rbtnFeminin;
        private System.Windows.Forms.RadioButton rbtnDivorce;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton rbtnMarie;
        private System.Windows.Forms.RadioButton rbtnCelibataire;
        private System.Windows.Forms.TextBox tId;
        private System.Windows.Forms.TextBox tNom;
        private System.Windows.Forms.TextBox tPren;
        private System.Windows.Forms.TextBox tNp;
        private System.Windows.Forms.TextBox tNm;
        private System.Windows.Forms.TextBox tLn;
        private System.Windows.Forms.TextBox tnbe;
        private System.Windows.Forms.ComboBox cboPro;
        private System.Windows.Forms.ComboBox cboCo;
        private System.Windows.Forms.DateTimePicker dateTimePickerRa;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnActualiser;
        private System.Windows.Forms.Button btnReinitialiser;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.DataGridView dgvRappatries;
        private System.Windows.Forms.ComboBox zonerecherche;
    }
}
