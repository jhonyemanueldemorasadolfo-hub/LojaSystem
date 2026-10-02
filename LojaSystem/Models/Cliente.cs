using System;
using System.Collections.Generic;
using System.Text;
using Supabase.Postgrest.Models;
using Supabase.Postgrest.Attributes;

namespace LojaSystem.Models
{
    [Table("Cliente")]
    internal class Cliente : BaseModel
    {
        [PrimaryKey("id")]
        public int id { get; set; }

        [Column("Nome")]
        public string Nome { get; set; }

        [Column("CPF")]
        public string CPF { get; set; }

        [Column("Telefone")]
        public string Telefone { get; set; }

    }
}
