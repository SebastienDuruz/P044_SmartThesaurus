
namespace sebduruz_Index_FormTestProject
{
    partial class MainView
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.IndexButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.webPageCheckbox = new System.Windows.Forms.CheckBox();
            this.FilterButton = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ouvrirLexploreurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favorisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeFavorisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirDansLexplorateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viderLesDonnéesChargéesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viderToutesLesDonnéesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 111);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1030, 510);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(599, 20);
            this.textBox2.TabIndex = 2;
            // 
            // IndexButton
            // 
            this.IndexButton.Location = new System.Drawing.Point(617, 37);
            this.IndexButton.Name = "IndexButton";
            this.IndexButton.Size = new System.Drawing.Size(68, 20);
            this.IndexButton.TabIndex = 3;
            this.IndexButton.Text = "Indexer";
            this.IndexButton.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.searchButton.Location = new System.Drawing.Point(270, 84);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(66, 20);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Chercher";
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // webPageCheckbox
            // 
            this.webPageCheckbox.AutoSize = true;
            this.webPageCheckbox.Location = new System.Drawing.Point(691, 40);
            this.webPageCheckbox.Name = "webPageCheckbox";
            this.webPageCheckbox.Size = new System.Drawing.Size(86, 17);
            this.webPageCheckbox.TabIndex = 5;
            this.webPageCheckbox.Text = "Page Web ?";
            this.webPageCheckbox.UseVisualStyleBackColor = true;
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(617, 83);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(66, 20);
            this.FilterButton.TabIndex = 6;
            this.FilterButton.Text = "Filtrer";
            this.FilterButton.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(365, 84);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(246, 20);
            this.textBox3.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sebduruz_Index_FormTestProject.Properties.Resources.help_icon;
            this.pictureBox1.Location = new System.Drawing.Point(974, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirLexploreurToolStripMenuItem,
            this.favorisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1054, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ouvrirLexploreurToolStripMenuItem
            // 
            this.ouvrirLexploreurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirDansLexplorateurToolStripMenuItem,
            this.viderLesDonnéesChargéesToolStripMenuItem,
            this.viderToutesLesDonnéesToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.ouvrirLexploreurToolStripMenuItem.Name = "ouvrirLexploreurToolStripMenuItem";
            this.ouvrirLexploreurToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ouvrirLexploreurToolStripMenuItem.Text = "Fichier";
            // 
            // favorisToolStripMenuItem
            // 
            this.favorisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeFavorisToolStripMenuItem,
            this.ajouterToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.favorisToolStripMenuItem.Name = "favorisToolStripMenuItem";
            this.favorisToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.favorisToolStripMenuItem.Text = "Favoris";
            // 
            // listeFavorisToolStripMenuItem
            // 
            this.listeFavorisToolStripMenuItem.Name = "listeFavorisToolStripMenuItem";
            this.listeFavorisToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listeFavorisToolStripMenuItem.Text = "Liste favoris";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            // 
            // ouvrirDansLexplorateurToolStripMenuItem
            // 
            this.ouvrirDansLexplorateurToolStripMenuItem.Name = "ouvrirDansLexplorateurToolStripMenuItem";
            this.ouvrirDansLexplorateurToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.ouvrirDansLexplorateurToolStripMenuItem.Text = "Ouvrir dans l\'explorateur";
            // 
            // viderLesDonnéesChargéesToolStripMenuItem
            // 
            this.viderLesDonnéesChargéesToolStripMenuItem.Name = "viderLesDonnéesChargéesToolStripMenuItem";
            this.viderLesDonnéesChargéesToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.viderLesDonnéesChargéesToolStripMenuItem.Text = "Vider les données chargées";
            // 
            // viderToutesLesDonnéesToolStripMenuItem
            // 
            this.viderToutesLesDonnéesToolStripMenuItem.Name = "viderToutesLesDonnéesToolStripMenuItem";
            this.viderToutesLesDonnéesToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.viderToutesLesDonnéesToolStripMenuItem.Text = "Vider toutes les données";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 633);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.webPageCheckbox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.IndexButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainView";
            this.Text = "Test indexation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button IndexButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.CheckBox webPageCheckbox;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ouvrirLexploreurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirDansLexplorateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viderLesDonnéesChargéesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viderToutesLesDonnéesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favorisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeFavorisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
    }
}

