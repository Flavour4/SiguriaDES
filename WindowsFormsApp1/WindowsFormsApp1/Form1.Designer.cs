namespace WindowsFormsApp1
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
            this.txtFile = new System.Windows.Forms.TextBox();
            this.Ngarko = new System.Windows.Forms.Button();
            this.txtCelesi = new System.Windows.Forms.TextBox();
            this.btnEnkriptoDES = new System.Windows.Forms.Button();
            this.btnDekripto = new System.Windows.Forms.Button();
            this.btnEnkripto3DES = new System.Windows.Forms.Button();
            this.btnDekripto3DES = new System.Windows.Forms.Button();
            this.btnEkripto2DES = new System.Windows.Forms.Button();
            this.btnDekripto2DES = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(116, 174);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(271, 20);
            this.txtFile.TabIndex = 0;
            // 
            // Ngarko
            // 
            this.Ngarko.Location = new System.Drawing.Point(403, 174);
            this.Ngarko.Name = "Ngarko";
            this.Ngarko.Size = new System.Drawing.Size(76, 20);
            this.Ngarko.TabIndex = 1;
            this.Ngarko.Text = "...";
            this.Ngarko.UseVisualStyleBackColor = true;
            this.Ngarko.Click += new System.EventHandler(this.Ngarko_Click);
            // 
            // txtCelesi
            // 
            this.txtCelesi.Location = new System.Drawing.Point(116, 246);
            this.txtCelesi.Name = "txtCelesi";
            this.txtCelesi.Size = new System.Drawing.Size(271, 20);
            this.txtCelesi.TabIndex = 2;
            // 
            // btnEnkriptoDES
            // 
            this.btnEnkriptoDES.Location = new System.Drawing.Point(64, 312);
            this.btnEnkriptoDES.Name = "btnEnkriptoDES";
            this.btnEnkriptoDES.Size = new System.Drawing.Size(76, 29);
            this.btnEnkriptoDES.TabIndex = 3;
            this.btnEnkriptoDES.Text = "EnkDes";
            this.btnEnkriptoDES.UseVisualStyleBackColor = true;
            this.btnEnkriptoDES.Click += new System.EventHandler(this.btnEnkriptoDES_Click);
            // 
            // btnDekripto
            // 
            this.btnDekripto.Location = new System.Drawing.Point(64, 362);
            this.btnDekripto.Name = "btnDekripto";
            this.btnDekripto.Size = new System.Drawing.Size(76, 29);
            this.btnDekripto.TabIndex = 4;
            this.btnDekripto.Text = "DekDes";
            this.btnDekripto.UseVisualStyleBackColor = true;
            this.btnDekripto.Click += new System.EventHandler(this.btnDekripto_Click);
            // 
            // btnEnkripto3DES
            // 
            this.btnEnkripto3DES.Location = new System.Drawing.Point(390, 312);
            this.btnEnkripto3DES.Name = "btnEnkripto3DES";
            this.btnEnkripto3DES.Size = new System.Drawing.Size(76, 29);
            this.btnEnkripto3DES.TabIndex = 5;
            this.btnEnkripto3DES.Text = "Enk3Des";
            this.btnEnkripto3DES.UseVisualStyleBackColor = true;
            this.btnEnkripto3DES.Click += new System.EventHandler(this.btnEnkripto3DES_Click);
            // 
            // btnDekripto3DES
            // 
            this.btnDekripto3DES.Location = new System.Drawing.Point(390, 366);
            this.btnDekripto3DES.Name = "btnDekripto3DES";
            this.btnDekripto3DES.Size = new System.Drawing.Size(76, 29);
            this.btnDekripto3DES.TabIndex = 6;
            this.btnDekripto3DES.Text = "Dek3Des";
            this.btnDekripto3DES.UseVisualStyleBackColor = true;
            this.btnDekripto3DES.Click += new System.EventHandler(this.btnDekripto3DES_Click);
            // 
            // btnEkripto2DES
            // 
            this.btnEkripto2DES.Location = new System.Drawing.Point(219, 312);
            this.btnEkripto2DES.Name = "btnEkripto2DES";
            this.btnEkripto2DES.Size = new System.Drawing.Size(76, 29);
            this.btnEkripto2DES.TabIndex = 7;
            this.btnEkripto2DES.Text = "Enk2Des";
            this.btnEkripto2DES.UseVisualStyleBackColor = true;
            this.btnEkripto2DES.Click += new System.EventHandler(this.btnEkripto2DES_Click);
            // 
            // btnDekripto2DES
            // 
            this.btnDekripto2DES.Location = new System.Drawing.Point(219, 362);
            this.btnDekripto2DES.Name = "btnDekripto2DES";
            this.btnDekripto2DES.Size = new System.Drawing.Size(76, 29);
            this.btnDekripto2DES.TabIndex = 8;
            this.btnDekripto2DES.Text = "Dek2Des";
            this.btnDekripto2DES.UseVisualStyleBackColor = true;
            this.btnDekripto2DES.Click += new System.EventHandler(this.btnDekripto2DES_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Celesi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ngarko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 48);
            this.label3.TabIndex = 11;
            this.label3.Text = "Enkriptimi dhe dekriptimi i fajllit me\r\n              2DES dhe 3DES";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 407);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDekripto2DES);
            this.Controls.Add(this.btnEkripto2DES);
            this.Controls.Add(this.btnDekripto3DES);
            this.Controls.Add(this.btnEnkripto3DES);
            this.Controls.Add(this.btnDekripto);
            this.Controls.Add(this.btnEnkriptoDES);
            this.Controls.Add(this.txtCelesi);
            this.Controls.Add(this.Ngarko);
            this.Controls.Add(this.txtFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button Ngarko;
        private System.Windows.Forms.TextBox txtCelesi;
        private System.Windows.Forms.Button btnEnkriptoDES;
        private System.Windows.Forms.Button btnDekripto;
        private System.Windows.Forms.Button btnEnkripto3DES;
        private System.Windows.Forms.Button btnDekripto3DES;
        private System.Windows.Forms.Button btnEkripto2DES;
        private System.Windows.Forms.Button btnDekripto2DES;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

