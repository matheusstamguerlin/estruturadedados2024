
// Definir o tamanho dos vetores
const int tamanho = 100;

// Criar os vetores para armazenas números pares e ímpares
int[] pares = new int[tamanho];
int[] ímpares = new int[tamanho];

// Preencher os vetores com os primeiros 100 números pares e ímpares
for (int i = 0; i < tamanho; i++)
{
    pares[i] = i;
    ímpares[i] = i + 1;
}

// Imprimir os números pares
Console.WriteLine("Números pares:");
for (int i = 0; i < tamanho; i++)
{
    Console.WriteLine(pares[i] + " ");
}
Console.WriteLine();   

// Imprimir os números ímpares
Console.WriteLine("Números ímpares:");
for (int i = 0; i < tamanho; i++)
{
    Console.WriteLine(ímpares[i] + "   ");
}
Console.WriteLine();
