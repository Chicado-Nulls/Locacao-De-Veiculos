namespace Locadora.Apresentacao.WinForm.ModuloVeiculo
{
    partial class TelaVeiculo
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
            this.comboBoxGrupoVeiculo = new System.Windows.Forms.ComboBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxTipoCombustivel = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.textBoxPlaca = new System.Windows.Forms.TextBox();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.textBoxCor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TextBoxCapacidadeTanque = new System.Windows.Forms.TextBox();
            this.textBoxKmPercorrido = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxGrupoVeiculo
            // 
            this.comboBoxGrupoVeiculo.FormattingEnabled = true;
            this.comboBoxGrupoVeiculo.Location = new System.Drawing.Point(28, 50);
            this.comboBoxGrupoVeiculo.Name = "comboBoxGrupoVeiculo";
            this.comboBoxGrupoVeiculo.Size = new System.Drawing.Size(142, 23);
            this.comboBoxGrupoVeiculo.TabIndex = 0;
            // 
            // btnInserir
            // 
            this.btnInserir.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnInserir.Location = new System.Drawing.Point(48, 509);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(100, 42);
            this.btnInserir.TabIndex = 1;
            this.btnInserir.Text = "Enviar";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(191, 509);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Grupo De Veiculo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Placa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Marca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cor";
            // 
            // comboBoxTipoCombustivel
            // 
            this.comboBoxTipoCombustivel.FormattingEnabled = true;
            this.comboBoxTipoCombustivel.Items.AddRange(new object[] {
            "Gasolina Comum",
            "Gasolina Adtivada",
            "Etanol",
            "Eletrico"});
            this.comboBoxTipoCombustivel.Location = new System.Drawing.Point(28, 331);
            this.comboBoxTipoCombustivel.Name = "comboBoxTipoCombustivel";
            this.comboBoxTipoCombustivel.Size = new System.Drawing.Size(142, 23);
            this.comboBoxTipoCombustivel.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "TipoDeCombustivel";
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(28, 107);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(232, 23);
            this.textBoxModelo.TabIndex = 10;
            // 
            // textBoxPlaca
            // 
            this.textBoxPlaca.Location = new System.Drawing.Point(28, 161);
            this.textBoxPlaca.Name = "textBoxPlaca";
            this.textBoxPlaca.Size = new System.Drawing.Size(142, 23);
            this.textBoxPlaca.TabIndex = 11;
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(28, 218);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(232, 23);
            this.textBoxMarca.TabIndex = 12;
            // 
            // textBoxCor
            // 
            this.textBoxCor.Location = new System.Drawing.Point(28, 274);
            this.textBoxCor.Name = "textBoxCor";
            this.textBoxCor.Size = new System.Drawing.Size(232, 23);
            this.textBoxCor.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Capacidade Tanque";
            // 
            // TextBoxCapacidadeTanque
            // 
            this.TextBoxCapacidadeTanque.Location = new System.Drawing.Point(28, 386);
            this.TextBoxCapacidadeTanque.Name = "TextBoxCapacidadeTanque";
            this.TextBoxCapacidadeTanque.Size = new System.Drawing.Size(140, 23);
            this.TextBoxCapacidadeTanque.TabIndex = 15;
            // 
            // textBoxKmPercorrido
            // 
            this.textBoxKmPercorrido.Location = new System.Drawing.Point(28, 440);
            this.textBoxKmPercorrido.Name = "textBoxKmPercorrido";
            this.textBoxKmPercorrido.Size = new System.Drawing.Size(142, 23);
            this.textBoxKmPercorrido.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 422);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Km Percorrido";
            // 
            // TelaVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 563);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxKmPercorrido);
            this.Controls.Add(this.TextBoxCapacidadeTanque);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxCor);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.textBoxPlaca);
            this.Controls.Add(this.textBoxModelo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxTipoCombustivel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.comboBoxGrupoVeiculo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaVeiculo";
            this.Text = "TelaVeiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxGrupoVeiculo;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxTipoCombustivel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.TextBox textBoxPlaca;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.TextBox textBoxCor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextBoxCapacidadeTanque;
        private System.Windows.Forms.TextBox textBoxKmPercorrido;
        private System.Windows.Forms.Label label8;
    }
}