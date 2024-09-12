using System.Collections;

// Utilizando a Lista Simples;

ArrayList arrList = new();
arrList.Add(5);
arrList.Add("Matheus");

// É possivel adicionar um conjunto de valores de uma so vez;

arrList.AddRange(new int[] {1,2,3});

// O metodo .Add() insere o valor ao final do vetor;

arrList.Insert(0, 15);

// Já o metodo insert, me permite incluir o valor desejado na posição especificada no primeiro parâmetro;

// Lendo valores da Lista
object primeiro = arrList[0]!;
int quarto = (int)arrList[3]!;

//Percorrendo a Lista com foreach
foreach(Object obj in arrList)
{
    Console.Write($" | {obj}"); 
}

// obetendo o tamanho9 total da lisa
// Quantos elementos tem
int tamanho = arrList.Count;
// obter a capacidade
// Quandos podem ser armazenados
int capacidade = arrList.Capacity;

// percorrendo no modo clássico
for(int i = 0; i < arrList.Count; i++)
{
    Console.Write( $" | {arrList[i]}" );
}

// Recursos importantes da Lista
// Verificar se um valor é contido na lista
bool contemNome = arrList.Contains("matheus");
if(!contemNome)
    Console.WriteLine("Nome Matheus não encontrado")

// Para saber o índice que contem o valor buscado
// Neste caso se o valor exisitr na lsita
// Ele retorna o índice (número inteiro)
// Caso o valor não exista na lsita, retorna -1
int indiceDoValor = arrList.IndexOf("Matheus");
if(indiceDoValor >= 0)
    Console.WriteLine($ "Matheus está em [{indiceDoValor}]");
    else
        Console.WriteLine("É, realmente não tem.");

// É possível também remover itens da lista
arrList.Remove("Matheus"); // Remove pelo valor
arrList.Remove(4); // Remove no índice
arrList.RemoveRange (0,2); 
// O primeiro parametro é o índice
// e o segundo é quantas casas após o índice  