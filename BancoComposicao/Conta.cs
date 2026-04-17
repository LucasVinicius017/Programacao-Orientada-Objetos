using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoComposicao
{
    
    public class Conta
    {
        private int numero;
        private decimal chequeEspecial;
        private decimal saldo;
        private string titular;
        public decimal ChequeEspecial
        {
            get { return chequeEspecial; }
            set { chequeEspecial = value; }
        }
        public int Numero 
        { 
            set { numero = value;}
            get { return numero; }
        }
        public decimal Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }        
        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }
        public Conta(int numero, string titular, decimal saldo, decimal chequeEspecial)
        {
            this.numero = numero;
            this.titular = titular;
            this.saldo = saldo;
            this.chequeEspecial = chequeEspecial;
        }
        public void Sacar(decimal valorSaque){
            if (valorSaque <= (saldo + chequeEspecial))
            {
                saldo -= valorSaque;
                Console.WriteLine($"Saque de {valorSaque:C} realizado na conta {numero}.");
            }
            else if (valorSaque <= saldo + chequeEspecial)
            {
                decimal restante = valorSaque - saldo;
                saldo = 0;
                chequeEspecial -= restante;
            }
        }
        public void Depositar(decimal valorDeposito){
            if (valorDeposito > 0)
            {
                saldo += valorDeposito;
                Console.WriteLine($"Depósito de {valorDeposito:C} realizado na conta {numero}.");
            }
        }
        public void GerarExtrato()
        {
            Console.WriteLine($"Extrato da Conta {numero} - Titular: {titular}");
            Console.WriteLine($"Saldo: {saldo:C}");
            Console.WriteLine($"Cheque Especial Disponível: {chequeEspecial:C}");
        }
        ~Conta()
        {
            Console.WriteLine($"Destruindo a Conta {numero} do(a) titular {titular}");
        }
    }
}