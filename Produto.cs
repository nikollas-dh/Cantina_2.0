using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina_2._0
{
    internal class Produto
    {
        public string Nome {  get; set; }
        public double Preco { get; set; } 
        public int Quantidade { get; set; }
        public override string ToString()
        {
            return $"{Quantidade}x {Nome} R${Preco:F2}";
        }

    }
   
}
