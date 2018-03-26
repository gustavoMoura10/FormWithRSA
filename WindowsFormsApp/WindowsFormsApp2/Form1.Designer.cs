namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.botao1 = new System.Windows.Forms.Button();
            this.botao2 = new System.Windows.Forms.Button();
            this.numer = new System.Windows.Forms.NumericUpDown();
            this.text1 = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.TextBox();
            this.text3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.keye = new System.Windows.Forms.Label();
            this.keyn = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.keyp = new System.Windows.Forms.Label();
            this.keyq = new System.Windows.Forms.Label();
            this.keyde = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numer)).BeginInit();
            this.SuspendLayout();
            // 
            // botao1
            // 
            this.botao1.Location = new System.Drawing.Point(234, 290);
            this.botao1.Name = "botao1";
            this.botao1.Size = new System.Drawing.Size(75, 23);
            this.botao1.TabIndex = 0;
            this.botao1.Text = "Criptografar";
            this.botao1.UseVisualStyleBackColor = true;
            this.botao1.Click += new System.EventHandler(this.botao1_Click);
            // 
            // botao2
            // 
            this.botao2.Location = new System.Drawing.Point(234, 402);
            this.botao2.Name = "botao2";
            this.botao2.Size = new System.Drawing.Size(75, 23);
            this.botao2.TabIndex = 1;
            this.botao2.Text = "Descriptografar";
            this.botao2.UseVisualStyleBackColor = true;
            this.botao2.Click += new System.EventHandler(this.botao2_Click);
            // 
            // numer
            // 
            this.numer.Location = new System.Drawing.Point(219, 25);
            this.numer.Name = "numer";
            this.numer.Size = new System.Drawing.Size(105, 20);
            this.numer.TabIndex = 2;
            this.numer.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numer.ValueChanged += new System.EventHandler(this.numer_ValueChanged);
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(30, 209);
            this.text1.Multiline = true;
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(494, 75);
            this.text1.TabIndex = 3;
            // 
            // text2
            // 
            this.text2.Location = new System.Drawing.Point(30, 319);
            this.text2.Multiline = true;
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(494, 77);
            this.text2.TabIndex = 4;
            // 
            // text3
            // 
            this.text3.Location = new System.Drawing.Point(30, 431);
            this.text3.Multiline = true;
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(494, 67);
            this.text3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(488, 504);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Escolha um número de 10  a 100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Chave pública";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "E";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(485, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "N";
            // 
            // keye
            // 
            this.keye.AutoSize = true;
            this.keye.Location = new System.Drawing.Point(421, 68);
            this.keye.Name = "keye";
            this.keye.Size = new System.Drawing.Size(13, 13);
            this.keye.TabIndex = 11;
            this.keye.Text = "0";
            this.keye.Click += new System.EventHandler(this.e_Click);
            // 
            // keyn
            // 
            this.keyn.AutoSize = true;
            this.keyn.Location = new System.Drawing.Point(485, 68);
            this.keyn.Name = "keyn";
            this.keyn.Size = new System.Drawing.Size(13, 13);
            this.keyn.TabIndex = 12;
            this.keyn.Text = "0";
            this.keyn.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Chave privada";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(422, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "P";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(465, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Q";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(526, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "D(E)";
            // 
            // keyp
            // 
            this.keyp.AutoSize = true;
            this.keyp.Location = new System.Drawing.Point(423, 135);
            this.keyp.Name = "keyp";
            this.keyp.Size = new System.Drawing.Size(13, 13);
            this.keyp.TabIndex = 17;
            this.keyp.Text = "0";
            // 
            // keyq
            // 
            this.keyq.AutoSize = true;
            this.keyq.Location = new System.Drawing.Point(468, 135);
            this.keyq.Name = "keyq";
            this.keyq.Size = new System.Drawing.Size(13, 13);
            this.keyq.TabIndex = 18;
            this.keyq.Text = "0";
            // 
            // keyde
            // 
            this.keyde.AutoSize = true;
            this.keyde.Location = new System.Drawing.Point(529, 135);
            this.keyde.Name = "keyde";
            this.keyde.Size = new System.Drawing.Size(13, 13);
            this.keyde.TabIndex = 19;
            this.keyde.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(431, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Obs: Pedimos para que seja evitado o uso de acentos para uma leitura boa da cript" +
    "ografia";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 539);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.keyde);
            this.Controls.Add(this.keyq);
            this.Controls.Add(this.keyp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.keyn);
            this.Controls.Add(this.keye);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.numer);
            this.Controls.Add(this.botao2);
            this.Controls.Add(this.botao1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botao1;
        private System.Windows.Forms.Button botao2;
        private System.Windows.Forms.NumericUpDown numer;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.TextBox text3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label keye;
        private System.Windows.Forms.Label keyn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label keyp;
        private System.Windows.Forms.Label keyq;
        private System.Windows.Forms.Label keyde;
        private System.Windows.Forms.Label label5;
    }
}

