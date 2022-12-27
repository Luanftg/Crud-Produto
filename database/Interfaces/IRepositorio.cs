namespace database.interfaces;
public interface IRepositorio<T>
{
    void Salvar(T obj);
    List<T> BuscarTodos();
    T BuscaPorId(string id);
    void Apagar(string id);
}