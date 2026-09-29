using LojaSystem.API.Models;
using LojaSystem.API.Data;
using MySql.Data.MySqlClient;

namespace LojaSystem.API.Repositories
{


    public class ProdutoDAO
    {

        public bool Cadastrar(Produto produto)
        {
            Conexao conexao = new Conexao();
           MySqlConnection connection =  conexao.CriarConexao();

            try
            {
                connection.Open();

                MySqlCommand sqlCommand = new MySqlCommand();
                sqlCommand.Connection = connection;

                sqlCommand.CommandText = "insert into produto values(default, @nome, @categoria, @preco, @estoque)";

                sqlCommand.Parameters.AddWithValue("@nome", produto.nome);
                sqlCommand.Parameters.AddWithValue("@categoria", produto.categoria);
                sqlCommand.Parameters.AddWithValue("@estoque", produto.estoque);
                sqlCommand.Parameters.AddWithValue("@preco", produto.preco);

                int linhasAfectadas = sqlCommand.ExecuteNonQuery();

                return linhasAfectadas > 0;

            }
            catch (MySqlException ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }




        }

        public List<Produto> Listar()
        {
            List<Produto> produtos = new List<Produto>();
            Conexao conexao = new Conexao();

            MySqlConnection mySqlConnection = conexao.CriarConexao();

            try
            {
                mySqlConnection.Open();

                MySqlCommand mySqlCommand = new MySqlCommand();
                mySqlCommand.Connection = mySqlConnection;

                mySqlCommand.CommandText = "select * from produto";

                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                while(reader.Read())
                {
                    var produtoID = reader["id"];
                    var produtoNome = reader["nome"];
                    var produtoCategoria = reader["categoria"];
                    var produtoPreco = reader["preco"];
                    var produtoEstoque = reader["estoque"];

                    produtos.Add(new Produto { nome = produtoNome.ToString(), categoria = produtoCategoria.ToString(), estoque = Convert.ToInt32(produtoEstoque), preco = Convert.ToDecimal( produtoPreco) });
                }

                return produtos;

            }catch(MySqlException ex)
            {
                return null;
            } finally
            {
                mySqlConnection.Close();
            }
        }
    }
}
