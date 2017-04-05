namespace Helper
{
    partial class WszystkieApteki
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
            this.dgvApteki = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApteki)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvApteki
            // 
            this.dgvApteki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApteki.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvApteki.Location = new System.Drawing.Point(0, 68);
            this.dgvApteki.Name = "dgvApteki";
            this.dgvApteki.Size = new System.Drawing.Size(471, 193);
            this.dgvApteki.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // WszystkieApteki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 261);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvApteki);
            this.Name = "WszystkieApteki";
            this.Text = "WszystkieApteki";
            ((System.ComponentModel.ISupportInitialize)(this.dgvApteki)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvApteki;
        private System.Windows.Forms.TextBox textBox1;
    }
}