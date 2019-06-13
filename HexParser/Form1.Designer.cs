namespace HexParser
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fileButton = new System.Windows.Forms.Button();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.parseButton = new System.Windows.Forms.Button();
            this.oneLineCheckBox = new System.Windows.Forms.CheckBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.gitLinkLabel = new System.Windows.Forms.LinkLabel();
            this.clipboardButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fileTextBox
            // 
            this.fileTextBox.Location = new System.Drawing.Point(12, 25);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.Size = new System.Drawing.Size(473, 20);
            this.fileTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hex file to parse into code";
            // 
            // fileButton
            // 
            this.fileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileButton.Location = new System.Drawing.Point(491, 24);
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(22, 22);
            this.fileButton.TabIndex = 2;
            this.fileButton.Text = "...";
            this.fileButton.UseVisualStyleBackColor = true;
            this.fileButton.Click += new System.EventHandler(this.fileButton_Click);
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(12, 94);
            this.codeTextBox.MaxLength = 65535;
            this.codeTextBox.Multiline = true;
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.ReadOnly = true;
            this.codeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.codeTextBox.Size = new System.Drawing.Size(501, 214);
            this.codeTextBox.TabIndex = 3;
            // 
            // parseButton
            // 
            this.parseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parseButton.Location = new System.Drawing.Point(12, 51);
            this.parseButton.Name = "parseButton";
            this.parseButton.Size = new System.Drawing.Size(347, 37);
            this.parseButton.TabIndex = 4;
            this.parseButton.Text = "Parse!";
            this.parseButton.UseVisualStyleBackColor = true;
            this.parseButton.Click += new System.EventHandler(this.parseButton_Click);
            // 
            // oneLineCheckBox
            // 
            this.oneLineCheckBox.AutoSize = true;
            this.oneLineCheckBox.Checked = true;
            this.oneLineCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.oneLineCheckBox.Location = new System.Drawing.Point(448, 55);
            this.oneLineCheckBox.Name = "oneLineCheckBox";
            this.oneLineCheckBox.Size = new System.Drawing.Size(65, 30);
            this.oneLineCheckBox.TabIndex = 5;
            this.oneLineCheckBox.Text = "One line\r\ncode";
            this.oneLineCheckBox.UseVisualStyleBackColor = true;
            // 
            // gitLinkLabel
            // 
            this.gitLinkLabel.AutoSize = true;
            this.gitLinkLabel.Location = new System.Drawing.Point(415, 8);
            this.gitLinkLabel.Name = "gitLinkLabel";
            this.gitLinkLabel.Size = new System.Drawing.Size(99, 13);
            this.gitLinkLabel.TabIndex = 6;
            this.gitLinkLabel.TabStop = true;
            this.gitLinkLabel.Text = "Made by Pokes303";
            this.gitLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gitLinkLabel_LinkClicked);
            // 
            // clipboardButton
            // 
            this.clipboardButton.Enabled = false;
            this.clipboardButton.Location = new System.Drawing.Point(365, 51);
            this.clipboardButton.Name = "clipboardButton";
            this.clipboardButton.Size = new System.Drawing.Size(77, 37);
            this.clipboardButton.TabIndex = 7;
            this.clipboardButton.Text = "Copy to clipboard";
            this.clipboardButton.UseVisualStyleBackColor = true;
            this.clipboardButton.Click += new System.EventHandler(this.clipboardButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 323);
            this.Controls.Add(this.clipboardButton);
            this.Controls.Add(this.gitLinkLabel);
            this.Controls.Add(this.oneLineCheckBox);
            this.Controls.Add(this.parseButton);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.fileButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileTextBox);
            this.Name = "Form1";
            this.Text = "Hex Code Parser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fileTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button fileButton;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Button parseButton;
        private System.Windows.Forms.CheckBox oneLineCheckBox;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.LinkLabel gitLinkLabel;
        private System.Windows.Forms.Button clipboardButton;
    }
}

