namespace Locadora.Apresentacao.WinForm.ModuloPlanoCobranca
{
    partial class TelaPlanoCobrancaDiario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxValorDiarioPlanoDiario = new System.Windows.Forms.TextBox();
            this.textBoxValorPorKmPlanoDiario = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor Diário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor Por Km";
            // 
            // textBoxValorDiarioPlanoDiario
            // 
            this.textBoxValorDiarioPlanoDiario.Location = new System.Drawing.Point(12, 44);
            this.textBoxValorDiarioPlanoDiario.Name = "textBoxValorDiarioPlanoDiario";
            this.textBoxValorDiarioPlanoDiario.Size = new System.Drawing.Size(127, 23);
            this.textBoxValorDiarioPlanoDiario.TabIndex = 2;
            // 
            // textBoxValorPorKmPlanoDiario
            // 
            this.textBoxValorPorKmPlanoDiario.Location = new System.Drawing.Point(12, 88);
            this.textBoxValorPorKmPlanoDiario.Name = "textBoxValorPorKmPlanoDiario";
            this.textBoxValorPorKmPlanoDiario.Size = new System.Drawing.Size(127, 23);
            this.textBoxValorPorKmPlanoDiario.TabIndex = 3;
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(137, 121);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(64, 23);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.Location = new System.Drawing.Point(207, 121);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(64, 23);
            this.buttonCancelar.TabIndex = 5;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaPlanoCobrancaDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 156);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxValorPorKmPlanoDiario);
            this.Controls.Add(this.textBoxValorDiarioPlanoDiario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaPlanoCobrancaDiario";
            this.Text = "Plano Diário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxValorDiarioPlanoDiario;
        private System.Windows.Forms.TextBox textBoxValorPorKmPlanoDiario;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancelar;
    }
}