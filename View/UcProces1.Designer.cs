namespace View
{
    partial class UcProces1
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
            this.txtIdProces = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProces = new System.Windows.Forms.DataGridView();
            this.tRechercher = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.btnActualiser = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.comboBoxParcelle = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.No = new System.Windows.Forms.Label();
            this.txtNomJ = new System.Windows.Forms.TextBox();
            this.txtPV = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpProces = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProces)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdProces
            // 
            this.txtIdProces.Enabled = false;
            this.txtIdProces.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProces.Location = new System.Drawing.Point(196, 55);
            this.txtIdProces.Name = "txtIdProces";
            this.txtIdProces.Size = new System.Drawing.Size(33, 24);
            this.txtIdProces.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Id";
            // 
            // dgvProces
            // 
            this.dgvProces.Location = new System.Drawing.Point(24, 311);
            this.dgvProces.Name = "dgvProces";
            this.dgvProces.Size = new System.Drawing.Size(853, 257);
            this.dgvProces.TabIndex = 47;
            // 
            // tRechercher
            // 
            this.tRechercher.Location = new System.Drawing.Point(750, 284);
            this.tRechercher.Name = "tRechercher";
            this.tRechercher.Size = new System.Drawing.Size(100, 20);
            this.tRechercher.TabIndex = 46;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(675, 282);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(75, 23);
            this.btnRechercher.TabIndex = 45;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            // 
            // btnActualiser
            // 
            this.btnActualiser.Location = new System.Drawing.Point(390, 265);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(75, 23);
            this.btnActualiser.TabIndex = 44;
            this.btnActualiser.Text = "Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(292, 265);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 43;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(196, 265);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 42;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(98, 265);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 41;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // comboBoxParcelle
            // 
            this.comboBoxParcelle.FormattingEnabled = true;
            this.comboBoxParcelle.Location = new System.Drawing.Point(196, 86);
            this.comboBoxParcelle.Name = "comboBoxParcelle";
            this.comboBoxParcelle.Size = new System.Drawing.Size(303, 21);
            this.comboBoxParcelle.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(405, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "PROCES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nom du juge";
            // 
            // No
            // 
            this.No.AutoSize = true;
            this.No.Location = new System.Drawing.Point(88, 95);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(45, 13);
            this.No.TabIndex = 36;
            this.No.Text = "Parcelle";
            // 
            // txtNomJ
            // 
            this.txtNomJ.Location = new System.Drawing.Point(196, 125);
            this.txtNomJ.Name = "txtNomJ";
            this.txtNomJ.Size = new System.Drawing.Size(303, 20);
            this.txtNomJ.TabIndex = 50;
            // 
            // txtPV
            // 
            this.txtPV.Location = new System.Drawing.Point(196, 196);
            this.txtPV.Name = "txtPV";
            this.txtPV.Size = new System.Drawing.Size(314, 50);
            this.txtPV.TabIndex = 51;
            this.txtPV.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "PV";
            // 
            // dtpProces
            // 
            this.dtpProces.Location = new System.Drawing.Point(196, 161);
            this.dtpProces.Name = "dtpProces";
            this.dtpProces.Size = new System.Drawing.Size(303, 20);
            this.dtpProces.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Date ";
            // 
            // UcProces1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpProces);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPV);
            this.Controls.Add(this.txtNomJ);
            this.Controls.Add(this.txtIdProces);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProces);
            this.Controls.Add(this.tRechercher);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.btnActualiser);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.comboBoxParcelle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.No);
            this.Name = "UcProces1";
            this.Size = new System.Drawing.Size(900, 609);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdProces;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProces;
        private System.Windows.Forms.TextBox tRechercher;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Button btnActualiser;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.ComboBox comboBoxParcelle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label No;
        private System.Windows.Forms.TextBox txtNomJ;
        private System.Windows.Forms.RichTextBox txtPV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpProces;
        private System.Windows.Forms.Label label4;
    }
}
