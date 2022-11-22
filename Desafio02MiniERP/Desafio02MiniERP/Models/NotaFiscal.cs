using Desafio02MiniERP.Databases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Desafio02MiniERP.Models
{
    internal class NotaFiscal
    {

        public int IdNota { get; set; }
        public Cliente Cliente { get; set; }

        public int IdCliente { get; set; }
        public List<NotaProduto> NotaProdutos { get; set; } = new List<NotaProduto>();
        public DateTime DataCompra { get; set; }
        public decimal TotalPagar { get; set; }

        public bool GravarNotaFiscal()
        {
            Banco banco = new Banco();

            SqlConnection cn = banco.AbrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;

            command.CommandText = "INSERT INTO notas_fiscais VALUES (@idCliente, @dataCompra, @totalPagar);";
            command.Parameters.Add("@idCliente", SqlDbType.Int);
            command.Parameters.Add("@dataCompra", SqlDbType.DateTime);
            command.Parameters.Add("@totalPagar", SqlDbType.Decimal);
            command.Parameters[0].Value = IdCliente;
            command.Parameters[1].Value = DataCompra;
            command.Parameters[2].Value = TotalPagar;

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

        public void AtribuirIdNotaFiscal()
        {
            Banco bd = new Banco();

            try
            {
                SqlConnection cn = bd.AbrirConexao();
                SqlCommand command = new SqlCommand($"SELECT * FROM notas_fiscais WHERE id_cliente='{IdCliente}'", cn);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {                 
                   IdNota = reader.GetInt32(0);                     
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("exceção: " + ex.Message);
            }
            finally
            {
                bd.FecharConexao();
            }
        }

        public bool AtualizarNotaFiscal()
        {
            Banco bd = new Banco();

            SqlConnection cn = bd.AbrirConexao();
            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = tran;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE notas_fiscais SET total_pagar = @totalPagar WHERE id = @id";
            cmd.Parameters.Add("@totalPagar", SqlDbType.Decimal);
            cmd.Parameters.Add("@id", SqlDbType.Int);

            cmd.Parameters[0].Value = TotalPagar;
            cmd.Parameters[1].Value = IdNota;

            try
            {
                cmd.ExecuteNonQuery();
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
                bd.FecharConexao();
            }
        }

    }
}
