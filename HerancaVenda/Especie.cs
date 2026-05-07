using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaVenda
{
    public class Especie : Pagamento
    {
        private double quantia, troco;
        public double Quantia 
        { 
            get { return quantia; }
            set { quantia = value; }
        }
        public double Troco 
        { 
            get { return troco; }
            set { troco = value; }
        }
        public Especie(double quantia, double troco, double total) : base(total)
        {
            Quantia = quantia;
            Troco = troco;

        }        
        public override void MostrarAtributos()
        {
            Console.WriteLine($"Quantia: {quantia}, Troco: {troco}");
        }
    }
}