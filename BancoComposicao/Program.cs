using System;
namespace BancoComposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco meuBanco = new Banco();
            Console.WriteLine("Abrindo contas");
            meuBanco.AbrirConta(990, "Lucas", 1000.00m, 1000.00m);
            meuBanco.AbrirConta(991, "Ana", 2000.00m, 900.00m);
            meuBanco.AbrirPoupanca(992, "Rosa", 10000.00m);
            Console.WriteLine("Movimentações");
            if (meuBanco.Contas.Count > 0)
            {
                meuBanco.Contas[0].Depositar(1000.00m);
                meuBanco.Contas[0].Sacar(200.00m);
                meuBanco.Contas[0].GerarExtrato();
            }
            meuBanco.Poupancas[0].GerarRendimento(10.0); 
            meuBanco.DecretarFalencia();
            meuBanco = null;
            GC.Collect();
        }
    }
}
