using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Medico : Pessoa
    {
        public string crm { get; set; }
        public string email { get; set; }
        public int idade { get; set; }
        public DateTime nascimento { get; set; }
        public string endereco { get; set; }
    }
}
