/*
// Criando um vetor MultiDimensional com 5 linhas e 2 colunas;

using Microsoft.Win32.SafeHandles;

int[,] numbers = new int[5,2];

// Criando um vetor Tridimensional;

int[,,] triNumbers = new int[5,4,3];

// Podemos inicializar os valores do vetor no momento de sua declaração;

int[,] iniNumbers = new int[,]
{
    {9,15,-9},
    {19,25,-90},
    {29,35,-91},
    {39,45,-92},
    {49,55,-93}
};

// Para acessar os valores contidos neste tipo variavel;

int valor = iniNumbers[0,1]; // neste caso igual a 15

Console.WriteLine($"iniNumbers[0,1] = {valor}");

*/


int[,] matriz = 
{
    {9, 15, -9},
    {19, 25, -90},
    {29, 35, -91},
    {3, 45, -92},
    {49, 55, -93}
};

var resultado = EncontrarMaiorELocalizacao(matriz);

Console.WriteLine($"O maior número é {resultado.maiorNumero} e está na posição ({resultado.linha}, {resultado.coluna})");

static (int maiorNumero, int linha, int coluna) EncontrarMaiorELocalizacao(int[,] matriz)
{
    int maiorNumero = matriz[0, 0];
    int linhaMaior = 0;
    int colunaMaior = 0;

    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            if (matriz[i, j] > maiorNumero)
            {
                maiorNumero = matriz[i, j];
                linhaMaior = i;
                colunaMaior = j;
            }
        }
    }
    return (maiorNumero, linhaMaior, colunaMaior);
}