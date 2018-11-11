using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ObjetoTransferencia;
using ProjetoPadrao;

namespace Modelo
{
    public class PacienteNegocio
    {
        //Instancia de conexão ao banco de dados
        AcessarDadosSQLServer acessarDados = new AcessarDadosSQLServer();

        public bool InserirPaciente(Paciente paciente)
        {
            try
            {
                //limpar parametros
                acessarDados.limparParametro();

                //Adicionando parametros
                acessarDados.adicionarParametro("@nome", paciente.nome);
                acessarDados.adicionarParametro("@rg", paciente.rg);
                acessarDados.adicionarParametro("@cpf", paciente.cpf);
                
                acessarDados.adicionarParametro("@sexo", paciente.sexo);

                acessarDados.adicionarParametro("@pai", paciente.pai);
                acessarDados.adicionarParametro("@mae", paciente.mae);
                acessarDados.adicionarParametro("@bairro", paciente.bairro);
                acessarDados.adicionarParametro("@cidade", paciente.cidade);
                acessarDados.adicionarParametro("@estado", paciente.estado);
                acessarDados.adicionarParametro("@cep", paciente.cep);
                acessarDados.adicionarParametro("@estadoCivil", paciente.estadoCivil);
                acessarDados.adicionarParametro("@telefone", paciente.telefone);
                acessarDados.adicionarParametro("@celular", paciente.celular);
                acessarDados.adicionarParametro("@responsavel", paciente.responsavel);
                acessarDados.adicionarParametro("@telefoneResponsavel", paciente.telefoneResponsavel);

                acessarDados.executarManipulacao(CommandType.StoredProcedure, "SPInserirPaciente");

                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Paciente> BuscarPacienteNome(string nome = "todos")
        {
            try
            {
                acessarDados.limparParametro();

                List<Paciente> pacientes = new List<Paciente>();

                acessarDados.adicionarParametro("@nome", nome);

                DataTable dataTable = acessarDados.executarConsulta(CommandType.StoredProcedure, "SPBuscarPacientes");

                foreach (DataRow linha in dataTable.Rows)
                {
                    Paciente paciente = new Paciente();

                    paciente.codigo = Convert.ToInt32(linha["codigo"]);
                    paciente.nome = Convert.ToString(linha["nome"]);
                    paciente.rg = Convert.ToString(linha["rg"]);

                    if (Convert.ToChar(linha["sexo"]) == '1')
                        paciente.sexo = 'M';
                    else if (Convert.ToChar(linha["sexo"]) == '2')
                        paciente.sexo = 'F';
                    else
                        paciente.sexo = 'O';

                    paciente.pai = Convert.ToString(linha["pai"]);
                    paciente.mae = Convert.ToString(linha["mae"]);
                    paciente.bairro = Convert.ToString(linha["bairro"]);
                    paciente.cidade = Convert.ToString(linha["cidade"]);
                    paciente.cep = Convert.ToString(linha["cep"]);
                    paciente.estadoCivil = Convert.ToString(linha["estadoCivil"]);
                    paciente.telefone = Convert.ToString(linha["telefone"]);
                    paciente.celular = Convert.ToString(linha["celular"]);
                    paciente.responsavel = Convert.ToString(linha["responsabilidade"]);
                    paciente.telefoneResponsavel = Convert.ToString(linha["telefoneResponsavel"]);
                    paciente.estado = Convert.ToString(linha["estado"]);
                    paciente.cpf = Convert.ToString(linha["cpf"]);

                    pacientes.Add(paciente);
                }

                return pacientes;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}