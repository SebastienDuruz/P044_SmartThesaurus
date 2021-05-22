using System;

namespace P044_SmartThesaurus
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
            this.components = new System.ComponentModel.Container();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.filesRadio = new System.Windows.Forms.RadioButton();
            this.webRadio = new System.Windows.Forms.RadioButton();
            this.execButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.filtersTextBox = new System.Windows.Forms.TextBox();
            this.addFavLbl = new System.Windows.Forms.Label();
            this.pathLabel = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.filterHelpPictureBox = new System.Windows.Forms.PictureBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.nbOfResultsLabel = new System.Windows.Forms.Label();
            this.fichiersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirDansLexplorateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exporterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterLapplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favorisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeFavorisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherLaideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.resultType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resultName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resultPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.outputListBox = new System.Windows.Forms.ListView();
            this.openFolderPictureBox = new System.Windows.Forms.PictureBox();
            this.favoritePictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterHelpPictureBox)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openFolderPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.favoritePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pathTextBox
            // 
            this.pathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.pathTextBox.Location = new System.Drawing.Point(53, 55);
            this.pathTextBox.Multiline = true;
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(637, 30);
            this.pathTextBox.TabIndex = 4;
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
            this.filesRadio.CheckedChanged += new System.EventHandler(this.FilesRadio_CheckedChanged);
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
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(21, 141);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(138, 34);
            this.searchButton.TabIndex = 17;
            this.searchButton.Text = "Rechercher";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // filtersTextBox
            // 
            this.filtersTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.filtersTextBox.Location = new System.Drawing.Point(21, 44);
            this.filtersTextBox.Multiline = true;
            this.filtersTextBox.Name = "filtersTextBox";
            this.filtersTextBox.Size = new System.Drawing.Size(259, 78);
            this.filtersTextBox.TabIndex = 18;
            this.filtersTextBox.Enter += new System.EventHandler(this.FilterBoxTakeFocus);
            this.filtersTextBox.Leave += new System.EventHandler(this.FilterBoxLeaveFocus);
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
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(14, 39);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(167, 13);
            this.pathLabel.TabIndex = 22;
            this.pathLabel.Text = "Dossier source \\ Page web (URL)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.filterHelpPictureBox);
            this.groupBox1.Controls.Add(this.cancelButton);
            this.groupBox1.Controls.Add(this.filtersTextBox);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Location = new System.Drawing.Point(727, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 204);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrer les résultats";
            // 
            // filterHelpPictureBox
            // 
            this.filterHelpPictureBox.Image = global::P044_SmartThesaurus.Properties.Resources.help_icon;
            this.filterHelpPictureBox.Location = new System.Drawing.Point(254, 15);
            this.filterHelpPictureBox.Name = "filterHelpPictureBox";
            this.filterHelpPictureBox.Size = new System.Drawing.Size(26, 24);
            this.filterHelpPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.filterHelpPictureBox.TabIndex = 28;
            this.filterHelpPictureBox.TabStop = false;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Tomato;
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelButton.Location = new System.Drawing.Point(165, 141);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(115, 34);
            this.cancelButton.TabIndex = 19;
            this.cancelButton.Text = "Annuler";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Visible = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // nbOfResultsLabel
            // 
            this.nbOfResultsLabel.AutoSize = true;
            this.nbOfResultsLabel.Location = new System.Drawing.Point(17, 608);
            this.nbOfResultsLabel.Name = "nbOfResultsLabel";
            this.nbOfResultsLabel.Size = new System.Drawing.Size(121, 13);
            this.nbOfResultsLabel.TabIndex = 26;
            this.nbOfResultsLabel.Text = "Nombres de résultats : 0";
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
            this.ouvrirDansLexplorateurToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.ouvrirDansLexplorateurToolStripMenuItem.Text = "Ouvrir la sélection";
            this.ouvrirDansLexplorateurToolStripMenuItem.Click += new System.EventHandler(this.OpenWithExplorer);
            // 
            // exporterToolStripMenuItem
            // 
            this.exporterToolStripMenuItem.Name = "exporterToolStripMenuItem";
            this.exporterToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.exporterToolStripMenuItem.Text = "Exporter";
            this.exporterToolStripMenuItem.Click += new System.EventHandler(this.ExportDataButtonClick);
            // 
            // quitterLapplicationToolStripMenuItem
            // 
            this.quitterLapplicationToolStripMenuItem.Name = "quitterLapplicationToolStripMenuItem";
            this.quitterLapplicationToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.quitterLapplicationToolStripMenuItem.Text = "Quitter";
            this.quitterLapplicationToolStripMenuItem.Click += new System.EventHandler(this.ExitButtonClick);
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
            this.listeFavorisToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listeFavorisToolStripMenuItem.Text = "Liste favoris";
            this.listeFavorisToolStripMenuItem.Click += new System.EventHandler(this.ShowBookmarksClick);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.CreateBookmarkClick);
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
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichiersToolStripMenuItem,
            this.favorisToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1056, 24);
            this.menuStrip.TabIndex = 9;
            this.menuStrip.Text = "menuStrip1";
            // 
            // resultType
            // 
            this.resultType.Text = "Type";
            this.resultType.Width = 75;
            // 
            // resultName
            // 
            this.resultName.Text = "Nom";
            this.resultName.Width = 200;
            // 
            // resultPath
            // 
            this.resultPath.Text = "Source";
            this.resultPath.Width = 400;
            // 
            // outputListBox
            // 
            this.outputListBox.AllowColumnReorder = true;
            this.outputListBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.resultType,
            this.resultName,
            this.resultPath});
            this.outputListBox.GridLines = true;
            this.outputListBox.HideSelection = false;
            this.outputListBox.Location = new System.Drawing.Point(14, 91);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(677, 514);
            this.outputListBox.TabIndex = 27;
            this.outputListBox.UseCompatibleStateImageBehavior = false;
            this.outputListBox.View = System.Windows.Forms.View.Details;
            this.outputListBox.DoubleClick += new System.EventHandler(this.OpenWithExplorer);
            // 
            // openFolderPictureBox
            // 
            this.openFolderPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openFolderPictureBox.Image = global::P044_SmartThesaurus.Properties.Resources.folder_blue;
            this.openFolderPictureBox.Location = new System.Drawing.Point(14, 55);
            this.openFolderPictureBox.Name = "openFolderPictureBox";
            this.openFolderPictureBox.Size = new System.Drawing.Size(33, 29);
            this.openFolderPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.openFolderPictureBox.TabIndex = 24;
            this.openFolderPictureBox.TabStop = false;
            this.openFolderPictureBox.Click += new System.EventHandler(this.OpenFolderPictureBox_Click);
            // 
            // favoritePictureBox
            // 
            this.favoritePictureBox.Image = global::P044_SmartThesaurus.Properties.Resources.filledStar;
            this.favoritePictureBox.Location = new System.Drawing.Point(812, 487);
            this.favoritePictureBox.Name = "favoritePictureBox";
            this.favoritePictureBox.Size = new System.Drawing.Size(49, 48);
            this.favoritePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.favoritePictureBox.TabIndex = 20;
            this.favoritePictureBox.TabStop = false;
            // 
            // MainView
            // 
            this.AcceptButton = this.execButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 631);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.outputListBox);
            this.Controls.Add(this.nbOfResultsLabel);
            this.Controls.Add(this.openFolderPictureBox);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.addFavLbl);
            this.Controls.Add(this.favoritePictureBox);
            this.Controls.Add(this.execButton);
            this.Controls.Add(this.webRadio);
            this.Controls.Add(this.filesRadio);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip;
            this.MaximumSize = new System.Drawing.Size(1072, 670);
            this.MinimumSize = new System.Drawing.Size(1072, 670);
            this.Name = "MainView";
            this.Text = "Indexator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterHelpPictureBox)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openFolderPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.favoritePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.RadioButton filesRadio;
        private System.Windows.Forms.RadioButton webRadio;
        private System.Windows.Forms.Button execButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox filtersTextBox;
        private System.Windows.Forms.PictureBox favoritePictureBox;
        private System.Windows.Forms.Label addFavLbl;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.PictureBox openFolderPictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.PictureBox filterHelpPictureBox;
        private System.Windows.Forms.Label nbOfResultsLabel;
        private System.Windows.Forms.ToolStripMenuItem fichiersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirDansLexplorateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exporterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterLapplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favorisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeFavorisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherLaideToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ColumnHeader resultType;
        private System.Windows.Forms.ColumnHeader resultName;
        private System.Windows.Forms.ColumnHeader resultPath;
        private System.Windows.Forms.ListView outputListBox;
    }
}

