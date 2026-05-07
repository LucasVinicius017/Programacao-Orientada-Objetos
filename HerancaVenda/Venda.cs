using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HerancaVenda
{
    public class Venda
    {
        private DateTime data;
        private double total;
        private Pagamento pagamento;
        public DateTime Data 
        { 
            get { return data; }
            set { data = value; }
        }
        public double Total 
        { 
            get { return total; }
            set { total = value; }
        }
        public Pagamento Pagamento 
        { 
            get { return pagamento; }
            set { pagamento = value; }
        }
        public Venda()
        {
            Data = DateTime.Now;
            Total = 0;
        }
    }
}