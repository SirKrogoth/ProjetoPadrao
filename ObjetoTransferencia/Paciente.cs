using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Paciente
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public char sexo { get; set; }
        public string pai { get; set; }
        public string mae { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string cep { get; set; }
        public string estadoCivil { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
        public string responsavel { get; set; }
        public string telefoneResponsavel { get; set; }
    }
}
