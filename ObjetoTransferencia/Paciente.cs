using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Paciente : Pessoa
    {
        public string pai { get; set; }
        public string mae { get; set; }
        public string estadoCivil { get; set; }
        public string responsavel { get; set; }
        public string telefoneResponsavel { get; set; }
    }
}
