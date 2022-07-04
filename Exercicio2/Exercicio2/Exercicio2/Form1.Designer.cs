namespace Exercicio2
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
            this.components = new System.ComponentModel.Container();
            this.pBarCarga = new System.Windows.Forms.ProgressBar();
            this.btnLigarDesligar = new System.Windows.Forms.Button();
            this.lblBateria = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cBoxOn = new System.Windows.Forms.CheckBox();
            this.cBoxOff = new System.Windows.Forms.CheckBox();
            this.btnTrocar = new System.Windows.Forms.Button();
            this.lblLaterna = new System.Windows.Forms.Label();
            this.txtBoxPorcentagem = new System.Windows.Forms.TextBox();
            this.timerControle = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pBarCarga
            // 
            this.pBarCarga.Location = new System.Drawing.Point(55, 22);
            this.pBarCarga.Name = "pBarCarga";
            this.pBarCarga.Size = new System.Drawing.Size(113, 22);
            this.pBarCarga.Step = 1;
            this.pBarCarga.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pBarCarga.TabIndex = 0;
            this.pBarCarga.Value = 100;
            // 
            // btnLigarDesligar
            // 
            this.btnLigarDesligar.Location = new System.Drawing.Point(15, 119);
            this.btnLigarDesligar.Name = "btnLigarDesligar";
            this.btnLigarDesligar.Size = new System.Drawing.Size(82, 23);
            this.btnLigarDesligar.TabIndex = 1;
            this.btnLigarDesligar.Text = "Ligar/Desligar";
            this.btnLigarDesligar.UseVisualStyleBackColor = true;
            this.btnLigarDesligar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblBateria
            // 
            this.lblBateria.AutoSize = true;
            this.lblBateria.Location = new System.Drawing.Point(12, 31);
            this.lblBateria.Name = "lblBateria";
            this.lblBateria.Size = new System.Drawing.Size(43, 13);
            this.lblBateria.TabIndex = 3;
            this.lblBateria.Text = "Bateria:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 60);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(85, 13);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status Lanterna:";
            this.lblStatus.Click += new System.EventHandler(this.label2_Click);
            // 
            // cBoxOn
            // 
            this.cBoxOn.AutoSize = true;
            this.cBoxOn.Location = new System.Drawing.Point(103, 60);
            this.cBoxOn.Name = "cBoxOn";
            this.cBoxOn.Size = new System.Drawing.Size(40, 17);
            this.cBoxOn.TabIndex = 6;
            this.cBoxOn.Text = "On";
            this.cBoxOn.UseVisualStyleBackColor = true;
            // 
            // cBoxOff
            // 
            this.cBoxOff.AutoSize = true;
            this.cBoxOff.Location = new System.Drawing.Point(103, 83);
            this.cBoxOff.Name = "cBoxOff";
            this.cBoxOff.Size = new System.Drawing.Size(40, 17);
            this.cBoxOff.TabIndex = 7;
            this.cBoxOff.Text = "Off";
            this.cBoxOff.UseVisualStyleBackColor = true;
            // 
            // btnTrocar
            // 
            this.btnTrocar.Location = new System.Drawing.Point(103, 119);
            this.btnTrocar.Name = "btnTrocar";
            this.btnTrocar.Size = new System.Drawing.Size(104, 23);
            this.btnTrocar.TabIndex = 8;
            this.btnTrocar.Text = "Trocar Bateria";
            this.btnTrocar.UseVisualStyleBackColor = true;
            this.btnTrocar.Click += new System.EventHandler(this.btnTrocar_Click);
            // 
            // lblLaterna
            // 
            this.lblLaterna.AutoSize = true;
            this.lblLaterna.Location = new System.Drawing.Point(12, 103);
            this.lblLaterna.Name = "lblLaterna";
            this.lblLaterna.Size = new System.Drawing.Size(118, 13);
            this.lblLaterna.TabIndex = 5;
            this.lblLaterna.Text = "Ligar/Desligar Lanterna";
            this.lblLaterna.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtBoxPorcentagem
            // 
            this.txtBoxPorcentagem.Location = new System.Drawing.Point(174, 24);
            this.txtBoxPorcentagem.Name = "txtBoxPorcentagem";
            this.txtBoxPorcentagem.ReadOnly = true;
            this.txtBoxPorcentagem.Size = new System.Drawing.Size(35, 20);
            this.txtBoxPorcentagem.TabIndex = 10;
            this.txtBoxPorcentagem.Text = "100%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 191);
            this.Controls.Add(this.txtBoxPorcentagem);
            this.Controls.Add(this.btnTrocar);
            this.Controls.Add(this.cBoxOff);
            this.Controls.Add(this.cBoxOn);
            this.Controls.Add(this.lblLaterna);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblBateria);
            this.Controls.Add(this.btnLigarDesligar);
            this.Controls.Add(this.pBarCarga);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pBarCarga;
        private System.Windows.Forms.Button btnLigarDesligar;
        private System.Windows.Forms.Label lblBateria;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox cBoxOn;
        private System.Windows.Forms.CheckBox cBoxOff;
        private System.Windows.Forms.Button btnTrocar;
        private System.Windows.Forms.Label lblLaterna;
        private System.Windows.Forms.TextBox txtBoxPorcentagem;
        private System.Windows.Forms.Timer timerControle;
    }
}

