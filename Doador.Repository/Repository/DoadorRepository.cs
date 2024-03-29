﻿using Dapper;
using Doador.domain.Command;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doador.Infrastructure.Repository
{
    public class DoadorRepository : IDoadorRepository
    {

        string conexao = @"Server=(localdb)\mssqllocaldb;Database=ProjetoDEB;Trusted_Connection=True;MultipleActiveResultSets=True";

        public void GetAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<string> PostAsync(DoadorCommand command)
        {

            string queryInsert = @" 
                Insert Into Doador(Nome,Estado,Cep,Email,Telefone)
                Values (@Nome,@Estado, @Cep,@Email, @Telefone)";
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

        public void PostAsync()
        {
            throw new NotImplementedException();
        }
    }
}
