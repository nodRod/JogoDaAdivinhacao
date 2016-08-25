namespace JogoDaAdivinhacao
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
            this.btnPalpite = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTentativas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPalpite = new System.Windows.Forms.TextBox();
            this.lbInform = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbResposta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPalpite
            // 
            this.btnPalpite.Location = new System.Drawing.Point(36, 133);
            this.btnPalpite.Name = "btnPalpite";
            this.btnPalpite.Size = new System.Drawing.Size(201, 30);
            this.btnPalpite.TabIndex = 0;
            this.btnPalpite.Text = "Enviar meu palpite";
            this.btnPalpite.UseVisualStyleBackColor = true;
            this.btnPalpite.Click += new System.EventHandler(this.btnPalpite_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "TENTATIVAS:";
            // 
            // lbTentativas
            // 
            this.lbTentativas.AutoSize = true;
            this.lbTentativas.Location = new System.Drawing.Point(89, 47);
            this.lbTentativas.Name = "lbTentativas";
            this.lbTentativas.Size = new System.Drawing.Size(0, 13);
            this.lbTentativas.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mensagem:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Seu palpite:";
            // 
            // txtPalpite
            // 
            this.txtPalpite.Location = new System.Drawing.Point(81, 94);
            this.txtPalpite.Name = "txtPalpite";
            this.txtPalpite.Size = new System.Drawing.Size(156, 20);
            this.txtPalpite.TabIndex = 6;
            // 
            // lbInform
            // 
            this.lbInform.AutoSize = true;
            this.lbInform.Location = new System.Drawing.Point(78, 117);
            this.lbInform.Name = "lbInform";
            this.lbInform.Size = new System.Drawing.Size(159, 13);
            this.lbInform.TabIndex = 7;
            this.lbInform.Text = "OBS: Digite números de 0 a 100";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "BEM VINDO!";
            // 
            // lbResposta
            // 
            this.lbResposta.AutoSize = true;
            this.lbResposta.Location = new System.Drawing.Point(78, 180);
            this.lbResposta.Name = "lbResposta";
            this.lbResposta.Size = new System.Drawing.Size(0, 13);
            this.lbResposta.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 262);
            this.Controls.Add(this.lbResposta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbInform);
            this.Controls.Add(this.txtPalpite);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTentativas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPalpite);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPalpite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTentativas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPalpite;
        private System.Windows.Forms.Label lbInform;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbResposta;
    }
}

