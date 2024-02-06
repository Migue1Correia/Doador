using Doador.domain.Command;
using Doador.domain.Interfaces;
using Doador.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class DoadorService : IDoadorService
    {

        private readonly IDoadorRepository _repository;

        public DoadorService(IDoadorRepository repository)
        {
            _repository = repository;
        }
        public void GetAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<string> PostAsync(DoadorCommand command)
        {
            return await _repository.PostAsync(command);    
        }

        public void PostAsync()
        {
            throw new NotImplementedException();
        }

    }
}

