
namespace P044_SmartThesaurus.Views
{
    partial class ModifyBookmarkView
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.sourceLabel = new System.Windows.Forms.Label();
            this.sourceTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(237, 383);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(88, 31);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "Annuler";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(107, 383);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(88, 31);
            this.acceptButton.TabIndex = 16;
            this.acceptButton.Text = "Valider";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.AcceptButtonClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Entrer une description de votre favoris (optionnel)";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(12, 257);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(420, 111);
            this.descriptionTextBox.TabIndex = 14;
            // 
            // sourceLabel
            // 
            this.sourceLabel.AutoSize = true;
            this.sourceLabel.Location = new System.Drawing.Point(12, 179);
            this.sourceLabel.Name = "sourceLabel";
            this.sourceLabel.Size = new System.Drawing.Size(117, 13);
            this.sourceLabel.TabIndex = 13;
            this.sourceLabel.Text = "Source de votre favoris";
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.Location = new System.Drawing.Point(12, 195);
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.ReadOnly = true;
            this.sourceTextBox.Size = new System.Drawing.Size(420, 20);
            this.sourceTextBox.TabIndex = 12;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 117);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(150, 13);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "Donner un nom à votre favoris";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "Modifier votre favoris";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 133);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(420, 20);
            this.nameTextBox.TabIndex = 9;
            // 
            // ModifyBookmarkView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 426);
            this.ControlBox = false;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.sourceLabel);
            this.Controls.Add(this.sourceTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.MaximumSize = new System.Drawing.Size(463, 465);
            this.MinimumSize = new System.Drawing.Size(463, 465);
            this.Name = "ModifyBookmarkView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modifier votre favoris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label sourceLabel;
        private System.Windows.Forms.TextBox sourceTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}