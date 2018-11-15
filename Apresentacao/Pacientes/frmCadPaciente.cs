using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjetoTransferencia;
using Modelo;
using ProjetoPadrao;

namespace Apresentacao
{
    public partial class frmCadPaciente : Form
    {
        public frmCadPaciente()
        {
            InitializeComponent();
        }

        public frmCadPaciente(Pacientes.PacienteEnum acao, Paciente paciente)
        {
            InitializeComponent();

            if(acao == Pacientes.PacienteEnum.Atualizar)
            {
                txtNome.Text = paciente.nome;

                if (paciente.sexo == 'M')
                    rbMasculino.Checked = true;
                else if (paciente.sexo == 'F')
                    rbFeminino.Checked = true;
                else
                    rbOutro.Checked = true;

                txtCPF.Text = paciente.cpf;
                txtRG.Text = paciente.rg;
                cboEstadoCivil.Text = paciente.estadoCivil;
                txtPai.Text = paciente.pai;
                txtMae.Text = paciente.mae;
                txtCEP.Text = paciente.cep;
                txtCidade.Text = paciente.cidade;
                cboEstado.Text = paciente.estado;
                txtBairro.Text = paciente.bairro;
                txtTelefonePrincipal.Text = paciente.telefone;
                txtTelefoneCelular.Text = paciente.celular;
                txtResponsavel.Text = paciente.responsavel;
                txtTelefoneResponsavel.Text = paciente.telefoneResponsavel;
                this.Tag = paciente.codigo;
                btnGravar.Text = "Alterar Paciente";
            }
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            FecharTelaEsc(e);
        }

        private void rbMasculino_KeyDown(object sender, KeyEventArgs e)
        {
            FecharTelaEsc(e);
        }

        private void rbFeminino_KeyDown(object sender, KeyEventArgs e)
        {
            FecharTelaEsc(e);
        }

        private void rbOutro_KeyDown(object sender, KeyEventArgs e)
        {
            FecharTelaEsc(e);
        }

        private void txtCPF_KeyDown(object sender, KeyEventArgs e)
        {
            FecharTelaEsc(e);
        }

        //método responsavel por fechar a tela quando clicado no ESC
        public void FecharTelaEsc(KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void txtRG_KeyDown(object sender, KeyEventArgs e)
        {
            FecharTelaEsc(e);
        }

        private void cboEstadoCivil_KeyDown(object sender, KeyEventArgs e)
        {
            FecharTelaEsc(e);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            FecharTelaEsc(e);
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            FecharTelaEsc(e);
        }

        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            FecharTelaEsc(e);
        }

        private void txtCidade_KeyDown(object sender, KeyEventArgs e)
        {
            FecharTelaEsc(e);
        }

        private void cboEstado_KeyDown(object sender, KeyEventArgs e)
        {
            FecharTelaEsc(e);
        }

        private void txtBairro_KeyDown(object sender, KeyEventArgs e)
        {
            FecharTelaEsc(e);
        }

        private void txtTelefonePrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            FecharTelaEsc(e);
        }

        private void txtTelefoneCelular_KeyDown(object sender, KeyEventArgs e)
        {
            FecharTelaEsc(e);
        }

        private void txtResponsavel_KeyDown(object sender, KeyEventArgs e)
        {
            FecharTelaEsc(e);
        }

        private void txtTelefoneResponsavel_KeyDown(object sender, KeyEventArgs e)
        {
            FecharTelaEsc(e);
        }

        private void btnGravar_KeyDown(object sender, KeyEventArgs e)
        {
            FecharTelaEsc(e);
        }

        private void btnLimpar_KeyDown(object sender, KeyEventArgs e)
        {
            FecharTelaEsc(e);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            bool retorno = GravarPaciente();

            if (retorno == true)
            {
                if(btnGravar.Text.Equals("Gravar Paciente"))
                {
                    MessageBox.Show("Paciente cadastrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparFormulario();
                }
                else
                {
                    MessageBox.Show("Paciente alterado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparFormulario();
                }
                
            }                
            else
                MessageBox.Show("Não foi possível cadastrar o paciente.", "Sem sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public bool GravarPaciente()
        {
            Paciente paciente = new Paciente();

            paciente.nome = txtNome.Text;

            if (rbMasculino.Checked)
                paciente.sexo = '1';
            else if(rbFeminino.Checked)
                paciente.sexo = '2';
            else
                paciente.sexo = '3';

            paciente.cpf = txtCPF.Text;
            paciente.rg = txtRG.Text;
            paciente.estadoCivil = cboEstadoCivil.Text;
            paciente.pai = txtPai.Text;
            paciente.mae = txtMae.Text;
            paciente.cep = txtCEP.Text;
            paciente.cidade = txtCidade.Text;
            paciente.estado = cboEstado.Text;
            paciente.bairro = txtBairro.Text;
            paciente.telefone = txtTelefonePrincipal.Text;
            paciente.celular = txtTelefoneCelular.Text;
            paciente.responsavel = txtResponsavel.Text;
            paciente.telefoneResponsavel = txtTelefoneResponsavel.Text;
            paciente.codigo = Convert.ToInt32(this.Tag);

            PacienteNegocio negocio = new PacienteNegocio();

            bool retorno = false;

            if (btnGravar.Text.Equals("Gravar Paciente"))
                retorno = negocio.InserirPaciente(paciente);
            else
                retorno = negocio.AlterarPaciente(paciente);
            return retorno;                
        }

        public void LimparFormulario()
        {
            txtNome.Text = string.Empty;
            txtCPF.Text = string.Empty;
            rbMasculino.Checked = true;
            txtRG.Text = string.Empty;
            cboEstadoCivil.Text = "Selcione";
            txtPai.Text = string.Empty;
            txtMae.Text = string.Empty;
            txtCEP.Text = string.Empty;
            cboEstado.Text = "Selecione";
            txtBairro.Text = string.Empty; 
            txtTelefonePrincipal.Text = string.Empty; 
            txtTelefoneCelular.Text = string.Empty;
            txtResponsavel.Text = string.Empty;
            txtTelefoneResponsavel.Text = string.Empty;
            txtCidade.Text = string.Empty;

            txtNome.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }
    }
}
