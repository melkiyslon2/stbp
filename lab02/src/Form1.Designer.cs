namespace AES_CriptorG3x
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
            this.textBoxOrigText = new System.Windows.Forms.TextBox();
            this.buttonCript = new System.Windows.Forms.Button();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.textBoxCriptedText = new System.Windows.Forms.TextBox();
            this.buttonDecript = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxOrigText
            // 
            this.textBoxOrigText.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOrigText.Location = new System.Drawing.Point(75, 85);
            this.textBoxOrigText.Multiline = true;
            this.textBoxOrigText.Name = "textBoxOrigText";
            this.textBoxOrigText.Size = new System.Drawing.Size(230, 88);
            this.textBoxOrigText.TabIndex = 0;
            // 
            // buttonCript
            // 
            this.buttonCript.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCript.Location = new System.Drawing.Point(75, 179);
            this.buttonCript.Name = "buttonCript";
            this.buttonCript.Size = new System.Drawing.Size(110, 35);
            this.buttonCript.TabIndex = 1;
            this.buttonCript.Text = "Cript";
            this.buttonCript.UseVisualStyleBackColor = true;
            this.buttonCript.Click += new System.EventHandler(this.buttonCript_Click);
            // 
            // textBoxPass
            // 
            this.textBoxPass.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPass.Location = new System.Drawing.Point(166, 22);
            this.textBoxPass.MaxLength = 50;
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(139, 27);
            this.textBoxPass.TabIndex = 2;
            this.textBoxPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPass.Location = new System.Drawing.Point(72, 31);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(85, 18);
            this.labelPass.TabIndex = 3;
            this.labelPass.Text = "Password";
            // 
            // textBoxCriptedText
            // 
            this.textBoxCriptedText.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCriptedText.Location = new System.Drawing.Point(75, 225);
            this.textBoxCriptedText.Multiline = true;
            this.textBoxCriptedText.Name = "textBoxCriptedText";
            this.textBoxCriptedText.Size = new System.Drawing.Size(230, 88);
            this.textBoxCriptedText.TabIndex = 4;
            // 
            // buttonDecript
            // 
            this.buttonDecript.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDecript.Location = new System.Drawing.Point(195, 179);
            this.buttonDecript.Name = "buttonDecript";
            this.buttonDecript.Size = new System.Drawing.Size(110, 35);
            this.buttonDecript.TabIndex = 5;
            this.buttonDecript.Text = "Decript";
            this.buttonDecript.UseVisualStyleBackColor = true;
            this.buttonDecript.Click += new System.EventHandler(this.buttonDecript_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 354);
            this.Controls.Add(this.buttonDecript);
            this.Controls.Add(this.textBoxCriptedText);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.buttonCript);
            this.Controls.Add(this.textBoxOrigText);
            this.Name = "Form1";
            this.Text = "AES Criptor G3x";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOrigText;
        private System.Windows.Forms.Button buttonCript;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox textBoxCriptedText;
        private System.Windows.Forms.Button buttonDecript;
    }
}

