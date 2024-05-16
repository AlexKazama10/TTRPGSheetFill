namespace TTRPGSheetFiller
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonCreateCharacter = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonViewCharacters = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Rubik", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(213, 42);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(575, 42);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Welcome to the TTRPG Sheet Filler";
            // 
            // buttonCreateCharacter
            // 
            this.buttonCreateCharacter.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonCreateCharacter.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateCharacter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCreateCharacter.Location = new System.Drawing.Point(25, 122);
            this.buttonCreateCharacter.Name = "buttonCreateCharacter";
            this.buttonCreateCharacter.Size = new System.Drawing.Size(178, 40);
            this.buttonCreateCharacter.TabIndex = 1;
            this.buttonCreateCharacter.Text = "Create character";
            this.buttonCreateCharacter.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDelete.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDelete.Location = new System.Drawing.Point(25, 260);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(178, 40);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete character";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonEdit.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEdit.Location = new System.Drawing.Point(25, 214);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(178, 40);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Edit character";
            this.buttonEdit.UseVisualStyleBackColor = false;
            // 
            // buttonViewCharacters
            // 
            this.buttonViewCharacters.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonViewCharacters.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewCharacters.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonViewCharacters.Location = new System.Drawing.Point(25, 168);
            this.buttonViewCharacters.Name = "buttonViewCharacters";
            this.buttonViewCharacters.Size = new System.Drawing.Size(178, 40);
            this.buttonViewCharacters.TabIndex = 4;
            this.buttonViewCharacters.Text = "View characters";
            this.buttonViewCharacters.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 597);
            this.Controls.Add(this.buttonViewCharacters);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonCreateCharacter);
            this.Controls.Add(this.labelTitle);
            this.Name = "Form1";
            this.Text = "TTRPG Sheet Filler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonCreateCharacter;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonViewCharacters;
    }
}

