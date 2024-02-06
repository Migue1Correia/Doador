using Doador.domain.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doador.domain.Interfaces
{
    public interface IProdutoService
    {
        Task<string> PostAsync(ProdutoCommand command);
        void PostAsync();
        void GetAsync();
    }
}
