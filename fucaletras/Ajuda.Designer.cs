namespace fucaletras
{
    partial class Ajuda
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BttOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BttVoltar = new System.Windows.Forms.Button();
            this.BttPassar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(142, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(496, 272);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BttOk
            // 
            this.BttOk.Location = new System.Drawing.Point(675, 391);
            this.BttOk.Name = "BttOk";
            this.BttOk.Size = new System.Drawing.Size(75, 23);
            this.BttOk.TabIndex = 1;
            this.BttOk.Text = "Ok";
            this.BttOk.UseVisualStyleBackColor = true;
            this.BttOk.Click += new System.EventHandler(this.BttOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ajuda";
            // 
            // BttVoltar
            // 
            this.BttVoltar.Location = new System.Drawing.Point(365, 379);
            this.BttVoltar.Name = "BttVoltar";
            this.BttVoltar.Size = new System.Drawing.Size(28, 23);
            this.BttVoltar.TabIndex = 3;
            this.BttVoltar.Text = "<";
            this.BttVoltar.UseVisualStyleBackColor = true;
            // 
            // BttPassar
            // 
            this.BttPassar.Location = new System.Drawing.Point(399, 379);
            this.BttPassar.Name = "BttPassar";
            this.BttPassar.Size = new System.Drawing.Size(26, 23);
            this.BttPassar.TabIndex = 4;
            this.BttPassar.Text = ">";
            this.BttPassar.UseVisualStyleBackColor = true;
            // 
            // Ajuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 456);
            this.Controls.Add(this.BttPassar);
            this.Controls.Add(this.BttVoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BttOk);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Ajuda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajuda";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BttOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BttVoltar;
        private System.Windows.Forms.Button BttPassar;
    }
}