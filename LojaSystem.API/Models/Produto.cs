using System;


namespace LojaSystem.API.Models
{
public class Produto
{
    public int id { get; private set; }
    public string nome { get; set; }
    public string categoria { get; set; }
    public decimal preco { get; set; }
    public int estoque { get; set; }
}
}

