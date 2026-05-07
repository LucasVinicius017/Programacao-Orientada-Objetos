using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaVenda
{
    public class Cheque : Pagamento
    {
        public long numeroCheque;
        public DateTime dataDeposito;
        private int situacao;
        public long NumeroCheque 
        { 
            get { return numeroCheque; }
            set { numeroCheque = value; }
        }
        public DateTime DataDeposito 
        { 
            get { return dataDeposito; }
            set { dataDeposito = value; }
        }
        public int Situacao 
        { 
            get { return situacao; }
            set { situacao = value; }
        }
        public Cheque(long numeroCheque, DateTime dataDeposito, int situacao, double total) : base(total)
        {
            NumeroCheque = numeroCheque;
            DataDeposito = dataDeposito;
            Situacao = situacao;
        }
        public override void MostrarAtributos()
        {
            if (Situacao == 0)
            {
                Console.WriteLine($"Número do Cheque: {NumeroCheque}, Data de Depósito: {DataDeposito}, Situação: Pendente");
            }
            else if (Situacao == 1)
            {
                Console.WriteLine($"Número do Cheque: {NumeroCheque}, Data de Depósito: {DataDeposito}, Situação: Compensado");
            }
            else if (Situacao == 2)
            {
                Console.WriteLine($"Número do Cheque: {NumeroCheque}, Data de Depósito: {DataDeposito}, Situação: Devolvido");
            }
        }
    }
}