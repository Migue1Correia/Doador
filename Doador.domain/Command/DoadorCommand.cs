using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doador.domain.Command
{
    public class DoadorCommand
    {

        public int Id { get; set; }

        public string Nome  { get; set; } 
        public string Estado { get; set; }

        public string Cep { get; set; }
        public string Email { get; set; }

        public string Telefone { get; set; }

    }
}


