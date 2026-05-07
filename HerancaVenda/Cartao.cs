using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaVenda
{
    public class Cartao : Pagamento
    {
        private string? dadosTransacao;
        private int resultadoTransacao;
        public string? DadosTransacao 
        { 
            get { return dadosTransacao; }
            set { dadosTransacao = value; }
        }
        public int ResultadoTransacao 
        { 
            get { return resultadoTransacao; }
            set { resultadoTransacao = value; }
        }
        public Cartao(string? dadosTransacao, int resultadoTransacao, double total) : base(total)
        {
            DadosTransacao = dadosTransacao;
            ResultadoTransacao = resultadoTransacao;
        }
        public override void MostrarAtributos()
        {
            string resultado = ResultadoTransacao == 0 ? "Transação Pendente" : "Transação Aprovada";
            Console.WriteLine($"Dados da Transação: {DadosTransacao}, Resultado da Transação: {resultado}");
        }
    }
}