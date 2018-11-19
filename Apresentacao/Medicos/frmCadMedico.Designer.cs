namespace Apresentacao.Medicos
{
    partial class frmCadMedico
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grbEndereco = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCRM = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.rbOutro = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.gbContato = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefoneCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.grbEndereco.SuspendLayout();
            this.gbContato.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCPF);
            this.groupBox1.Controls.Add(this.dtpNascimento);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.rbOutro);
            this.groupBox1.Controls.Add(this.rbFeminino);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.rbMasculino);
            this.groupBox1.Controls.Add(this.txtIdade);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtCRM);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtRG);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoais";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(10, 36);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(301, 22);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "RG:";
            // 
            // txtRG
            // 
            this.txtRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRG.Location = new System.Drawing.Point(10, 80);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(115, 22);
            this.txtRG.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CPF:";
            // 
            // grbEndereco
            // 
            this.grbEndereco.Controls.Add(this.txtCEP);
            this.grbEndereco.Controls.Add(this.cboEstado);
            this.grbEndereco.Controls.Add(this.label8);
            this.grbEndereco.Controls.Add(this.txtBairro);
            this.grbEndereco.Controls.Add(this.label7);
            this.grbEndereco.Controls.Add(this.label6);
            this.grbEndereco.Controls.Add(this.txtCidade);
            this.grbEndereco.Controls.Add(this.label5);
            this.grbEndereco.Controls.Add(this.txtEndereco);
            this.grbEndereco.Controls.Add(this.label4);
            this.grbEndereco.Location = new System.Drawing.Point(12, 181);
            this.grbEndereco.Name = "grbEndereco";
            this.grbEndereco.Size = new System.Drawing.Size(549, 168);
            this.grbEndereco.TabIndex = 1;
            this.grbEndereco.TabStop = false;
            this.grbEndereco.Text = "Endereço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(10, 47);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(301, 22);
            this.txtEndereco.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cidade:";
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(10, 91);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(152, 22);
            this.txtCidade.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "CEP:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Bairro:";
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(10, 135);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(152, 22);
            this.txtBairro.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(166, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Estado:";
            // 
            // cboEstado
            // 
            this.cboEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "Selecione",
            "Acre (AC)",
            "Alagoas (AL)",
            "Amapá (AP)",
            "Amazonas (AM)",
            "Bahia (BA)",
            "Ceará (CE)",
            "Distrito Federal (DF)",
            "Espírito Santo (ES)",
            "Goiás (GO)",
            "Maranhão (MA)",
            "Mato Grosso (MT)",
            "Mato Grosso do Sul (MS)",
            "Minas Gerais (MG)",
            "Pará (PA) ",
            "Paraíba (PB)",
            "Paraná (PR)",
            "Pernambuco (PE)",
            "Piauí (PI)",
            "Rio de Janeiro (RJ)",
            "Rio Grande do Norte (RN)",
            "Rio Grande do Sul (RS)",
            "Rondônia (RO)",
            "Roraima (RR)",
            "Santa Catarina (SC)",
            "São Paulo (SP)",
            "Sergipe (SE)",
            "Tocantins (TO)"});
            this.cboEstado.Location = new System.Drawing.Point(169, 135);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(142, 24);
            this.cboEstado.TabIndex = 9;
            this.cboEstado.Text = "Selecione";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "CRM:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtCRM
            // 
            this.txtCRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCRM.Location = new System.Drawing.Point(10, 126);
            this.txtCRM.Name = "txtCRM";
            this.txtCRM.Size = new System.Drawing.Size(115, 22);
            this.txtCRM.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(185, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(185, 48);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(301, 22);
            this.txtEmail.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(260, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Idade:";
            // 
            // txtIdade
            // 
            this.txtIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdade.Location = new System.Drawing.Point(263, 127);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(48, 22);
            this.txtIdade.TabIndex = 11;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Checked = true;
            this.rbMasculino.Location = new System.Drawing.Point(326, 83);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 12;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(323, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Sexo:";
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Location = new System.Drawing.Point(406, 83);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbFeminino.TabIndex = 14;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // rbOutro
            // 
            this.rbOutro.AutoSize = true;
            this.rbOutro.Location = new System.Drawing.Point(479, 83);
            this.rbOutro.Name = "rbOutro";
            this.rbOutro.Size = new System.Drawing.Size(51, 17);
            this.rbOutro.TabIndex = 15;
            this.rbOutro.TabStop = true;
            this.rbOutro.Text = "Outro";
            this.rbOutro.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(132, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Nascimento:";
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(135, 126);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(122, 22);
            this.dtpNascimento.TabIndex = 17;
            // 
            // gbContato
            // 
            this.gbContato.Controls.Add(this.txtTelefoneCelular);
            this.gbContato.Controls.Add(this.txtTelefone);
            this.gbContato.Controls.Add(this.label15);
            this.gbContato.Controls.Add(this.label14);
            this.gbContato.Controls.Add(this.txtEmail);
            this.gbContato.Controls.Add(this.label10);
            this.gbContato.Location = new System.Drawing.Point(13, 355);
            this.gbContato.Name = "gbContato";
            this.gbContato.Size = new System.Drawing.Size(548, 144);
            this.gbContato.TabIndex = 2;
            this.gbContato.TabStop = false;
            this.gbContato.Text = "Contato";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Telefone:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 88);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Telefone Celular:";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(170, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Gravar Médico";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(275, 517);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 44);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtCEP
            // 
            this.txtCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCEP.Location = new System.Drawing.Point(172, 90);
            this.txtCEP.Mask = "00000-000";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(139, 22);
            this.txtCEP.TabIndex = 10;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(9, 50);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(152, 22);
            this.txtTelefone.TabIndex = 10;
            // 
            // txtTelefoneCelular
            // 
            this.txtTelefoneCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefoneCelular.Location = new System.Drawing.Point(9, 104);
            this.txtTelefoneCelular.Name = "txtTelefoneCelular";
            this.txtTelefoneCelular.Size = new System.Drawing.Size(152, 22);
            this.txtTelefoneCelular.TabIndex = 11;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(135, 79);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(176, 20);
            this.txtCPF.TabIndex = 18;
            // 
            // frmCadMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 573);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbContato);
            this.Controls.Add(this.grbEndereco);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCadMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Médicos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbEndereco.ResumeLayout(false);
            this.grbEndereco.PerformLayout();
            this.gbContato.ResumeLayout(false);
            this.gbContato.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbEndereco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCRM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton rbOutro;
        private System.Windows.Forms.RadioButton rbFeminino;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.GroupBox gbContato;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.MaskedTextBox txtTelefoneCelular;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox txtCPF;
    }
}