
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichiersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirDansLexplorateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exporterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterLapplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favorisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeFavorisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherLaideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.filesRadio = new System.Windows.Forms.RadioButton();
            this.webRadio = new System.Windows.Forms.RadioButton();
            this.execButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addFavLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichiersToolStripMenuItem,
            this.favorisToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1054, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichiersToolStripMenuItem
            // 
            this.fichiersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirDansLexplorateurToolStripMenuItem,
            this.exporterToolStripMenuItem,
            this.quitterLapplicationToolStripMenuItem});
            this.fichiersToolStripMenuItem.Name = "fichiersToolStripMenuItem";
            this.fichiersToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.fichiersToolStripMenuItem.Text = "Fichiers";
            // 
            // ouvrirDansLexplorateurToolStripMenuItem
            // 
            this.ouvrirDansLexplorateurToolStripMenuItem.Name = "ouvrirDansLexplorateurToolStripMenuItem";
            this.ouvrirDansLexplorateurToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.ouvrirDansLexplorateurToolStripMenuItem.Text = "Ouvrir dans l\'explorateur";
            // 
            // exporterToolStripMenuItem
            // 
            this.exporterToolStripMenuItem.Name = "exporterToolStripMenuItem";
            this.exporterToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.exporterToolStripMenuItem.Text = "Exporter";
            this.exporterToolStripMenuItem.Click += new System.EventHandler(this.ExportDatasToolStripMenuItem_Click);
            // 
            // quitterLapplicationToolStripMenuItem
            // 
            this.quitterLapplicationToolStripMenuItem.Name = "quitterLapplicationToolStripMenuItem";
            this.quitterLapplicationToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.quitterLapplicationToolStripMenuItem.Text = "Quitter";
            this.quitterLapplicationToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // favorisToolStripMenuItem
            // 
            this.favorisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeFavorisToolStripMenuItem,
            this.ajouterToolStripMenuItem});
            this.favorisToolStripMenuItem.Name = "favorisToolStripMenuItem";
            this.favorisToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.favorisToolStripMenuItem.Text = "Favoris";
            // 
            // listeFavorisToolStripMenuItem
            // 
            this.listeFavorisToolStripMenuItem.Name = "listeFavorisToolStripMenuItem";
            this.listeFavorisToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.listeFavorisToolStripMenuItem.Text = "Liste favoris";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afficherLaideToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // afficherLaideToolStripMenuItem
            // 
            this.afficherLaideToolStripMenuItem.Name = "afficherLaideToolStripMenuItem";
            this.afficherLaideToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.afficherLaideToolStripMenuItem.Text = "Afficher l\'aide";
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(14, 55);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(677, 20);
            this.pathTextBox.TabIndex = 11;
            // 
            // filesRadio
            // 
            this.filesRadio.AutoSize = true;
            this.filesRadio.Checked = true;
            this.filesRadio.Location = new System.Drawing.Point(727, 56);
            this.filesRadio.Name = "filesRadio";
            this.filesRadio.Size = new System.Drawing.Size(61, 17);
            this.filesRadio.TabIndex = 12;
            this.filesRadio.TabStop = true;
            this.filesRadio.Text = "Fichiers";
            this.filesRadio.UseVisualStyleBackColor = true;
            // 
            // webRadio
            // 
            this.webRadio.AutoSize = true;
            this.webRadio.Location = new System.Drawing.Point(794, 56);
            this.webRadio.Name = "webRadio";
            this.webRadio.Size = new System.Drawing.Size(76, 17);
            this.webRadio.TabIndex = 13;
            this.webRadio.Text = "Page Web";
            this.webRadio.UseVisualStyleBackColor = true;
            // 
            // execButton
            // 
            this.execButton.Location = new System.Drawing.Point(892, 41);
            this.execButton.Name = "execButton";
            this.execButton.Size = new System.Drawing.Size(150, 47);
            this.execButton.TabIndex = 14;
            this.execButton.Text = "Executer";
            this.execButton.UseVisualStyleBackColor = true;
            this.execButton.Click += new System.EventHandler(this.ExecButton);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(759, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(735, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Extension";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(794, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 34);
            this.button2.TabIndex = 17;
            this.button2.Text = "Rechercher";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(794, 191);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(213, 20);
            this.textBox2.TabIndex = 18;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(794, 255);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(213, 20);
            this.textBox3.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(780, 474);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 70);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // addFavLbl
            // 
            this.addFavLbl.AutoSize = true;
            this.addFavLbl.Location = new System.Drawing.Point(889, 502);
            this.addFavLbl.Name = "addFavLbl";
            this.addFavLbl.Size = new System.Drawing.Size(94, 13);
            this.addFavLbl.TabIndex = 21;
            this.addFavLbl.Text = "Ajouter aux favoris";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "chemin d\'accès \\ Page web (URL)";
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(14, 91);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(677, 530);
            this.outputBox.TabIndex = 23;
            this.outputBox.Text = "";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 633);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addFavLbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.execButton);
            this.Controls.Add(this.webRadio);
            this.Controls.Add(this.filesRadio);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainView";
            this.Text = "Test indexation";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem favorisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeFavorisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichiersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirDansLexplorateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterLapplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exporterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherLaideToolStripMenuItem;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.RadioButton filesRadio;
        private System.Windows.Forms.RadioButton webRadio;
        private System.Windows.Forms.Button execButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label addFavLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox outputBox;
    }
}

