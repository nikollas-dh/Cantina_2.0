using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina_2._0
{
    internal class Pedido
    {
        public string Nome { get; set; }
        public string Produto { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        

        public override string ToString()
        {

            if (Quantidade > 0)
            {
                return $"{Quantidade}x {Produto} R${Preco:F2}";
            }
            else
            {
                return $"{Produto} R${Preco:F2}";
            }

            

        }

    }
   
}
