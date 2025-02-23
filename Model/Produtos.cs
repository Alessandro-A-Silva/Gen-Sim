using Gen_Sim.Data;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen_Sim.Model
{
    public class Produtos
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }

        public bool Create()
        {
            try
            {
                using(SqliteConnection connection = new SqliteConnection(DbContext.ConnectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO Produtos (Nome, Descricao, Preco, Estoque) VALUES (@Nome, @Descricao, @Preco, @Estoque)";
                    using(SqliteCommand command = new SqliteCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@Nome", Nome);
                        command.Parameters.AddWithValue("@Descricao", Descricao);
                        command.Parameters.AddWithValue("@Preco", Preco);
                        command.Parameters.AddWithValue("@Estoque",Estoque);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Registrado com sucesso!", "Dados do Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao registrar! " + ex.Message, "Dados do Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public List<Produtos> ReadAll()
        {
            var listProdutos = new List<Produtos>();
            try
            {
                using(SqliteConnection connection = new SqliteConnection(DbContext.ConnectionString))
                {
                    connection.Open();
                    string query = @"SELECT * FROM Produtos";
                    using (SqliteCommand command = new SqliteCommand(query, connection))
                    {
                        using(SqliteDataReader reader = command.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                listProdutos.Add(new Produtos()
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Nome = reader["Nome"].ToString(),
                                    Descricao = reader["Descricao"].ToString(),
                                    Preco = Convert.ToDecimal(reader["Preco"]),
                                    Estoque = Convert.ToInt32(reader["Estoque"])
                                });
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao consultar! " + ex.Message, "Dados do Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return listProdutos;
        }

        public bool Update()
        {
            try
            {
                using(SqliteConnection connection = new SqliteConnection(DbContext.ConnectionString))
                {
                    connection.Open();
                    string query = @"UPDATE Produtos SET Nome = @Nome, Descricao = @Descricao, Preco = @Preco WHERE Id = @Id";
                    using (SqliteCommand command = new SqliteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", Id);
                        command.Parameters.AddWithValue("@Nome", Nome);
                        command.Parameters.AddWithValue("@Descricao", Descricao);
                        command.Parameters.AddWithValue("@Preco", Preco);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Atualizado com sucesso!", "Dados do Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao atualizar! " + ex.Message, "Dados do Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        
        public bool Delete()
        {
            try
            {
                using(SqliteConnection connection = new SqliteConnection(DbContext.ConnectionString))
                {
                    connection.Open();
                    string query = @"DELETE FROM Produtos WHERE Id = @Id";
                    using(SqliteCommand command = new SqliteCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@Id", Id);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Deletado com sucesso!", "Dados do Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao deletar! " + ex.Message, "Dados do Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool UpdateEstoque()
        {
            try
            {
                using (SqliteConnection connection = new SqliteConnection(DbContext.ConnectionString))
                {
                    connection.Open();
                    string query = @"UPDATE Produtos SET Estoque = @Estoque WHERE Id = @Id";
                    using (SqliteCommand command = new SqliteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", Id);
                        command.Parameters.AddWithValue("@Estoque", Estoque);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Atualizado com sucesso!", "Dados do Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar! " + ex.Message, "Dados do Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
