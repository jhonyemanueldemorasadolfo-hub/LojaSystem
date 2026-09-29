using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;

namespace LojaSystem.API.Data
{
    public class Conexao
    {

        private readonly string? connectionString;


        private readonly IConfiguration configuration;

        public Conexao(IConfiguration configuration)
        {
            this.configuration = configuration;

            connectionString = configuration["connectionString:LojaSystem"];
        }

        public MySqlConnection CriarConexao()
        {
            return new MySqlConnection(connectionString);
        }
    }
}