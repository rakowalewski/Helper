namespace Helper
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
            this.ZalogujButton = new System.Windows.Forms.Button();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.HasloTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ZalogujButton
            // 
            this.ZalogujButton.Location = new System.Drawing.Point(29, 155);
            this.ZalogujButton.Name = "ZalogujButton";
            this.ZalogujButton.Size = new System.Drawing.Size(156, 44);
            this.ZalogujButton.TabIndex = 0;
            this.ZalogujButton.Text = "Zaloguj";
            this.ZalogujButton.UseVisualStyleBackColor = true;
            this.ZalogujButton.Click += new System.EventHandler(this.ZalogujButton_Click);
            // 
            // UserTextBox
            // 
            this.UserTextBox.Location = new System.Drawing.Point(29, 44);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(156, 20);
            this.UserTextBox.TabIndex = 1;
            // 
            // HasloTextBox
            // 
            this.HasloTextBox.Location = new System.Drawing.Point(29, 99);
            this.HasloTextBox.Name = "HasloTextBox";
            this.HasloTextBox.PasswordChar = '*';
            this.HasloTextBox.Size = new System.Drawing.Size(156, 20);
            this.HasloTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(222, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 155);
            this.panel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 242);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HasloTextBox);
            this.Controls.Add(this.UserTextBox);
            this.Controls.Add(this.ZalogujButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ZalogujButton;
        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.TextBox HasloTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}

