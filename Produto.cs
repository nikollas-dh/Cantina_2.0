using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina_2._0
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public bool PrecisaPreparar { get; set; }

        public override string ToString()
        {
         if (Quantidade > 0)
          {
           return $"{Quantidade}x {Nome} R${Preco:F2}";
          }
        else
          {
           return $"{Nome} - R${Preco:F2}";
          }
        }

    }

}
   

