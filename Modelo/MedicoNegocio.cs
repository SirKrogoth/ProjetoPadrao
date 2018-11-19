using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoPadrao;
using ObjetoTransferencia;


namespace Modelo
{
    public class MedicoNegocio
    {
        //Instancia de conexão ao banco de dados
        AcessarDadosSQLServer acessarDados = new AcessarDadosSQLServer();

        public bool InserirMedico(Medico medico)
        {
            try
            {
                acessarDados.limparParametro();

                acessarDados.adicionarParametro("@nome", medico.nome);
                acessarDados.adicionarParametro("@rg", medico.rg);
                acessarDados.adicionarParametro("@cpf", medico.cpf);
                acessarDados.adicionarParametro("@endereco", medico.endereco);
                acessarDados.adicionarParametro("@cidade", medico.cidade);
                acessarDados.adicionarParametro("@cep", medico.cep);
                acessarDados.adicionarParametro("@bairro", medico.bairro);
                acessarDados.adicionarParametro("@estado", medico.estado);
                acessarDados.adicionarParametro("@crm", medico.crm);
                acessarDados.adicionarParametro("@email", medico.email);
                acessarDados.adicionarParametro("@idade", medico.idade);
                acessarDados.adicionarParametro("@sexo", medico.sexo);
                acessarDados.adicionarParametro("@nascimento", medico.nascimento);
                acessarDados.adicionarParametro("@telefone", medico.telefone);
                acessarDados.adicionarParametro("@telefoneCelular", medico.celular);

                acessarDados.executarManipulacao(System.Data.CommandType.StoredProcedure, "SPInserirMedico");

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
