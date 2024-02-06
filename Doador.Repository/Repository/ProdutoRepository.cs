using Dapper;
using Doador.domain.Command;
using Doador.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produto.Repository.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {

        string conexao = @"insert into Produto(Nome,Descrição,Categoria,DisponibilidadeParaDoação,DpadorId )\r\nValues (@Nome,@Descrição, @Categoria,@DisponibilidadeParaDoação, @DpadorId)";

        public void GetAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<string> PostAsync(ProdutoCommand command)
        {

            string queryInsert = @" 
                Insert Into Doador(Nome,Descrição,Categoria,DisponibilidadeParaDoação,DpadorId )
                Volues (@Nome,@Descrição, @Categoria,@DisponibilidadeParaDoação, @DpadorId)";
            using (SqlConnection conn = new SqlConnection(conexao))
            {


                conn.Execute(queryInsert, new
                {
                    Nome = command.Nome,
                    Descrição = command.Descrição,
                    Categoria = command.Categoria,
                    DisponibilidadeParaDoação = command.DisponibilidadeParaDoação,
                    DpadorId = command.DpadorId

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

 
