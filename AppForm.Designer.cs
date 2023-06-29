namespace LTS2
{
    partial class AppForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionDesStocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entréeEnStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortieDeStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortieDeStockToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.avarisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mouvementsDeStcoksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magasinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesStocksToolStripMenuItem,
            this.aProposToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(502, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionDesStocksToolStripMenuItem
            // 
            this.gestionDesStocksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entréeEnStockToolStripMenuItem,
            this.sortieDeStockToolStripMenuItem,
            this.sortieDeStockToolStripMenuItem1,
            this.avarisToolStripMenuItem,
            this.mouvementsDeStcoksToolStripMenuItem,
            this.magasinsToolStripMenuItem});
            this.gestionDesStocksToolStripMenuItem.Name = "gestionDesStocksToolStripMenuItem";
            this.gestionDesStocksToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.gestionDesStocksToolStripMenuItem.Text = "Gestion des stocks";
            // 
            // entréeEnStockToolStripMenuItem
            // 
            this.entréeEnStockToolStripMenuItem.Name = "entréeEnStockToolStripMenuItem";
            this.entréeEnStockToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.entréeEnStockToolStripMenuItem.Text = "Etat des stock";
            // 
            // sortieDeStockToolStripMenuItem
            // 
            this.sortieDeStockToolStripMenuItem.Name = "sortieDeStockToolStripMenuItem";
            this.sortieDeStockToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.sortieDeStockToolStripMenuItem.Text = "Entrée en stock";
            // 
            // sortieDeStockToolStripMenuItem1
            // 
            this.sortieDeStockToolStripMenuItem1.Name = "sortieDeStockToolStripMenuItem1";
            this.sortieDeStockToolStripMenuItem1.Size = new System.Drawing.Size(196, 22);
            this.sortieDeStockToolStripMenuItem1.Text = "Sortie de stock";
            // 
            // avarisToolStripMenuItem
            // 
            this.avarisToolStripMenuItem.Name = "avarisToolStripMenuItem";
            this.avarisToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.avarisToolStripMenuItem.Text = "Avariés";
            // 
            // mouvementsDeStcoksToolStripMenuItem
            // 
            this.mouvementsDeStcoksToolStripMenuItem.Name = "mouvementsDeStcoksToolStripMenuItem";
            this.mouvementsDeStcoksToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.mouvementsDeStcoksToolStripMenuItem.Text = "Mouvements de stocks";
            // 
            // magasinsToolStripMenuItem
            // 
            this.magasinsToolStripMenuItem.Name = "magasinsToolStripMenuItem";
            this.magasinsToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.magasinsToolStripMenuItem.Text = "Magasins";
            this.magasinsToolStripMenuItem.Click += new System.EventHandler(this.magasinsToolStripMenuItem_Click);
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.aProposToolStripMenuItem.Text = "A propos";
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 350);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AppForm";
            this.Text = "LTS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionDesStocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entréeEnStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortieDeStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortieDeStockToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem avarisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mouvementsDeStcoksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magasinsToolStripMenuItem;
    }
}

