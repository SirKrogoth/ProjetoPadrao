namespace Apresentacao
{
    partial class frmCadPaciente
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
            this.gbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.cboEstadoCivil = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMae = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbOutro = new System.Windows.Forms.RadioButton();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbEndereco = new System.Windows.Forms.GroupBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbContato = new System.Windows.Forms.GroupBox();
            this.txtTelefoneResponsavel = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtResponsavel = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTelefoneCelular = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTelefonePrincipal = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gbDadosPessoais.SuspendLayout();
            this.gbEndereco.SuspendLayout();
            this.gbContato.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDadosPessoais
            // 
            this.gbDadosPessoais.Controls.Add(this.cboEstadoCivil);
            this.gbDadosPessoais.Controls.Add(this.label11);
            this.gbDadosPessoais.Controls.Add(this.txtMae);
            this.gbDadosPessoais.Controls.Add(this.label6);
            this.gbDadosPessoais.Controls.Add(this.txtPai);
            this.gbDadosPessoais.Controls.Add(this.label5);
            this.gbDadosPessoais.Controls.Add(this.rbOutro);
            this.gbDadosPessoais.Controls.Add(this.rbFeminino);
            this.gbDadosPessoais.Controls.Add(this.rbMasculino);
            this.gbDadosPessoais.Controls.Add(this.label4);
            this.gbDadosPessoais.Controls.Add(this.txtRG);
            this.gbDadosPessoais.Controls.Add(this.label3);
            this.gbDadosPessoais.Controls.Add(this.txtCPF);
            this.gbDadosPessoais.Controls.Add(this.label2);
            this.gbDadosPessoais.Controls.Add(this.txtNome);
            this.gbDadosPessoais.Controls.Add(this.label1);
            this.gbDadosPessoais.Location = new System.Drawing.Point(12, 12);
            this.gbDadosPessoais.Name = "gbDadosPessoais";
            this.gbDadosPessoais.Size = new System.Drawing.Size(701, 209);
            this.gbDadosPessoais.TabIndex = 0;
            this.gbDadosPessoais.TabStop = false;
            this.gbDadosPessoais.Text = "Dados Pessoais";
            // 
            // cboEstadoCivil
            // 
            this.cboEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstadoCivil.FormattingEnabled = true;
            this.cboEstadoCivil.Items.AddRange(new object[] {
            "Selecione",
            "Solteiro(a)",
            "Casado(a)",
            "Divorciado(a)",
            "Viúvo(a)"});
            this.cboEstadoCivil.Location = new System.Drawing.Point(458, 82);
            this.cboEstadoCivil.Name = "cboEstadoCivil";
            this.cboEstadoCivil.Size = new System.Drawing.Size(121, 24);
            this.cboEstadoCivil.TabIndex = 7;
            this.cboEstadoCivil.Text = "Selecione";
            this.cboEstadoCivil.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboEstadoCivil_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(455, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Estado civíl";
            // 
            // txtMae
            // 
            this.txtMae.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMae.Location = new System.Drawing.Point(23, 174);
            this.txtMae.Name = "txtMae";
            this.txtMae.Size = new System.Drawing.Size(387, 22);
            this.txtMae.TabIndex = 9;
            this.txtMae.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nome da mãe";
            // 
            // txtPai
            // 
            this.txtPai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPai.Location = new System.Drawing.Point(23, 128);
            this.txtPai.Name = "txtPai";
            this.txtPai.Size = new System.Drawing.Size(387, 22);
            this.txtPai.TabIndex = 8;
            this.txtPai.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nome do pai";
            // 
            // rbOutro
            // 
            this.rbOutro.AutoSize = true;
            this.rbOutro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOutro.Location = new System.Drawing.Point(637, 41);
            this.rbOutro.Name = "rbOutro";
            this.rbOutro.Size = new System.Drawing.Size(58, 20);
            this.rbOutro.TabIndex = 4;
            this.rbOutro.TabStop = true;
            this.rbOutro.Text = "Outro";
            this.rbOutro.UseVisualStyleBackColor = true;
            this.rbOutro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbOutro_KeyDown);
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFeminino.Location = new System.Drawing.Point(551, 41);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(81, 20);
            this.rbFeminino.TabIndex = 3;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            this.rbFeminino.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbFeminino_KeyDown);
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Checked = true;
            this.rbMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMasculino.Location = new System.Drawing.Point(458, 41);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(87, 20);
            this.rbMasculino.TabIndex = 2;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            this.rbMasculino.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbMasculino_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(455, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sexo";
            // 
            // txtRG
            // 
            this.txtRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRG.Location = new System.Drawing.Point(200, 82);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(210, 22);
            this.txtRG.TabIndex = 6;
            this.txtRG.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRG_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "RG";
            // 
            // txtCPF
            // 
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(23, 83);
            this.txtCPF.Mask = "###.###.###-##";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(167, 22);
            this.txtCPF.TabIndex = 5;
            this.txtCPF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCPF_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(23, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(387, 22);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // gbEndereco
            // 
            this.gbEndereco.Controls.Add(this.cboEstado);
            this.gbEndereco.Controls.Add(this.label10);
            this.gbEndereco.Controls.Add(this.txtCidade);
            this.gbEndereco.Controls.Add(this.label9);
            this.gbEndereco.Controls.Add(this.txtCEP);
            this.gbEndereco.Controls.Add(this.label8);
            this.gbEndereco.Controls.Add(this.txtBairro);
            this.gbEndereco.Controls.Add(this.label7);
            this.gbEndereco.Location = new System.Drawing.Point(13, 228);
            this.gbEndereco.Name = "gbEndereco";
            this.gbEndereco.Size = new System.Drawing.Size(700, 141);
            this.gbEndereco.TabIndex = 1;
            this.gbEndereco.TabStop = false;
            this.gbEndereco.Text = "Endereço";
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
            this.cboEstado.Location = new System.Drawing.Point(445, 37);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(121, 24);
            this.cboEstado.TabIndex = 12;
            this.cboEstado.Text = "Selecione";
            this.cboEstado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboEstado_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(442, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Estado";
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(215, 37);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(194, 22);
            this.txtCidade.TabIndex = 11;
            this.txtCidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCidade_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(212, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Cidade";
            // 
            // txtCEP
            // 
            this.txtCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCEP.Location = new System.Drawing.Point(22, 37);
            this.txtCEP.Mask = "#####-###";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(157, 22);
            this.txtCEP.TabIndex = 10;
            this.txtCEP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox1_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "CEP";
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(22, 93);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(157, 22);
            this.txtBairro.TabIndex = 1;
            this.txtBairro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBairro_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Bairro";
            // 
            // gbContato
            // 
            this.gbContato.Controls.Add(this.txtTelefoneResponsavel);
            this.gbContato.Controls.Add(this.label15);
            this.gbContato.Controls.Add(this.txtResponsavel);
            this.gbContato.Controls.Add(this.label14);
            this.gbContato.Controls.Add(this.txtTelefoneCelular);
            this.gbContato.Controls.Add(this.label13);
            this.gbContato.Controls.Add(this.txtTelefonePrincipal);
            this.gbContato.Controls.Add(this.label12);
            this.gbContato.Location = new System.Drawing.Point(13, 376);
            this.gbContato.Name = "gbContato";
            this.gbContato.Size = new System.Drawing.Size(700, 140);
            this.gbContato.TabIndex = 2;
            this.gbContato.TabStop = false;
            this.gbContato.Text = "Contato";
            // 
            // txtTelefoneResponsavel
            // 
            this.txtTelefoneResponsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefoneResponsavel.Location = new System.Drawing.Point(436, 83);
            this.txtTelefoneResponsavel.Mask = "(999) 00000-0000";
            this.txtTelefoneResponsavel.Name = "txtTelefoneResponsavel";
            this.txtTelefoneResponsavel.Size = new System.Drawing.Size(157, 22);
            this.txtTelefoneResponsavel.TabIndex = 16;
            this.txtTelefoneResponsavel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTelefoneResponsavel_KeyDown);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(433, 65);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Telefone do responsável";
            // 
            // txtResponsavel
            // 
            this.txtResponsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResponsavel.Location = new System.Drawing.Point(22, 83);
            this.txtResponsavel.Name = "txtResponsavel";
            this.txtResponsavel.Size = new System.Drawing.Size(387, 22);
            this.txtResponsavel.TabIndex = 15;
            this.txtResponsavel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtResponsavel_KeyDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Responsável";
            // 
            // txtTelefoneCelular
            // 
            this.txtTelefoneCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefoneCelular.Location = new System.Drawing.Point(218, 37);
            this.txtTelefoneCelular.Mask = "(999) 00000-0000";
            this.txtTelefoneCelular.Name = "txtTelefoneCelular";
            this.txtTelefoneCelular.Size = new System.Drawing.Size(157, 22);
            this.txtTelefoneCelular.TabIndex = 14;
            this.txtTelefoneCelular.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTelefoneCelular_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(215, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Telefone Celular";
            // 
            // txtTelefonePrincipal
            // 
            this.txtTelefonePrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonePrincipal.Location = new System.Drawing.Point(22, 37);
            this.txtTelefonePrincipal.Mask = "(999) 00000-0000";
            this.txtTelefonePrincipal.Name = "txtTelefonePrincipal";
            this.txtTelefonePrincipal.Size = new System.Drawing.Size(157, 22);
            this.txtTelefonePrincipal.TabIndex = 13;
            this.txtTelefonePrincipal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTelefonePrincipal_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Telefone Principal";
            // 
            // btnGravar
            // 
            this.btnGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(231, 522);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 53);
            this.btnGravar.TabIndex = 17;
            this.btnGravar.Text = "Gravar Paciente";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            this.btnGravar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnGravar_KeyDown);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(347, 522);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 53);
            this.btnLimpar.TabIndex = 18;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            this.btnLimpar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnLimpar_KeyDown);
            // 
            // frmCadPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 600);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.gbContato);
            this.Controls.Add(this.gbEndereco);
            this.Controls.Add(this.gbDadosPessoais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCadPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pacientes";
            this.gbDadosPessoais.ResumeLayout(false);
            this.gbDadosPessoais.PerformLayout();
            this.gbEndereco.ResumeLayout(false);
            this.gbEndereco.PerformLayout();
            this.gbContato.ResumeLayout(false);
            this.gbContato.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDadosPessoais;
        private System.Windows.Forms.ComboBox cboEstadoCivil;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMae;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbOutro;
        private System.Windows.Forms.RadioButton rbFeminino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbEndereco;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbContato;
        private System.Windows.Forms.MaskedTextBox txtTelefoneResponsavel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtResponsavel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox txtTelefoneCelular;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox txtTelefonePrincipal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnLimpar;
    }
}