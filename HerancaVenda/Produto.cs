using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaVenda
{
    public class Produto
    {
        private double codigo, preco;
        private string? nome;
        private int estoque;
        public double Codigo 
        { 
            get{ return codigo;}
            set{ codigo = value;} 
        }
        public string? Nome 
        { 
            get{ return nome;}
            set{ nome = value;} 
        }
        public double Preco 
        { 
            get{ return preco;}
            set{ preco = value;} 
        }
        public int Estoque 
        { 
            get{ return estoque;}
            set{ estoque = value;} 
        }
        public Produto(double codigo, string nome, double preco, int estoque)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.preco = preco;
            this.estoque = estoque;
        }
        public void MostrarProduto()
        {
            Console.WriteLine($"Código: {codigo}, Nome: {nome}, Preço: {preco}, Estoque: {estoque}");
        }
    }
}