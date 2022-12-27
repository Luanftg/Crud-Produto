namespace negocio.models;
public record Produto

{
    public string Id {get;set;} = default!;
    public string Nome {get;set;} = default!;
    public string Descricao {get;set;} = default!;
    public DateTime Dt_de_validade {get;set;}
    public DateTime Dt_de_criacao {get;set;}
    public int Quantidade {get;set;}
}