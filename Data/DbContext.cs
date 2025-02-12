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
        public static string ConnectionString { get { return "Data Source=db\\db.db"; } }
        
        public DbContext()
        {

        }

        private void Start()
        {
            if (!File.Exists("db\\db.db"))
                CreateDataBase();
        }

        private void CreateDataBase()
        {
            using(var connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();
                string sqlTables = @"
                        CREATE TABLE Clientes 
                        (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            Nome VARCHAR(100) NOT NULL,
                            CnpjCpf VARCHAR(14) UNIQUE NOT NULL,
                            InscricaoEstadual VARCHAR(9),
                            Cep VARCHAR(8),
                            Logradouro VARCHAR(100),
                            Bairro VARCHAR(50),
                            Numero INTEGER DEFAULT 0 CHECK (VALOR >= 0),
                            Estado VARCHAR(50) NOT NULL,
                            Telefone VARCHAR(11),
                            Whatssap VARCHAR(11),
                            Email VARCHAR(100)
                        );";
            }
        }
    }
}
