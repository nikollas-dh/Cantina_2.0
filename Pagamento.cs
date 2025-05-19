using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace Cantina_2._0
{
    internal class Pagamento
    {
        public string FormaPagamento { get; set; }

        public override string ToString()
        {
            return $"{FormaPagamento}" ;
        }
    }

    internal class Escolha
    {
        private List<Pagamento> itens = new List<Pagamento>();

        public void AdicionarPagamento(Pagamento pagamento)
        {
            itens.Add(pagamento);
        }

        public List<Pagamento> ObterPagamentos()
        {
            return itens;
        }
    }


}
