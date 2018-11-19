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

namespace Apresentacao.Medicos
{
    public partial class frmCadMedico : Form
    {
        public frmCadMedico()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastrarMedico();
        }

        public void CadastrarMedico()
        {
            Medico medico = new Medico();
            MedicoNegocio medicoNegocio = new MedicoNegocio();

            medico.nome = txtNome.Text;
            medico.rg = txtRG.Text;
            medico.cpf = txtCPF.Text;

            if (rbMasculino.Checked == true)
                medico.sexo = '1';
            else if (rbFeminino.Checked == true)
                medico.sexo = '2';
            else
                medico.sexo = '3';

            medico.crm = txtCRM.Text;
            medico.nascimento = dtpNascimento.Value;
            medico.idade = Convert.ToInt32(txtIdade.Text);
            medico.endereco = txtEndereco.Text;
            medico.cep = txtCEP.Text;
            medico.cidade = txtCidade.Text;
            medico.bairro = txtBairro.Text;
            medico.estado = cboEstado.Text;
            medico.telefone = txtTelefone.Text;
            medico.celular = txtTelefoneCelular.Text;
            medico.email = txtEmail.Text;

            bool retorno = medicoNegocio.InserirMedico(medico);

            if (retorno == true)
            {
                MessageBox.Show("Médico inserido com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparDados();
            }                
            else
                MessageBox.Show("Não foi possível inserir médico.", "Falha ao inseri médico", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparDados();
        }

        public void LimparDados()
        {
            txtNome.Text = string.Empty;
            txtRG.Text = string.Empty;
            txtCPF.Text = string.Empty;
            rbMasculino.Checked = true;
            txtCRM.Text = string.Empty;
            txtIdade.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtCEP.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtBairro.Text = string.Empty;
            cboEstado.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtTelefoneCelular.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }
    }
}
