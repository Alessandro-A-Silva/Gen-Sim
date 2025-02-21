using Gen_Sim.Data;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Gen_Sim.Model
{
    public class Clientes
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? CnpjCpf { get; set; }
        public string? InscricaoEstadual { get; set; }
        public string? Cep { get; set; }
        public string? Logradouro { get; set; }
        public string? Bairro { get; set; }
        public int Numero { get; set; }
        public string? Estado { get; set; }
        public string? Telefone { get; set; }
        public string? Whatssap { get; set; }
        public string? Email { get; set; }
        public string? Cidade { get; set; }


        public bool Create()
        {
            try
            {
                using (var connection = new SqliteConnection(DbContext.ConnectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO Clientes (Nome, CnpjCpf, InscricaoEstadual, Cep, Logradouro, Bairro, Numero, Estado, Telefone, Whatssap, Email, Cidade)
                                             VALUES (@Nome, @CnpjCpf, @InscricaoEstadual, @Cep, @Logradouro, @Bairro, @Numero, @Estado, @Telefone, @Whatssap, @Email, @Cidade)";
                    using (SqliteCommand command = new SqliteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nome", Nome);
                        command.Parameters.AddWithValue("@CnpjCpf", CnpjCpf);
                        command.Parameters.AddWithValue("@InscricaoEstadual", InscricaoEstadual);
                        command.Parameters.AddWithValue("@Cep", Cep);
                        command.Parameters.AddWithValue("@Logradouro", Logradouro);
                        command.Parameters.AddWithValue("@Bairro", Bairro);
                        command.Parameters.AddWithValue("@Numero", Numero);
                        command.Parameters.AddWithValue("@Estado", Estado);
                        command.Parameters.AddWithValue("@Telefone", Telefone);
                        command.Parameters.AddWithValue("@Whatssap", Whatssap);
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@Cidade", Cidade);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Registrado com sucesso!","Dados do Cliente",MessageBoxButtons.OK,MessageBoxIcon.Information);

                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao registrar! "+ex.Message,"Dados do Cliente",MessageBoxButtons.OK,MessageBoxIcon.Error);

                return false;
            }
        }

        public List<Clientes> ReadAll()
        {
            var listClientes = new List<Clientes>();
            using(var connectionString = new SqliteConnection(DbContext.ConnectionString))
            {   
                connectionString.Open();
                string query = @"SELECT * FROM Clientes";
                using(SqliteCommand command = new SqliteCommand(query, connectionString))
                {
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listClientes.Add(new Clientes()
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Nome = reader["Nome"].ToString(),
                                CnpjCpf = reader["CnpjCpf"].ToString(),
                                InscricaoEstadual = reader["InscricaoEstadual"].ToString(),
                                Cep = reader["Cep"].ToString(),
                                Logradouro = reader["Logradouro"].ToString(),
                                Bairro = reader["Bairro"].ToString(),
                                Numero = Convert.ToInt32(reader["Numero"]),
                                Estado = reader["Estado"].ToString(),
                                Telefone = reader["Telefone"].ToString(),
                                Whatssap = reader["Whatssap"].ToString(),
                                Email = reader["Email"].ToString(),
                                Cidade = reader["Cidade"].ToString()
                            });
                        }
                    }
                }

            }
            return listClientes;
        }
    }
}
