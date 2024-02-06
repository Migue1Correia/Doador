using Doador.domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doador.domain.Command
{ 
    public class ProdutoCommand
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Descrição { get; set; }
    public ECategoria Categoria { get; set; }

    public EDisponibilidadeParaDoação DisponibilidadeParaDoação { get; set; }
    public int DpadorId { get; set; }

}
}

