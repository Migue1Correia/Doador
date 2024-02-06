using Doador.domain.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doador.domain.Interfaces
{
    public interface IDoadorService
    {
       Task<string> PostAsync(DoadorCommand command);
       void PostAsync();
       void GetAsync();
    }
}
