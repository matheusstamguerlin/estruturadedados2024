using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarefa___Hanoi_Tower
{
public class HanoiTower
    {
        public int DiscsCount { get; private set; }
        public int MovesCount { get; private set; }
        public Stack<int> From { get; private set; }
        public Stack<int> To { get; private set; }
        public Stack<int> Auxiliary { get; private set; }
        public event EventHandler<EventArgs> MoveCompleted;

        // Construtor que inicializa a Torre de Hanoi com o número de discos
        public HanoiTower(int discs)
        {
            DiscsCount = discs;
            From = new Stack<int>();
            To = new Stack<int>();
            Auxiliary = new Stack<int>();
            // Coloca os discos na pilha 'From' em ordem
            for (int i = 1; i <= discs; i++)
            {
                From.Push(discs - i + 1);
            }
        }

        // Inicia o processo de movimento dos discos
        public void Start()
        {
            Move(DiscsCount, From, To, Auxiliary);
        }

        // Método recursivo para mover os discos
        private void Move(int discs, Stack<int> from, Stack<int> to, Stack<int> auxiliary)
        {
            if (discs > 0)
            {
                // Move discos de 'from' para 'auxiliary'
                Move(discs - 1, from, auxiliary, to);
                
                // Move o disco maior de 'from' para 'to'
                int disk = from.Pop();
                to.Push(disk);
                MovesCount++;
                
                // Dispara o evento
                MoveCompleted?.Invoke(this, EventArgs.Empty);
                
                // Move discos de 'auxiliary' para 'to'
                Move(discs - 1, auxiliary, to, from);
            }
        }

        // Método para exibir o estado atual das pilhas (opcional)
        public void DisplayStacks()
        {
            Console.WriteLine($"From: {string.Join(", ", From.ToArray())}");
            Console.WriteLine($"To: {string.Join(", ", To.ToArray())}");
            Console.WriteLine($"Auxiliary: {string.Join(", ", Auxiliary.ToArray())}");
            Console.WriteLine($"Moves made: {MovesCount}");
            Console.WriteLine();
        }
    }
}
