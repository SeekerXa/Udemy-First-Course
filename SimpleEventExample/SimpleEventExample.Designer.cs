namespace SimpleEventExample
{
    partial class SimpleEventExample
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
            this.passwordText = new System.Windows.Forms.TextBox();
            this.passwordButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(13, 77);
            this.passwordText.Name = "passwordText";
            this.passwordText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passwordText.Size = new System.Drawing.Size(466, 27);
            this.passwordText.TabIndex = 0;
            this.passwordText.UseSystemPasswordChar = true;
            // 
            // passwordButton
            // 
            this.passwordButton.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordButton.Location = new System.Drawing.Point(179, 177);
            this.passwordButton.Name = "passwordButton";
            this.passwordButton.Size = new System.Drawing.Size(128, 43);
            this.passwordButton.TabIndex = 1;
            this.passwordButton.Text = "Show Password";
            this.passwordButton.UseVisualStyleBackColor = true;
            this.passwordButton.Click += new System.EventHandler(this.passwordButton_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(13, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 27);
            this.label1.TabIndex = 2;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SimpleEventExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(504, 251);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordButton);
            this.Controls.Add(this.passwordText);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SimpleEventExample";
            this.Text = "SimpleEventExample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Button passwordButton;
        private System.Windows.Forms.Label label1;
    }
}

