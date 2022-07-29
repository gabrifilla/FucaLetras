namespace fucaletras
{
    partial class EditarLetra
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EdLetraRTxt = new System.Windows.Forms.RichTextBox();
            this.okEdLeBtt = new System.Windows.Forms.Button();
            this.cancEdLeBtt = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.EdLetraRTxt);
            this.groupBox1.Location = new System.Drawing.Point(33, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 410);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Letra";
            // 
            // EdLetraRTxt
            // 
            this.EdLetraRTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdLetraRTxt.Location = new System.Drawing.Point(6, 19);
            this.EdLetraRTxt.Name = "EdLetraRTxt";
            this.EdLetraRTxt.ReadOnly = true;
            this.EdLetraRTxt.Size = new System.Drawing.Size(483, 377);
            this.EdLetraRTxt.TabIndex = 0;
            this.EdLetraRTxt.Text = "";
            // 
            // okEdLeBtt
            // 
            this.okEdLeBtt.Location = new System.Drawing.Point(682, 410);
            this.okEdLeBtt.Name = "okEdLeBtt";
            this.okEdLeBtt.Size = new System.Drawing.Size(75, 23);
            this.okEdLeBtt.TabIndex = 1;
            this.okEdLeBtt.Text = "Ok";
            this.okEdLeBtt.UseVisualStyleBackColor = true;
            this.okEdLeBtt.Click += new System.EventHandler(this.BttOk_Click);
            // 
            // cancEdLeBtt
            // 
            this.cancEdLeBtt.Location = new System.Drawing.Point(601, 410);
            this.cancEdLeBtt.Name = "cancEdLeBtt";
            this.cancEdLeBtt.Size = new System.Drawing.Size(75, 23);
            this.cancEdLeBtt.TabIndex = 2;
            this.cancEdLeBtt.Text = "Cancelar";
            this.cancEdLeBtt.UseVisualStyleBackColor = true;
            this.cancEdLeBtt.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(528, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(528, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // EditarLetra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 456);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cancEdLeBtt);
            this.Controls.Add(this.okEdLeBtt);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditarLetra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarLetra";
            this.Load += new System.EventHandler(this.EditarLetra_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox EdLetraRTxt;
        private System.Windows.Forms.Button okEdLeBtt;
        private System.Windows.Forms.Button cancEdLeBtt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}