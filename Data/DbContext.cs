using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Gen_Sim.Data
{
    public class DbContext
    {
        public static string ConnectionString { get { return "Data Source=DataBase.db"; } }

        public void CreateDataBase()
        {

            if (!File.Exists("DataBase.db"))
            {
                using (var connection = new SqliteConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"
                        CREATE TABLE Clientes 
                        (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            Nome VARCHAR(100) NOT NULL,
                            CnpjCpf VARCHAR(14) UNIQUE NOT NULL,
                            InscricaoEstadual VARCHAR(9),
                            Cep VARCHAR(8),
                            Logradouro VARCHAR(100),
                            Bairro VARCHAR(50) NOT NULL,
                            Numero INTEGER DEFAULT 0 CHECK (Numero >= 0),
                            Estado VARCHAR(50) NOT NULL,
                            Telefone VARCHAR(11),
                            Whatssap VARCHAR(11),
                            Email VARCHAR(100),
                            Cidade VARCHAR(50) NOT NULL
                        );
                        CREATE TABLE Produtos
                        (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            Nome VARCHAR(100) UNIQUE NOT NULL
                            Descricao VARCHAR(100),
                            Preco DECIMAL,
                            Estoque INTEGER DEFAULT 0 CHECK (Estoque >= 0)
                        )      
                        ";

                    using(var command = new SqliteCommand(query,connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
