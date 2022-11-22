using Desafio02MiniERP.Databases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desafio02MiniERP.Helpers;
using System.Data.SqlTypes;
using System.ComponentModel;

namespace Desafio02MiniERP.Models
{
    internal class Produto
    {
        public int Id { get; set; }
        public string CodigoBarra { get; set; }
        public string Marca { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public int IdFornecedor { get; set; }

        public Produto(string codigoBarra, string marca, string descricao, decimal valor, int idFornecedor)
        {
            CodigoBarra = codigoBarra;
            Marca = marca;
            Descricao = descricao;
            Valor = valor;
            IdFornecedor = idFornecedor;
        }

        public Produto()
        {
        }

        public bool ValidarCamposProduto()
        {
            //MessageBox.Show("descricao " + Util.NomeValido(Descricao).ToString());
            //MessageBox.Show("codigo barra " + Util.ContemLetrasOuNumeros(CodigoBarra).ToString());
            //MessageBox.Show("valor " + Util.NumeroRealValido(Valor.ToString()).ToString());
            //MessageBox.Show("IdFornecedor " + Util.NumeroInteiroValido(IdFornecedor.ToString()).ToString());

            if (!(Util.ContemLetrasOuNumeros(Descricao) && Util.ContemLetrasOuNumeros(CodigoBarra) && 
                Util.NumeroRealValido(Valor.ToString()) && Util.NumeroInteiroValido(IdFornecedor.ToString()))) return false;

            //if (Util.ContemLetras(Cnpj) && Util.ContemNumeros(NomeFantasia) && Util.ContemNumeros(RazaoSocial)) return false;

            return true;
            //if (String.IsNullOrEmpty(RazaoSocial)) return false;
            //if (String.IsNullOrEmpty(NomeFantasia)) return false;
            //if (String.IsNullOrEmpty(Cnpj)) return false;
        }

        public bool GravarProduto()
        {
            Banco banco = new Banco();

            SqlConnection cn = banco.AbrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;

            command.CommandText = "INSERT INTO produtos " +
                "VALUES (@codigoBarra, @descricao, @marca, @valor, @idFornecedor);";
            command.Parameters.Add("@codigoBarra", SqlDbType.VarChar);
            command.Parameters.Add("@descricao", SqlDbType.VarChar);
            command.Parameters.Add("@marca", SqlDbType.VarChar);
            command.Parameters.Add("@valor", SqlDbType.Decimal);
            command.Parameters.Add("@idFornecedor", SqlDbType.Int);
            command.Parameters[0].Value = CodigoBarra;
            command.Parameters[1].Value = Marca;
            command.Parameters[2].Value = Descricao;
            command.Parameters[3].Value = Valor;
            command.Parameters[4].Value = IdFornecedor;

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

        public bool ExcluirProduto()
        {
            Banco bd = new Banco();

            SqlConnection cn = bd.AbrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM produtos WHERE id = @id";
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

        public bool AtualizarProduto()
        {
            Banco bd = new Banco();

            SqlConnection cn = bd.AbrirConexao();
            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = tran;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE produtos SET codigo_barra = @codigoBarra, descricao = @descricao, " +
                "marca = @marca, valor = @valor, id_fornecedor = @idFornecedor WHERE id = @id";
            cmd.Parameters.Add("@codigoBarra", SqlDbType.VarChar);
            cmd.Parameters.Add("@descricao", SqlDbType.VarChar);
            cmd.Parameters.Add("@marca", SqlDbType.VarChar);
            cmd.Parameters.Add("@valor", SqlDbType.Decimal);
            cmd.Parameters.Add("@idFornecedor", SqlDbType.Int);
            cmd.Parameters.Add("@id", SqlDbType.Int);
            cmd.Parameters[0].Value = CodigoBarra;
            cmd.Parameters[1].Value = Descricao;
            cmd.Parameters[2].Value = Marca;
            cmd.Parameters[3].Value = Valor;
            cmd.Parameters[4].Value = IdFornecedor;
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

        public Produto ConsultarProduto(string descricao)
        {
            Banco bd = new Banco();

            try
            {
                SqlConnection cn = bd.AbrirConexao();
                SqlCommand command = new SqlCommand("SELECT * FROM produtos", cn);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetString(1) == descricao)
                    {
                        Id = reader.GetInt32(0);
                        CodigoBarra = reader.GetString(1);
                        Marca = reader.GetString(2);
                        Descricao = reader.GetString(3);
                        Valor = reader.GetDecimal(4);
                        IdFornecedor = reader.GetInt32(5);

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

        public Produto ConsultarProdutoId(int id)
        {
            Banco bd = new Banco();

            try
            {
                SqlConnection cn = bd.AbrirConexao();
                SqlCommand command = new SqlCommand("SELECT * FROM produtos", cn);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetInt32(0) == id)
                    {
                        Id = reader.GetInt32(0);
                        CodigoBarra = reader.GetString(1);
                        Marca = reader.GetString(2);
                        Descricao = reader.GetString(3);
                        Valor = reader.GetDecimal(4);
                        IdFornecedor = reader.GetInt32(5);

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

        public DataTable ConsultarPorDescricao()
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.AbrirConexao();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT * FROM produtos WHERE descricao LIKE CONCAT('%', @descricao, '%');";
            cmd.Parameters.Add("@descricao", SqlDbType.VarChar);
            cmd.Parameters[0].Value = Descricao;

            try
            {
                cmd.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                //if (dt == null) 
                //    MessageBox.Show("eh nulo");
                //else
                //    MessageBox.Show("nao eh nulo");
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("azedo: " + e.Message);
                return null;
            }
            finally
            {
                bd.FecharConexao();
            }
        }
    }
}
