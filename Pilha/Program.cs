using Pilha;
int inputPositiveInteger(string message, int? max = int.MaxValue, int? min = 1)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine());

    while (value < min || value > max)
    {
        Console.Write($"Valor inválido, tente um valor maior que {min} {(max != int.MaxValue ? $"e menor que {max}" : "")}: ");
        value = int.Parse(Console.ReadLine());
    }

    return value;
}

void waitForAnyKey()
{
    Console.WriteLine("Pressione qualquer tecla para continuar.");
    Console.ReadKey();
}

Stack stack = new Stack();

Book createBook()
{
    Console.Write("Informe o título do livro: ");
    string title = Console.ReadLine();

    return new Book(title);
}

void insertBook()
{
    Console.Clear();
    stack.Insert(createBook());
}

void removeBook()
{
    Console.Clear();
    if (stack.IsEmpty())
    {
        Console.WriteLine("Pilha vazia");
        waitForAnyKey();
        return;
    }

    Console.WriteLine($"Livro removido:\n{stack.Unstack()}");
    waitForAnyKey();
}

void displayStack()
{
    Console.Clear();

    if (stack.IsEmpty())
    {
        Console.WriteLine("Pilha vazia");
        waitForAnyKey();
        return;
    }

    stack.Display();
    waitForAnyKey();
}

void searchBook()
{
    Console.Clear();

    if (stack.IsEmpty())
    {
        Console.WriteLine("Pilha vazia");
        waitForAnyKey();
        return;
    }

    Console.Write("Digite o nome do livro que deseja procurar: ");

    stack.Search(Console.ReadLine());
    waitForAnyKey();
}

void getStackCount()
{
    Console.Clear();
    Console.WriteLine($"Contagem atual dos livros na pilha: {stack.Count()}");
    waitForAnyKey();
}

int selectOperationMenu()
{
    Console.Clear();
    return inputPositiveInteger("Menu principal - Pilha de livros\n[ 1 ] Inserir livro\n[ 2 ] Remover livro\n[ 3 ] Imprimir pilha\n[ 4 ] Procurar por livro\n[ 5 ] Mostrar contagem dos livros\n[ 6 ] Sair\nSua opção: ", min: 1, max: 6);
}

while (true)
{
    switch (selectOperationMenu())
    {
        case 1:
            insertBook();
            break;
        case 2:
            removeBook();
            break;
        case 3:
            displayStack();
            break;
        case 4:
            searchBook();
            break;
        case 5:
            getStackCount();
            break;
        default:
            Environment.Exit(0);
            break;
    }
}