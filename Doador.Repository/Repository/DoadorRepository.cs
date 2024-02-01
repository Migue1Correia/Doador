using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doador.Infrastructure.Repository
{
    public class DoadorRepository : IDoadorRepository
    {

        string conexao = @"insert into Doador(Nome,Estado,Cep,Email,Telefone )\r\nValues (@Nome,@Estado, @Cep,@Email, @Telefone)";
        public async Task<string> PostAsync(DoadorCommand command)
        {

            string queryInsert = @" 
                Insert Into Doador(Nome,Estado,Cep,Email,Telefone )
                Volues (@Nome,@Estado, @Cep,@Email, @Telefone)";
            using (SqlConnection conn = new SqlConnection(conexao))
            {


                conn.Execute(queryInsert, new
                {
                    Nome = command.Nome,
                    Estado = command.Estado,
                    Cep = command.Cep,
                    Email = command.Email,
                    Telefone = command.Telefone

                });

                return "Doador cadastrado com sucesso";
            }
        }
    }
}
