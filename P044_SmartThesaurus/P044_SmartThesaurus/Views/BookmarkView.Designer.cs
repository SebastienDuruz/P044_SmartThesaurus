
namespace P044_SmartThesaurus.Views
{
    partial class BookmarkView
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
            this.bookmarksListView = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.closeButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bookmarksListView
            // 
            this.bookmarksListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookmarksListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.path,
            this.description});
            this.bookmarksListView.FullRowSelect = true;
            this.bookmarksListView.GridLines = true;
            this.bookmarksListView.HideSelection = false;
            this.bookmarksListView.Location = new System.Drawing.Point(12, 12);
            this.bookmarksListView.MultiSelect = false;
            this.bookmarksListView.Name = "bookmarksListView";
            this.bookmarksListView.Size = new System.Drawing.Size(656, 522);
            this.bookmarksListView.TabIndex = 0;
            this.bookmarksListView.UseCompatibleStateImageBehavior = false;
            this.bookmarksListView.View = System.Windows.Forms.View.Details;
            this.bookmarksListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.SelectionChanged);
            this.bookmarksListView.DoubleClick += new System.EventHandler(this.DoubleClickSelectedItem);
            // 
            // name
            // 
            this.name.Text = "Nom";
            this.name.Width = 100;
            // 
            // path
            // 
            this.path.Text = "Source";
            this.path.Width = 250;
            // 
            // description
            // 
            this.description.Text = "Description";
            this.description.Width = 300;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Location = new System.Drawing.Point(579, 551);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(89, 33);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Fermer";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButtonClick);
            // 
            // modifyButton
            // 
            this.modifyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.modifyButton.Enabled = false;
            this.modifyButton.Location = new System.Drawing.Point(12, 551);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(89, 33);
            this.modifyButton.TabIndex = 3;
            this.modifyButton.Text = "Modifier";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.ModifyButtonClick);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(107, 551);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(89, 33);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Supprimer";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButtonClick);
            // 
            // BookmarkView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 596);
            this.ControlBox = false;
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.bookmarksListView);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "BookmarkView";
            this.Text = "Mes favoris";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView bookmarksListView;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader path;
        private System.Windows.Forms.ColumnHeader description;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button deleteButton;
    }
}