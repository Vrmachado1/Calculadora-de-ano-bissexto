﻿namespace WindowsFormsApp6
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAinicial = new System.Windows.Forms.TextBox();
            this.txtAfinal = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lstAnos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ano inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ano final";
            // 
            // txtAinicial
            // 
            this.txtAinicial.Location = new System.Drawing.Point(87, 6);
            this.txtAinicial.Name = "txtAinicial";
            this.txtAinicial.Size = new System.Drawing.Size(100, 20);
            this.txtAinicial.TabIndex = 2;
            // 
            // txtAfinal
            // 
            this.txtAfinal.Location = new System.Drawing.Point(87, 48);
            this.txtAfinal.Name = "txtAfinal";
            this.txtAfinal.Size = new System.Drawing.Size(100, 20);
            this.txtAfinal.TabIndex = 3;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(221, 6);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(138, 62);
            this.btnVerificar.TabIndex = 4;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lstAnos
            // 
            this.lstAnos.FormattingEnabled = true;
            this.lstAnos.Location = new System.Drawing.Point(15, 92);
            this.lstAnos.Name = "lstAnos";
            this.lstAnos.Size = new System.Drawing.Size(172, 95);
            this.lstAnos.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstAnos);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtAfinal);
            this.Controls.Add(this.txtAinicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAinicial;
        private System.Windows.Forms.TextBox txtAfinal;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.ListBox lstAnos;
    }
}

