namespace Locadora.Apresentacao.WinForm.ModuloTaxa
{
    partial class TelaTaxa
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
            this.checkFixo = new System.Windows.Forms.CheckBox();
            this.checkDiario = new System.Windows.Forms.CheckBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.textDescricao = new System.Windows.Forms.TextBox();
            this.ValorNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Descrição = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ValorNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // checkFixo
            // 
            this.checkFixo.AutoSize = true;
            this.checkFixo.Location = new System.Drawing.Point(28, 178);
            this.checkFixo.Name = "checkFixo";
            this.checkFixo.Size = new System.Drawing.Size(91, 19);
            this.checkFixo.TabIndex = 0;
            this.checkFixo.Text = "Calculo Fixo";
            this.checkFixo.UseVisualStyleBackColor = true;
            // 
            // checkDiario
            // 
            this.checkDiario.AutoSize = true;
            this.checkDiario.Location = new System.Drawing.Point(28, 153);
            this.checkDiario.Name = "checkDiario";
            this.checkDiario.Size = new System.Drawing.Size(100, 19);
            this.checkDiario.TabIndex = 1;
            this.checkDiario.Text = "Calculo Diario";
            this.checkDiario.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(174, 307);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 32);
            this.btnGravar.TabIndex = 2;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Location = new System.Drawing.Point(255, 307);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 32);
            this.BtnCancelar.TabIndex = 3;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // textDescricao
            // 
            this.textDescricao.Location = new System.Drawing.Point(28, 103);
            this.textDescricao.Name = "textDescricao";
            this.textDescricao.Size = new System.Drawing.Size(293, 23);
            this.textDescricao.TabIndex = 4;
            // 
            // ValorNumeric
            // 
            this.ValorNumeric.Location = new System.Drawing.Point(28, 42);
            this.ValorNumeric.Name = "ValorNumeric";
            this.ValorNumeric.Size = new System.Drawing.Size(150, 23);
            this.ValorNumeric.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Valor";
            // 
            // Descrição
            // 
            this.Descrição.AutoSize = true;
            this.Descrição.Location = new System.Drawing.Point(28, 85);
            this.Descrição.Name = "Descrição";
            this.Descrição.Size = new System.Drawing.Size(58, 15);
            this.Descrição.TabIndex = 7;
            this.Descrição.Text = "Descrição";
            // 
            // TelaTaxa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 361);
            this.Controls.Add(this.Descrição);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ValorNumeric);
            this.Controls.Add(this.textDescricao);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.checkDiario);
            this.Controls.Add(this.checkFixo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaTaxa";
            this.Text = "Cadastro de Taxa";
            ((System.ComponentModel.ISupportInitialize)(this.ValorNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkFixo;
        private System.Windows.Forms.CheckBox checkDiario;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox textDescricao;
        private System.Windows.Forms.NumericUpDown ValorNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Descrição;
    }
}