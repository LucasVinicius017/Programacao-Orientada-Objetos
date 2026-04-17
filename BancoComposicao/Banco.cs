using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BancoComposicao
{
    public class Banco
    {
        private List<Poupanca> poupancas;
        private List<Conta> contas;
        public List<Conta> Contas
        {
            get { return contas; }
        }
        public List<Poupanca> Poupancas
        {
            get { return poupancas; }
        }
        public Banco()
        {
            IniciarBanco();
        }
        public void IniciarBanco()
        {
            poupancas = new List<Poupanca>();
            contas = new List<Conta>();
        }
        public void AbrirConta(int numero, string titular, decimal saldo, decimal chequeEspecial)
        {
            Conta novaConta = new Conta(numero, titular, saldo, chequeEspecial);
            contas.Add(novaConta);
            Console.WriteLine($"Conta Corrente {numero} criada para {titular}.");
        }
        public void AbrirPoupanca(int numero, string titular, decimal saldo)
        {
            Poupanca novaPoupanca = new Poupanca(numero, titular, saldo);
            poupancas.Add(novaPoupanca);
            Console.WriteLine($"Conta Poupança {numero} criada para {titular}.");
        }
        public void DecretarFalencia()
        {
            contas.Clear();
            poupancas.Clear();
            Console.WriteLine("Banco faliu. Todas as contas foram removidas."); 
        }
        ~Banco()
        {
            contas = null;
            poupancas = null;
            Console.WriteLine("Banco falido e destruído.");
        }
    }
}