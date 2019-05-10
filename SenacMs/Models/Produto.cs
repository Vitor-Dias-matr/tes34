using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SenacMs.Models
{
    public class Produto : Entity
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }

        public int TipoProdutoId { get; set; }
        public int MarcaId { get; set; }

        [ForeignKey("TipoProdutoId")]

        public virtual TipoProduto TipoProduto { get; set; }

        [ForeignKey ("MarcaId")]

        public virtual Marca Marca { get; set; }



       
    }
}

