using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
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
    }
}

