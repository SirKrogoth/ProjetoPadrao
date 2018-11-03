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
    }
}