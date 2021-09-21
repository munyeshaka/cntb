
namespace View
{
    partial class ucReclamer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.No = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxParcelle = new System.Windows.Forms.ComboBox();
            this.comboBoxRappatrie = new System.Windows.Forms.ComboBox();
            this.dgvResident = new System.Windows.Forms.DataGridView();
            this.tRechercher = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.btnActualiser = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResident)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Rappatrie";
            // 
            // No
            // 
            this.No.AutoSize = true;
            this.No.Location = new System.Drawing.Point(82, 130);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(45, 13);
            this.No.TabIndex = 13;
            this.No.Text = "Parcelle";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(412, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "RECLAMER";
            // 
            // comboBoxParcelle
            // 
            this.comboBoxParcelle.FormattingEnabled = true;
            this.comboBoxParcelle.Location = new System.Drawing.Point(190, 121);
            this.comboBoxParcelle.Name = "comboBoxParcelle";
            this.comboBoxParcelle.Size = new System.Drawing.Size(303, 21);
            this.comboBoxParcelle.TabIndex = 18;
            // 
            // comboBoxRappatrie
            // 
            this.comboBoxRappatrie.FormattingEnabled = true;
            this.comboBoxRappatrie.Location = new System.Drawing.Point(190, 169);
            this.comboBoxRappatrie.Name = "comboBoxRappatrie";
            this.comboBoxRappatrie.Size = new System.Drawing.Size(303, 21);
            this.comboBoxRappatrie.TabIndex = 19;
            // 
            // dgvResident
            // 
            this.dgvResident.Location = new System.Drawing.Point(28, 296);
            this.dgvResident.Name = "dgvResident";
            this.dgvResident.Size = new System.Drawing.Size(853, 257);
            this.dgvResident.TabIndex = 33;
            this.dgvResident.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResident_CellContentClick);
            // 
            // tRechercher
            // 
            this.tRechercher.Location = new System.Drawing.Point(754, 269);
            this.tRechercher.Name = "tRechercher";
            this.tRechercher.Size = new System.Drawing.Size(100, 20);
            this.tRechercher.TabIndex = 32;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(679, 267);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(75, 23);
            this.btnRechercher.TabIndex = 31;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            // 
            // btnActualiser
            // 
            this.btnActualiser.Location = new System.Drawing.Point(394, 250);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(75, 23);
            this.btnActualiser.TabIndex = 30;
            this.btnActualiser.Text = "Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = true;
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(296, 250);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 29;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(200, 250);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 28;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(102, 250);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 27;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Parcelle";
            // 
            // txtnumero
            // 
            this.txtnumero.Enabled = false;
            this.txtnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumero.Location = new System.Drawing.Point(190, 90);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(33, 24);
            this.txtnumero.TabIndex = 35;
            // 
            // ucReclamer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvResident);
            this.Controls.Add(this.tRechercher);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.btnActualiser);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.comboBoxRappatrie);
            this.Controls.Add(this.comboBoxParcelle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.No);
            this.Name = "ucReclamer";
            this.Size = new System.Drawing.Size(900, 609);
            this.Load += new System.EventHandler(this.ucReclamer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResident)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label No;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxParcelle;
        private System.Windows.Forms.ComboBox comboBoxRappatrie;
        private System.Windows.Forms.DataGridView dgvResident;
        private System.Windows.Forms.TextBox tRechercher;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Button btnActualiser;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnumero;
    }
}
