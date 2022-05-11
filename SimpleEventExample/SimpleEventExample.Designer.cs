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
            this.clickButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clickButton
            // 
            this.clickButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clickButton.Location = new System.Drawing.Point(285, 201);
            this.clickButton.Name = "clickButton";
            this.clickButton.Size = new System.Drawing.Size(190, 143);
            this.clickButton.TabIndex = 0;
            this.clickButton.Text = "Click Me";
            this.clickButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.clickButton.UseVisualStyleBackColor = true;
            this.clickButton.Click += new System.EventHandler(this.clickButton_Click);
            // 
            // SimpleEventExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.clickButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SimpleEventExample";
            this.Text = "SimpleEventExample";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clickButton;
    }
}

