using HerancaVenda;

List<Produto> produtos = new List<Produto>();
Venda venda = new Venda();

int opcao = 0;

// Produtos iniciais
produtos.Add(new Produto(1, "Coca-Cola", 10.00, 100));
produtos.Add(new Produto(2, "Pepsi", 8.50, 150));
produtos.Add(new Produto(3, "Fanta", 7.99, 200));

while (opcao != 5)
{
    Console.WriteLine("\n===== MENU =====");
    Console.WriteLine("1 - Cadastrar Produto");
    Console.WriteLine("2 - Adicionar Item à Venda");
    Console.WriteLine("3 - Realizar Pagamento");
    Console.WriteLine("4 - Exibir Venda");
    Console.WriteLine("5 - Sair");

    Console.Write("Escolha uma opção: ");
    opcao = Convert.ToInt32(Console.ReadLine());

    // CADASTRAR PRODUTO
    if (opcao == 1)
    {
        Console.Write("Código: ");
        double codigo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Preço: ");
        double preco = Convert.ToDouble(Console.ReadLine());

        Console.Write("Estoque: ");
        int estoque = Convert.ToInt32(Console.ReadLine());

        produtos.Add(new Produto(codigo, nome, preco, estoque));

        Console.WriteLine("Produto cadastrado com sucesso.");
    }

    else if (opcao == 2)
    {
        Console.WriteLine("\n=== PRODUTOS DISPONÍVEIS ===");

        foreach (Produto p in produtos)
        {
            p.MostrarProduto();
        }

        Console.Write("\nDigite o código do produto: ");
        double codigoBusca = Convert.ToDouble(Console.ReadLine());

        Produto produtoEncontrado = null;

        foreach (Produto p in produtos)
        {
            if (p.Codigo == codigoBusca)
            {
                produtoEncontrado = p;
            }
        }

        if (produtoEncontrado != null)
        {
            Console.Write("Quantidade: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            if (quantidade <= produtoEncontrado.Estoque)
            {
                ItemVenda item = new ItemVenda(produtoEncontrado, quantidade);

                venda.Total += item.Subtotal;

                produtoEncontrado.Estoque -= quantidade;

                Console.WriteLine("Item adicionado com sucesso.");

                item.MostrarItemVenda();
            }
            else
            {
                Console.WriteLine("Estoque insuficiente.");
            }
        }
        else
        {
            Console.WriteLine("Produto não encontrado.");
        }
    }

    else if (opcao == 3)
    {
        Console.WriteLine($"\nTotal da venda: {venda.Total:c}");

        Console.WriteLine("Forma de pagamento:");
        Console.WriteLine("1 - Espécie");
        Console.WriteLine("2 - Cheque");
        Console.WriteLine("3 - Cartão");

        int forma = Convert.ToInt32(Console.ReadLine());

        if (forma == 1)
        {
            Console.Write("Quantia recebida: ");
            double quantia = Convert.ToDouble(Console.ReadLine());

            double troco = quantia - venda.Total;

            venda.Pagamento = new Especie(quantia, troco, venda.Total);

            Console.WriteLine("Pagamento em dinheiro realizado.");
        }
        else if (forma == 2)
        {
            Console.Write("Número do cheque: ");
            long numero = Convert.ToInt64(Console.ReadLine());

            venda.Pagamento = new Cheque(numero, DateTime.Now, 1, venda.Total);

            Console.WriteLine("Pagamento em cheque realizado.");
        }
        else if (forma == 3)
        {
            Console.Write("Dados da transação: ");
            string dados = Console.ReadLine();

            venda.Pagamento = new Cartao(dados, 1, venda.Total);

            Console.WriteLine("Pagamento em cartão realizado.");
        }
        else
        {
            Console.WriteLine("Forma de pagamento inválida.");
        }
    }

    else if (opcao == 4)
    {
        Console.WriteLine("\n===== DADOS DA VENDA =====");

        Console.WriteLine($"Data: {venda.Data}");
        Console.WriteLine($"Total: {venda.Total:c}");

        if (venda.Pagamento != null)
        {
            Console.WriteLine("\n=== PAGAMENTO ===");
            venda.Pagamento.MostrarAtributos();
        }
        else
        {
            Console.WriteLine("Pagamento ainda não realizado.");
        }
    }

    else if (opcao == 5)
    {
        Console.WriteLine("Programa encerrado.");
    }

    else
    {
        Console.WriteLine("Opção inválida.");
    }
}