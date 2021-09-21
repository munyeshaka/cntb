namespace View
{
    partial class ucParcelle
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
            this.tId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvParcelle = new System.Windows.Forms.DataGridView();
            this.tRechercher = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.btnActualiser = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.tRue = new System.Windows.Forms.TextBox();
            this.tCni = new System.Windows.Forms.TextBox();
            this.tTaille = new System.Windows.Forms.TextBox();
            this.tNum = new System.Windows.Forms.TextBox();
            this.tCom = new System.Windows.Forms.TextBox();
            this.cbProvince = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelle)).BeginInit();
            this.SuspendLayout();
            // 
            // tId
            // 
            this.tId.Location = new System.Drawing.Point(7, 85);
            this.tId.Name = "tId";
            this.tId.Size = new System.Drawing.Size(125, 20);
            this.tId.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Id";
            // 
            // dgvParcelle
            // 
            this.dgvParcelle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcelle.Location = new System.Drawing.Point(7, 276);
            this.dgvParcelle.Name = "dgvParcelle";
            this.dgvParcelle.Size = new System.Drawing.Size(888, 265);
            this.dgvParcelle.TabIndex = 58;
            // 
            // tRechercher
            // 
            this.tRechercher.Location = new System.Drawing.Point(770, 215);
            this.tRechercher.Name = "tRechercher";
            this.tRechercher.Size = new System.Drawing.Size(100, 20);
            this.tRechercher.TabIndex = 57;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(649, 215);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(75, 23);
            this.btnRechercher.TabIndex = 56;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            // 
            // btnActualiser
            // 
            this.btnActualiser.Location = new System.Drawing.Point(471, 217);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(75, 23);
            this.btnActualiser.TabIndex = 55;
            this.btnActualiser.Text = "Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(328, 217);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 54;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(200, 217);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 53;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(57, 217);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 52;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // tRue
            // 
            this.tRue.Location = new System.Drawing.Point(700, 85);
            this.tRue.Name = "tRue";
            this.tRue.Size = new System.Drawing.Size(125, 20);
            this.tRue.TabIndex = 51;
            // 
            // tCni
            // 
            this.tCni.Location = new System.Drawing.Point(471, 162);
            this.tCni.Name = "tCni";
            this.tCni.Size = new System.Drawing.Size(125, 20);
            this.tCni.TabIndex = 50;
            // 
            // tTaille
            // 
            this.tTaille.Location = new System.Drawing.Point(215, 162);
            this.tTaille.Name = "tTaille";
            this.tTaille.Size = new System.Drawing.Size(125, 20);
            this.tTaille.TabIndex = 49;
            // 
            // tNum
            // 
            this.tNum.Location = new System.Drawing.Point(7, 162);
            this.tNum.Name = "tNum";
            this.tNum.Size = new System.Drawing.Size(125, 20);
            this.tNum.TabIndex = 48;
            // 
            // tCom
            // 
            this.tCom.Location = new System.Drawing.Point(471, 85);
            this.tCom.Name = "tCom";
            this.tCom.Size = new System.Drawing.Size(125, 20);
            this.tCom.TabIndex = 47;
            // 
            // cbProvince
            // 
            this.cbProvince.FormattingEnabled = true;
            this.cbProvince.Items.AddRange(new object[] {
            "Bubanza",
            "Bujumbura Mairie",
            "Bujumbura ",
            "Bururi ",
            "Cankuzo ",
            "Cibitoke ",
            "Gitega ",
            "Karuzi ",
            "Kayanza ",
            "Kirundo ",
            "Makamba ",
            "Muramvya ",
            "Muyinga ",
            "Mwaro ",
            "Ngozi ",
            "Rumonge ",
            "Rutana ",
            "Ruyigi"});
            this.cbProvince.Location = new System.Drawing.Point(215, 84);
            this.cbProvince.Name = "cbProvince";
            this.cbProvince.Size = new System.Drawing.Size(159, 21);
            this.cbProvince.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(468, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Cni Resident";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Taille";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Numero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(697, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Rue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(468, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Commune";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Province";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(341, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "PARCELLE";
            // 
            // ucParcelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvParcelle);
            this.Controls.Add(this.tRechercher);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.btnActualiser);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.tRue);
            this.Controls.Add(this.tCni);
            this.Controls.Add(this.tTaille);
            this.Controls.Add(this.tNum);
            this.Controls.Add(this.tCom);
            this.Controls.Add(this.cbProvince);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Name = "ucParcelle";
            this.Size = new System.Drawing.Size(899, 561);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvParcelle;
        private System.Windows.Forms.TextBox tRechercher;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Button btnActualiser;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox tRue;
        private System.Windows.Forms.TextBox tCni;
        private System.Windows.Forms.TextBox tTaille;
        private System.Windows.Forms.TextBox tNum;
        private System.Windows.Forms.TextBox tCom;
        private System.Windows.Forms.ComboBox cbProvince;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
    }
}
