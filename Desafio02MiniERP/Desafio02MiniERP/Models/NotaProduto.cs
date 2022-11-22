using Desafio02MiniERP.Databases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02MiniERP.Models
{
    internal class NotaProduto
    {

        public int IdNotaProduto { get; set; }
        public int IdNotaFiscal { get; set; }
        public int IdProduto { get; set; }

        public NotaProduto(int idNotaFiscal, int idProduto)
        {
            IdNotaFiscal = idNotaFiscal;
            IdProduto = idProduto;
        }

        public NotaProduto()
        {
        }

        public bool GravarNotaProduto()
        {
            Banco banco = new Banco();

            SqlConnection cn = banco.AbrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;

            command.CommandText = "INSERT INTO notas_produtos VALUES (@idNotaFiscal, @idProduto);";
            command.Parameters.Add("@idNotaFiscal", SqlDbType.Int);
            command.Parameters.Add("@idProduto", SqlDbType.Int);

            command.Parameters[0].Value = IdNotaFiscal;
            command.Parameters[1].Value = IdProduto;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                banco.FecharConexao();
            }
        }
    }
}
