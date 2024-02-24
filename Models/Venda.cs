using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tipos_anonimos.Models
{
    public class Venda
    {
        public int Id { get; set; }

        public decimal Preco { get; set; }

        public string? Produto { get; set; }
    }
}