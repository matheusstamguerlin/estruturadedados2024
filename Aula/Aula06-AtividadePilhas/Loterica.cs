using System; // Necessário para Console.WriteLine
using System.Collections.Generic; // Necessário para Stack<T>

class Programa
{
    static void Main()
    {
        Stack<string> pilha = new Stack<string>(); // Cria a pilha que será usada como fila
        
        // Adicionando pessoas à "fila"
        pilha.Push("João");
        pilha.Push("Maria");
        pilha.Push("Carlos");
        pilha.Push("Ana");

        Console.WriteLine("Fila original:");
        foreach (var pessoa in pilha)
        {
            Console.WriteLine(pessoa);
        }

        // Criando uma pilha auxiliar para inverter a ordem e simular uma fila
        Stack<string> pilhaInvertida = new Stack<string>();

        while (pilha.Count > 0)
        {
            pilhaInvertida.Push(pilha.Pop());
        }

        // Agora, podemos atender as pessoas na ordem correta
        Console.WriteLine("\nAtendendo as pessoas na ordem correta:");
        while (pilhaInvertida.Count > 0)
        {
            Console.WriteLine(pilhaInvertida.Pop() + " foi atendido(a).");
        }
    }
}
