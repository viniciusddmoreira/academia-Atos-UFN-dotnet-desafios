using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02MiniERP.Databases
{
    internal class Banco
    {
        private string stringConexao = "Data Source=localhost; Initial Catalog=supermercado_db; User ID=sa; password=1234;language=Portuguese";

        private SqlConnection cn;

        private void Conexao()
        {
            cn = new SqlConnection(stringConexao);
        }

        public SqlConnection AbrirConexao()
        {
            try
            {
                Conexao();
                cn.Open();

                return cn;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void FecharConexao()
        {
            try
            {
                cn.Close();
            }
            catch (Exception ex)
            {
                return;
            }
        }

        public DataTable ExecutarConsultaGenerica(string sql)
        {
            try
            {
                AbrirConexao();

                SqlCommand command = new SqlCommand(sql, cn);
                command.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
