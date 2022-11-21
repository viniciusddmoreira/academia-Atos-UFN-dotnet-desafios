using Desafio02MiniERP.Databases;
using Desafio02MiniERP.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio02MiniERP.Models
{
    internal class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }

        public Cliente(string nome, string endereco, string telefone, string email, string cpf)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            Email = email;
            Cpf = cpf;
        }
        public Cliente()
        {
        }

        public bool ValidarCamposCliente(Cliente Cliente)
        {
            //MessageBox.Show("cpf " + Util.CpfValido(Cpf).ToString());
            //MessageBox.Show("nome " + Util.NomeValido(Nome).ToString());
            //MessageBox.Show("endereco " + Util.ContemLetrasOuNumeros(Endereco).ToString());
            //MessageBox.Show("telefone " + Util.ContemLetrasOuNumeros(Telefone).ToString());
            //MessageBox.Show("email " + Util.ContemLetrasOuNumeros(Email).ToString());
            if (!(Util.CpfValido(Cpf) && Util.NomeValido(Nome) && Util.ContemLetrasOuNumeros(Endereco) 
                && Util.ContemLetrasOuNumeros(Telefone) && Util.EmailValido(Email))) return false;
            //if (Util.ContemLetras(Cnpj) && Util.ContemNumeros(NomeFantasia) && Util.ContemNumeros(RazaoSocial)) return false;

            return true;
            //if (String.IsNullOrEmpty(RazaoSocial)) return false;
            //if (String.IsNullOrEmpty(NomeFantasia)) return false;
            //if (String.IsNullOrEmpty(Cnpj)) return false;
        }

        public bool GravarCliente()
        {
            Banco banco = new Banco();

            SqlConnection cn = banco.AbrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;

            command.CommandText = "INSERT INTO clientes VALUES (@nome, @endereco, @telefone, @email, @cpf);";
            command.Parameters.Add("@nome", SqlDbType.VarChar);
            command.Parameters.Add("@endereco", SqlDbType.VarChar);
            command.Parameters.Add("@telefone", SqlDbType.VarChar);
            command.Parameters.Add("@email", SqlDbType.VarChar);
            command.Parameters.Add("@cpf", SqlDbType.VarChar);
            command.Parameters[0].Value = Nome;
            command.Parameters[1].Value = Endereco;
            command.Parameters[2].Value = Telefone;
            command.Parameters[3].Value = Email;
            command.Parameters[4].Value = Cpf;

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

        public bool ExcluirCliente()
        {
            Banco bd = new Banco();

            SqlConnection cn = bd.AbrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM clientes WHERE id = @id";
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

        public bool AtualizarCliente()
        {
            Banco bd = new Banco();

            SqlConnection cn = bd.AbrirConexao();
            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = tran;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE clientes SET nome = @nome, endereco = @endereco, " +
                "telefone = @telefone, email = @email, cpf = @cpf WHERE id = @id";
            cmd.Parameters.Add("@nome", SqlDbType.VarChar);
            cmd.Parameters.Add("@endereco", SqlDbType.VarChar);
            cmd.Parameters.Add("@telefone", SqlDbType.VarChar);
            cmd.Parameters.Add("@email", SqlDbType.VarChar);
            cmd.Parameters.Add("@cpf", SqlDbType.VarChar);
            cmd.Parameters.Add("@id", SqlDbType.Int);
            cmd.Parameters[0].Value = Nome;
            cmd.Parameters[1].Value = Endereco;
            cmd.Parameters[2].Value = Telefone;
            cmd.Parameters[3].Value = Email;
            cmd.Parameters[4].Value = Cpf;
            cmd.Parameters[5].Value = Id;

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

        public Cliente ConsultarCliente(string nome)
        {
            Banco bd = new Banco();

            try
            {
                SqlConnection cn = bd.AbrirConexao();
                SqlCommand command = new SqlCommand("SELECT * FROM clientes", cn);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetString(1) == nome)
                    {
                        Id = reader.GetInt32(0);
                        Nome = reader.GetString(1);
                        Endereco = reader.GetString(2);
                        Telefone = reader.GetString(3);
                        Email = reader.GetString(4);
                        Cpf = reader.GetString(5);

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

        public DataTable ConsultarPorNome()
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.AbrirConexao();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT * FROM clientes WHERE nome LIKE CONCAT('%', @nome, '%');";
            cmd.Parameters.Add("@nome", SqlDbType.VarChar);
            cmd.Parameters[0].Value = Nome;

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
