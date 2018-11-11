using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using ObjetoTransferencia;

namespace Apresentacao.Pacientes
{
    public partial class frmConsultarPaciente : Form
    {
        public frmConsultarPaciente()
        {
            InitializeComponent();
            dgvPacientes.AutoGenerateColumns = false;
            AtualizarGrid();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            PacienteNegocio pacienteNegocio = new PacienteNegocio();

            List<Paciente> pacientes = new List<Paciente>();

            if(txtNome.Text == "")
                pacientes = pacienteNegocio.BuscarPacienteNome();
            else
                pacientes = pacienteNegocio.BuscarPacienteNome(txtNome.Text);
        }

        private void AtualizarGrid()
        {
            PacienteNegocio pacienteNegocio = new PacienteNegocio();
            List<Paciente> pacientes = new List<Paciente>();

            if(txtNome.Text == "")
                pacientes = pacienteNegocio.BuscarPacienteNome();
            else
                pacientes = pacienteNegocio.BuscarPacienteNome(txtNome.Text);

            dgvPacientes.DataSource = null;
            dgvPacientes.DataSource = pacientes;
            dgvPacientes.Update();
            dgvPacientes.Refresh();
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                AtualizarGrid();
        }
    }
}