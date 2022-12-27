using database.interfaces;
using MySql.Data.MySqlClient;
using negocio.models;

namespace database.mysql;
public class RepositorioMYSQL
{
    private readonly string? conexao = Environment.GetEnvironmentVariable("CODIGO_MYSQL");
    
    public void Salvar(string nome,string descricao, DateTime dt_de_criacao, DateTime dt_de_validade, int quantidade)
    {
        var query = 
        $"insert into produtos (name, descricao, dt_de_criacao, dt_de_validade, quantidade) values ({nome}, {descricao}, {dt_de_criacao}, {dt_de_validade}, {quantidade});";

        using(var conn = new MySqlConnection(conexao))
        {
            conn.Open();

            var command = new MySqlCommand(query, conn);

            conn.Close();
        }
    }
    public void Apagar(string id)
    {
        throw new NotImplementedException();
    }

    public Produto BuscaPorId(string id)
    {
        throw new NotImplementedException();
    }

    public List<Produto> BuscarTodos()
    {
        throw new NotImplementedException();
    }

}
