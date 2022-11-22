using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Desafio02MiniERP.Databases;
using Desafio02MiniERP.Helpers;

namespace Desafio02MiniERP.Models
{
    internal class Fornecedor
    {
        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Cnpj { get; set; }

        public Fornecedor(string razaoSocial, string nomeFantasia, string cnpj)
        {
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            Cnpj = cnpj;
        }
        public Fornecedor()
        {
        }

        public bool ValidarCamposFornecedor(Fornecedor fornecedor)
        {
            if (!(Util.CnpjValido(Cnpj) && Util.ContemLetrasOuNumeros(NomeFantasia) && Util.ContemLetrasOuNumeros(RazaoSocial))) return false;            

            return true;
        }

        public bool GravarFornecedor()
        {
            Banco banco = new Banco();

            SqlConnection cn = banco.AbrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;

            command.CommandText = "INSERT INTO fornecedores VALUES (@razaoSocial, @nomeFantasia, @cnpj);";
            command.Parameters.Add("@razaoSocial", SqlDbType.VarChar);
            command.Parameters.Add("@nomeFantasia", SqlDbType.VarChar);
            command.Parameters.Add("@cnpj", SqlDbType.VarChar);
            command.Parameters[0].Value = RazaoSocial;
            command.Parameters[1].Value = NomeFantasia;
            command.Parameters[2].Value = Cnpj;

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

        public bool ExcluirFornecedor()
        {
            Banco bd = new Banco();

            SqlConnection cn = bd.AbrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM fornecedores WHERE id = @id";
            command.Parameters.Add("@id", SqlDbType.Int);
            command.Parameters[0].Value = Id;

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
                bd.FecharConexao();
            }
        }

        public bool AtualizarFornecedor()
        {
            Banco bd = new Banco();

            SqlConnection cn = bd.AbrirConexao();
            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = tran;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE fornecedores SET razao_social = @razaoSocial, nome_fantasia = @nomeFantasia, " +
                "cnpj = @cnpj WHERE id = @id";
            cmd.Parameters.Add("@razaoSocial", SqlDbType.VarChar);
            cmd.Parameters.Add("@nomeFantasia", SqlDbType.VarChar);
            cmd.Parameters.Add("@cnpj", SqlDbType.VarChar);
            cmd.Parameters.Add("@id", SqlDbType.Int);
            cmd.Parameters[0].Value = RazaoSocial;
            cmd.Parameters[1].Value = NomeFantasia;
            cmd.Parameters[2].Value = Cnpj;
            cmd.Parameters[3].Value = Id;

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

        public Fornecedor ConsultarFornecedor(string razaoSocial)
        {
            Banco bd = new Banco();

            try
            {
                SqlConnection cn = bd.AbrirConexao();
                SqlCommand command = new SqlCommand("SELECT * FROM fornecedores", cn);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetString(1) == razaoSocial)
                    {
                        Id = reader.GetInt32(0);
                        RazaoSocial = reader.GetString(1);
                        NomeFantasia = reader.GetString(2);
                        Cnpj = reader.GetString(3);

                        return this;
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                bd.FecharConexao();
            }
        }

        public DataTable ConsultarPorRazaoSocial()
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.AbrirConexao();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT * FROM fornecedores WHERE razao_social LIKE CONCAT('%', @razaoSocial, '%');";
            cmd.Parameters.Add("@razaoSocial", SqlDbType.VarChar);
            cmd.Parameters[0].Value = RazaoSocial;

            try
            {

                cmd.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                bd.FecharConexao();
            }
        }
    }
}
