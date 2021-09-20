namespace cntb
{
    partial class Form1
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
            this.HomePanel = new System.Windows.Forms.Panel();
            this.donneessDeBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.residentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rappatriésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reclamerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parcelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomePanel
            // 
            this.HomePanel.Location = new System.Drawing.Point(12, 27);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(1148, 643);
            this.HomePanel.TabIndex = 1;
            // 
            // donneessDeBaseToolStripMenuItem
            // 
            this.donneessDeBaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.residentToolStripMenuItem,
            this.rappatriésToolStripMenuItem,
            this.reclamerToolStripMenuItem,
            this.parcelleToolStripMenuItem});
            this.donneessDeBaseToolStripMenuItem.Name = "donneessDeBaseToolStripMenuItem";
            this.donneessDeBaseToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.donneessDeBaseToolStripMenuItem.Text = "Données de base";
            this.donneessDeBaseToolStripMenuItem.Click += new System.EventHandler(this.donneessDeBaseToolStripMenuItem_Click);
            // 
            // residentToolStripMenuItem
            // 
            this.residentToolStripMenuItem.Name = "residentToolStripMenuItem";
            this.residentToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.residentToolStripMenuItem.Text = "Residents";
            this.residentToolStripMenuItem.Click += new System.EventHandler(this.residentToolStripMenuItem_Click);
            // 
            // rappatriésToolStripMenuItem
            // 
            this.rappatriésToolStripMenuItem.Name = "rappatriésToolStripMenuItem";
            this.rappatriésToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rappatriésToolStripMenuItem.Text = "Rappatriés";
            this.rappatriésToolStripMenuItem.Click += new System.EventHandler(this.rappatriésToolStripMenuItem_Click);
            // 
            // reclamerToolStripMenuItem
            // 
            this.reclamerToolStripMenuItem.Name = "reclamerToolStripMenuItem";
            this.reclamerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reclamerToolStripMenuItem.Text = "Reclamer";
            this.reclamerToolStripMenuItem.Click += new System.EventHandler(this.reclamerToolStripMenuItem_Click);
            // 
            // parcelleToolStripMenuItem
            // 
            this.parcelleToolStripMenuItem.Name = "parcelleToolStripMenuItem";
            this.parcelleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.parcelleToolStripMenuItem.Text = "Parcelle";
            this.parcelleToolStripMenuItem.Click += new System.EventHandler(this.parcelleToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donneessDeBaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1172, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 682);
            this.Controls.Add(this.HomePanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "CNTB";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HomePanel;
        private System.Windows.Forms.ToolStripMenuItem donneessDeBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem residentToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rappatriésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reclamerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parcelleToolStripMenuItem;
    }
}