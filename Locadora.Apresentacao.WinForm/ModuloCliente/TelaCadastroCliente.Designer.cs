namespace Locadora.Apresentacao.WinForm.ModuloCliente
{
    partial class TelaCadastroCliente
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
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.labelNome = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textCPF = new System.Windows.Forms.TextBox();
            this.labelCpf = new System.Windows.Forms.Label();
            this.textCNPJ = new System.Windows.Forms.TextBox();
            this.labelCNPJ = new System.Windows.Forms.Label();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.textCNH = new System.Windows.Forms.TextBox();
            this.labelCNH = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textTelefone = new System.Windows.Forms.TextBox();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxTipoCadastro = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBoxTipoCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInserir
            // 
            this.btnInserir.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnInserir.Location = new System.Drawing.Point(538, 340);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(91, 33);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(441, 340);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 33);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(12, 58);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(40, 15);
            this.labelNome.TabIndex = 2;
            this.labelNome.Text = "Nome";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(12, 76);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(324, 23);
            this.textNome.TabIndex = 3;
            // 
            // textCPF
            // 
            this.textCPF.Location = new System.Drawing.Point(12, 120);
            this.textCPF.Name = "textCPF";
            this.textCPF.Size = new System.Drawing.Size(324, 23);
            this.textCPF.TabIndex = 5;
            // 
            // labelCpf
            // 
            this.labelCpf.AutoSize = true;
            this.labelCpf.Location = new System.Drawing.Point(12, 102);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(28, 15);
            this.labelCpf.TabIndex = 4;
            this.labelCpf.Text = "CPF";
            this.labelCpf.Click += new System.EventHandler(this.labelCpf_Click);
            // 
            // textCNPJ
            // 
            this.textCNPJ.Location = new System.Drawing.Point(12, 164);
            this.textCNPJ.Name = "textCNPJ";
            this.textCNPJ.Size = new System.Drawing.Size(324, 23);
            this.textCNPJ.TabIndex = 7;
            // 
            // labelCNPJ
            // 
            this.labelCNPJ.AutoSize = true;
            this.labelCNPJ.Location = new System.Drawing.Point(12, 146);
            this.labelCNPJ.Name = "labelCNPJ";
            this.labelCNPJ.Size = new System.Drawing.Size(34, 15);
            this.labelCNPJ.TabIndex = 6;
            this.labelCNPJ.Text = "CNPJ";
            // 
            // textEndereco
            // 
            this.textEndereco.Location = new System.Drawing.Point(12, 208);
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.Size = new System.Drawing.Size(324, 23);
            this.textEndereco.TabIndex = 9;
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Location = new System.Drawing.Point(12, 190);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelEndereco.Size = new System.Drawing.Size(56, 15);
            this.labelEndereco.TabIndex = 8;
            this.labelEndereco.Text = "Endereço";
            // 
            // textCNH
            // 
            this.textCNH.Location = new System.Drawing.Point(12, 252);
            this.textCNH.Name = "textCNH";
            this.textCNH.Size = new System.Drawing.Size(324, 23);
            this.textCNH.TabIndex = 11;
            // 
            // labelCNH
            // 
            this.labelCNH.AutoSize = true;
            this.labelCNH.Location = new System.Drawing.Point(12, 234);
            this.labelCNH.Name = "labelCNH";
            this.labelCNH.Size = new System.Drawing.Size(33, 15);
            this.labelCNH.TabIndex = 10;
            this.labelCNH.Text = "CNH";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(12, 296);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(324, 23);
            this.textEmail.TabIndex = 13;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(12, 278);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(36, 15);
            this.labelEmail.TabIndex = 12;
            this.labelEmail.Text = "Email";
            // 
            // textTelefone
            // 
            this.textTelefone.Location = new System.Drawing.Point(12, 340);
            this.textTelefone.Name = "textTelefone";
            this.textTelefone.Size = new System.Drawing.Size(324, 23);
            this.textTelefone.TabIndex = 15;
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(12, 322);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(51, 15);
            this.labelTelefone.TabIndex = 14;
            this.labelTelefone.Text = "Telefone";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(12, 7);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(17, 15);
            this.labelId.TabIndex = 18;
            this.labelId.Text = "Id";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(46, 23);
            this.textBox1.TabIndex = 19;
            // 
            // groupBoxTipoCadastro
            // 
            this.groupBoxTipoCadastro.Controls.Add(this.radioButton2);
            this.groupBoxTipoCadastro.Controls.Add(this.radioButton1);
            this.groupBoxTipoCadastro.Location = new System.Drawing.Point(99, 7);
            this.groupBoxTipoCadastro.Name = "groupBoxTipoCadastro";
            this.groupBoxTipoCadastro.Size = new System.Drawing.Size(237, 42);
            this.groupBoxTipoCadastro.TabIndex = 20;
            this.groupBoxTipoCadastro.TabStop = false;
            this.groupBoxTipoCadastro.Text = "Tipo Cadastro";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(94, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(137, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(94, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // TelaCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 385);
            this.Controls.Add(this.groupBoxTipoCadastro);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.textTelefone);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textCNH);
            this.Controls.Add(this.labelCNH);
            this.Controls.Add(this.textEndereco);
            this.Controls.Add(this.labelEndereco);
            this.Controls.Add(this.textCNPJ);
            this.Controls.Add(this.labelCNPJ);
            this.Controls.Add(this.textCPF);
            this.Controls.Add(this.labelCpf);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnInserir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastroCliente";
            this.Text = "TelaCadastroCliente";
            this.Load += new System.EventHandler(this.TelaCadastroCliente_Load);
            this.groupBoxTipoCadastro.ResumeLayout(false);
            this.groupBoxTipoCadastro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textCPF;
        private System.Windows.Forms.Label labelCpf;
        private System.Windows.Forms.TextBox textCNPJ;
        private System.Windows.Forms.Label labelCNPJ;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.TextBox textCNH;
        private System.Windows.Forms.Label labelCNH;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textTelefone;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxTipoCadastro;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}