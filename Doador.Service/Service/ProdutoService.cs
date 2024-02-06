using Doador.domain.Command;
using Doador.domain.Interfaces;
using Doador.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doador.Service.Service
{

    public class ProdutoService : IProdutoService
    {

        private readonly IProdutoRepository _repository;

        public ProdutoService(IProdutoRepository repository)
        {
            _repository = repository;
        }
        public void GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<string> PostAsync(ProdutoCommand command)
        {
            throw new NotImplementedException();
        }

        public void PostAsync()
        {
            throw new NotImplementedException();
        }

    }
}

