using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoComposicao
{
   public class Poupanca
    {
        private int numero;
        private string titular;
        private decimal saldo;
        public int Numero
        { 
            get{ return numero; }
            set{ numero = value; }
        }
        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }
        public decimal Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }    
        public Poupanca(int numero, string titular, decimal saldo)
        {
            this.numero = numero;
            this.titular = titular;
            this.saldo = saldo;
        }
        public void Sacar(decimal valorSaque){
            if (valorSaque <= saldo)
            {
                saldo -= valorSaque;
                Console.WriteLine($"Saque de {valorSaque:C} realizado na Poupança {numero}.");
            }
            else
            {
                Console.WriteLine($"Saldo insuficiente para saque de {valorSaque:C} na Poupança {numero}.");
            }
    
        }
        public void Depositar(decimal valorDeposito){
            if (valorDeposito > 0)
            {
                saldo += valorDeposito;
                Console.WriteLine($"Depósito de {valorDeposito:C} realizado na Poupança {numero}.");
            }
        }
        public void GerarRendimento(double taxaJuros)
        {
            decimal rendimento = saldo * (decimal)(taxaJuros / 100);
            saldo += rendimento;
            Console.WriteLine($"Rendimento de {rendimento:C} gerado. Novo saldo da Poupança {numero}: {saldo:C}");
        }
        ~Poupanca()
        {
            Console.WriteLine($"Destruindo a Poupança {numero} do(a) titular {titular}");
        }
    }
}