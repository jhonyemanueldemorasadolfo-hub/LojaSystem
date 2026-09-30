using Supabase.Postgrest.Models;
using Supabase.Postgrest.Attributes;
using System;


namespace LojaSystem.Models
{
    [Table("Produto")]
    public class Produto: BaseModel
    {

        [PrimaryKey("id")]
        public long Id { get; set; }

        [Column("Nome")]
        public string Nome { get; set; }

        [Column("Categoria")]
        public string Categoria { get; set; }

        [Column("Preco")]
        public decimal Preco { get; set; }

        [Column("QtdeEstoque")]
        public int Estoque { get; set; }

    }
}

