List<string> produtos = new List<string>();

int count = 1;
string AddProdutos = " ";

Console.WriteLine("Vamos fazer uma lista de compras para o mês");
Console.WriteLine("Adicione os produtos e a quantidade junto");
Console.WriteLine("Após adiciona los pressione a TECLA ENTER");
Console.WriteLine();

while (AddProdutos.Length != null)
{
    AddProdutos = Console.ReadLine();
    if (AddProdutos.Length == 0)
    {
        break;
    }
    else
    {
        produtos.Add(AddProdutos);
    }
}
    Console.WriteLine($"Você adicionou {produtos.Count} produtos para comprar este mes");
    Console.WriteLine();
    Console.WriteLine("Produtos adicionados para comprar este mês");
    Console.WriteLine();
    
    foreach(string produto in produtos)
    {
        Console.WriteLine("#" + count + " " + produto);
        count++;
    }
    
    Console.WriteLine("Oi, você comprou algum produto da lista ? E este produto vai sair da lista ? (S OU N)");
    char escolha = char.Parse(Console.ReadLine());
    
    while(escolha == 'S' || escolha == 's')
    {
       Console.WriteLine("Digite o nome do produto que você deseja retirar da lista");
       AddProdutos = Console.ReadLine();

        while(AddProdutos.Length > 0)
        {
            if(produtos.Contains(AddProdutos))
            {
                Console.WriteLine("O produto já foi comprado, e saiu da lista agora mesmo");
                produtos.Remove(AddProdutos);
                break;
            }
            else if(!produtos.Contains(AddProdutos))
            {
                Console.WriteLine("Este produto não esta na lista, acho que você digitou errado");
                AddProdutos = Console.ReadLine();

                if (produtos.Contains(AddProdutos))
                {
                    Console.WriteLine("O produto saiu da lista");
                    produtos.Remove(AddProdutos);
                    break;
                }
            }
            else
            {
                Console.WriteLine("O produto já saiu da lista");
                break;
            }
        }
        Console.WriteLine("Mais algum produto já foi comprado e você deseja retira-lo da lista ?(S ou N)");
        escolha = char.Parse(Console.ReadLine());
    }
    count = 1;
    Console.WriteLine($"A lista esta com estes produtos agora = {produtos.Count} ");
    Console.WriteLine();

    foreach (string produto in produtos)
    {
        Console.WriteLine("#" + count + " " + produto);
        count++;
    }