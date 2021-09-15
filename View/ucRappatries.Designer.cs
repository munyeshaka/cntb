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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnActualiser = new System.Windows.Forms.Button();
            this.btnReinitialiser = new System.Windows.Forms.Button();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.dgvRappatries = new System.Windows.Forms.DataGridView();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 20);
            this.textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(122, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 20);
            this.textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(122, 131);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(191, 20);
            this.textBox3.TabIndex = 16;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(122, 162);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(191, 20);
            this.textBox4.TabIndex = 17;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(122, 192);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(191, 20);
            this.textBox5.TabIndex = 18;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(790, 66);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(200, 20);
            this.textBox6.TabIndex = 19;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(790, 96);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(200, 20);
            this.textBox7.TabIndex = 20;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(790, 122);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 21;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(790, 149);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 21);
            this.comboBox2.TabIndex = 22;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(790, 176);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(203, 253);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 24;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(284, 253);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 25;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnActualiser
            // 
            this.btnActualiser.Location = new System.Drawing.Point(365, 253);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(75, 23);
            this.btnActualiser.TabIndex = 26;
            this.btnActualiser.Text = "Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = true;
            // 
            // btnReinitialiser
            // 
            this.btnReinitialiser.Location = new System.Drawing.Point(446, 253);
            this.btnReinitialiser.Name = "btnReinitialiser";
            this.btnReinitialiser.Size = new System.Drawing.Size(75, 23);
            this.btnReinitialiser.TabIndex = 27;
            this.btnReinitialiser.Text = "Reinitialiser";
            this.btnReinitialiser.UseVisualStyleBackColor = true;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(650, 250);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(75, 23);
            this.btnRechercher.TabIndex = 28;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(790, 256);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 29;
            // 
            // dgvRappatries
            // 
            this.dgvRappatries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRappatries.Location = new System.Drawing.Point(122, 309);
            this.dgvRappatries.Name = "dgvRappatries";
            this.dgvRappatries.Size = new System.Drawing.Size(868, 210);
            this.dgvRappatries.TabIndex = 30;
            // 
            // ucRappatries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvRappatries);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.btnReinitialiser);
            this.Controls.Add(this.btnActualiser);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnActualiser;
        private System.Windows.Forms.Button btnReinitialiser;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.DataGridView dgvRappatries;
    }
}
