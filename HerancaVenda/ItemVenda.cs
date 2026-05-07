using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaVenda
{
    public class ItemVenda
    {
        private int quantidade;
        private double preco, subtotal;
        private Produto produto;
        public int Quantidade 
        { 
            get { return quantidade; }
            set { 
                    if (value > 0) quantidade = value;
                    else Console.WriteLine("Quantidade inválida.");
                }
        }
        public double Preco 
        { 
            get { return preco; }
            set { 
                    if (value > 0) preco = value;
                    else Console.WriteLine("Preço inválido.");
                }
        }
        public double Subtotal 
        { 
            get { return quantidade * preco; }
        }
        public Produto Produto 
        { 
            get { return produto; }
            set { produto = value; }
        }
        public ItemVenda(Produto produto, int quantidade)
        {
            this.produto = produto;
            Quantidade = quantidade;
            
            if (quantidade >= 50)
            {
                Preco = produto.Preco * 0.8; 
            }
            else
            {
                Preco = produto.Preco;
            }
        }
        public void MostrarItemVenda()
        {
            Console.WriteLine($"Produto: {Produto.Nome}, Quantidade: {Quantidade}, Preço Unitário: {Preco:c}, Subtotal: {Subtotal:c}");
        }
    }
}