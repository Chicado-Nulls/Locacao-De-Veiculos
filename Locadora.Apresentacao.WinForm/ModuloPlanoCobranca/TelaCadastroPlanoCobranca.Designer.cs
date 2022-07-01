namespace Locadora.Apresentacao.WinForm.ModuloPlanoCobranca
{
    partial class TelaCadastroPlanoCobranca
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
            this.buttonDiario = new System.Windows.Forms.Button();
            this.buttonLivre = new System.Windows.Forms.Button();
            this.buttonControlado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxGrupoVeiculo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonDiario
            // 
            this.buttonDiario.Location = new System.Drawing.Point(12, 88);
            this.buttonDiario.Name = "buttonDiario";
            this.buttonDiario.Size = new System.Drawing.Size(120, 44);
            this.buttonDiario.TabIndex = 2;
            this.buttonDiario.Text = "Plano Diário";
            this.buttonDiario.UseVisualStyleBackColor = true;
            // 
            // buttonLivre
            // 
            this.buttonLivre.Location = new System.Drawing.Point(138, 88);
            this.buttonLivre.Name = "buttonLivre";
            this.buttonLivre.Size = new System.Drawing.Size(120, 44);
            this.buttonLivre.TabIndex = 3;
            this.buttonLivre.Text = "Plano Livre";
            this.buttonLivre.UseVisualStyleBackColor = true;
            // 
            // buttonControlado
            // 
            this.buttonControlado.Location = new System.Drawing.Point(264, 88);
            this.buttonControlado.Name = "buttonControlado";
            this.buttonControlado.Size = new System.Drawing.Size(120, 44);
            this.buttonControlado.TabIndex = 4;
            this.buttonControlado.Text = "Plano Controlado";
            this.buttonControlado.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grupo de veículo";
            // 
            // comboBoxGrupoVeiculo
            // 
            this.comboBoxGrupoVeiculo.FormattingEnabled = true;
            this.comboBoxGrupoVeiculo.Location = new System.Drawing.Point(12, 27);
            this.comboBoxGrupoVeiculo.Name = "comboBoxGrupoVeiculo";
            this.comboBoxGrupoVeiculo.Size = new System.Drawing.Size(121, 23);
            this.comboBoxGrupoVeiculo.TabIndex = 5;
            
            // 
            // TelaCadastroPlanoCobranca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 144);
            this.Controls.Add(this.comboBoxGrupoVeiculo);
            this.Controls.Add(this.buttonControlado);
            this.Controls.Add(this.buttonLivre);
            this.Controls.Add(this.buttonDiario);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastroPlanoCobranca";
            this.Text = "Plano de Cobrança";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDiario;
        private System.Windows.Forms.Button buttonLivre;
        private System.Windows.Forms.Button buttonControlado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxGrupoVeiculo;
    }
}