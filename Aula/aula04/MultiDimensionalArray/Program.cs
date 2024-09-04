﻿/*
// Criando um vetor multidimensional
// Com 5 linhas e 2 colunas


int[,] numbers = new int[5,2];

// Criando um vetor tridimensional
int [,,] triNumbers = new int[5,4,3];

// Podemos inicializar os valores do vetor
// no momento de sua declaração
int[,] iniNumbers = new int[,]
{
    {9,15,-9},
    {19,25,-90},
    {29,35,-91},
    {39,45,-92},
    {49,55,-93},
};

// Para acessar os valores contidos neste
// tipo de variável int
int valor = iniNumbers[0,1]; // Neste caso = 15

Console.WriteLine( $"iniNumbers[0,1] == {valor}" );

*/

        int[,] iniNumbers = new int[,]
        {
            {9, 15, -9},
            {19, 25, -90},
            {29, 35, -91},
            {39, 45, -92},
            {49, 55, -93},
        };

        // Variáveis para armazenar o maior número e sua posição
        int maiorNumero = iniNumbers[0, 0];
        int linhaMaior = 0;
        int colunaMaior = 0;

        // Percorrendo a matriz
        for (int i = 0; i < iniNumbers.GetLength(0); i++)
        {
            for (int j = 0; j < iniNumbers.GetLength(1); j++)
            {
                if (iniNumbers[i, j] > maiorNumero)
                {
                    maiorNumero = iniNumbers[i, j];
                    linhaMaior = i;
                    colunaMaior = j;
                }
            }
        }

        // Exibindo o maior número e sua posição
        Console.WriteLine($"O maior número é {maiorNumero} na posição [{linhaMaior}, {colunaMaior}]");
    